using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory;
using Sandbox;
using Utilities;

namespace CustomerSite
{
    public partial class ItemPage : System.Web.UI.Page
    {
        private int imgSize = 500;
        private int itemId;
        private int dropDownMaxQuantity = 10;
        private int defaultItemId = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            SeedQuantityDropDown();
            itemId = String.IsNullOrEmpty(Request.QueryString["Id"]) ? defaultItemId : Convert.ToInt32(Request.QueryString["Id"]);

            var items = (List<Item>)Session["Items"];
            var item = items.Single(i => i.Id == itemId);
            var reviews = new Reviews().GetReviewForItemId(itemId);
            lblRating.Text = "Rating: 5.0 / " + reviews.Average(r => r.Rating);
            SeedReviews(reviews);
            DisplayItemDetails(item);
        }

        private void DisplayItemDetails(Item item)
        {
            lblDescription.Text = item.Description;
            lblName.Text = item.Name;
            lblPrice.Text = item.Price.ToString("C");
            imgItem.ImageUrl = SetImageUrlSize(item.Image);
        }

        private string SetImageUrlSize(string img)
        {
            return Regex.Replace(img, @"/\d00/\d00", $"/{imgSize}/{imgSize}");
        }

        private void SeedQuantityDropDown()
        {
            var ddlItems = Enumerable.Range(1, dropDownMaxQuantity)
                .Select(n => new ListItem(n.ToString(), n.ToString())).ToArray();

            ddlQuantity.Items.AddRange(ddlItems);
        }

        private void SeedReviews(List<Review> reviews)
        {
            ReviewRepeater.DataSource = DataTableUtils.GetReviewDataTable(reviews);
            ReviewRepeater.DataBind();
        }

        protected void AddItemToBasket(object sender, EventArgs e)
        {
            var master = this.Master;
            var basket = (Basket)Session["Basket"];
            var quantity = Convert.ToInt32(ddlQuantity.SelectedValue);
            basket.Add(itemId, quantity);
            if (master != null)
            {
                var basketControl = master.FindControl("lblBasketQuantity") as Label;
                basketControl.Text = basket.GetItemQuantity.ToString();
            }
        }
    }
}