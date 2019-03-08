using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory;
using Sandbox;
using Utilities;

namespace CustomerSite
{
    public partial class BasketPage : System.Web.UI.Page
    {
        private Basket Basket => (Basket)Session["Basket"];

        protected void Page_Load(object sender, EventArgs e)
        {
            var isBasketEmpty = Basket.GetItemQuantity == 0;
            if (!isBasketEmpty)
            {
                RepeaterPanel.Visible = !isBasketEmpty;
                EmptyBasketPanel.Visible = isBasketEmpty;
                SeedBasketRepeater();
            }

        }

        private void SeedBasketRepeater()
        {
            var allItems = (List<Item>)Session["Items"];
            var basketContent = Basket.BasketContent;
            var items = allItems.Where(i => basketContent.Keys.Contains(i.Id)).ToList();

            var totalPrice = items.Aggregate(0m, (total, next) => total += next.Price * basketContent[next.Id]);
            lblBasketTotal.Text = totalPrice.ToString("C");
            lblBasketItemCount.Text = Basket.GetItemQuantity.ToString();


            BasketRepeater.DataSource = DataTableUtils.GetBasketDataTable(items, basketContent);


            BasketRepeater.DataBind();

        }


        protected void EmptyBasketHandler(object sender, EventArgs e)
        {
            Basket.EmptyBasket();
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}