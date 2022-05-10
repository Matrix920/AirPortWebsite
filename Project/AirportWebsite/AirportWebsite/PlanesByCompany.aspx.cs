using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AirportWebsite.WcfServiceReference;
using AirportWebsite.Utils;
using RemotingLib;

namespace AirportWebsite
{
    public partial class PlanesByCompany : System.Web.UI.Page
    {

        AirportManagerClient service;

        RemotingLib.IAirportManager manager = Remoting.getAriportManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            service = new AirportManagerClient();

            if (!IsPostBack)
            {
                var companies = manager.retrieveAllCompanies();

                foreach (RemoteCompany company in companies)
                {
                    DropDownListCompany.Items.Add(new ListItem
                    {
                        Text = company.companyName,
                        Value = company.companyID.ToString()
                    });
                }
            }

        }
        

        private void getPlanesByCompany(int companyID)
        {
            var planes = service.retrievePlanesByCompanyL(companyID);
            if (planes != null)
            {
                GridView1.DataSource = planes;
                GridView1.DataBind();
            }
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

            // getPlanes();
        }

        protected void DropDownListCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            String companyID = DropDownListCompany.SelectedValue;

            getPlanesByCompany(Int32.Parse(companyID));
        }
    }
}