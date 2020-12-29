
namespace CarServiceApp
{
    partial class NewRepairOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMalfunctionDesciption = new System.Windows.Forms.Label();
            this.textBoxMalfunctionDescription = new System.Windows.Forms.TextBox();
            this.textBoxRepairPrice = new System.Windows.Forms.TextBox();
            this.labelRepairPrice = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.labelNewCarInspectionTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonNewRepairOrder = new System.Windows.Forms.Button();
            this.comboBoxOwners = new System.Windows.Forms.ComboBox();
            this.buttonAddOwner = new System.Windows.Forms.Button();
            this.textBoxChassisNumber = new System.Windows.Forms.TextBox();
            this.labelChassisNumber = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.textBoxYearOfManufacture = new System.Windows.Forms.TextBox();
            this.labelYearOfManufacture = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxLicencePlate = new System.Windows.Forms.TextBox();
            this.labelLicencePlate = new System.Windows.Forms.Label();
            this.groupBoxVehicle = new System.Windows.Forms.GroupBox();
            this.labelLicencePlateRegex = new System.Windows.Forms.Label();
            this.labelEmailRegex = new System.Windows.Forms.Label();
            this.groupBoxVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMalfunctionDesciption
            // 
            this.labelMalfunctionDesciption.AutoSize = true;
            this.labelMalfunctionDesciption.BackColor = System.Drawing.SystemColors.Control;
            this.labelMalfunctionDesciption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMalfunctionDesciption.Location = new System.Drawing.Point(36, 413);
            this.labelMalfunctionDesciption.Name = "labelMalfunctionDesciption";
            this.labelMalfunctionDesciption.Size = new System.Drawing.Size(160, 18);
            this.labelMalfunctionDesciption.TabIndex = 0;
            this.labelMalfunctionDesciption.Text = "Malfunction description";
            // 
            // textBoxMalfunctionDescription
            // 
            this.textBoxMalfunctionDescription.Location = new System.Drawing.Point(222, 411);
            this.textBoxMalfunctionDescription.Name = "textBoxMalfunctionDescription";
            this.textBoxMalfunctionDescription.Size = new System.Drawing.Size(175, 20);
            this.textBoxMalfunctionDescription.TabIndex = 1;
            // 
            // textBoxRepairPrice
            // 
            this.textBoxRepairPrice.Location = new System.Drawing.Point(222, 446);
            this.textBoxRepairPrice.Name = "textBoxRepairPrice";
            this.textBoxRepairPrice.Size = new System.Drawing.Size(175, 20);
            this.textBoxRepairPrice.TabIndex = 3;
            // 
            // labelRepairPrice
            // 
            this.labelRepairPrice.AutoSize = true;
            this.labelRepairPrice.BackColor = System.Drawing.SystemColors.Control;
            this.labelRepairPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepairPrice.Location = new System.Drawing.Point(36, 448);
            this.labelRepairPrice.Name = "labelRepairPrice";
            this.labelRepairPrice.Size = new System.Drawing.Size(87, 18);
            this.labelRepairPrice.TabIndex = 2;
            this.labelRepairPrice.Text = "Repair price";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.BackColor = System.Drawing.SystemColors.Control;
            this.labelOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwner.Location = new System.Drawing.Point(36, 104);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(52, 18);
            this.labelOwner.TabIndex = 4;
            this.labelOwner.Text = "Owner";
            // 
            // labelNewCarInspectionTitle
            // 
            this.labelNewCarInspectionTitle.AutoSize = true;
            this.labelNewCarInspectionTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelNewCarInspectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewCarInspectionTitle.Location = new System.Drawing.Point(130, 25);
            this.labelNewCarInspectionTitle.Name = "labelNewCarInspectionTitle";
            this.labelNewCarInspectionTitle.Size = new System.Drawing.Size(170, 31);
            this.labelNewCarInspectionTitle.TabIndex = 6;
            this.labelNewCarInspectionTitle.Text = "Repair Order";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(93, 494);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(113, 44);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonNewRepairOrder
            // 
            this.buttonNewRepairOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewRepairOrder.Location = new System.Drawing.Point(250, 494);
            this.buttonNewRepairOrder.Name = "buttonNewRepairOrder";
            this.buttonNewRepairOrder.Size = new System.Drawing.Size(113, 44);
            this.buttonNewRepairOrder.TabIndex = 8;
            this.buttonNewRepairOrder.Text = "Create new repair order";
            this.buttonNewRepairOrder.UseVisualStyleBackColor = true;
            this.buttonNewRepairOrder.Click += new System.EventHandler(this.buttonNewRepairOrder_Click);
            // 
            // comboBoxOwners
            // 
            this.comboBoxOwners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOwners.FormattingEnabled = true;
            this.comboBoxOwners.Location = new System.Drawing.Point(140, 101);
            this.comboBoxOwners.Name = "comboBoxOwners";
            this.comboBoxOwners.Size = new System.Drawing.Size(191, 21);
            this.comboBoxOwners.TabIndex = 9;
            // 
            // buttonAddOwner
            // 
            this.buttonAddOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOwner.Location = new System.Drawing.Point(350, 83);
            this.buttonAddOwner.Name = "buttonAddOwner";
            this.buttonAddOwner.Size = new System.Drawing.Size(80, 48);
            this.buttonAddOwner.TabIndex = 10;
            this.buttonAddOwner.Text = "Add owner";
            this.buttonAddOwner.UseVisualStyleBackColor = true;
            this.buttonAddOwner.Click += new System.EventHandler(this.buttonAddOwner_Click);
            // 
            // textBoxChassisNumber
            // 
            this.textBoxChassisNumber.Location = new System.Drawing.Point(201, 35);
            this.textBoxChassisNumber.Name = "textBoxChassisNumber";
            this.textBoxChassisNumber.Size = new System.Drawing.Size(175, 26);
            this.textBoxChassisNumber.TabIndex = 12;
            // 
            // labelChassisNumber
            // 
            this.labelChassisNumber.AutoSize = true;
            this.labelChassisNumber.BackColor = System.Drawing.SystemColors.Control;
            this.labelChassisNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChassisNumber.Location = new System.Drawing.Point(17, 37);
            this.labelChassisNumber.Name = "labelChassisNumber";
            this.labelChassisNumber.Size = new System.Drawing.Size(116, 18);
            this.labelChassisNumber.TabIndex = 11;
            this.labelChassisNumber.Text = "Chassis number";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(201, 78);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(175, 26);
            this.textBoxBrand.TabIndex = 14;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.BackColor = System.Drawing.SystemColors.Control;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(17, 80);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(47, 18);
            this.labelBrand.TabIndex = 13;
            this.labelBrand.Text = "Brand";
            // 
            // textBoxYearOfManufacture
            // 
            this.textBoxYearOfManufacture.Location = new System.Drawing.Point(201, 157);
            this.textBoxYearOfManufacture.Name = "textBoxYearOfManufacture";
            this.textBoxYearOfManufacture.Size = new System.Drawing.Size(175, 26);
            this.textBoxYearOfManufacture.TabIndex = 16;
            // 
            // labelYearOfManufacture
            // 
            this.labelYearOfManufacture.AutoSize = true;
            this.labelYearOfManufacture.BackColor = System.Drawing.SystemColors.Control;
            this.labelYearOfManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearOfManufacture.Location = new System.Drawing.Point(17, 159);
            this.labelYearOfManufacture.Name = "labelYearOfManufacture";
            this.labelYearOfManufacture.Size = new System.Drawing.Size(141, 18);
            this.labelYearOfManufacture.TabIndex = 15;
            this.labelYearOfManufacture.Text = "Year of manufacture";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.SystemColors.Control;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(17, 118);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(40, 18);
            this.labelType.TabIndex = 15;
            this.labelType.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(201, 116);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(175, 26);
            this.textBoxType.TabIndex = 16;
            // 
            // textBoxLicencePlate
            // 
            this.textBoxLicencePlate.Location = new System.Drawing.Point(201, 196);
            this.textBoxLicencePlate.Name = "textBoxLicencePlate";
            this.textBoxLicencePlate.Size = new System.Drawing.Size(175, 26);
            this.textBoxLicencePlate.TabIndex = 18;
            // 
            // labelLicencePlate
            // 
            this.labelLicencePlate.AutoSize = true;
            this.labelLicencePlate.BackColor = System.Drawing.SystemColors.Control;
            this.labelLicencePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicencePlate.Location = new System.Drawing.Point(17, 198);
            this.labelLicencePlate.Name = "labelLicencePlate";
            this.labelLicencePlate.Size = new System.Drawing.Size(94, 18);
            this.labelLicencePlate.TabIndex = 17;
            this.labelLicencePlate.Text = "Licence plate";
            // 
            // groupBoxVehicle
            // 
            this.groupBoxVehicle.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVehicle.Controls.Add(this.labelLicencePlateRegex);
            this.groupBoxVehicle.Controls.Add(this.labelEmailRegex);
            this.groupBoxVehicle.Controls.Add(this.textBoxLicencePlate);
            this.groupBoxVehicle.Controls.Add(this.labelLicencePlate);
            this.groupBoxVehicle.Controls.Add(this.textBoxType);
            this.groupBoxVehicle.Controls.Add(this.labelType);
            this.groupBoxVehicle.Controls.Add(this.textBoxYearOfManufacture);
            this.groupBoxVehicle.Controls.Add(this.labelYearOfManufacture);
            this.groupBoxVehicle.Controls.Add(this.textBoxBrand);
            this.groupBoxVehicle.Controls.Add(this.labelBrand);
            this.groupBoxVehicle.Controls.Add(this.textBoxChassisNumber);
            this.groupBoxVehicle.Controls.Add(this.labelChassisNumber);
            this.groupBoxVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVehicle.Location = new System.Drawing.Point(21, 152);
            this.groupBoxVehicle.Name = "groupBoxVehicle";
            this.groupBoxVehicle.Size = new System.Drawing.Size(420, 243);
            this.groupBoxVehicle.TabIndex = 19;
            this.groupBoxVehicle.TabStop = false;
            this.groupBoxVehicle.Text = "Vehicle";
            this.groupBoxVehicle.Enter += new System.EventHandler(this.groupBoxVehicle_Enter);
            // 
            // labelLicencePlateRegex
            // 
            this.labelLicencePlateRegex.AutoSize = true;
            this.labelLicencePlateRegex.BackColor = System.Drawing.Color.Transparent;
            this.labelLicencePlateRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicencePlateRegex.ForeColor = System.Drawing.Color.Red;
            this.labelLicencePlateRegex.Location = new System.Drawing.Point(203, 224);
            this.labelLicencePlateRegex.Name = "labelLicencePlateRegex";
            this.labelLicencePlateRegex.Size = new System.Drawing.Size(0, 13);
            this.labelLicencePlateRegex.TabIndex = 37;
            // 
            // labelEmailRegex
            // 
            this.labelEmailRegex.AutoSize = true;
            this.labelEmailRegex.BackColor = System.Drawing.Color.Transparent;
            this.labelEmailRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailRegex.ForeColor = System.Drawing.Color.Red;
            this.labelEmailRegex.Location = new System.Drawing.Point(203, 62);
            this.labelEmailRegex.Name = "labelEmailRegex";
            this.labelEmailRegex.Size = new System.Drawing.Size(0, 13);
            this.labelEmailRegex.TabIndex = 36;
            // 
            // NewRepairOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::CarServiceApp.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 559);
            this.Controls.Add(this.groupBoxVehicle);
            this.Controls.Add(this.buttonAddOwner);
            this.Controls.Add(this.comboBoxOwners);
            this.Controls.Add(this.buttonNewRepairOrder);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelNewCarInspectionTitle);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.textBoxRepairPrice);
            this.Controls.Add(this.labelRepairPrice);
            this.Controls.Add(this.textBoxMalfunctionDescription);
            this.Controls.Add(this.labelMalfunctionDesciption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewRepairOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCarInspection";
            this.Load += new System.EventHandler(this.NewCarInspection_Load);
            this.groupBoxVehicle.ResumeLayout(false);
            this.groupBoxVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMalfunctionDesciption;
        private System.Windows.Forms.TextBox textBoxMalfunctionDescription;
        private System.Windows.Forms.TextBox textBoxRepairPrice;
        private System.Windows.Forms.Label labelRepairPrice;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelNewCarInspectionTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonNewRepairOrder;
        private System.Windows.Forms.ComboBox comboBoxOwners;
        private System.Windows.Forms.Button buttonAddOwner;
        private System.Windows.Forms.TextBox textBoxChassisNumber;
        private System.Windows.Forms.Label labelChassisNumber;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textBoxYearOfManufacture;
        private System.Windows.Forms.Label labelYearOfManufacture;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxLicencePlate;
        private System.Windows.Forms.Label labelLicencePlate;
        private System.Windows.Forms.GroupBox groupBoxVehicle;
        private System.Windows.Forms.Label labelEmailRegex;
        private System.Windows.Forms.Label labelLicencePlateRegex;
    }
}