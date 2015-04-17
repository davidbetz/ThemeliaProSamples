<%@ Page Language="C#" MasterPageFile="~/Resource_/Partition/Standard.master" AutoEventWireup="true" CodeFile="Member.aspx.cs" Inherits="WebSite.Security.Member" Title="Welcome to our Web Site!" %>
<asp:Content ID="cHead" ContentPlaceHolderID="cphHead" Runat="Server">
</asp:Content>
<asp:Content ID="cBody" ContentPlaceHolderID="cphBody" Runat="Server">
    <p>You are logged in.</p>
    
    <a href="./logout">Logout</a>
</asp:Content>