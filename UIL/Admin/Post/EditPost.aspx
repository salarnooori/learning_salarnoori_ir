<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Layout.Master" AutoEventWireup="true" CodeBehind="EditPost.aspx.cs" Inherits="UIL.Admin.Post.EditPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>ویرایش آموزش</title>
    <style>
        textarea, input[type='text'] {
            background-color: rgba(0,255,255,0.2);
            text-align: center;
            color: yellow;
            border: 1px solid yellow;
            box-shadow: 0 0 5px 0px yellow;
        }
        input[type='text'][readonly='readonly'],input[type='date'][readonly='readonly']{
            background-color: rgba(0,127,127,0.2);
            text-align: center;
            color: rgb(127,127,0);
            border: 1px solid yellow;
            box-shadow: 0 0 5px 0px rgb(127,127,0);
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageBody" runat="server">

    <div class="header container p-5 pb-2 text-center">
        <h1>ویرایش کاربر</h1>
        <br />
        <h3><a class="btn btn-outline-primary" href="ShowPost.aspx">بازگشت</a></h3>
    </div>
    <hr />

    <div class="container text-center" style="width:50%;">
        <div class="row">

            <div class="col-12">
                <asp:Label runat="server" SkinID="post_img"> عکس</asp:Label>
                <asp:Image ReadOnly="true" Width="100%" Height="300px"  runat="server" ID="post_img" CssClass="mb-4"></asp:Image>
            </div>

            <div class="col-6">
                <asp:Label runat="server" SkinID="subject_txt"> موضوع</asp:Label>
                <asp:TextBox Width="100%" runat="server" ID="subject_txt" CssClass="mb-4"></asp:TextBox>
            </div>

            <div class="col-6">
                <asp:Label runat="server" SkinID="modifydate_txt">تاریخ</asp:Label>
                <asp:TextBox ReadOnly="true" TextMode="Date" Width="100%" runat="server" ID="modifydate_txt" CssClass="mb-4"></asp:TextBox>
            </div>

            <div class="col-6">
                <asp:Label runat="server" SkinID="author_id_txt"> نویسنده</asp:Label>
                <asp:TextBox ReadOnly="true" Width="100%" runat="server" ID="author_id_txt" CssClass="mb-4"></asp:TextBox>
            </div>

            <div class="col-6">
                <asp:Label runat="server" SkinID="category_id_txt"> دسته</asp:Label>
                <asp:TextBox ReadOnly="true" Width="100%" runat="server" ID="category_id_txt" CssClass="mb-4"></asp:TextBox>
            </div>
            
            <div class="col-12">
                <asp:Label runat="server" SkinID="context_txt"> محتوا</asp:Label>
                <asp:TextBox TextMode="MultiLine" Width="100%" Height="200px" runat="server" ID="context_txt" CssClass="mb-4"></asp:TextBox>
            </div>

            <div class="col-12">
                <asp:Label runat="server" SkinID="summery_txt"> خلاصه</asp:Label>
                <asp:TextBox TextMode="MultiLine" Width="100%" Height="100px" runat="server" ID="summery_txt" CssClass="mb-4"></asp:TextBox>
            </div>

        </div>
        
         <asp:Button Width="50%" runat="server" ID="add_post_btn" Text="ویرایش آموزش" CssClass="my-2 btn btn-outline-success" OnClick="edit_post_btn_Click" />
    </div>

</asp:Content>
