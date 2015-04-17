using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
//+
namespace WebSite.Security
{
    public partial class Home : ThemeliaPage
    {
        //- #OnInit -//
        protected override void OnInit(EventArgs e)
        {
            //+ events
            btnLogout.Click += new EventHandler(OnLogout);
            btnProblem.Click += new EventHandler(OnProblem);
            //+
            base.OnInit(e);
        }

        //- $OnLogout -//
        private void OnLogout(Object sender, EventArgs e)
        {
            Themelia.Web.Http.Redirect("/logout/");
        }

        //- $OnProblem -//
        private void OnProblem(Object sender, EventArgs e)
        {
            throw new ArgumentNullException("Oops!");
        }
    }
}