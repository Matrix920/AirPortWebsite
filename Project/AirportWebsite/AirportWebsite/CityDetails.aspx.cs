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
    public partial class CityDetails : System.Web.UI.Page
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
        }

        private void loadInformation(){
            var city = manager.retrieveCity(Int32.Parse(id));
            viewInformation(city);
        }

        private void viewInformation(RemoteCity city)
        {
            LabelID.Text = city.cityID.ToString();
            TextBoxCode.Text = city.cityCode;
            TextBoxName.Text = city.cityName;
            TextBoxPosition.Text = city.position;
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            String name = TextBoxName.Text;
            String cID = LabelID.Text;
            String code = TextBoxCode.Text;
            String postion = TextBoxPosition.Text;

            if (STATE.Equals(EDIT))
            {
                RemoteCity rCity = new RemoteCity(Int32.Parse(cID), name, code, postion);
                manager.modifyCity(rCity);
                
            }
            else
            {
                manager.addCtiy(new RemoteCity(name, code, postion));
            }

            Response.Redirect("~/AllCities.aspx");
        }
    }
}