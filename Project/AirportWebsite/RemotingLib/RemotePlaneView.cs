using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingLib
{
    [Serializable]
   public class RemotePlaneView
    {

        public RemotePlaneView(int planeID,String cityName, String companyName, String currentPosition, String currentState, String type, int speed, String name, String direction)
        {
            this.planeID = planeID;
            this.cityName = cityName;
            this.companyName = companyName;
            this.currentPosition = currentPosition;
            this.currentState = currentState;
            this.type = type;
            this.planeName = name;
            this.speed = speed;
            this.direction = direction;
        }
        public int planeID
        {
            set;
            get;
        }

        public String cityName
        {
            get;
            set;
        }

        public String companyName
        {
            set;
            get;
        }

       

        public String planeName
        {
            set;
            get;
        }

        public String currentState
        {
            set;
            get;
        }

        public String type
        {
            set;
            get;
        }

        public String currentPosition
        {
            set;
            get;
        }

        public int speed
        {
            set;
            get;
        }

        public String direction
        {
            set;
            get;
        }
    }
}
