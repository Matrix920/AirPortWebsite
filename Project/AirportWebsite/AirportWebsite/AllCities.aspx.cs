using AirportWebsite.Utils;
using RemotingLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirportWebsite
{
    public partial class AllCities : System.Web.UI.Page
    {
        IAirportManager manager = Remoting.getAriportManager();
        protected void Page_Load(object sender, EventArgs e)
        {


            getCities();

        }

        private void getCities()
        {
            var planes = manager.retrieveAllCites().ToList();

            GridView1.DataSource = planes;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;

            String cityID = row.Cells[1].Text;

            Response.Redirect("~/CityDetails.aspx?id=" + cityID);
        }



        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];

            String planeID = row.Cells[1].Text;
            manager.delteCity(Int32.Parse(planeID));

            getCities();
        }
    }
}