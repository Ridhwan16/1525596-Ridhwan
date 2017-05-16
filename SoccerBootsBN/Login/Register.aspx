<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SoccerBootsBN.Login.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <asp:Literal ID="Status" runat="server"></asp:Literal>
    </p>
    <p>
        User Name :
    </p>
    <p>
        <asp:TextBox ID="UserNameText" runat="server" CssClass="insert"></asp:TextBox>
    </p>
    <p>
        Password :</p>
    <p>
        <asp:TextBox ID="PasswordText" runat="server" CssClass="insert" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        Confirm Password :</p>
    <p>
        <asp:TextBox ID="ConfirmPasswordText" runat="server" CssClass="insert" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        First Name :</p>
    <p>
        <asp:TextBox ID="FirstNameText" runat="server" CssClass="insert"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Last Name :</p>
    <p>
        <asp:TextBox ID="LastNameText" runat="server" CssClass="insert"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Address :</p>
    <p>
        <asp:TextBox ID="AddressText" runat="server" CssClass="insert"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Post Code :</p>
    <p>
        <asp:TextBox ID="PostCodeText" runat="server" CssClass="insert"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Button" />
    </p>
</asp:Content>
