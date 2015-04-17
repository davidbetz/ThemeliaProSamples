<%@ Page Title="Contact Form" Language="C#" MasterPageFile="~/Resource_/Partition/Standard.master" CodeFile="Contact.aspx.cs" Inherits="WebSite.Sequence.Contact" %>
<asp:Content ID="Content4" ContentPlaceHolderID="cphHead" Runat="Server">
    <link rel="Stylesheet" href="/Resource_/Partition/Standard/Style/contact.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphBody" Runat="Server">
<t:Sequencer SequenceName="Contact" ID="Controller" runat="server">
    <View Name="MessageInput" />
    <View Name="MessageSent" />
    <View Name="ProblemInput" />
    <View Name="ProblemSaved" />
</t:Sequencer>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cphBottom" Runat="Server">
</asp:Content>