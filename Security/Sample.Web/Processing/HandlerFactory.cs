using System;
//+
namespace Sample.Web.Processing
{
    public class HandlerFactory : Themelia.Web.Processing.HandlerFactory
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