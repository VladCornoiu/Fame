<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddCategory.aspx.cs" Inherits="AddCategory" %>

<asp:Content ContentPlaceHolderID="Body" runat="server">
    <div style="width: 700px; margin: auto; padding-top: 50px;">
        <p>Create new Category</p>
        <asp:Label ID="ReturnMessage" runat="server"></asp:Label>
        <div class="row">
            <asp:Label ID="CategoryTitleLabel" CssClass="col-12 col-form-label" runat="server">Category Title</asp:Label>
            <asp:TextBox ID="CategoryTitle" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredCategoryName" 
                                        runat="server" ControlToValidate="CategoryTitle"
                                        ErrorMessage="Category Title is required"
                                        Display="Dynamic"
                                        style="color: red;"></asp:RequiredFieldValidator>
        </div>

        <div class="row">
            <textarea id="CategoryContent" class="col-12 col-form-label"  rows="10" runat="server"></textarea>
        </div>

        <div class="row" style="display: flex; justify-content: center; padding: 10px;">
            <asp:Button ID="CreateCategoryButton" CssClass="btn btn-forum" runat="server" Text="Create Category" OnClick="CreateCategoryButton_Click"/>
        </div> 
    </div>
</asp:Content>
