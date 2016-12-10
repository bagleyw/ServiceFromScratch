using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class HelloIndigoService : System.ServiceModel.ClientBase<Client.IHelloIndigoService>, Client.IHelloIndigoService
    {
        public HelloIndigoService()
        {
        }

        public HelloIndigoService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }

        public HelloIndigoService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }

        public HelloIndigoService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }

        public HelloIndigoService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public string HelloIndigo()
        {
            return "Hell Indigo!";
        }
    }
}
