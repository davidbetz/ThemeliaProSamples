using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Description;
//+
using Sample.Service.Behavior;
using Sample.Web.Service;
//+
namespace Sample.Web.Service.Activation
{
    public class PersonServiceHostFactory : ServiceHostFactory
    {
        //- @CreateServiceHost -//
        public PersonServiceHost CreateServiceHost(Uri[] baseAddresses)
        {
            return (PersonServiceHost)CreateServiceHost(typeof(PersonService), baseAddresses);
        }

        //- #CreateServiceHost -//
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            PersonServiceHost host = new PersonServiceHost(baseAddresses);
            //+ add fault handler
            host.Description.Behaviors.Add(new FaultHandlingBehavior());
            //+ add metadata exchange
            ServiceMetadataBehavior serviceMetadataBehavior = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (serviceMetadataBehavior == null)
            {
                serviceMetadataBehavior = new ServiceMetadataBehavior();
                host.Description.Behaviors.Add(serviceMetadataBehavior);
            }
            serviceMetadataBehavior.HttpGetEnabled = true;
            ServiceEndpoint serviceEndpoint = host.Description.Endpoints.Find(typeof(IMetadataExchange));
            if (serviceEndpoint == null)
            {
                host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            }
            //+
            return host;
        }
    }
}