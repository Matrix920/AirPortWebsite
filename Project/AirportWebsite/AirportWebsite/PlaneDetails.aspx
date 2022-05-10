<%@ Page Title="" Language="C#" MasterPageFile="~/AirportMaster.Master" AutoEventWireup="true" CodeBehind="PlaneDetails.aspx.cs" Inherits="AirportWebsite.PlaneDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Plane Details</title>
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
                <asp:Label ID="LabelPlaneID" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Current City</td>
            <td>
                <asp:DropDownList ID="DropDownListCity" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Current State</td>
            <td>
                <asp:DropDownList ID="DropDownListState" runat="server">
                    <asp:ListItem>Travelling</asp:ListItem>
                    <asp:ListItem>Standby</asp:ListItem>
                    <asp:ListItem>Maintenance</asp:ListItem>
                    <asp:ListItem>Just arrived</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>Direction</td>
            <td>
                <asp:DropDownList ID="DropDownListDirection" runat="server">
                    <asp:ListItem>Stopped</asp:ListItem>
                    <asp:ListItem>Approaching</asp:ListItem>
                    <asp:ListItem>Leaving</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>Company</td>
            <td>
                <asp:DropDownList ID="DropDownListCompany" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Current Positiion</td>
            <td>
                <asp:TextBox ID="TextBoxCurrentPosition" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Type</td>
            <td>
                <asp:DropDownList ID="DropDownListType" runat="server">
                    <asp:ListItem>Small</asp:ListItem>
                    <asp:ListItem>Medium</asp:ListItem>
                    <asp:ListItem>Large</asp:ListItem>
                </asp:DropDownList></td>
        </tr>

        <tr>
            <td>Speed</td>
            <td>
                <asp:TextBox ID="TextBoxSpeed" runat="server"></asp:TextBox>
        </tr>
    </table>
    <asp:Button ID="ButtonSave" CssClass="fakeimg" Height="60px" OnClick="ButtonSave_Click" runat="server" Text="Save" />

    <asp:Label ID="Label1" runat="server" Visible="false" Text="Save"></asp:Label>
</asp:Content>
