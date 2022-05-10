<%@ Page Title="" Language="C#" MasterPageFile="~/AirportMaster.Master" AutoEventWireup="true" CodeBehind="CompanyDetails.aspx.cs" Inherits="AirportWebsite.CompanyDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Company Details</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>ID</td>
            <td>
                <asp:Label ID="LabelID" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Name</td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Nationality</td>
            <td>
                <asp:TextBox ID="TextBoxNationality" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Code</td>
            <td>
                <asp:TextBox ID="TextBoxCode" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="ButtonSave"  CssClass="fakeimg" Height="60px" OnClick="ButtonSave_Click" runat="server" Text="Save" />
</asp:Content>
