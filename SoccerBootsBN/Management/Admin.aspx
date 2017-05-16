<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="SoccerBootsBN.Management.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!--Source taken from https://www.youtube.com/watch?v=sXS2lX7XdOs-->
    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="button" PostBackUrl="~/Management/ManageBootProduct.aspx">Add New Item</asp:LinkButton>
<hr />
<asp:GridView ID="GridBoots" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="sdsBoots" Width="100%" OnRowEditing="GridBoots_RowEditing" CellPadding="4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
        <asp:BoundField DataField="ShoeType" HeaderText="ShoeType" SortExpression="ShoeType" />
        <asp:BoundField DataField="ShoeName" HeaderText="ShoeName" SortExpression="ShoeName" />
        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
        <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
    </Columns>
    <EditRowStyle BackColor="#7C6F57" />
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F8FAFA" />
    <SortedAscendingHeaderStyle BackColor="#246B61" />
    <SortedDescendingCellStyle BackColor="#D4DFE1" />
    <SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView>
<asp:SqlDataSource ID="sdsBoots" runat="server" ConnectionString="<%$ ConnectionStrings:db_1525596_co5027ConnectionString %>" DeleteCommand="DELETE FROM [BootProduct] WHERE [ID] = @ID" InsertCommand="INSERT INTO [BootProduct] ([ShoeType], [ShoeName], [Price], [Description], [Image]) VALUES (@ShoeType, @ShoeName, @Price, @Description, @Image)" SelectCommand="SELECT * FROM [BootProduct]" UpdateCommand="UPDATE [BootProduct] SET [ShoeType] = @ShoeType, [ShoeName] = @ShoeName, [Price] = @Price, [Description] = @Description, [Image] = @Image WHERE [ID] = @ID">
    <DeleteParameters>
        <asp:Parameter Name="ID" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="ShoeType" Type="Int32" />
        <asp:Parameter Name="ShoeName" Type="String" />
        <asp:Parameter Name="Price" Type="Int32" />
        <asp:Parameter Name="Description" Type="String" />
        <asp:Parameter Name="Image" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ShoeType" Type="Int32" />
        <asp:Parameter Name="ShoeName" Type="String" />
        <asp:Parameter Name="Price" Type="Int32" />
        <asp:Parameter Name="Description" Type="String" />
        <asp:Parameter Name="Image" Type="String" />
        <asp:Parameter Name="ID" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
<hr />
<asp:LinkButton ID="LinkButton2" runat="server" CssClass="button" PostBackUrl="~/Management/ManageBootType.aspx">Add New Brand</asp:LinkButton>
<br />
<asp:GridView ID="GridBootsType" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="sdsBootsType" Width="50%" CellPadding="4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
        <asp:BoundField DataField="ShoeName" HeaderText="ShoeName" SortExpression="ShoeName" />
    </Columns>
    <EditRowStyle BackColor="#7C6F57" />
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F8FAFA" />
    <SortedAscendingHeaderStyle BackColor="#246B61" />
    <SortedDescendingCellStyle BackColor="#D4DFE1" />
    <SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView>
<asp:SqlDataSource ID="sdsBootsType" runat="server" ConnectionString="<%$ ConnectionStrings:db_1525596_co5027ConnectionString %>" DeleteCommand="DELETE FROM [BootType] WHERE [ID] = @ID" InsertCommand="INSERT INTO [BootType] ([ShoeName]) VALUES (@ShoeName)" SelectCommand="SELECT * FROM [BootType]" UpdateCommand="UPDATE [BootType] SET [ShoeName] = @ShoeName WHERE [ID] = @ID">
    <DeleteParameters>
        <asp:Parameter Name="ID" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="ShoeName" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ShoeName" Type="String" />
        <asp:Parameter Name="ID" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
