<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrmProduct.aspx.cs" Inherits="POS.wfrmProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><asp:Label ID="lblCode" runat="server" Text="Product Code:"></asp:Label></td>
                    <td><asp:TextBox runat="server" ID="txtCode"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblProductName" runat="server" Text="Product Name:"></asp:Label></td>
                    <td><asp:TextBox ID="txtProductName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblProductPrice" runat="server" Text="Product Price:"></asp:Label></td>
                    <td><asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblUnitOfMeasure" runat="server" Text="Unit Of Measure :"></asp:Label></td>
                    <td><asp:TextBox ID="txtUnitOfMeasure" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Label ID="lblMessage" runat="server"></asp:Label></td>
                    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
