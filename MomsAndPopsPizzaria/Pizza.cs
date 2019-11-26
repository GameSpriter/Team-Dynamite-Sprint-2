using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MomsAndPopsPizzaria
{
    public class Pizza
    {
        public enum Crust { };
        public Crust SelectedCrust;
        public enum Size { };
        public Size SelectedSize;
        public List<Item> ToppingsList;
        public float price;

        public Pizza()
        {

        }

        public void addTopping(Item topping)
        {

        }

        public void addTopping(string topping)
        {

        }

        private void updatePrice()
        {

        }
    }
}