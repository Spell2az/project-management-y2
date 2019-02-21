<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BasketPage.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceholder" Runat="Server">
    <h1>
        Shopping Basket
    </h1>
    <div class="row">
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
        <div class="w-100 text-right" >
                    <p >Subtotal (<asp:Label ID="lblBasketItemCount" runat="server"></asp:Label> Items): <asp:Label ID="lblBasketTotal" runat="server"></asp:Label></p>
                </div>
    </div>
</asp:Content>

