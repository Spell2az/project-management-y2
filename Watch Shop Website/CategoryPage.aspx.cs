using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    private string category;
    private DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        category = Request.QueryString["category"];
        CategoryHeading.Text = category;
        dt = SeeDataTable();
        Repeater1.DataSource = dt;
        Repeater1.DataBind();
    }

    private DataTable SeeDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("productId");
        dt.Columns.Add("name");
        dt.Columns.Add("image");
        dt.Columns.Add("category");

        var idList = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        var nameList = new List<string>(){ "logitech", "other", "speaker", "cat", "dog", "hifi", "aeroplane", "london", "leicester", "banana"};
        for (int i = 0; i < idList.Count; i++)
        {
            var row = dt.NewRow();
            row["productId"] = idList[i];
            row["name"] = nameList[i]  + " " + category;
            row["image"] = "bluetooth-speakers.png";
            row["category"] = "speakers";
            dt.Rows.Add(row);
        }
       
        return dt;
    }
}