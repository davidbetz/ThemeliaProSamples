using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
//+
using Themelia.Web;
//+
namespace WebSite.Quality
{
    public partial class Problem : System.Web.UI.Page
    {
        //- #OnInit -//
        protected override void OnInit(EventArgs e)
        {
            if (Http.GetUrlPart(Themelia.Position.Penultima) == "problem")
            {
                lblMessage.Text = "<p>A problem occured while using this web site. Please use the following form to decribe what you were trying to do.</p>";
            }
            else
            {
                lblMessage.Text = "<p>Use the following space to report a problem.</p>";
            }
            //+ events
            btnSubmit.Click += new EventHandler(OnSubmit);
            //+
            base.OnInit(e);
        }

        //- $OnSubmit -//
        private void OnSubmit(Object sender, EventArgs e)
        {
            if (Http.GetUrlPart(Themelia.Position.Penultima) == "problem")
            {
                //+ in this case, you could get this from Http.GetUrlPart(Http.Position.Ultima) in
                String guid = HttpData.GetCaptureItem("guid");
                Sample.Web.ExceptionSaver.Save(guid, txtDescription.Text);
            }
            //+
            mv01.SetActiveView(vSent);
        }
    }
}