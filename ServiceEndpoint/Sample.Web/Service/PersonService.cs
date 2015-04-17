using System;
//+
using Sample.Service;
//+
namespace Sample.Web.Service
{
    public class PersonService : Sample.Service.IPersonService
    {
        public Person GetPersonData(String personGuid)
        {
            Contact contact = Sample.Service.Agent.ContactAgent.LoadContact(personGuid);
            if (contact != null)
            {
                return new Person
                {
                    City = contact.City,
                    FirstName = contact.FirstName,
                    Guid = contact.Guid,
                    LastName = contact.LastName,
                    PostalCode = contact.PostalCode,
                    State = contact.State
                };
            }
            //+
            return new Person();
        }
    }
}