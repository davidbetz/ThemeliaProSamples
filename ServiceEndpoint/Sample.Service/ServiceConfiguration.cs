using System;
//+
using Themelia.Configuration;
//+
namespace Sample.Service
{
    public static class ServiceConfiguration
    {
        //- @ActiveContactServiceEndpoint -//
        public static String ActiveContactServiceEndpoint
        {
            get
            {
                return ConfigAccessor.ApplicationSettings("ActiveContactServiceEndpoint");
            }
        }
    }
}
