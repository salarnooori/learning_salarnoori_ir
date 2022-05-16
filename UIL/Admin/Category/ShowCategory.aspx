<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Layout.Master" AutoEventWireup="true" CodeBehind="ShowCategory.aspx.cs" Inherits="UIL.Admin.Category.ShowCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>مدیریت دسته ها</title>
    <style>
        table tr td, table tr th {
            border: 2px solid black;
        }

        table {
            width: 100%;
        }

        a {
            text-decoration: none;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageBody" runat="server">

    <div class="header container p-5 pb-2s text-center">
        <h1>لیست دسته ها</h1>
        <br />
        <h3><a class="btn btn-outline-primary" href="../Management.aspx">بازگشت</a></h3>
    </div>
    <hr />


    <div class="container">
        <asp:GridView runat="server" ID="GridView1" CssClass="text-center" AutoGenerateColumns="false" DataKeyNames="id">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="کد" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow" />
                <asp:BoundField DataField="name" HeaderText="موضوع" ReadOnly="false" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow" />
                <asp:BoundField DataField="quantity" HeaderText="تعداد پست ها" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow" />
                <asp:BoundField DataField="description" HeaderText="توضیحات" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow" />
            </Columns>
        </asp:GridView>
        <hr />
        <asp:GridView runat="server" ID="categories_gv" CssClass="text-center" AutoGenerateColumns="false" DataKeyNames="id" OnRowDeleting="categories_gv_RowDeleting" OnRowEditing="categories_gv_RowEditing">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="کد" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow" />
                <asp:BoundField DataField="name" HeaderText="موضوع" ReadOnly="false" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow" />
                <asp:BoundField DataField="maincategory_name" HeaderText="دسته مادر" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow" />
                <asp:BoundField DataField="quantity" HeaderText="تعداد پست ها" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow" />
                <asp:CommandField ShowEditButton="true" EditText="ویرایش" ControlStyle-CssClass="btn btn-outline-primary btn-block" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderStyle="None" />
                <asp:CommandField ShowDeleteButton="true" DeleteText="حذف" ControlStyle-CssClass="btn btn-outline-danger btn-block" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderStyle="None" />
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
