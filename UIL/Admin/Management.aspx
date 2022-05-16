<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Layout.Master" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="UIL.Admin.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>مدیریت</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageBody" runat="server">

    <div class="header container p-5 pb-2 text-center">
        <h1>سلام به پنل مدیریت خوش آمدید</h1>
        <br />
        <h3><a class="btn btn-outline-primary" href="../MainPage.aspx">صفحه اصلی</a></h3>
    </div>

    <hr />
    <br />

    <div class="container text-center">
        <div class="row">

        <div class="col-sm-12 col-md-6 col-lg-4 py-2 ">
            <div class="container border border-1 shadow">
                <h3 class="my-2">مدیریت آموزش ها</h3>
                <hr />
                <a type="button" href="Post/AddPost.aspx" width="100%" class="btn-block btn btn-outline-warning my-2">افزودن آموزش جدید</a>
                <a type="button" href="Post/ShowPost.aspx" width="100%" class="btn-block btn btn-outline-warning my-2">نمایش آموزش ها</a>
            </div>
            
        </div>

        <div class="col-sm-12 col-md-6 col-lg-4 py-2">
            <div class="container border border-1 shadow">
                <h3 class="my-2">مدیریت دسته ها</h3>
                <hr />
                <a type="button" href="Category/AddCategory.aspx" width="100%" class="btn-block btn btn-outline-warning my-2">افزودن دسته جدید</a>
                <a type="button" href="Category/ShowCategory.aspx" width="100%" class="btn-block btn btn-outline-warning my-2">نمایش دسته ها</a>
            </div>
            
        </div>

        <div class="col-sm-12 col-md-6 col-lg-4 py-2">
            <div class="container border border-1 shadow">
                <h3 class="my-2">مدیریت کاربران</h3>
                <hr />
                <a type="button" href="User/AddUser.aspx" width="100%" class="btn-block btn btn-outline-warning my-2">افزودن کاربر جدید</a>
                <a type="button" href="User/ShowUser.aspx" width="100%" class="btn-block btn btn-outline-warning my-2">نمایش کاربران</a>
            </div>
            
        </div>

    </div>
    </div>
    



</asp:Content>
