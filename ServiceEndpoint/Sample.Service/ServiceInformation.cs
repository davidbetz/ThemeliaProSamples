using System;
//+
namespace Sample.Service
{
    public class Information
    {
        //- @NamespaceRoot -//
        public const String NamespaceRoot = "http://www.netfxharmonics.com/service/";

        //+
        //- @Namespace -//
        public class Namespace
        {
            public const String Person = Information.NamespaceRoot + "Person/2008/10/";
            public const String Contact = Information.NamespaceRoot + "Contact/2008/10/";
        }
    }
}
