using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Unity;

namespace CarServiceWebApplication1
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            var container = this.AddUnity();

            container.RegisterType<IOwnerRepository, OwnerRepository>();
            container.RegisterType<IOwnerBusiness, OwnerBusiness>();

            container.RegisterType<IRepairOrderRepository, RepairOrderRepository>();
            container.RegisterType<IRepairOrderBusiness, RepairOrderBusiness>();

            container.RegisterType<IVehicleRepository, VehicleRepository>();
            container.RegisterType<IVehicleBusiness, VehicleBusiness>();

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}