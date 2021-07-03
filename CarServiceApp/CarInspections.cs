using BusinessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class CarInspections : Form
    {
        private readonly IRepairOrderBusiness _repairOrderBusiness;
        private readonly IOwnerBusiness _ownerBusiness;
        private readonly IVehicleBusiness _vehicleBusiness;
        public CarInspections(IRepairOrderBusiness repairOrderBusiness, IOwnerBusiness ownerBusiness, IVehicleBusiness vehicleBusiness)
        {
            this._ownerBusiness = ownerBusiness;
            this._vehicleBusiness = vehicleBusiness;
            this._repairOrderBusiness = repairOrderBusiness;
            InitializeComponent();
        }

        private void CarInspections_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            List<RepairOrder> repairOrders = _repairOrderBusiness.getActiveRepairOrders();

            listBoxActiveCarInspections.Items.Clear();

            if (repairOrders.Count == 0) 
                listBoxActiveCarInspections.Items.Add("No active car inspections");
            else
                foreach (RepairOrder repairOrder in repairOrders)
                    if(!repairOrder.RepairStatus)
                        listBoxActiveCarInspections.Items.Add("ID: " + repairOrder.Id + ". Date of receipt => " + repairOrder.DateOfReceipt + " Description => " + repairOrder.Description + " Price => " + repairOrder.Price + " Chassis number: " + repairOrder.VehicleId);
        }
        private void buttonNewInspection_Click(object sender, EventArgs e)
        {
            NewRepairOrder newRepairOrder = new NewRepairOrder(_ownerBusiness, _vehicleBusiness, _repairOrderBusiness);
            newRepairOrder.ShowDialog();

            RefreshData();
        }
        private void buttonUpdateInspection_Click(object sender, EventArgs e)
        {
            UpdateCarInspectionInfo updateCarInspectionInfo = new UpdateCarInspectionInfo(_repairOrderBusiness,_vehicleBusiness,_ownerBusiness);
            updateCarInspectionInfo.ShowDialog();

            RefreshData();
        }

        private void buttonDeleteInspection_Click(object sender, EventArgs e)
        {
            DeleteCarInspectionInfo deleteCarInspectionInfo = new DeleteCarInspectionInfo(_repairOrderBusiness);
            deleteCarInspectionInfo.ShowDialog();

            RefreshData();
        }

        private void buttonCarInspectionHistory_Click(object sender, EventArgs e)
        {
            CarInspectionHistory carInspectionHistory = new CarInspectionHistory(_repairOrderBusiness);
            carInspectionHistory.ShowDialog();

            RefreshData();
        }
    }
}
