using DBLib.LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.UtilRemoting
{
    public class UtilPlane
    {
        AirportLinqDataContext db = new AirportLinqDataContext();

        public int addPlane(Plane plane)
        {
            db.Planes.InsertOnSubmit(plane);
            db.SubmitChanges();

            return plane.PlaneID;
        }

        public void deletePlane(int planeID)
        {
            Plane myPlane = (from plane in db.Planes
                           where plane.PlaneID == planeID
                           select plane).SingleOrDefault();

            if (myPlane != null)
            {
                db.Planes.DeleteOnSubmit(myPlane);
                db.SubmitChanges();
            }
        }

        public void modifyPlane(Plane p)
        {
            deletePlane(p.PlaneID);
            addPlane(p);
        }

        public List<Plane> retrieveAllPlanes()
        {
            return db.Planes.ToList();
        }

        public List<Plane> retrievePlanesByCity(int cityID)
        {
            var planes = (from plane in db.Planes
                          where plane.CityID == cityID
                          select plane).ToList();

            return planes;
        }

        public List<Plane> retrievePlanesByCompany(int companyID)
        {
            var planes = (from plane in db.Planes
                          where plane.CompanyID == companyID
                          select plane).ToList();

            return planes;
        }

        public Plane retrievePlane(int planeID)
        {
            var myPlane = (from plane in db.Planes
                           where plane.PlaneID == planeID
                           select plane).SingleOrDefault();

            return myPlane;
        }

    }
}
