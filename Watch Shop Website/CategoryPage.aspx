<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CategoryPage.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceholder" Runat="Server">
    <h1> <asp:Label ID="CategoryHeading" runat="server"></asp:Label></h1>
    <div class="row">
        <asp:Repeater id="Repeater1" runat="server">
            <ItemTemplate>
                <div class="col-3 p-4">
                    <div class="d-flex flex-column">
                        <asp:Image runat="server" Height="100px" Width="100px" ImageUrl='<%# String.Concat("~/Img/", Eval("image")) %>' />
                        <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("name") %>' Font-Bold="true"/>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

