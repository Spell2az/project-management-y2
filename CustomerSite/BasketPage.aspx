<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BasketPage.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceholder" runat="Server">
    <h1>Shopping Basket
    </h1>
    <asp:Panel CssClass="row" Visible="False" ID="RepeaterPanel" runat="server">
        <asp:Repeater runat="server" ID="BasketRepeater">
            <HeaderTemplate>
                <table class="table">
                    <tr>
                        <th>Name</th>
                        <th>Quantity</th>
                        <th>Price</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Quantity") %></td>
                    <td><%# Eval("Price") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <div class="w-100 text-right">
            <p>
                Subtotal (<asp:Label ID="lblBasketItemCount" runat="server"></asp:Label>
                Items):
                <asp:Label ID="lblBasketTotal" runat="server"></asp:Label>
            </p>

        </div>
           <div class="row">
        <asp:LinkButton ID="LinkButton1" PostBackUrl="~/AccountPages/CheckoutPage.aspx" CssClass="btn btn-dark" runat="server" Text="Proceed to Checkout" />
        <asp:Button ID="btnEmptyBasket" OnClick="EmptyBasketHandler" CssClass="btn btn-dark" runat="server" Text="Empty Basket" />
    </div>
    </asp:Panel>
 
    <asp:Panel Visible="True" ID="EmptyBasketPanel" CssClass="row  pt-5" runat="server">
        <h3>Your basket is empty
        </h3>
    </asp:Panel>

</asp:Content>

