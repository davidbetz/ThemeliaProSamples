<%@ Page Language="C#" MasterPageFile="~/Resource_/Partition/Standard.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="WebSite.Security.Login" Title="Login" %>
<asp:Content ID="cHead" ContentPlaceHolderID="cphHead" Runat="Server">
</asp:Content>
<asp:Content ID="cBody" ContentPlaceHolderID="cphBody" Runat="Server">
    <label for="<%=txtUserName.ClientID %>">UserName:</label>
    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
    
    <label for="<%=txtPassword.ClientID %>">Password:</label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
    
    <asp:Button ID="btnSubmit" runat="server" Text="Login" /><br />
    
    <asp:PlaceHolder id="ValidationPane" runat="server"></asp:PlaceHolder>
</asp:Content>