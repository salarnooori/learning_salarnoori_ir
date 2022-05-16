<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Layout.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="UIL.Admin.User.AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>افزودن کاربر</title>
    <style>
        textarea, input[type='text'] {
            background-color: rgba(0,255,255,0.2);
            text-align: center;
            color: yellow;
            border: 1px solid yellow;
            box-shadow: 0 0 5px 0px yellow;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="pageBody" runat="server">

    <div class="header container p-5 pb-2 text-center">
        <h1>افزودن کاربر جدید</h1>
        <br />
        <h3><a class="btn btn-outline-primary" href="../Management.aspx">بازگشت</a></h3>
    </div>
    <hr />


    <div class="container text-center" style="width: 50%;">
        <div class="row">
            <div class="col-6">
                <asp:Label runat="server" SkinID="username_txt">نام کاربری</asp:Label>
                <asp:TextBox Width="100%" runat="server" ID="username_txt" CssClass="mb-4"></asp:TextBox>
            </div>

            <div class="col-6">
                <asp:Label runat="server" SkinID="email_txt">ایمیل</asp:Label>
                <asp:TextBox Width="100%" runat="server" ID="email_txt" CssClass="mb-4"></asp:TextBox>
            </div>

            <div class="col-6">
                <asp:Label runat="server" SkinID="name_txt">نام</asp:Label>
                <asp:TextBox Width="100%" runat="server" ID="name_txt" CssClass="mb-4"></asp:TextBox>
            </div>

            <div class="col-6">
                <asp:Label runat="server" SkinID="family_txt">نام خانوادگی</asp:Label>
                <asp:TextBox Width="100%" runat="server" ID="family_txt" CssClass="mb-4"></asp:TextBox>
            </div>

            <div class="col-6">
                <asp:Label runat="server" SkinID="password_txt">رمز عبور</asp:Label>
                <asp:TextBox Width="100%" runat="server" ID="password_txt" CssClass="mb-4"></asp:TextBox>
            </div>

            <div class="col-6">
                <asp:Label runat="server" SkinID="repassword_txt">تکرار رمز عبور</asp:Label>
                <asp:TextBox Width="100%" runat="server" ID="repassword_txt" CssClass="mb-4"></asp:TextBox>
            </div>

            <div class="col-12">
                <asp:Label runat="server" SkinID="FileUpLoad1">عکس پروفایل</asp:Label>
                <asp:FileUpload  Width="100%" id="FileUpLoad1" runat="server"  CssClass="btn btn-outline-primary mb-4"  />
            </div>

            <div class="col-12">
                <asp:Label runat="server" SkinID="bio_txt">بیو</asp:Label>
                <asp:TextBox  Width="100%" Height="200px" TextMode="MultiLine" id="bio_txt" runat="server" CssClass="mb-4" />
            </div>

        </div>

        <asp:Button Width="50%" runat="server" ID="add_user_btn" Text="افزودن کاربر" CssClass="my-2 btn btn-outline-success" OnClick="add_user_btn_Click" />
    </div>

</asp:Content>
