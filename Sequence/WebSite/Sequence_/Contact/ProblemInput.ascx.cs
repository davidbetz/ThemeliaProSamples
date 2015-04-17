using System;
using System.Linq;
//+
using Themelia.Web;
//+
namespace WebSite.Sequence.Contact
{
    public partial class ProblemInput : Themelia.Web.Sequence.View
    {
        //- #OnInit -//
        protected override void OnInit(EventArgs e)
        {
            Load += new EventHandler(Page_Load);
            btnSubmit.Click += new EventHandler(OnSubmit);
            //+
            base.OnInit(e);
        }

        //- $OnSubmit -//
        private void OnSubmit(object sender, EventArgs e)
        {
            litError.Text = String.Empty;
            //+
            String message = txtMessage.Text;
            //+
            String code = String.Empty;
            if (Themelia.Web.Http.GetUrlPart(Themelia.Position.Penultima) == "problem")
            {
                code = Themelia.Web.Http.GetUrlPart(Themelia.Position.Ultima);
            }
            if (!String.IsNullOrEmpty(code))
            {
                //+ save user message to problem code
            }
            else
            {
                //+ save user message
            }
            //+
            this.MoveToNextView();
        }

        //- #Page_Load -//
        protected void Page_Load(Object sender, EventArgs ea)
        {
            if (Themelia.Web.Http.GetUrlPart(Themelia.Position.Penultima) == "problem")
            {
                litProblemMessage.Text = @"
<p>Was there a problem?</p>
<p>Your problem was logged and the appropriate parties have been notified.  Please use this form to tell what you were doing when the problem occured.</p>";
                litMessageLabel.Text = "Your comment:";
            }
        }

        //- #OnPreRender -//
        protected override void OnPreRender(EventArgs e)
        {
            this.PageTitle = "Problem Report";
            //+
            base.OnPreRender(e);
        }
    }
}