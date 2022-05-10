using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAirportManager
    {

        [OperationContract]
        List<WcfPlane> retrievePlanesByCompanyL(int  companyID);

        [OperationContract]
        List<WcfPlane> findCollision();


        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfService.ContractType".
    [DataContract]
    public class WcfPlane
    {
        public WcfPlane(int planeID,String planeName,String city,String company,String type,String position,String direction,int speed,String state)
        {
            this.planeID = planeID;
            this.planeName = planeName;
            this.city = city;
            this.company = company;
            this.speed = speed;
            this.type = type;
            this.CurrentPosition = position;
            this.direction = direction;
            this.currentState = state;
        }

        [DataMember]
        public int planeID
        {
            get;
            set;
        }

        [DataMember]
        public String planeName
        {
            get;
            set;
        }

        [DataMember]
        public string city
        {
            set;
            get;
        }

        [DataMember]
        public string direction
        {
            set;
            get;
        }

        [DataMember]
        public string company
        {
            set;
            get;
        }

        [DataMember]
        public string type
        {
            set;
            get;
        }

        [DataMember]
        public int speed
        {
            set;
            get;
        }

        [DataMember]
        public string CurrentPosition
        {
            set;
            get;
        }

        [DataMember]
        public string currentState
        {
            set;
            get;
        }
    }
}
