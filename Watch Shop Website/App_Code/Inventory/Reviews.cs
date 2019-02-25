using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Sandbox;

namespace Inventory
{
    public class Reviews
    {
        private List<Review> ReviewList { get; set; }

        public Reviews()
        {
            LoadJson();
        }
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "review-data.json"))
            {
                string json = r.ReadToEnd();
                ReviewList = JsonConvert.DeserializeObject<List<Review>>(json);
            }
        }

        public List<Review> GetReviewForItemId(int itemId)
        {
            return ReviewList.Where(r => r.ItemId == itemId).ToList();
        }
        
    }
}