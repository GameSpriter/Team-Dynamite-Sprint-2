using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MomsAndPopsPizzaria
{
    public class Pizza
    {
        public enum Crusts 
        {
            regular = 0,
            thin = 1,
            pan = 2,
        };
        public Crusts SelectedCrust;
        public enum Sizes 
        {
            small = 0,
            medium = 1,
            large = 2,
            extraLarge = 3,
        };
        public Sizes SelectedSize;
        public enum Toppings 
        {
            cheese = 0,
            ham = 1,
            tomatoes = 2,
            pepperoni = 3,
            greenPeppers = 4,
            mushrooms = 5,
            sausage = 6,
            onions = 7,
            pineapple = 8,
        };
        public List<Item> SelectedToppings;
        public float price;

        public Pizza()
        {
            SelectedCrust = 0;
            SelectedSize = 0;
        }

        public Pizza(Crusts c, Sizes s, List<Item> st)
        {
            SelectedCrust = c;
            SelectedSize = s;
            SelectedToppings = st;
        }

        public void addTopping(Item topping)
        {
            SelectedToppings.Add(topping);
        }

        public void addTopping(string topping)
        {
            //What is the purpose of this method?
        }

        private void updatePrice()
        {
            if(SelectedSize == Sizes.small) 
            {
                price += 4.00f;
            }
            else if(SelectedSize == Sizes.medium)
            {
                price += 6.00f;
            }
            else if(SelectedSize == Sizes.large)
            {
                price += 8.00f;
            } 
            else
            {
                price += 10.00f;
            }

            if(SelectedToppings.Count > 1)
            {
                price += 1.00f;
            }

        }
    }
}