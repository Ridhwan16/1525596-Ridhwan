<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SoccerBootsBN.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div style="font-family:Arial;align-content:center">
        <fieldset style="width:350px">
            <legend style="align-content:center">Contact Us</legend>
            <table>
                <tr>
                    <td>
                        <b>Name:</b>
                    </td>
                    <td>
                        <asp:TextBox ID="TextName" width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <%--<asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator1" 
                            runat="server" 
                            ErrorMessage="Name must be inserted"
                            ControlToValidate="TextName"
                            Text="*"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>--%>
                    </td>
                    <tr>
                    <td>
                        <b>Email:</b>
                    </td>
                    <td>
                        <asp:TextBox ID="TextEmail" width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <%--<asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator2" 
                            runat="server" 
                            ErrorMessage="Email must be inserted"
                            ControlToValidate="TextEmail"
                            Text="*"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
                <tr>
                <td>
                        <b>Subject:</b>
                    </td>
                    <td>
                        <asp:TextBox ID="TextSubject" width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <%--<asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator3" 
                            runat="server" 
                            ErrorMessage="Subject must be inserted"
                            ControlToValidate="TextSubject"
                            Text="*"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>--%>
                    </td>
                 </tr>
                <tr>
                <td>
                        <b>Comments:</b>
                    </td>
                    <td>
                        <asp:TextBox ID="TextComment" width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <%--<asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator4" 
                            runat="server" 
                            ErrorMessage="Subject must be inserted"
                            ControlToValidate="TextComment"
                            Text="*"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>--%>
                    </td>
                 </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Button1" runat="server" Text="Submit" />
                    </td>
                </tr>
            </table>
        </fieldset>
    </div>
</asp:Content>
