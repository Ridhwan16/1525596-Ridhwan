<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Brands.aspx.cs" Inherits="SoccerBootsBN.Brands" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="BootsImage" runat="server" CssClass="ImageDetails" /></td>
            <td><h2>
                <asp:Label ID="BootsTitle" runat="server" Text="Label"></asp:Label>
                <hr />
                </h2></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="BootsDescription" runat="server" CssClass="bootsDescription"></asp:Label></td>
            <td>
                <asp:Label ID="BootsPrice" runat="server" CssClass="bootsPrice"></asp:Label>
                <br />
                Quantity : 
                <br />
            <asp:DropDownList ID="AmountDropDown" runat="server"></asp:DropDownList>
            
                <br />
                <asp:Button ID="buttonATC" runat="server" Text="Add Shoe" CssClass="button" OnClick="buttonATC_Click1" />
            
            <asp:Label ID="BootsResult" runat="server" Text=""></asp:Label>
            </td>

        </tr>
        <tr>
            <td>Boots ID : <asp:Label ID="BootsID" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Available" CssClass="ShoePrice"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
