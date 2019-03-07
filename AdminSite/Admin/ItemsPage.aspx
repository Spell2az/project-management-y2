<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ItemsPage.aspx.cs" Inherits="AdminSite.Admin.ItemsPage" %>
<%@ Import Namespace="Inventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Products</h1>
        
    </div>
    <asp:Repeater runat="server" ID="ItemRepeater">
        <HeaderTemplate>
            <table class="table">
                <tr>
                    <th>Item Id</th>
                    <th>Item Title</th>
                    <th>Category</th>
                    <th>Price</th>
                    <th>Image</th>
                    <th></th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("Id") %></td>
                <td><%#Eval("Name") %></td>
                <td><%#Eval("Category") %></td>
                <td><%# Convert.ToDecimal(Eval("Price")).ToString("C") %></td>
                <td><asp:Image Height="60" Width="60"  runat="server" ImageUrl='<%# Eval("Image") %>' /></td>
                <td><a class="btn btn-outline-info">Edit</a></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
