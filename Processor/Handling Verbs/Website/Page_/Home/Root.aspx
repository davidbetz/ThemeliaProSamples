<%@ Page Language="C#" MasterPageFile="~/Resource_/Partition/Standard.master" AutoEventWireup="true" CodeFile="Root.aspx.cs" Inherits="WebSite.Home.Root" Title="Welcome to our Web Site!" %>
<asp:Content ID="cHead" ContentPlaceHolderID="cphHead" Runat="Server">
</asp:Content>
<asp:Content ID="cBody" ContentPlaceHolderID="cphBody" Runat="Server">
    <p>Click the below links to view sample "Help Links".</p>
    <ul>
    <li><a href="/help/producta">Product A Help</a></li>
    <li><a href="/help/productb">Product B Help</a></li>
    <li><a href="/help/faq">FAQ Help</a></li>
    <li><a href="/help/investor">Investors Help</a></li>
    </ul>
    <form method="post">
        <input type="submit" value="Click for POST" />
    </form>
</asp:Content>