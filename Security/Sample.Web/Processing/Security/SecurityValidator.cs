using System;
using Themelia.Web;
//+
namespace Sample.Web.Processing.Security
{
    public class SecurityValidator : Themelia.Web.Security.ISecurityValidator
    {
        //- @IsValid -//
        public bool IsValid()
        {
            return HttpData.GetSessionItem<Boolean>(Sample.Web.Setting.IsAuthenticated);
        }

        //- @Logout -//
        public void Logout()
        {
            HttpData.SetSessionItem<Boolean>(Sample.Web.Setting.IsAuthenticated, false);
        }
    }
}