using System;
//+
namespace Sample.Web.Routing.Security
{
    public class AuthenticationHttpHandler : Themelia.Web.Routing.ReusableHttpHandler
    {
        //- @ProcessRequest -//
        public override void ProcessRequest(System.Web.HttpContext context)
        {
            Themelia.Map map = Themelia.Web.HttpData.GetHeaderItemMap(true, "username", "password");
            if (map != null)
            {
                if (map["username"] == map["password"])
                {
                    context.Response.Write("true");
                    return;
                }
            }
            //+
            context.Response.Write("false");
        }
    }
}