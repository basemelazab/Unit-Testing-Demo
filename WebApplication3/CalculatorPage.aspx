<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorPage.aspx.cs" Inherits="WebApplication3.CalculatorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator Application</title>
</head>

<body style="font-family:Arial">
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Numerator</td>
                <td >
                    <asp:TextBox ID="txtNumerator" runat="server" Width="50px"></asp:TextBox>
                   </td>
            </tr>

             <tr>
                <td>Demonirator</td>
                <td>
                    <asp:TextBox ID="txtDemonirator" runat="server" Width="50px"></asp:TextBox>
                    </td>
            </tr>

            <tr>
                <td>Result</td>
                  <td>
                      <asp:Label ID="lblResult"  runat="server" Width="50px"></asp:Label>
                      </td>
                
               </tr>
            <tr>
                <td>
                    <asp:Button OnClick="Divide" Text="Divide" runat="server" style="height: 29px" />                                    
                    <%--<asp:Button OnClick="submit"  id="bl" Text="Divide" runat="server" />--%>                                       
                </td>
                   
            </tr>

        </table>
    </form>
</body>
</html>
