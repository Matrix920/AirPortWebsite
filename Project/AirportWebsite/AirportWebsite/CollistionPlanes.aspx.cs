using AirportWebsite.WcfServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirportWebsite
{
    public partial class CollistionPlanes : System.Web.UI.Page
    {
        AirportManagerClient service;
        protected void Page_Load(object sender, EventArgs e)
        {

            service = new AirportManagerClient();

            getPlanes();

        }

        private void getPlanes()
        {
            var planes = service.findCollision();

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
           // manager.deletePlane(Int32.Parse(planeID));

            getPlanes();
        }
    }
}