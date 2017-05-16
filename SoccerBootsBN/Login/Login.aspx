<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SoccerBootsBN.Login.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!--Source taken from https://www.youtube.com/watch?v=sXS2lX7XdOs-->
    <asp:Literal ID="Status" runat="server"></asp:Literal>
<hr />
<hr />
User Name :<hr />
<asp:TextBox ID="UserNameText" runat="server" CssClass="insert"></asp:TextBox>
<hr />
Password :<hr />
<asp:TextBox ID="PasswordText" runat="server" CssClass="insert" TextMode="Password"></asp:TextBox>
<hr />
<asp:Button ID="LoginBtn" runat="server" CssClass="button" OnClick="LoginBtn_Click" Text="Login" />
</asp:Content>
