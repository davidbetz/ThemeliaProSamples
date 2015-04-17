<%@ Control AutoEventWireup="false" Language="C#" Inherits="WebSite.Sequence.Contact.ProblemInput" CodeFile="ProblemInput.ascx.cs" %>
 <div id="contact">
    <h1>Problem Report</h1>
    <asp:Literal ID="litProblemMessage" runat="server"></asp:Literal>
    <strong><label for="<%=lblMessage.ClientID %>"><asp:Literal ID="litMessageLabel" runat="server" Text="Please describe your problem in the box below."></asp:Literal></label></strong><br />
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <br />
    <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Rows="10" Columns="50"></asp:TextBox>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit"></asp:Button>
    <br />
    <span class="error-message"><asp:Literal ID="litError" runat="server"></asp:Literal></span>
</div>
