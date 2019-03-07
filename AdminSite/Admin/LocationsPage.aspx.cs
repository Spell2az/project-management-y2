using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminSite.Admin
{
    public partial class LocationsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LocationRepeater.DataSource = GetLocations(20, 10);
            LocationRepeater.DataBind();
        }

        private DataTable GetLocations(int aisles, int locationsPerAisle)
        {
            var dt = new DataTable();
            dt.Columns.Add("LocationNo");
            dt.Columns.Add("ItemCount");
            var random = new Random(500);
            for (int aisleNo = 1; aisleNo < aisles + 1; aisleNo++)
            {
                for (int locationCount = 1; locationCount < locationsPerAisle + 1; locationCount++)
                {
                    var row = dt.NewRow();
                    row["LocationNo"] =
                        $"WH-A{aisleNo.ToString().PadLeft(3, '0')}-L{locationCount.ToString().PadLeft(3, '0')}";
                    row["ItemCount"] = random.Next(0, 30);
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }
    }
}