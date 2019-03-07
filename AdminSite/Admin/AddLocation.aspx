<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddLocation.aspx.cs" Inherits="AdminSite.Admin.AddLocation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Add Locations
        </h1>
    </div>
        <div class="form-group row">
            <label for="aisleNumber" class="col-4 col-form-label">Aisle Number:</label> 
            <div class="col-8">
                <input id="aisleNumber" name="aisleNumber" type="text" class="form-control" required="required">
            </div>
        </div>
        <div class="form-group row">
            <label for="locationCount" class="col-4 col-form-label">Location count:</label> 
            <div class="col-8">
                <input id="locationCount" name="locationCount" type="text" class="form-control" required="required">
            </div>
        </div>
        <div class="form-group row">
            <label for="locationStart" class="col-4 col-form-label">Start from location:</label> 
            <div class="col-8">
                <input id="locationStart" name="locationStart" type="text" class="form-control" required="required">
            </div>
        </div> 
        <div class="form-group row">
            <div class="offset-4 col-8">
                <button name="submit" type="submit" class="btn btn-primary">Add locations</button>
            </div>
        </div>
    
</asp:Content>
