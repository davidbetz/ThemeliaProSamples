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
                case "sample":
                    return new Security.SampleHttpHandler();
            }
            //+
            return null;
        }
    }
}