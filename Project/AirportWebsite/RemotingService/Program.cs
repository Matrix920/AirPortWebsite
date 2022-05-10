using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Http;

namespace RemotingService
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HttpChannel channel = new HttpChannel(1111);

                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(AirportManager),
                    "AriportManager.soap",
                    WellKnownObjectMode.Singleton);

                Console.WriteLine("server strarted");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("cannot start server");
            }
        }
    }
}
