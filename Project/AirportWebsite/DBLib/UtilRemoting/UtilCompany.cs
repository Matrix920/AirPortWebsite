using DBLib.LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.UtilRemoting
{
    public class UtilCompany
    {
        AirportLinqDataContext db = new AirportLinqDataContext();

        public int addCompany(Company comapny)
        {
            db.Companies.InsertOnSubmit(comapny);
                db.SubmitChanges();

            return comapny.CompanyID;
        }

        public void modifyCompany(Company c)
        {
            var myCompany = (from company in db.Companies
                             where company.CompanyID == c.CompanyID
                             select company).SingleOrDefault();

            if (myCompany != null)
            {
                myCompany.CompanyCode = c.CompanyCode;
                myCompany.Nationality = c.Nationality;
                myCompany.CompanyName = c.CompanyName;

                db.SubmitChanges();
            }
        }

        public void delteCompany(int companyID)
        {
            var myCompany = (from company in db.Companies
                             where company.CompanyID == companyID
                             select company).SingleOrDefault();

            if (myCompany != null)
            {
                db.Companies.DeleteOnSubmit(myCompany);
                db.SubmitChanges();
            }
        }

        public List<Company> retrieveAllCompanies()
        {
            return db.Companies.ToList();
        }


        public Company retrieveCompany(int companyID)
        {
            var myCompany = (from company in db.Companies
                             where company.CompanyID == companyID
                             select company).SingleOrDefault();

            return myCompany;
        }
    }

   
}
