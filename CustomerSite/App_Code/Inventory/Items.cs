using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Inventory
{
    public class Items
    {
        public List<Item> ItemList { get; set; }

        public Items()
        {
            LoadJson();
        }
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "data.json"))
            {
                string json = r.ReadToEnd();
                ItemList = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }
    }
}