using System;
//+
namespace WebSite.Sequence.Contact
{
    public partial class ProblemSaved : Themelia.Web.Sequence.View
    {
        //- #OnInit -//
        protected override void OnInit(EventArgs e)
        {
            Load += new EventHandler(Page_Load);
            //+
            base.OnInit(e);
        }

        //- #Page_Load -//
        protected void Page_Load(Object sender, EventArgs ea)
        {
            if (Themelia.Web.Http.GetUrlPart(Themelia.Position.Penultima) == "problem")
            {
                litSavedMessage.Text = "Your information has been saved. Please try again later as the problem will be fixed shortly.";
            }
            else
            {
                litSavedMessage.Text = "Thank you for taking time to report a problem.  Your information has been sent to the appropriate party.";
            }
        }

        //- #OnPreRender -//
        protected override void OnPreRender(EventArgs e)
        {
            if (Themelia.Web.Http.GetUrlPart(Themelia.Position.Penultima) == "problem")
            {
                this.PageTitle = "Thank you for your information.";
            }
            else
            {
                this.PageTitle = "Thank you for reporting this problem.";
            }
            //+
            base.OnPreRender(e);
        }
    }
}