<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Layout.Master" AutoEventWireup="true" CodeBehind="ShowPost.aspx.cs" Inherits="UIL.Admin.Post.ShowPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>مدیریت آموزش ها</title>
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
        <asp:GridView runat="server" ID="posts_gv" CssClass="text-center" AutoGenerateColumns="false" DataKeyNames="Id" OnRowDeleting="posts_gv_RowDeleting" OnRowEditing="posts_gv_RowEditing">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="کد" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:ImageField ControlStyle-Width="150px" ControlStyle-Height="100px" DataImageUrlField="image" HeaderText="عکس" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="subject" HeaderText="موضوع" ReadOnly="false" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="modifydate" HeaderText="تاریخ" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="author_name" HeaderText="نویسنده" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="category_name" HeaderText="دسته" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="context" HeaderText="محتوا" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:BoundField DataField="summery" HeaderText="خلاصه" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderColor="Yellow"/>
                <asp:CommandField ShowEditButton="true" EditText="ویرایش" ControlStyle-CssClass="btn btn-outline-primary btn-block" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderStyle="None"/>
                <asp:CommandField ShowDeleteButton="true" DeleteText="حذف"  ControlStyle-CssClass="btn btn-outline-danger btn-block" ItemStyle-BorderColor="Yellow" HeaderStyle-BorderStyle="None"/>
            </Columns>
        </asp:GridView>
    </div>


</asp:Content>
