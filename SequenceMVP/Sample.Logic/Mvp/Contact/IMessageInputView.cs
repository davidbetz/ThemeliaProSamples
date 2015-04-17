using System;
//+
using Themelia;
//+
namespace Sample.Logic.Mvp.Contact
{
    //++ SAMPLE NOTE: this is the view.  This contains the properties that will be
    //++ implemented on the web page (or non-web visual entity) and used on the 
    //++ presenter.
    public interface IMessageInputView : Themelia.Mvp.IView
    {
        //- Title -//
        String Title { get; set; }

        //- TopicKey - //
        Int32 TopicKey { get; }

        //- TopicText - //
        String TopicText { get; }

        //- ErrorMessage - //
        String ErrorMessage { get; set; }

        //- Message - //
        String Message { get; set; }
    }
}