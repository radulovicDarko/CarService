using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceWebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ButtonCarInspections.Click += new EventHandler(this.ButtonCarInspections_Click);
            ButtonClients.Click += new EventHandler(this.ButtonClients_Click);
        }
        private void ButtonCarInspections_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CarInspections.aspx");
        }
        private void ButtonClients_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Clients.aspx");
        }
    }
}