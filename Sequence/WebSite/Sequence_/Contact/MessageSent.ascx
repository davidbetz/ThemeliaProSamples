<%@ Control AutoEventWireup="false" Language="C#" Inherits="WebSite.Sequence.Contact.MessageSent" CodeFile="MessageSent.ascx.cs" %>
<div id="contact">
    <h1>Contact</h1>
    <h2>Message Sent</h2>
    <!--SAMPLE NOTE: Though you can use the programmatic method to navigate in your sequence, this is not the most
        efficient technique.  This is because by the time your programmatic logic is ran, the sequence had to have
        already been loaded.  Not only that, but the view on which your programmatic logic is running had to, of 
        course, also be loaded.  Because of this, Themelia Pro also allows you to use messages to communicate to
        your sequence.  These are are much more efficient as they are processed long before sequences are loaded,
        thus only one view is loaded.  The pattern for sequence messages are as follows:
        
        Sequence@Action#OptionalParameter
        
        Here are some samples:
        Sequence@Next
        Sequence@Previous
        Sequence@First
        Sequence@Last
        Sequence@Jump#Input
        --->
    <t:MessageButton Message="Sequence@Next" runat="server" Text="Next" />
    <p>Your message have been sent to the appropriate party.</p>
</div>
