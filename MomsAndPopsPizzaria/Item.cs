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

        public Item(string n, int c, float p)
        {
            Name = n;
            Count = c;
            Price = p;
        }
    }

}