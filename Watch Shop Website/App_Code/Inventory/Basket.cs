using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    public class Basket
    {
        public int GetItemQuantity => BasketContent.Values.Sum();

        public Dictionary<int, int> BasketContent { get;  } = new Dictionary<int, int>();

        public void Add(int itemId, int quantity = 1)
        {
            if (BasketContent.ContainsKey(itemId))
            {
                BasketContent[itemId] += quantity;
            }
            else
            {
                BasketContent.Add(itemId, quantity);
            }

        }
        public void Remove(int itemId, int quantity = 1)
        {
            if (BasketContent[itemId] - quantity > 0)
            {
                BasketContent[itemId] -= quantity;
            }
            else
            {
                BasketContent.Remove(itemId);
            }

        }

        public void EmptyBasket()
        {
            BasketContent.Clear();
        }
    }
}