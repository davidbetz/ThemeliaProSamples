using System;
using Sample.Logic.Mvp.Contact;
//+
namespace Sample.Wpf.Mvp
{
    public partial class MainWindow : Themelia.Windows.Mvp.Window<MessageInputPresenter>, IMessageInputView
    {
        //- @TopicKey -//
        public Int32 TopicKey
        {
            get
            {
                Themelia.MapEntry<int, string> selected = cbTopic.SelectionBoxItem as Themelia.MapEntry<int, string>;
                if (selected != null)
                {
                    return selected.Key;
                }
                //+
                return -1;
            }
        }

        //- @TopicText -//
        public String TopicText
        {
            get
            {
                Themelia.MapEntry<int, string> selected = cbTopic.SelectionBoxItem as Themelia.MapEntry<int, string>;
                if (selected != null)
                {
                    return selected.Value;
                }
                //+
                return String.Empty;
            }
        }

        //- @ErrorMessage -//
        public String ErrorMessage
        {
            get { return tbErrorMessage.Text; }
            set { tbErrorMessage.Text = value; }
        }

        //- @Message -//
        public String Message
        {
            get { return txtMessage.Text; }
            set { txtMessage.Text = value; }
        }

        //+
        //- @Ctor -//
        public MainWindow():base()
        {
            InitializeComponent();
            //+
            cbTopic.ItemsSource = Presenter.InitData().GetDataSource();
            //+
            btnSubmit.Click += delegate
            {
                //++ SAMPLE NOTE: This isn't the best example in the world,
                //++ but if you step through it, you'll get the point.
                Presenter.Submit();
            };
        }
    }
}
