<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="AdminSite.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Add Employee</h1>
        
    </div>
    <div class="form-group row  justify-content-center mt-5">
    <label for="userID" class="col-2 col-form-label">User ID:</label> 
    <div class="col-4">
      <input id="userID" name="userID" placeholder="User ID" type="text" required="required" class="form-control">
    </div>
  </div>
  <div class="form-group row justify-content-center">
    <label for="firstName" class="col-2 col-form-label">First Name:</label> 
    <div class="col-4">
      <input id="firstName" name="firstName" placeholder="First name" type="text" required="required" class="form-control">
    </div>
  </div>
  <div class="form-group row justify-content-center">
    <label for="lastName" class="col-2 col-form-label">Last Name:</label> 
    <div class="col-4">
      <input id="lastName" name="lastName" placeholder="Last name" type="text" required="required" class="form-control">
    </div>
  </div>
  <div class="form-group row  justify-content-center">
    <label for="password" class="col-2 col-form-label">Password:</label> 
    <div class="col-4">
      <input id="password" name="password" placeholder="Password" type="text" required="required" class="form-control">
    </div>
  </div>
  <div class="form-group row  justify-content-center">
    <label for="confirmPassword" class="col-2 col-form-label">Confirm Password:</label> 
    <div class="col-4">
      <input id="confirmPassword" name="confirmPassword" placeholder="Confirm Password" type="text" required="required" class="form-control">
    </div>
  </div>
  <div class="form-group row  justify-content-center">
    <label class="col-2 col-form-label">Tasks</label> 
    <div class="col-4">
      <div class="custom-controls-stacked">
        <div class="custom-control custom-checkbox">
          <input name="tasks" id="tasks_0" type="checkbox" class="custom-control-input" value="receive"> 
          <label for="tasks_0" class="custom-control-label">Receive</label>
        </div>
      </div>
      <div class="custom-controls-stacked">
        <div class="custom-control custom-checkbox">
          <input name="tasks" id="tasks_1" type="checkbox" class="custom-control-input" value="stow"> 
          <label for="tasks_1" class="custom-control-label">Stow</label>
        </div>
      </div>
      <div class="custom-controls-stacked">
        <div class="custom-control custom-checkbox">
          <input name="tasks" id="tasks_2" type="checkbox" class="custom-control-input" value="pick"> 
          <label for="tasks_2" class="custom-control-label">Pick</label>
        </div>
      </div>
      <div class="custom-controls-stacked">
        <div class="custom-control custom-checkbox">
          <input name="tasks" id="tasks_3" type="checkbox" class="custom-control-input" value="pack"> 
          <label for="tasks_3" class="custom-control-label">Pack</label>
        </div>
      </div>
      <div class="custom-controls-stacked">
        <div class="custom-control custom-checkbox">
          <input name="tasks" id="tasks_4" type="checkbox" class="custom-control-input" value="ship"> 
          <label for="tasks_4" class="custom-control-label">Ship</label>
        </div>
      </div>
    </div>
  </div> 
  <div class="form-group row  justify-content-center">
    <div class="col-4">
      <button name="submit" type="submit" class="btn btn-primary btn-block">Add Employee</button>
    </div>
  </div>
</asp:Content>
