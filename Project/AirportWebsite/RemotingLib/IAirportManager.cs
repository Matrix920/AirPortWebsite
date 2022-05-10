using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingLib
{
    public interface IAirportManager
    {
        ValidationResult verifyPlane(RemotePlane rPlane);

        int addPlane(RemotePlane rPlane);

        void deletePlane(int planeID);


        void modifyPlane(RemotePlane rPlane);

        RemotePlaneView[] retrievePlanesByCity(int cityID);

         RemotePlane retrievePlane(int palneID);

        RemotePlaneView[] retrieveAllPlanes();


        RemoteCity[] retrieveAllCites();

        RemoteCompany[] retrieveAllCompanies();

        void addCompany(RemoteCompany rCompany);

        void modifyCompany(RemoteCompany rCompany);


        void deleteCompany(int companyID);

        RemoteCompany retrieveCompany(int companyID);

        void addCtiy(RemoteCity rCity);

        void modifyCity(RemoteCity rCity);

        bool modifyCityBool(RemoteCity rCity);


        void delteCity(int cityID);

        RemoteCity retrieveCity(int cityID);

    }
}
