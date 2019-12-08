using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MomsAndPopsPizzaria
{
    public class Item
    {
        public string Name;
        public int Count;
        public float Price;

        public Item(string Name, int Count, float Price)
        {
            this.Name = Name;
            this.Count = Count;
            this.Price = Price;
        }
    }

    

}