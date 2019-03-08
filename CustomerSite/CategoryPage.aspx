<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CategoryPage.aspx.cs" Inherits="CustomerSite.CategoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceholder" runat="server">
    <div class="container pt-5">
        <h1 class="my-4 text-center"> <asp:Label ID="CategoryHeading" runat="server"></asp:Label></h1>
        <div class="row">
            <asp:Repeater id="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="col-4 p-4">
                    
                        <asp:HyperLink class="d-flex flex-column product-tile" runat="server" NavigateUrl='<%# String.Concat("ItemPage.aspx?id=", Eval("Id"))  %>'>
                            <asp:Image  runat="server" ImageUrl='<%# Eval("Image") %>' />
                            <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("name") %>' Font-Bold="true"/>
                        </asp:HyperLink>
                  
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

    </div>
</asp:Content>
