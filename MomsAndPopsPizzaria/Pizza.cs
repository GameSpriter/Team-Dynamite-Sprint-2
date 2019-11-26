using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MomsAndPopsPizzaria
{
    public class Pizza
    {
        public enum Crusts { };
        public Crusts SelectedCrust;
        public enum Sizes { };
        public Sizes SelectedSize;
        public enum Toppings { };
        public List<Item> SelectedToppings;
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