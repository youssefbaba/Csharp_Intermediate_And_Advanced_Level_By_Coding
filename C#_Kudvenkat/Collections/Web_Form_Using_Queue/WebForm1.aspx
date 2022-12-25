<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web_Form_Using_Queue.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style ="font-family:Arial ; border:1px solid black ; text-align:center">
            <tr>
                <td>
                    <b>Counter 1</b>
                </td>
                <td></td>
                <td>
                    <b>Counter 2</b>
                </td>
                <td></td>
                <td>
                    <b>Counter 3</b>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextCounter1" runat="server" BackColor="#3333CC" Font-Size="Larger" OnTextChanged="TextBox1_TextChanged" Width="150px" ForeColor="White"></asp:TextBox>
                </td>
                <td></td>
                <td>
                    <asp:TextBox ID="TextCounter2" runat="server" BackColor="#3333CC" Font-Size="Larger" OnTextChanged="TextBox2_TextChanged" Width="150px" ForeColor="White"></asp:TextBox>
                </td>
                <td></td>
                <td>
                    <asp:TextBox ID="TextCounter3" runat="server" BackColor="#3333CC" Font-Size="Larger" OnTextChanged="TextBox3_TextChanged" ForeColor="White" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonCounter1" runat="server" Text="Next" Width="150px" OnClick="ButtonCounter1_Click" />
                </td>
                <td></td>
                <td>
                    <asp:Button ID="ButtonCounter2" runat="server" Text="Next" Width="150px" OnClick="ButtonCounter2_Click" />
                </td>
                <td></td>
                <td>
                    <asp:Button ID="ButtonCounter3" runat="server" Text="Next" Width="150px" OnClick="ButtonCounter3_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:TextBox ID="TextTokenNumber" runat="server" BackColor="#339966" Font-Size="Larger" ForeColor="White" OnTextChanged="TextTokenNumber_TextChanged" Width="500px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td colspan="5">
                    <asp:ListBox ID="ListTokens" runat="server" Font-Size="Larger" OnSelectedIndexChanged="ListTokens_SelectedIndexChanged" Width="150px" ></asp:ListBox>
                </td>
            </tr>
              <tr>
                <td colspan="5">
                    <asp:Button ID="ButtonPrintToken" runat="server" Text="Print Token" OnClick="ButtonPrintToken_Click" />
                </td>
            </tr>
              <tr>
                <td colspan="5">
                    <asp:Label ID="LabelStatus" runat="server" Font-Size="Larger"></asp:Label>
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
