using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory;
using Utilities;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SeedBasketRepeater();
    }

    private void SeedBasketRepeater()
    {
        var basket = (Basket) Session["Basket"];
        var allItems = (List<Item>) Session["Items"];
        var basketContent = basket.BasketContent;
        var items = allItems.Where(i => basketContent.Keys.Contains(i.Id)).ToList();

        var totalPrice = items.Aggregate(0m, (total, next) => total += next.Price * basketContent[next.Id]);
        lblBasketTotal.Text = totalPrice.ToString("C");
        lblBasketItemCount.Text = basket.GetItemQuantity.ToString();


        BasketRepeater.DataSource = DataTableUtils.GetBasketDataTable(items, basketContent);


        BasketRepeater.DataBind();
    }
}