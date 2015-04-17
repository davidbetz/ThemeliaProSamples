<%@ Page Language="C#" MasterPageFile="~/Resource_/Frame/Standard.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="WebSite.Security.Home" Title="Welcome to our Web Site!" %>
<asp:Content ID="cHead" ContentPlaceHolderID="cphHead" Runat="Server">
</asp:Content>
<asp:Content ID="cBody" ContentPlaceHolderID="cphBody" Runat="Server">
    <p>You are logged in.</p>
    
    <asp:Button ID="btnLogout" runat="server" Text="Logout" /><br />

    <asp:Button ID="btnProblem" runat="server" Text="Emulate Problem" /><br />
    
</asp:Content>