<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 260px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" cellpadding="0" class="style1">
            <tr>
                <td width="60">
                    Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Width="98%"></asp:TextBox>
                </td>
                <td width="25">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtName" ErrorMessage="Please Enter Your Name">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Mail</td>
                <td>
                    <asp:TextBox ID="txtMail" runat="server" Width="98%"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtMail" ErrorMessage="Please Enter Your Mail Address">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtMail" ErrorMessage="Invalid Mail Address" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    URL</td>
                <td>
                    <asp:TextBox ID="txtURL" runat="server" Width="98%"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="txtURL" ErrorMessage="Invalid URL" 
                        ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Subject</td>
                <td>
                    <asp:TextBox ID="txtSubject" runat="server" Width="98%"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtSubject" ErrorMessage="Please Enter Subject">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Body</td>
                <td>
                    <asp:TextBox ID="txtBody" runat="server" Height="95px" TextMode="MultiLine" 
                        Width="98%"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtBody" ErrorMessage="Please Enter Your Message">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td style="text-align: right">
                    <asp:Button ID="Button2" runat="server" Text="Send" onclick="Button2_Click" />
                    <input type="reset" value="Clear" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
