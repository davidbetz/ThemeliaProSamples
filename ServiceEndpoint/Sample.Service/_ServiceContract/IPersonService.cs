using System;
using System.ServiceModel;
//+
namespace Sample.Service
{
    [ServiceContract(Namespace = Information.Namespace.Contact)]
    public interface IPersonService
    {
        //- LoadPerson -//
        [OperationContract]
        Person GetPersonData(String personGuid);
    }
}