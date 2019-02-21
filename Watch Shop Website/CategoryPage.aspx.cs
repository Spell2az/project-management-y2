using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory;
using Utilities;

public partial class Default2 : System.Web.UI.Page
{
    private string category;
    private DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        category = Request.QueryString["category"];
        CategoryHeading.Text = category;

        var items = GetItems();
        Session["Items"] = items;
        var categoryItems = items.Where(i => i.Category == (Categories)Enum.Parse(typeof(Categories), category)).ToList();
        dt = DataTableUtils.GetItemDataTable(categoryItems);
        Repeater1.DataSource =
            dt.AsEnumerable().Where(r => r.Field<string>("Category").Equals(category)).CopyToDataTable();
        Repeater1.DataBind();
    }

    private List<Item> GetItems()
    {
        var items = new Items();
        return items.ItemList;

    }
   
}