using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingLib
{
    [Serializable]
    public class RemotePlane
    {
        public RemotePlane(int planeID,int cityID,int companyID,String currentPosition, String currentState,String type,int speed,String name,String direction)
        {
            this.planeID = planeID;
            this.cityID = cityID;
            this.companyID = companyID;
            this.currentPosition = currentPosition;
            this.currentState = currentState;
            this.type = type;
            this.planeName = name;
            this.speed = speed;
            this.direction = direction;
        }
        public RemotePlane(int cityID, int companyID, String currentPosition, String currentState, String type, int speed, String name, String direction)
        {
            this.cityID = cityID;
            this.companyID = companyID;
            this.currentPosition = currentPosition;
            this.currentState = currentState;
            this.type = type;
            this.planeName = name;
            this.speed = speed;
            this.direction = direction;
        }

        public RemotePlane(String cityName, String companyName, String currentPosition, String currentState, String type, int speed, String name, String direction)
        {
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

       

        public int cityID
        {
            set;
            get;
        }

        public int companyID
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
