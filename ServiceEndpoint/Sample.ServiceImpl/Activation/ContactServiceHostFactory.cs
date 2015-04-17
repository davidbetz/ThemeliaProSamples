using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Description;
//+
using Themelia.ServiceModel.Behavior;
//+
namespace Sample.Service.Activation
{
    public class ContactServiceHostFactory : ServiceHostFactory
    {
        //- @CreateServiceHost -//
        public ContactServiceHost CreateServiceHost(Uri[] baseAddresses)
        {
            return (ContactServiceHost)CreateServiceHost(typeof(ContactService), baseAddresses);
        }

        //- #CreateServiceHost -//
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            ContactServiceHost host = new ContactServiceHost(baseAddresses);
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