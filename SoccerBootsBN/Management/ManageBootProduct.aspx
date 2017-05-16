<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageBootProduct.aspx.cs" Inherits="SoccerBootsBN.Management.ManageBootProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!--Source taken from https://www.youtube.com/watch?v=sXS2lX7XdOs-->
    <p>
        Name:</p>
    <p>
        <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox>
    </p>
    <p>
        Type:</p>
    <p>
        <asp:DropDownList ID="TypeDropDown" runat="server" DataSourceID="SqlDataSource1" DataTextField="ShoeName" DataValueField="ID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db_1525596_co5027ConnectionString %>" SelectCommand="SELECT * FROM [BootType] ORDER BY [ShoeName]"></asp:SqlDataSource>
    </p>
    <p>
        Price:</p>
    <p>
        <asp:TextBox ID="Pricetxt" runat="server"></asp:TextBox>
    </p>
    <p>
        Image:</p>
    <p>
        <asp:DropDownList ID="ImageDropDown" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        Description:</p>
    <p>
        <asp:TextBox ID="Desctxt" runat="server" Height="70px" TextMode="MultiLine" Width="250px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Submitbtn" runat="server" OnClick="Submitbtn_Click" Text="Submit" />
    </p>
    <p>
        <asp:Label ID="ResultLabel" runat="server"></asp:Label>
    </p>
</asp:Content>
