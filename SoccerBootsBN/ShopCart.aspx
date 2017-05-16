<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShopCart.aspx.cs" Inherits="SoccerBootsBN.ShopCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!--Source taken from https://www.youtube.com/watch?v=sXS2lX7XdOs-->
    <asp:Panel ID="ShopCartPanel" runat="server">

    </asp:Panel>

    <table>
        <tr>
            <td><b>Total: </b></td>
            <td><asp:Literal ID="TotalLiteral" runat="server" Text=""></asp:Literal></td>
        </tr>
        <tr>
            <td><b>Tax: </b></td>
            <td><asp:Literal ID="TaxLiteral" runat="server" Text=""></asp:Literal></td>
        </tr>
        <tr>
            <td><b>Shipping Charge: </b></td>
            <td>BND 33</td>
        </tr>
        <tr>
            <td><b>Total Price: </b></td>
            <td><asp:Literal ID="TotalPriceLiteral" runat="server" Text=""></asp:Literal></td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="ContinueShop" runat="server" PostBackUrl="~/Default.aspx"
                    Text="Continue Shopping" />
                OR
                <asp:Button ID="CekOutBtn" runat="server" PostBackUrl="~/Completed.aspx"
                    CssClass="button" Width="250px" Text="Continue to Payment" />
            </td>
        </tr>
    </table>
</asp:Content>
