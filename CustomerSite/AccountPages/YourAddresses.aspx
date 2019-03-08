<%@ Page Title="Your Addresses" Language="C#" MasterPageFile="~/AccountPages/AccountMaster.master" AutoEventWireup="true" CodeBehind="YourAddresses.aspx.cs" Inherits="CustomerSite.AccountPages.YourAddresses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AccountPagePlaceholder" runat="server">
    Your Addresses
    <div class="row">
        <div class="col-6">
            <a href="./AddAddress.aspx" class="d-flex flex-column justify-content-center align-items-center border  border-dark h-100">
                <i class="fas fa-plus"></i>
                <span>Add Address</span>
            </a>
        </div>
        <div class="col-6">
            <div class="d-flex flex-column justify-content-center align-items-start border  border-dark p-3">
               
                <span>John Doe</span>
                <span>Flat 8b</span>
                <span>London road 22</span>
                <span>Leicester</span>
                <span>L23 442A</span>
                <hr class="border-dark w-100" />
                <span>
                    <button class="btn btn-primary">Edit</button>
                    <button class="btn btn-danger">Delete</button>
                    <button class="btn btn-info">Set as Default</button>
                </span>
            </div>
        </div>
    </div>
    </asp:Content>
