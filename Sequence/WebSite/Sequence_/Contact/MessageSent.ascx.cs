using System;
//+
namespace WebSite.Sequence.Contact
{
    public partial class MessageSent : Themelia.Web.Sequence.View
    {
        //- #OnPreRender -//
        protected override void OnPreRender(EventArgs e)
        {
            this.PageTitle = "Thank you for your message.";
            //+
            base.OnPreRender(e);
        }
    }
}