using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MomsAndPopsPizzaria
{
    /// <summary>
    /// This allows Items to be created with a Name, Count, and Price. For use with Toppings, Drinks, Appetizers, and Deserts
    /// </summary>
    public class Item
    {
        public string Name;
        public int Count;
        public float Price;

        /// <summary>
        /// Constructor for Item
        /// </summary>
        /// <param name="Name">The name of the item</param>
        /// <param name="Count">The count of the item</param>
        /// <param name="Price">The price of the item</param>
        public Item(string Name, int Count, float Price)
        {
            this.Name = Name;
            this.Count = Count;
            this.Price = Price;
        }
    }
}