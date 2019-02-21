﻿using System;
using System.Collections.Generic;
using System.Data;
using Inventory;

namespace Utilities
{
    public class DataTableUtils
    {
        public static DataTable GetItemDataTable(IEnumerable<Item> items)
        {
                var dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("Name");
                dt.Columns.Add("Image");
                dt.Columns.Add("Category");
                dt.Columns.Add("Description");
                dt.Columns.Add("Price");

                foreach (Item item in items)
                {
                    var row = dt.NewRow();

                    row["Id"] = item.Id;
                    row["Name"] = item.Name;
                    row["Image"] = item.Image;
                    row["Category"] = Enum.GetName(typeof(Categories), item.Category);
                    row["Description"] = item.Description;
                    row["Price"] = item.Price;
                    dt.Rows.Add(row);
                }

                return dt;
            
        }

        public static DataTable GetBasketDataTable(IEnumerable<Item> items, Dictionary<int, int> basketContent)
        {
            var dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Image");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
    
            foreach (Item item in items)
            {
                var row = dt.NewRow();

                row["Id"] = item.Id;
                row["Name"] = item.Name;
                row["Image"] = item.Image;
                row["Price"] = item.Price;
                row["Quantity"] = basketContent[item.Id];
                dt.Rows.Add(row);
            }

            return dt;

        }
    }
}