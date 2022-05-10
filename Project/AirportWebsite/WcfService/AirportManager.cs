using DBLib.LinqToDB;
using DBLib.UtilRemoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AirportManager : IAirportManager
    {
        UtilPlane pln = new UtilPlane();

        /*
        find if two planes are in the same position and have the same current state which is travelling 
        will cause collistion 
        */
        public List<WcfPlane> findCollision()
        {
            var planes = pln.retrieveAllPlanes();

            var collisionPlanes = new List<WcfPlane>();

            for (int i = 0; i < planes.Count; i++)
                for (int j = i + 1; j < planes.Count; j++)
                {
                    var plane1 = planes[i];
                    var plane2 = planes[j];
                    if (plane1.CurrentState.Equals(plane2.CurrentState)&&plane1.CurrentState.Equals("Travelling")
                            && plane1.CurrentPosition.Equals(plane2.CurrentPosition) && !(plane1.Direction.Equals("Stopped")|| plane2.Direction.Equals("Stopped")))
                    {
                        collisionPlanes.Add(new WcfPlane(plane1.PlaneID, plane1.PlaneName, plane1.City.CityName, plane1.Company.CompanyName, plane1.Type, plane1.CurrentPosition, plane1.Direction, plane1.Speed, plane1.CurrentState));
                        collisionPlanes.Add(new WcfPlane(plane2.PlaneID, plane2.PlaneName, plane2.City.CityName, plane2.Company.CompanyName, plane2.Type, plane2.CurrentPosition, plane2.Direction, plane2.Speed, plane2.CurrentState));
                    }
                }
            return collisionPlanes;
        }

        /*
        retrieve all planes with a specified company
        */
        public List<WcfPlane> retrievePlanesByCompanyL(int companyID)
        {
            var planes = pln.retrievePlanesByCompany(companyID);

            var wcfPlanes = new List<WcfPlane>();

            foreach(Plane plane in planes)
            {
                wcfPlanes.Add(new WcfPlane(plane.PlaneID,plane.PlaneName, plane.City.CityName, plane.Company.CompanyName, plane.Type, plane.CurrentPosition, plane.Direction, plane.Speed, plane.CurrentState));
            }

            return wcfPlanes;
        }
    }
}
