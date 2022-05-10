using DBLib.LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.UtilRemoting
{
    public class UtilCity
    {
        AirportLinqDataContext db = new AirportLinqDataContext();

        public int addCity(City city)
        {
            db.Cities.InsertOnSubmit(city);
            db.SubmitChanges();

            return city.CityID;
        }

        public void deleteCity(int cityID)
        {
            var myCity = (from city in db.Cities
                          where city.CityID == cityID
                          select city).SingleOrDefault();

            if (myCity != null)
            {
                db.Cities.DeleteOnSubmit(myCity);
                db.SubmitChanges();
            }
        }

        public void modify(City c)
        {
            var myCity = (from city in db.Cities
                          where city.CityID == c.CityID
                          select city).SingleOrDefault();

            if (myCity != null)
            {
                myCity.CityName = c.CityName;
                myCity.CityCode = c.CityCode;
                myCity.Position = c.Position;

                db.SubmitChanges();
            }
        }

        public bool modifyBool(City c)
        {
            var myCity = (from city in db.Cities
                          where city.CityID == c.CityID
                          select city).SingleOrDefault();

            if (myCity != null)
            {
                myCity.CityName = c.CityName;
                myCity.CityCode = c.CityCode;
                myCity.Position = c.Position;

                db.SubmitChanges();
                return true;
            }

            return false;
        }

        public List<City> retrieveAllCities()
        {
            return db.Cities.ToList();
        }

        public City retrieveCity(int cityID)
        {
            var myCity = (from city in db.Cities
                          where city.CityID == cityID
                          select city).SingleOrDefault();

            return myCity;
        }

    }
}
