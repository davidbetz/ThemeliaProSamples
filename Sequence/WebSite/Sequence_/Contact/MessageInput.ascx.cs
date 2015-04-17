using System;
//+
using Themelia;
//+
namespace WebSite.Sequence.Contact
{
    public partial class MessageInput : Themelia.Web.Sequence.View
    {
        //- #OnInit -//
        protected override void OnInit(EventArgs e)
        {
            this.AutoDataBind = true;
            //+
            btnSubmit.Click += new EventHandler(OnSubmit);
            //+
            base.OnInit(e);
        }

        //- $OnSubmit -//
        private void OnSubmit(object sender, EventArgs e)
        {
            litError.Text = String.Empty;
            //+
            String topicKey = ddlTopic.SelectedItem.Value;
            String topicValue = ddlTopic.SelectedItem.Text;
            String message = txtMessage.Text;
            //+
            //++ SAMPLE NOTE: When working programmatically, you may use workflow-like methods
            //++ to navigate forward and backwards in your sequence.
            //+
            //++ save message
            //+
            this.MoveToNextView();
        }

        //- #OnDataBinding -//
        protected override void OnDataBinding(EventArgs e)
        {
            Int32StringMap data = new Int32StringMap();
            data.Add(-2, "Select a topic...");
            data.Add(-1, "-------------------------");
            data.Add(1, "General Comment");
            data.Add(2, "Help Request");
            data.Add(3, "Suggestion");
            ddlTopic.DataSource = data.GetDataSource();
            //+
            base.OnDataBinding(e);
        }
    }
}