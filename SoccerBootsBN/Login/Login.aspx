<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SoccerBootsBN.Login.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Literal ID="Status" runat="server"></asp:Literal>
<br />
<br />
User Name :<br />
<asp:TextBox ID="UserNameText" runat="server" CssClass="insert"></asp:TextBox>
<br />
<br />
Password :<br />
<asp:TextBox ID="PasswordText" runat="server" CssClass="insert" TextMode="Password"></asp:TextBox>
<br />
<asp:Button ID="LoginBtn" runat="server" CssClass="button" OnClick="LoginBtn_Click" Text="Login" />
<br />
<br />
</asp:Content>
