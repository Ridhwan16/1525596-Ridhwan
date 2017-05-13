<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageBootType.aspx.cs" Inherits="SoccerBootsBN.Management.ManageBootsType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        Name:</p>
    <p>
        <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Submitbtn" runat="server" OnClick="Submitbtn_Click" Text="Submit" />
    </p>
    <p>
        <asp:Label ID="LabelResult" runat="server"></asp:Label>
    </p>
</asp:Content>
