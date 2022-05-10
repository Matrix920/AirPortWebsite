<%@ Page Title="" Language="C#" MasterPageFile="~/AirportMaster.Master" AutoEventWireup="true" CodeBehind="CityDetails.aspx.cs" Inherits="AirportWebsite.CityDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>City Details</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table align="center" class="auto-style1">
        <tr>
            <td>ID</td>
            <td>
                <asp:Label ID="LabelID" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Position</td>
            <td>
                <asp:TextBox ID="TextBoxPosition" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Code</td>
            <td>
                <asp:TextBox ID="TextBoxCode" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>

    <asp:Button ID="ButtonSave" runat="server" Text="Save"  CssClass="fakeimg" Height="60px" OnClick="ButtonSave_Click" />
</asp:Content>
