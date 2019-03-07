<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="LocationsPage.aspx.cs" Inherits="AdminSite.Admin.LocationsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Locations</h1>
    </div>
    <div class="form-group row">
        <label for="locationSearch" class="col-4 col-form-label">Search:</label> 
        <div class="col-8">
            <div class="input-group">
                <div class="input-group-prepend">
                    <div class="input-group-text">
                        <i class="fa fa-search"></i>
                    </div>
                </div> 
                <input id="locationSearch" name="locationSearch" placeholder="Search locations" type="text" required="required" class="form-control">
                <button class="btn-primary">Search</button>
            </div>
        </div>
    </div> 
    <asp:Repeater runat="server" ID="LocationRepeater">
        <HeaderTemplate>
            <table class="table">
                <tr>
                    <th>Location Number</th>
                    <th>Number of Items</th>
                    <th></th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("LocationNo") %></td>
                <td><%#Eval("ItemCount") %></td>
                <td><a href="#" class="btn btn-outline-info">View location Items</a></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
