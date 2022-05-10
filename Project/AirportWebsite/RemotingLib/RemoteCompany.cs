using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingLib
{
    [Serializable]
    public class RemoteCompany
    {
        public RemoteCompany(int companyID,String companyName,String nationality,String companyCode)
        {
            this.companyID = companyID;
            this.companyCode = companyCode;
            this.nationality = nationality;
            this.companyName = companyName;
        }
        public RemoteCompany( String companyName, String nationality, String companyCode)
        {
            this.companyCode = companyCode;
            this.nationality = nationality;
            this.companyName = companyName;
        }

        public int companyID
        {
            set;
            get;
        }

        public String companyName
        {
            set;
            get;
        }

        public String nationality
        {
            set;
            get;
        }

        public String companyCode
        {
            set;
            get;
        }
    }
}
