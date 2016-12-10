using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            EndpointAddress ep = new EndpointAddress("http://Localhost:8000/HelloIndigo/HelloIndigoService");

            //IHelloIndigoService proxy = ChannelFactory<IHelloIndigoService>.CreateChannel(new WSHttpBinding(), ep);
            var Client = new HelloIndigoService(new WSHttpBinding(), ep);

            // string configSettings = proxy.
            //string s = proxy.HelloIndigo();
            string s = Client.HelloIndigo();
            Console.WriteLine(s);

            Console.WriteLine("Press <ENTER> to terminate client.");
            Console.ReadLine();
        }
    }
}
