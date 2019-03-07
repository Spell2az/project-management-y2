﻿using Inventory;

namespace Sandbox
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

    }
}

