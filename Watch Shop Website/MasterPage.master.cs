using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string BasketQuantityLabelText
    {
        get => lblBasketQuantity.Text;
        set => lblBasketQuantity.Text = value;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
       
            var basket = (Basket)Session["Basket"] ?? new Basket();
            Session["Basket"] = basket;
            var basketQuantity = basket.GetItemQuantity;
            lblBasketQuantity.Text = basketQuantity == 0 ? "" : basketQuantity.ToString();
        
    }

    }



