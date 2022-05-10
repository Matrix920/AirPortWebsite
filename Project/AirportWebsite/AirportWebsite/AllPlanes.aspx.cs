using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AirportWebsite.Utils;
using RemotingLib;

namespace AirportWebsite
{
    public partial class AllPlanes : System.Web.UI.Page
    {
        IAirportManager manager = Remoting.getAriportManager();
        protected void Page_Load(object sender, EventArgs e)
        {


            getPlanes();

        }

        private void getPlanes()
        {
            var planes = manager.retrieveAllPlanes().ToList();

            GridView1.DataSource = planes;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;

            String planeID = row.Cells[1].Text;

            Response.Redirect("~/PlaneDetails.aspx?id=" + planeID);


        }

    

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];

            String planeID = row.Cells[1].Text;
            manager.deletePlane(Int32.Parse(planeID));

            getPlanes();
        }
    }
}