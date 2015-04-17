using System;
//+
namespace Sample.Web.Routing
{
    public class AliasedHandlerFactory : Themelia.Web.Routing.AliasedHandlerFactoryBase
    {
        //- @CreateHttpHandler -//
        public override System.Web.IHttpHandler CreateHttpHandler(String text)
        {
            switch (text)
            {
                case "auth":
                case "authentication":
                    return new Security.AuthenticationHttpHandler();
            }
            //+
            return null;
        }
    }
}