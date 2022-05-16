<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Layout.Master" AutoEventWireup="true" CodeBehind="ShowUser.aspx.cs" Inherits="UIL.Admin.User.ShowUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>مدیریت کاربران</title>
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
        <h1>لیست کاربران</h1>
        <br />
        <h3><a class="btn btn-outline-primary" href="../Management.aspx">بازگشت</a></h3>
    </div>
    <hr />


    <div class="container">
        <asp:GridView runat="server" ID="users_gv" CssClass="text-center" AutoGenerateColumns="false" DataKeyNames="Id" OnRowDeleting="users_gv_RowDeleting" OnRowEditing="users_gv_RowEditing">
            <Columns>
                <asp:ImageField ControlStyle-Width="50px" ControlStyle-Height="50px" DataImageUrlField="image" HeaderText="عکس" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="username" HeaderText="نام کاربری" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="password" HeaderText="رمز" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="email" HeaderText="ایمیل" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="name" HeaderText="نام" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="family" HeaderText="نام خانوادگی" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="bio" HeaderText="بیو" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:CommandField ShowEditButton="true" EditText="ویرایش" ControlStyle-CssClass="btn btn-outline-primary btn-block" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderStyle="None"/>
                <asp:CommandField ShowDeleteButton="true" DeleteText="حذف"  ControlStyle-CssClass="btn btn-outline-danger btn-block" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderStyle="None"/>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
