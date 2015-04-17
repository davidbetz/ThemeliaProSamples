<%@ Page Language="C#" MasterPageFile="~/Resource_/Frame/Standard.master" AutoEventWireup="true" CodeFile="Problem.aspx.cs" Inherits="WebSite.Quality.Problem" Title="Problem Report" %>
<asp:Content ID="cHead" ContentPlaceHolderID="cphHead" Runat="Server">
</asp:Content>
<asp:Content ID="cBody" ContentPlaceHolderID="cphBody" Runat="Server">
<asp:MultiView ID="mv01" runat="server" ActiveViewIndex="0">
    <asp:View ID="vReport" runat="server">
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="7" Columns="50"></asp:TextBox><br />
        
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" /><br />
    </asp:View>
    <asp:View ID="vSent" runat="server">
        <p>The problem has been reported to the appropriate party.</p>
    </asp:View>
</asp:MultiView>
</asp:Content>