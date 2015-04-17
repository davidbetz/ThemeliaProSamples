using System;
using System.Runtime.Serialization;
//+
namespace Sample.Service
{
    [DataContract(Namespace = Information.Namespace.Contact)]
    public class Contact
    {
        //- @Id -//
        [DataMember]
        public Int32 Id { get; set; }

        //- @Password -//
        [DataMember]
        public String Password { get; set; }

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