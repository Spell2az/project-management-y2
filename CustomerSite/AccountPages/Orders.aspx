<%@ Page Title="Orders" Language="C#" MasterPageFile="~/AccountPages/AccountMaster.master" %>

<asp:content id="OrdersContent" ContentPlaceHolderID="AccountPagePlaceholder" runat="server">
    <h1>Orders</h1>
    <asp:Repeater runat="server" ID="OrdersRepeater">
        <ItemTemplate>

        </ItemTemplate>
    </asp:Repeater>
</asp:content>