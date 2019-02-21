<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ItemPage.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceholder" Runat="Server">
    
    
    <div class="row mt-5">
        <div class="col-6">
            <asp:Image ID="imgItem" runat="server"/>
        </div>
        <div class="col-6 flex-column">
            <h2 class="my-3">
                <asp:Label id="lblName" runat="server"></asp:Label>
            </h2>
            <h4 class="my-3">
                <asp:Label id="lblPrice" runat="server"></asp:Label>
            </h4>
            <div class="d-flex">
                <asp:Label runat="server">Quantity: </asp:Label>
                <asp:DropDownList CssClass="ml-2" ID="ddlQuantity" runat="server">
                </asp:DropDownList>
                
                <asp:Button OnClick="AddItemToBasket" CssClass="btn btn-dark ml-4" runat="server" Text="Add to Basket"/>
            </div>
            <p class="mt-3">
                <asp:Label runat="server" ID="lblDescription"></asp:Label>
            </p>
        </div>
    </div>

</asp:Content>

