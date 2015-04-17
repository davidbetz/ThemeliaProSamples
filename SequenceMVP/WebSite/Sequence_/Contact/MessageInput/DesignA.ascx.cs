using System;
//+
using Themelia;
//+
using Sample.Logic.Mvp.Contact;
//+
namespace WebSite.Sequence.Contact.MessageInput
{
    //++ SAMPLE NOTE: To use MVP, just have your sequence view use the generic version of the
    //++ SequenceView class and implement your view.
    public partial class DesignA : Themelia.Web.Sequence.Mvp.View<MessageInputPresenter>, IMessageInputView
    {
        //- @TopicKey - //
        public Int32 TopicKey
        {
            get { return Parser.ParseInt32(ddlTopic.SelectedItem.Value); }
        }

        //- @TopicText - //
        public String TopicText
        {
            get { return ddlTopic.SelectedItem.Text; }
        }

        //- @Message - //
        public String Message
        {
            get { return txtMessage.Text; }
            set { txtMessage.Text = value; }
        }

        //- @ErrorMessage - //
        public String ErrorMessage
        {
            get { return litError.Text; }
            set { litError.Text = value; }
        }

        //- @Title - //
        public String Title
        {
            get
            {
                return litTitle.Text;
            }
            set
            {
                litTitle.Text = value;
            }
        }

        //+
        //- #OnInit -//
        protected override void OnInit(EventArgs e)
        {
            this.AutoDataBind = true;
            //+
            btnSubmit.Click += new EventHandler(OnSubmit);
            Load += new EventHandler(OnPageLoad);
            //+
            base.OnInit(e);
        }

        //- $OnPageLoad -//
        private void OnPageLoad(Object sender, EventArgs e)
        {
            Presenter.Init(Sequencer.ActiveViewName);
        }

        //- $OnSubmit -//
        private void OnSubmit(object sender, EventArgs e)
        {
            Presenter.Submit();
        }

        //- #OnDataBinding -//
        protected override void OnDataBinding(EventArgs e)
        {
            ddlTopic.DataSource = Presenter.InitData();
            //+
            base.OnDataBinding(e);
        }
    }
}