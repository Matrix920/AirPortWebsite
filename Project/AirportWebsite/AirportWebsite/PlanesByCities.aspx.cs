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
    public partial class PlanesByCities : System.Web.UI.Page
    {
        IAirportManager manager = Remoting.getAriportManager();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                var cities=getCities();

                foreach(RemoteCity city in cities)
                {
                    DropDownListCity.Items.Add(new ListItem
                    {
                        Text = city.cityName,
                        Value = city.cityID.ToString()
                    });
                }
            }

        }

        private List<RemoteCity> getCities()
        {
            var rCities = manager.retrieveAllCites().ToList();

            return rCities;
        }

        private void getPlanesByCity(int cityID)
        {
            var planes = manager.retrievePlanesByCity(cityID).ToList();
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
            String cityID = DropDownListCity.SelectedValue;

            getPlanesByCity(Int32.Parse(cityID));
        }
    }
}