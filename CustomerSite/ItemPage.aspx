<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ItemPage.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceholder" Runat="Server">
    <div class="container pt-5">
    
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
            <h5 class="my-3">
                <asp:Label id="lblRating" runat="server"></asp:Label>
            </h5>
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
    <div class="row mt-4">
        <h3 class="my-4">Reviews</h3>
        <asp:Repeater id="ReviewRepeater" runat="server">
            <ItemTemplate>
                <div class="row w-100">
                 <p class="col-6"> <%# Eval("Reviewer") %></p>
                 <p class="col-6 text-right">Rating: 5/<%# Eval("Rating") %></p>
                </div>
                <div class="row">
                    <p class="col-12"><%# Eval("ReviewText") %></p>
                   
                </div>
                <hr class="w-100" />
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </div>
</asp:Content>

