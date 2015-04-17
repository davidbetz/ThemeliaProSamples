<%@ Control AutoEventWireup="false" Language="C#" Inherits="WebSite.Sequence.Contact.MessageInput.DesignB" CodeFile="DesignB.ascx.cs" %>
<div id="contact">
    <h1><asp:Literal ID="litTitle" runat="server"></asp:Literal></h1>
    <p>Design B</p>
    <p>This example uses both MVP and sequence versions.</p>
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

