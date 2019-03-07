<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="EmployeesPage.aspx.cs" Inherits="AdminSite.Admin.EmployeesPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Employees</h1>
        
    </div>
    <asp:Repeater ID="EmployeeRepeater" runat="server">
        <HeaderTemplate>
            <table class="table">
            <tr>
                <th>User Id</th>
                <th>Name</th>
                <th>Receive</th>
                <th>Stow</th>
                <th>Pick</th>
                <th>Pack</th>
                <th>Ship</th>
                <th></th>
            </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("UserId") %></td>
                <td><%# string.Concat(Eval("FirstName"), " ",Eval("LastName")) %></td>
                <td><asp:CheckBox runat="server" Enabled="False" Checked='<%# Convert.ToBoolean(Eval("Receive")) %>'/></td>
                <td><asp:CheckBox runat="server" Enabled="False" Checked='<%# Convert.ToBoolean(Eval("Stow")) %>'/></td>
                <td><asp:CheckBox runat="server" Enabled="False" Checked='<%# Convert.ToBoolean(Eval("Pick")) %>'/></td>
                <td><asp:CheckBox runat="server" Enabled="False" Checked='<%# Convert.ToBoolean(Eval("Pack")) %>'/></td>
                <td><asp:CheckBox runat="server" Enabled="False" Checked='<%# Convert.ToBoolean(Eval("Ship")) %>'/></td>
                <td><a class="btn btn-outline-info">Edit</a></td>
            </tr>
        </ItemTemplate>
        
        <FooterTemplate>
        </table>
        </FooterTemplate>
    </asp:Repeater>

</asp:Content>
