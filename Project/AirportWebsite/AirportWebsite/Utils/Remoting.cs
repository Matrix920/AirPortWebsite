using RemotingLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Web;

namespace AirportWebsite.Utils
{
    public class Remoting
    {
        private static IAirportManager airportManager;

        public static IAirportManager getAriportManager()
        {
            if (airportManager == null)
            {
                HttpChannel channel = new HttpChannel();
                ChannelServices.RegisterChannel(channel);

                airportManager = (IAirportManager)Activator.GetObject(typeof(IAirportManager), "http://localhost:1111/AriportManager.soap");
            }

            return airportManager;
        }
    }
}