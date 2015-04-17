using System;
using System.Collections.Generic;
using System.Linq;
//+
using Themelia;
using Themelia.Web;
//+
namespace WebSite
{
    public class ThemeliaPage : System.Web.UI.Page
    {
        //- #OnInit -//
        protected override void OnInit(EventArgs e)
        {
            if (!HttpData.GetSessionItem<Boolean>(Sample.Web.Setting.IsAuthenticated))
            {
                if (!Http.UrlPartArray.Contains("login") && !Http.UrlPartArray.Contains("problem"))
                {
                    Http.Redirect(WebDomain.PathWithLeadingSlash + "/login/");
                }
            }
            //+
            base.OnInit(e);
        }
    }
}