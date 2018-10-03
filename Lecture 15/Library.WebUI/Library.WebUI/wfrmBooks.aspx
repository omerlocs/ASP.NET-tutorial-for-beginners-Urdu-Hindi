<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfrmBooks.aspx.cs" Inherits="Library.WebUI.wfrmBooks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td colspan="2">
                <h1>Manage Library Books</h1>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblBookCode" runat="server" Text="Book Code."></asp:Label></td>
            <td><asp:TextBox ID="txtBookCode" runat="server"></asp:TextBox> </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblBookTitle" runat="server" Text="Book Title."></asp:Label> </td>
            <td><asp:TextBox ID="txtBookTitle" runat="server"></asp:TextBox> </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblBookAuthor" runat="server" Text="Book Author."></asp:Label> </td>
            <td><asp:TextBox ID="txtBookAuthor" runat="server"></asp:TextBox> </td>
        </tr>
        <tr>
            <td> <asp:Label ID="lblBookPublisher" runat="server"></asp:Label></td>
            <td> <asp:TextBox ID="txtBookPublisher" runat="server"></asp:TextBox> </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
