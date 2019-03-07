<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddItem.aspx.cs" Inherits="AdminSite.Admin.AddItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group row justify-content-center">
        <label for="itemId" class="col-2 col-form-label">Barcode(ItemId):</label> 
        <div class="col-4">
            <input id="itemId" name="itemId" placeholder="Barcode" type="text" required="required" class="form-control">
        </div>
    </div>
    <div class="form-group row justify-content-center">
        <label for="itemTitle" class="col-2 col-form-label">Item Title</label> 
        <div class="col-4">
            <input id="itemTitle" name="itemTitle" placeholder="Item Title" type="text" required="required" class="form-control">
        </div>
    </div>
    <div class="form-group row justify-content-center">
        <label for="itemDescription" class="col-2 col-form-label">Item description</label> 
        <div class="col-4">
            <textarea id="itemDescription" name="itemDescription" cols="40" rows="5" required="required" class="form-control"></textarea>
        </div>
    </div>
    <div class="form-group row justify-content-center">
        <label for="price" class="col-2 col-form-label">Price:</label> 
        <div class="col-4">
            <input id="price" name="price" placeholder="Price" type="text" required="required" class="form-control">
        </div>
    </div>
    <div class="form-group row justify-content-center">
        <label for="selectCategory" class="col-2 col-form-label">Category:</label> 
        <div class="col-4">
            <select id="selectCategory" name="selectCategory" required="required" class="custom-select">
                <option value="speakers">Speakers</option>
                <option value="headphones">Headphones</option>
                <option value="accessories">Accessories</option>
            </select>
        </div>
    </div> 
    <div class="form-group row justify-content-center">
        <label for="imageSelect" class="col-2 col-form-label">Item Image:</label> 
        <div class="col-4">
            <input type="file" id="imageSelect" name="pic" accept="image/*">
        </div>
    </div>
    <div class="form-group row justify-content-center">
        <div class="col-4">
            <button name="submit" type="submit" class="btn btn-primary btn-block">Add Item</button>
        </div>
    </div>
</asp:Content>
