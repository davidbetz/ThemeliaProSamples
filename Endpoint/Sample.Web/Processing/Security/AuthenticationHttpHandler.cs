using System;
//+
namespace Sample.Web.Processing.Security
{
    public class AuthenticationHttpHandler : Themelia.Web.ReusableHttpHandler
    {
        //- @Process -//
        public override void Process()
        {
            Themelia.Map map = Themelia.Web.HttpData.GetHeaderItemMap(true, "username", "password");
            if (map != null)
            {
                if (map["username"] == map["password"])
                {
                    Output.Append("true");
                    return;
                }
            }
            //+
            Output.Append("false");
        }
    }
}