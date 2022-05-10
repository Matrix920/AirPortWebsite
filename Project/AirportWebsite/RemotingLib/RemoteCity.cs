using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingLib
{
    [Serializable]
    public class RemoteCity
    {
        public RemoteCity(int cityID,String cityName,String cityCode,String position)
        {
            this.cityID = cityID;
            this.cityName = cityName;
            this.cityCode = cityCode;
            this.position = position;
        }

        public RemoteCity(String cityName, String cityCode, String position)
        {
            this.cityName = cityName;
            this.cityCode = cityCode;
            this.position = position;
        }

        public int cityID
        {
            set;
            get;
        }

        public String cityName
        {
            set;
            get;
        }

        public String position
        {
            set;
            get;
        }

        public String cityCode
        {
            set;
            get;
        }
    }
}
