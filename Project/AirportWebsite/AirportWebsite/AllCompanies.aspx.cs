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
    public partial class AllCompanies : System.Web.UI.Page
    {
        IAirportManager manager = Remoting.getAriportManager();
        protected void Page_Load(object sender, EventArgs e)
        {


            getPlanes();

        }

        private void getPlanes()
        {
            var planes = manager.retrieveAllCompanies().ToList();

            GridView1.DataSource = planes;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;

            String companyID = row.Cells[1].Text;

            Response.Redirect("~/CompanyDetails.aspx?id=" + companyID);
        }



        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];

            String id = row.Cells[1].Text;
            manager.deleteCompany(Int32.Parse(id));

            getPlanes();
        }
    }
}