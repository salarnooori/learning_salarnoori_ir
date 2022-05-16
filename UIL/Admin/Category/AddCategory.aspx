<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Layout.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="UIL.Admin.Category.AddCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>افزودن دسته</title>
    <style>
        textarea,input[type='text']{
            background-color: rgba(0,255,255,0.2);
            text-align:center;
            color:yellow;
            border:1px solid yellow;
            box-shadow: 0 0 5px 0px yellow;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="pageBody" runat="server">

    <div class="header container p-5 pb-2 text-center">
        <h1>افزودن دسته جدید</h1>
        <br />
        <h3><a class="btn btn-outline-primary" href="../Management.aspx">بازگشت</a></h3>
    </div>
    <hr />


    <div class="container text-center" style="width:50%;">
        <asp:Label runat="server" SkinID="name_txt"> نام دسته</asp:Label>
        <asp:TextBox Width="100%" runat="server" ID="name_txt" CssClass="mb-4"></asp:TextBox>
        <asp:Label runat="server" SkinID="details_txt"> توضیحات دسته</asp:Label>
        <asp:TextBox Width="100%" Height="200px" TextMode="MultiLine" runat="server" ID="details_txt" CssClass="mb-4"></asp:TextBox>
        <asp:Label runat="server" SkinID="details_txt"> دسته مادر</asp:Label>
        <asp:DropDownList Width="100%"  ID="category_lst" runat="server"  CssClass="mb-4"></asp:DropDownList>
        <asp:Button Width="50%" runat="server" ID="add_category_btn" Text="افزودن دسته" CssClass="my-2 btn btn-outline-success" OnClick="add_category_btn_Click" />
    </div>

</asp:Content>
