using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MomsAndPopsPizzaria
{
    public class Item
    ///This class allows new items to be created
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