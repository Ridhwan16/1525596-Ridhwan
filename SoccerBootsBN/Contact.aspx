<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SoccerBootsBN.contact" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link href="StyleSheet/Contact.css" rel="stylesheet" type="text/css" />
    <!--source taken from https://www.youtube.com/watch?v=ngldKCSXA6U and https://www.youtube.com/watch?v=Fw1X7HLZfos-->
    <div id ="left">
        <fieldset>
            <legend>Contact Us</legend>
            <table id="bold">
                <tr>
                    <td>
                        <div>Name:</div>
                    </td>
                    <td>
                        <asp:TextBox ID="TextName" width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                       
                        <asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator1"
                            runat="server" 
                            ErrorMessage="Name field must be inserted"
                            ControlToValidate="TextName"
                            Text="*"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </td>
                    <tr>
                    <td>
                        <div>Email:</div>
                    </td>
                    <td>
                        <asp:TextBox ID="TextEmail" width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator2"                             
                            runat="server" 
                            ErrorMessage="Email field must be inserted"
                            ControlToValidate="TextEmail"
                            Display="Dynamic"
                            Text="*"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator 
                            ID="RegularExpressionValidator1" 
                            runat="server" 
                            ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            ErrorMessage="Invalid Email Format" 
                            ControlToValidate="TextEmail"
                            ForeColor="Red"
                            Display="Dynamic">
                            *
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                <td>
                        <div>Subject:</div>
                    </td>
                    <td>
                        <asp:TextBox ID="TextSubject" width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator3"
                            runat="server" 
                            ErrorMessage="Subject field must be inserted"
                            ControlToValidate="TextSubject"
                            Text="*"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </td>
                 </tr>
                <tr>
                <td style="vertical-align:top">
                        <div>Comments:</div>
                    </td>
                    <td style="vertical-align:top">
                        <asp:TextBox ID="TextComment" width="200px" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td style="vertical-align:top">
                        <asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator4"
                            runat="server" 
                            ErrorMessage="Comments field must be inserted"
                            ControlToValidate="TextComment"
                            Text="*"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </td>
                 </tr>
                <tr>
                    <td colspan="3">
                        <asp:ValidationSummary HeaderText="Please fix the following errors:" ID="ValidationSummary1" runat="server" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="NotesLabel" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="SbmtGmailBtn" runat="server" Text="Submit" OnClick="SbmtGmailBtn_Click" />
                    </td>
                </tr>
            </table>
        </fieldset>
    </div>
     
    <div id="right">
        <p>Find us here:</p>
        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d835.7084918127937!2d114.93123784756648!3d4.885651315406314!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x32228ac8ee3f7d03%3A0xcacd96016959ec39!2sLaksamana+College+of+Business!5e0!3m2!1sen!2sbn!4v1493095312705"> </iframe>


    </div>
</asp:Content>
