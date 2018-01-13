<%@ Page Language="C#" Title="Login" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content" ContentPlaceHolderID="Body" Runat="Server">
    <p> Please Login </p>
    <asp:Login id="Login1" runat="server" DestinationPageUrl="~\Default.aspx"></asp:Login>
</asp:Content>