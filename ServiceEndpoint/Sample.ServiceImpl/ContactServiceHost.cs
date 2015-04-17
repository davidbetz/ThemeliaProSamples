using System;
using System.ServiceModel;
//+
namespace Sample.Service
{
    public class ContactServiceHost : ServiceHost
    {
        //- @Ctor -//
        public ContactServiceHost(params Uri[] baseAddresses)
            : base(typeof(ContactService), baseAddresses)
        {
        }
    }
}