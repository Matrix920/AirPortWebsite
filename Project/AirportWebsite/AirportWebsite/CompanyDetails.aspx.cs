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
    public partial class CompanyDetails : System.Web.UI.Page
    {
        IAirportManager manager = Remoting.getAriportManager();

        
        private static readonly String EDIT = "edit";
        private static readonly String NEW = "new";
        private  String STATE = NEW;

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

        private void loadInformation()
        {
            var c = manager.retrieveCompany(Int32.Parse(id));
            viewInformation(c);
        }

        private void viewInformation(RemoteCompany c)
        {
            LabelID.Text = c.companyID.ToString();
            TextBoxCode.Text = c.companyCode;
            TextBoxName.Text = c.companyName;
            TextBoxNationality.Text = c.nationality;
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            String name = TextBoxName.Text;
            String code = TextBoxCode.Text;
            String nationality = TextBoxNationality.Text;

            if (STATE.Equals(EDIT))
            {
                manager.modifyCompany(new RemoteCompany(Int32.Parse(id), name, nationality, code));
            }
            else
            {
                manager.addCompany(new RemoteCompany(name, nationality, code));
            }

            Response.Redirect("~/AllCompanies.aspx");
        }
    }
}