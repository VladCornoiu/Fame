<%@ Page Language="C#" Title="Subject" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Subject.aspx.cs" Inherits="Subject" %>

<asp:Content ID="Content" ContentPlaceHolderID="Body" Runat="Server">
    <asp:LoginView runat="server" ViewStateMode="Disabled">
        <AnonymousTemplate>
        </AnonymousTemplate>
        <LoggedInTemplate>
            <asp:Button id="BNewSubject" CssClass="btn btn-link" Text="Create new subject" OnClick="CreateNewSubject_Click" runat="server"/>
        </LoggedInTemplate>
    </asp:LoginView>
    <div class="container">
        <div class="row" style="display: flex; justify-content: center;">
            <div class="col-6">
                <div class="input-group mb-2 mr-sm-2 mb-sm-0">
                    <asp:TextBox ID="SearchTextBox" CssClass="form-control" runat="server"/>
                    <asp:Button ID="SearchButton" CssClass="btn btn-forum" runat="server" Text="Search" OnClick="SearchButton_Click"></asp:Button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>