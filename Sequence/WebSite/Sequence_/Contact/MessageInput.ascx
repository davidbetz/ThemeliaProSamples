<%@ Control AutoEventWireup="true" Language="C#" Inherits="WebSite.Sequence.Contact.MessageInput" CodeFile="MessageInput.ascx.cs" %>
<div id="contact">
    <h1>Contact</h1>
    <strong><label for="<%=ddlTopic.ClientID %>">Topic</label></strong><br />
    <t:MapDropDownList ID="ddlTopic" runat="server"></t:MapDropDownList>
    <br />
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <br />
    <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Rows="10" Columns="50"></asp:TextBox>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit"></asp:Button>
    <br />
    <span class="error-message"><asp:Literal ID="litError" runat="server"></asp:Literal></span>
</div>

