<%@ Page Language="C#" MasterPageFile="~/Resource_/Partition/Standard.master" AutoEventWireup="false" CodeFile="Help.aspx.cs" Inherits="WebSite.Info.Help" Title="Help Page" %>
<asp:Content ID="cHead" ContentPlaceHolderID="cphHead" Runat="Server">
</asp:Content>
<asp:Content ID="cBody" ContentPlaceHolderID="cphBody" Runat="Server">
    <p>This is the help page.</p>
    
    <p>You accessed the <asp:Literal ID="litSection" runat="server"></asp:Literal> section.</p>
    
    <p>Go <a href="/">home</a></p>
</asp:Content>