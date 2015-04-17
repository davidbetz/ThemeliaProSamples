using System;
//+
using Themelia;
//+
namespace Sample.Logic.Mvp.Contact
{
    //++ SAMPLE NOTE: This is the presenter which actually does the logic.
    //++ This is not tied to any UI.  This allows you to reuse the logic
    //++ all over the place.
    public class MessageInputPresenter : Themelia.Mvp.Presenter<Sample.Logic.Mvp.Contact.IMessageInputView>
    {
        //- @Init -//
        public void Init(String viewName)
        {
            View.Title = viewName == "ProblemInput" ? "Problem Report" : "Contact";
        }

        //- @Submit -//
        public void Submit()
        {
            View.ErrorMessage = String.Empty;
            Int32 topicKey = View.TopicKey;
            String topicValue = View.TopicText;
            String message = View.Message;
            //+ validate
            if (topicKey < 0)
            {
                View.ErrorMessage = "Topic is required.";
                return;
            }
            if (String.IsNullOrEmpty(message))
            {
                View.ErrorMessage = "Message is required.";
                return;
            }
            //+
            //++ do something here, like save the message.
            //+
            //++ SAMPLE NOTE: this will only happen for controls implementing
            //++ the ISequencedControl interface.
            this.MoveToNextView();
        }

        //- @InitData -//
        public Int32StringMap InitData()
        {
            Int32StringMap data = new Int32StringMap();
            data.Add(-2, "Select a topic...");
            data.Add(-1, "-------------------------");
            data.Add(1, "General Comment");
            data.Add(2, "Help Request");
            data.Add(3, "Suggestion");
            //+
            return data;
        }
    }
}