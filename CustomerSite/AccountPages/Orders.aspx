<%@ Page Title="Orders" Language="C#" MasterPageFile="~/AccountPages/AccountMaster.master" %>

<asp:content id="OrdersContent" ContentPlaceHolderID="AccountPagePlaceholder" runat="server">
    <h1>Orders</h1>
    
    <div class="card  mb-4">
        <div class="card-header d-flex">
            <div class="col-4 d-flex flex-column">
                <span>Order placed</span>
                <span>22 January 2019</span>
            </div>
            <div class="col-4 d-flex flex-column">
                <span>Order Total</span>
                <span>$199.99</span>
            </div>
            <div class="col-4 d-flex flex-column text-right">
                <span>Order #122112121231</span>
                <a href="#">Order Details</a>
            </div>
        </div>
        <div class="card-body d-flex">
          
           <a class="card-text col-6" href="#">Bose Speakers</a>
            <div class="col-6 text-right">
                <a class="btn btn-dark" href="#">Write Review</a>
            </div>
        </div>
    </div>
    <div class="card   mb-4">
        <div class="card-header d-flex">
            <div class="col-4 d-flex flex-column">
                <span>Order placed</span>
                <span>22 January 2019</span>
            </div>
            <div class="col-4 d-flex flex-column">
                <span>Order Total</span>
                <span>$199.99</span>
            </div>
            <div class="col-4 d-flex flex-column text-right">
                <span>Order #122112121231</span>
                <a href="#">Order Details</a>
            </div>
        </div>
        <div class="card-body d-flex">
          
            <a class="card-text col-6" href="#">Bose Speakers</a>
            <div class="col-6 text-right">
                <a class="btn btn-dark" href="#">Write Review</a>
            </div>
        </div>
    </div>
    <div class="card   mb-4">
        <div class="card-header d-flex">
            <div class="col-4 d-flex flex-column">
                <span>Order placed</span>
                <span>22 January 2019</span>
            </div>
            <div class="col-4 d-flex flex-column">
                <span>Order Total</span>
                <span>$199.99</span>
            </div>
            <div class="col-4 d-flex flex-column text-right">
                <span>Order #122112121231</span>
                <a href="#">Order Details</a>
            </div>
        </div>
        <div class="card-body d-flex">
          
            <a class="card-text col-6" href="#">Bose Speakers</a>
            <div class="col-6 text-right">
                <a class="btn btn-dark" href="#">Write Review</a>
            </div>
        </div>
    </div>
    <div class="card  mb-4">
        <div class="card-header d-flex">
            <div class="col-4 d-flex flex-column">
                <span>Order placed</span>
                <span>22 January 2019</span>
            </div>
            <div class="col-4 d-flex flex-column">
                <span>Order Total</span>
                <span>$199.99</span>
            </div>
            <div class="col-4 d-flex flex-column text-right">
                <span>Order #122112121231</span>
                <a href="#">Order Details</a>
            </div>
        </div>
        <div class="card-body d-flex">
          
            <a class="card-text col-6" href="#">Bose Speakers</a>
            <div class="col-6 text-right">
                <a class="btn btn-dark" href="#">Write Review</a>
            </div>
        </div>
    </div>
    <asp:Repeater runat="server" ID="OrdersRepeater">
        <ItemTemplate>

        </ItemTemplate>
    </asp:Repeater>
</asp:content>