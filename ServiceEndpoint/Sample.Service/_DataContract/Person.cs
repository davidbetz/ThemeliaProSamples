using System;
using System.Runtime.Serialization;
//+
namespace Sample.Service
{
    [DataContract(Namespace = Information.Namespace.Person)]
    public class Person
    {
        //- @Guid -//
        [DataMember]
        public String Guid { get; set; }

        //- @FirstName -//
        [DataMember]
        public String FirstName { get; set; }

        //- @LastName -//
        [DataMember]
        public String LastName { get; set; }

        //- @City -//
        [DataMember]
        public String City { get; set; }

        //- @State -//
        [DataMember]
        public String State { get; set; }

        //- @PostalCode -//
        [DataMember]
        public String PostalCode { get; set; }
    }
}