<%@ Page Title="Login and Security" Language="C#" MasterPageFile="~/AccountPages/AccountMaster.master" %>

<asp:content id="PersonalInfoContent" ContentPlaceHolderID="AccountPagePlaceholder" runat="server">
    <h2 class="mb-5 w-100 text-center">Login and Security</h2>
    <div class="d-flex">
        <div class="flex-grow-1">
            <h5>Name:</h5>
            <p>Some Name</p>
        </div>
        <div class=" d-flex w-25 justify-content-end align-items-center">
            <button class="btn w-50 d-block btn-primary">Edit</button>
        </div>
    </div>
    <hr />
    <div class="d-flex">
        <div class="flex-grow-1">
            <h5>Email:</h5>
            <p>some@email.com</p>
        </div>
        <div class=" d-flex w-25 justify-content-end align-items-center">
            <button class="btn w-50 d-block btn-primary">Edit</button>
        </div>
    </div>
    <hr />
    <div class="d-flex">
        <div class="flex-grow-1">
            <h5>Phone Number:</h5>
            <p>0900 092332 0399</p>
        </div>
        <div class=" d-flex w-25 justify-content-end align-items-center">
            <button class="btn w-50 d-block btn-primary">Edit</button>
        </div>
    </div>
    <hr />
    <div class="d-flex">
        <div class="flex-grow-1">
            <h5>Password:</h5>
            <p>**************</p>
        </div>
        <div class=" d-flex w-25 justify-content-end align-items-center">
            <button class="btn w-50 d-block btn-primary">Edit</button>
        </div>
    </div>
  
</asp:content>