using System;
using System.Collections.Generic;
using System.ServiceModel;
//+
using Sample.Service.Client;
//+
namespace Sample.Service.Agent
{
    public class ContactAgent
    {
        //- @LoadContact -//
        public static Contact LoadContact(String contactGuid)
        {
            using (ContactClient client = new ContactClient(ServiceConfiguration.ActiveContactServiceEndpoint))
            {
                return client.LoadContact(contactGuid);
            }
        }

        //- @LoadContactList -//
        public static List<Contact> LoadContactList()
        {
            using (ContactClient client = new ContactClient(ServiceConfiguration.ActiveContactServiceEndpoint))
            {
                return client.LoadContactList();
            }
        }
    }
}