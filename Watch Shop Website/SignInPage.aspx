<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignInPage.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceholder" Runat="Server">
    <div class="row text-center">
        <h2 class="w-100">Sign In</h2>
    </div>
    <div class="w-50 m-auto">
    <div class="form-group">
        <label for="MainContentPlaceholder_TextBox1">Email address</label>
        <asp:TextBox CssClass="form-control" type="email" placeholder="Enter email" ID="TextBox1" runat="server"></asp:TextBox>
     
    </div>
    <div class="form-group">
        <label for="exampleInputPassword1">Password</label>
        <asp:TextBox CssClass="form-control"  type="password" placeholder="Password" ID="TextBox2" runat="server"></asp:TextBox>
      
    </div>
   
    <button type="submit" class="btn btn-primary">Sign In</button>
    </div>
</asp:Content>

