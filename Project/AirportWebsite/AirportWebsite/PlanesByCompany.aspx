<%@ Page Title="" Language="C#" MasterPageFile="~/AirportMaster.Master" AutoEventWireup="true" CodeBehind="PlanesByCompany.aspx.cs" Inherits="AirportWebsite.PlanesByCompany" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Planes By Company</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .notblock{
            padding: 10px;
            display:inline-block;
            font-size:20px;
            background-color:#5d7b9d;
            color:white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
             <div class="notblock">Company</div>
            
                 <asp:DropDownList CssClass="notblock" AutoPostBack="true" ID="DropDownListCompany" runat="server" OnSelectedIndexChanged="DropDownListCity_SelectedIndexChanged">
                 </asp:DropDownList>
         

     <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="False" AutoGenerateDeleteButton="False" OnRowDeleting="GridView1_RowDeleting"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <EditRowStyle BackColor="#999999" />
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#E9E7E2" />
    <SortedAscendingHeaderStyle BackColor="#506C8C" />
    <SortedDescendingCellStyle BackColor="#FFFDF8" />
    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>
</asp:Content>
