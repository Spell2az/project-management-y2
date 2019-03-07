using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory;
using Utilities;

namespace AdminSite.Admin
{
    public partial class ItemsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ItemRepeater.DataSource = DataTableUtils.GetItemDataTable(new Items().ItemList);
            ItemRepeater.DataBind();
        }
    }
}