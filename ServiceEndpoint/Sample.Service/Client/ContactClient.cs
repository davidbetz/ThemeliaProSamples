using System;
using System.Collections.Generic;
using System.ServiceModel;
//+
namespace Sample.Service.Client
{
    public class ContactClient : ClientBase<IContactService>, IContactService
    {
        //- @Ctor -//
        public ContactClient(String endpointConfigurationName)
            : base(endpointConfigurationName) { }

        //+
        //- @LoadContactList -//
        public List<Contact> LoadContactList()
        {
            return base.Channel.LoadContactList();
        }

        //- @LoadContact -//
        public Contact LoadContact(String contactGuid)
        {
            return base.Channel.LoadContact(contactGuid);
        }
    }
}