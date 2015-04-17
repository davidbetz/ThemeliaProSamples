<%@ Page Language="C#" MasterPageFile="~/Resource_/Partition/Standard.master" AutoEventWireup="true" CodeFile="Person.aspx.cs" Inherits="WebSite.Information.Person" Title="Person Page" %>
<asp:Content ID="cHead" ContentPlaceHolderID="cphHead" Runat="Server">
</asp:Content>
<asp:Content ID="cBody" ContentPlaceHolderID="cphBody" Runat="Server">
    <input id="txtGetPerson" type="button" value="Test Person Services" />
    <script type="text/javascript">
        Themelia.AspNet.registerObject('txtGetPerson');
        document.observe('dom:loaded', Initialization.init);
    </script>
</asp:Content>