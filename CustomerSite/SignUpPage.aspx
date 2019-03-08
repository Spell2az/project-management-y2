<%@ Page Title="" Language="C#" MasterPageFile="~/SignInSignUp.master" AutoEventWireup="true" CodeBehind="SignUpPage.aspx.cs" Inherits="CustomerSite.SignUpPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="SignInSignUpPlacehodler" runat="server">
    <div class="w-50 m-auto">
        <div class="form-group">
            <label for="MainContentPlaceholder_TextBox1">First Name</label>
            <asp:TextBox CssClass="form-control" type="text" placeholder="First Name" ID="TextBox1" runat="server"></asp:TextBox>
     
        </div>
        <div class="form-group">
            <label for="MainContentPlaceholder_TextBox1">Last Name</label>
            <asp:TextBox CssClass="form-control" type="text" placeholder="Last Name" ID="TextBox3" runat="server"></asp:TextBox>
     
        </div>
        <div class="form-group">
            <label for="MainContentPlaceholder_TextBox1">Email address</label>
            <asp:TextBox CssClass="form-control" type="email" placeholder="Enter email" ID="TextBox4" runat="server"></asp:TextBox>
     
        </div>
        <div class="form-group">
            <label for="exampleInputPassword1">Password</label>
            <asp:TextBox CssClass="form-control"  type="password" placeholder="Password" ID="TextBox2" runat="server"></asp:TextBox>
      
        </div>
        <div class="form-group">
            <label for="exampleInputPassword1">Confirm Password</label>
            <asp:TextBox CssClass="form-control"  type="password" placeholder="Confirm Password" ID="TextBox5" runat="server"></asp:TextBox>
      
        </div>
   
        <button type="submit" class="btn btn-primary">Sign Up</button>
    </div>
    </asp:Content>
