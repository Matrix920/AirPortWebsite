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
    public partial class PlaneDetails : System.Web.UI.Page
    {
        IAirportManager manager = Remoting.getAriportManager();

        private static readonly String EDIT = "edit";
        private static readonly String NEW = "new";
        private String STATE = NEW;

        String id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                id = Request.QueryString["id"];
                STATE = EDIT;
                if (!IsPostBack)
                {
                    loadInformation();
                }
            }
            else
            {
                STATE = NEW;
            }

            if (!IsPostBack)
            {
                var cities = manager.retrieveAllCites().ToList();

                foreach (RemoteCity city in cities)
                {
                    DropDownListCity.Items.Add(new ListItem
                    {
                        Text = city.cityName,
                        Value = city.cityID.ToString()
                    });
                }
                var companies = manager.retrieveAllCompanies().ToList();

                foreach (RemoteCompany c in companies)
                {
                    DropDownListCompany.Items.Add(new ListItem
                    {
                        Text = c.companyName,
                        Value = c.companyID.ToString()
                    });
                }

            }
        }

        private void loadInformation()
        {
            var c = manager.retrievePlane(Int32.Parse(id));
            viewInformation(c);
        }

        private void viewInformation(RemotePlane c)
        {
            LabelPlaneID.Text = c.planeID.ToString();
            TextBoxCurrentPosition.Text = c.currentPosition;
            TextBoxName.Text = c.planeName;
            TextBoxSpeed.Text = c.speed.ToString();
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            
            String postion = TextBoxCurrentPosition.Text;
            String state = DropDownListState.SelectedValue;
            String direction = DropDownListDirection.SelectedValue;
            String type = DropDownListType.SelectedValue;
            String cityID = DropDownListCity.SelectedValue;
            String companyID = DropDownListCompany.SelectedValue;
            String speed = TextBoxSpeed.Text;
            String name = TextBoxName.Text;

            if (STATE.Equals(EDIT))
            {
                RemotePlane plane = new RemotePlane(Int32.Parse(id), Int32.Parse(cityID), Int32.Parse(companyID), postion, state, type, Int32.Parse(speed), name, direction);
                // RemotePlane plane = new RemotePlane(Int32.Parse(id), 2, 2, postion, state, type, Int32.Parse(speed), name, direction);
                var valid = manager.verifyPlane(plane);
                if (valid.ok)
                {
                    manager.modifyPlane(plane);
                    Response.Redirect("~/AllPlanes.aspx");
                }
                else
                {
                    Label1.Text = valid.validationMessage;
                }
                
            }
            else
            {
                 RemotePlane plane = new RemotePlane(Int32.Parse(cityID), Int32.Parse(companyID), postion, state, type, Int32.Parse(speed),name, direction);
           
                var valid = manager.verifyPlane(plane);
                if (valid.ok)
                {
                    manager.addPlane(plane);
                    Response.Redirect("~/AllPlanes.aspx");
                }
                else
                {
                    Label1.Text = valid.validationMessage;
                }
            }

            
        }
    }
}