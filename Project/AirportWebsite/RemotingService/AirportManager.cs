using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemotingLib;
using DBLib.LinqToDB;
using DBLib.UtilRemoting;

namespace RemotingService
{
    public class AirportManager : MarshalByRefObject, IAirportManager
    {
        UtilCompany cmp = new UtilCompany();
        UtilCity cty = new UtilCity();
        UtilPlane pln = new UtilPlane();

        public void addCompany(RemoteCompany rCompany)
        {
            cmp.addCompany(new Company
            {
                CompanyCode = rCompany.companyCode,
                CompanyName = rCompany.companyName,
                Nationality = rCompany.nationality
            });
        }

        public void addCtiy(RemoteCity rCity)
        {
            cty.addCity(new City
            {
                CityCode = rCity.cityCode,
                CityName = rCity.cityName,
                Position = rCity.position
            });
        }

        public int addPlane(RemotePlane rPlane)
        {
            int id=pln.addPlane(new Plane
            {
                PlaneName = rPlane.planeName,
                CompanyID = rPlane.companyID,
                CityID = rPlane.cityID,
                CurrentPosition = rPlane.currentPosition,
                CurrentState = rPlane.currentState,
                Type = rPlane.type,
                Direction = rPlane.direction,
                Speed = rPlane.speed
            });

            return id;
        }



        public void deleteCompany(int companyID)
        {
            cmp.delteCompany(companyID);
        }

        
        public void deletePlane(int planeID)
        {
            pln.deletePlane(planeID);
        }

        public void delteCity(int cityID)
        {
            cty.deleteCity(cityID);
        }

        public void modifyCity(RemoteCity rCity)
        {
            cty.modify(new City

            { CityID=rCity.cityID,
                CityCode = rCity.cityCode,
                CityName = rCity.cityName,
                Position = rCity.position
            });
        }

        public bool modifyCityBool(RemoteCity rCity)
        {
            bool x=cty.modifyBool(new City

            {
                CityID = rCity.cityID,
                CityCode = rCity.cityCode,
                CityName = rCity.cityName,
                Position = rCity.position
            });

            return x;
        }

        public void modifyCompany(RemoteCompany rCompany)
        {
            cmp.modifyCompany(new Company
            {
                CompanyID=rCompany.companyID,
                Nationality = rCompany.nationality,
                CompanyName = rCompany.companyName,
                CompanyCode = rCompany.companyCode
            });
        }

        public void modifyPlane(RemotePlane rPlane)
        {
            Plane plane = new Plane
            {
                PlaneID = rPlane.planeID,
                PlaneName = rPlane.planeName,
                CityID = rPlane.cityID,
                CompanyID = rPlane.companyID,
                CurrentPosition = rPlane.currentPosition,
                CurrentState = rPlane.currentState,
                Type = rPlane.type,
                Speed = rPlane.speed,
                Direction = rPlane.direction
            };
            pln.modifyPlane(plane);
        }

       
        public RemoteCity[] retrieveAllCites()
        {

            var cities = cty.retrieveAllCities();

            RemoteCity[] rCities = new RemoteCity[cities.Count];

            int i = 0;
            foreach (City city in cities)
            {
                rCities[i]=retrieveCity(city.CityID);
                i++;
            }

            return rCities;
        }

        public RemoteCompany[] retrieveAllCompanies()
        {
            var companies = cmp.retrieveAllCompanies();

            var rCompanies = new RemoteCompany[companies.Count];

            int i = 0;
            foreach(Company c in companies)
            {
                rCompanies[i]=retrieveCompany(c.CompanyID);
                i++;
            }

            return rCompanies;
        }

     

        public RemotePlaneView[] retrieveAllPlanes()
        {
            var planes = pln.retrieveAllPlanes();

            var rPlanes = new RemotePlaneView[planes.Count];

            int i = 0;
            foreach (Plane p in planes)
            {
                rPlanes[i]= retrievePlaneFroView(p.PlaneID);
                i++;
            }

            return rPlanes;
        }

        public RemoteCity retrieveCity(int cityID)
        {
            var city = cty.retrieveCity(cityID);

            var rCity = new RemoteCity (city.CityID,city.CityName,  city.CityCode, city.Position);

            return rCity;
        }

        public RemoteCompany retrieveCompany(int companyID)
        {
            var c = cmp.retrieveCompany(companyID);

            var rCompany = new RemoteCompany(c.CompanyID,c.CompanyName, c.Nationality, c.CompanyCode);

            return rCompany;
        }

        public RemotePlane retrievePlane(int planeID)
        {
            var p = pln.retrievePlane(planeID);

            var rPlane = new RemotePlane(p.PlaneID,p.CityID, p.CompanyID, p.CurrentPosition, p.CurrentState, p.Type, p.Speed, p.PlaneName, p.Direction);

            return rPlane;
        }

        public RemotePlaneView retrievePlaneFroView(int planeID)
        {
            var p = pln.retrievePlane(planeID);

            var rPlane = new RemotePlaneView(p.PlaneID,p.City.CityName, p.Company.CompanyName, p.CurrentPosition, p.CurrentState, p.Type, p.Speed, p.PlaneName, p.Direction);

            return rPlane;
        }

        public RemotePlaneView[] retrievePlanesByCity(int cityID)
        {
            var planes = pln.retrievePlanesByCity(cityID);

            var rPlanes = new RemotePlaneView[planes.Count];

            int i = 0;
            foreach (Plane p in planes)
            {
                rPlanes[i]= retrievePlaneFroView(p.PlaneID);
            }

            return rPlanes;
        }

        public ValidationResult verifyPlane(RemotePlane rPlane)
        {
            if(rPlane.planeName==null || rPlane.planeName.Length == 0)
            {
                return new ValidationResult(false, "plane name missing");
            }

            if (rPlane.currentPosition == null || rPlane.currentPosition.Length == 0)
            {
                return new ValidationResult(false, "current postion missing");
            }

            if (rPlane.currentState == null || rPlane.currentState.Length == 0)
            {
                return new ValidationResult(false, "current state missing");
            }

            if (rPlane.type == null || rPlane.type.Length == 0)
            {
                return new ValidationResult(false, "type missing");
            }

            if (rPlane.direction == null || rPlane.direction.Length == 0)
            {
                return new ValidationResult(false, "direction missing");
            }

          

            return new ValidationResult(true, "validation succeeded");
        }
    }
}
