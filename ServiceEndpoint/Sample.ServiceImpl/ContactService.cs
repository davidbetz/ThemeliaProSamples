using System;
using System.Collections.Generic;
using System.Linq;
//+
namespace Sample.Service
{
    public class ContactService : IContactService
    {
        private static List<Contact> ContactDatabase = null;

        //+
        //- @Ctor -//
        public ContactService()
        {
            ContactDatabase = new List<Contact>(
                new Contact[] {
                    new Contact{
                         Id=1, Guid="8946B939-2176-4aa0-8E0B-51FAED078A56", FirstName="David", LastName="Betz",
                         City="Unknown", PostalCode="12345", State="KS"
                    },
                    new Contact{
                         Id=2, Guid="72E0335A-2864-49d8-8060-12D6BEB01385", FirstName="John", LastName="Doe",
                         City="Unknown", PostalCode="23456", State="MA"
                    },
                    new Contact{
                         Id=3, Guid="C2DDCFC7-63E0-4bab-B9F1-D5D59B88F88C", FirstName="Bob", LastName="Smith",
                         City="Unknown", PostalCode="45678", State="MO"
                    }
                }
            );
        }
        //- @LoadContactList -//
        public List<Contact> LoadContactList()
        {
            return ContactDatabase;
        }

        //- @LoadContact -//
        public Contact LoadContact(String contactGuid)
        {
            return ContactDatabase.SingleOrDefault(p => p.Guid == contactGuid);
        }
    }
}