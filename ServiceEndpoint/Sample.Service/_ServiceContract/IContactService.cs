using System;
using System.Collections.Generic;
using System.ServiceModel;
//+
namespace Sample.Service
{
    [ServiceContract(Namespace = Information.Namespace.Contact)]
    public interface IContactService
    {
        //- LoadContact -//
        [OperationContract]
        Contact LoadContact(String contactGuid);

        //- LoadContactList -//
        [OperationContract]
        List<Contact> LoadContactList();
    }
}