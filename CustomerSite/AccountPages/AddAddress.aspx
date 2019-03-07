<%@ Page Title="" Language="C#" MasterPageFile="~/AccountPages/AccountMaster.master" AutoEventWireup="true" CodeFile="AddAddress.aspx.cs" Inherits="AccountPages_AddAddress" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AccountPagePlaceholder" Runat="Server">
    <div class="form-group row">
        <label for="fullName" class="col-2 col-form-label">Full name</label> 
        <div class="col-10">
            <input id="fullName" name="fullName" type="text" required="required" class="form-control">
        </div>
    </div>
    <div class="form-group row">
        <label for="addressLine1" class="col-2 col-form-label">Street address</label> 
        <div class="col-10">
            <input id="addressLine1" name="addressLine1" placeholder="Street and Number" type="text" required="required" class="form-control">
        </div>
    </div>
    <div class="form-group row">
        <label class="col-2"></label> 
        <div class="col-10">
            <input id="addressLine2" name="addressLine2" placeholder="Flat, suite, unit, building, etc." type="text" class="form-control">
        </div>
    </div>
    <div class="form-group row">
        <label for="townCity" class="col-2 col-form-label">Town/City</label> 
        <div class="col-10">
            <input id="townCity" name="townCity" type="text" required="required" class="form-control">
        </div>
    </div>
    <div class="form-group row">
        <label for="county" class="col-2 col-form-label">County</label> 
        <div class="col-10">
            <input id="county" name="county" type="text" class="form-control">
        </div>
    </div> 
    <div class="form-group row">
        <div class="offset-2 col-10">
            <a href="YourAddresses.aspx" class="btn btn-primary">Add Address</a>
        </div>
    </div>
</asp:Content>

