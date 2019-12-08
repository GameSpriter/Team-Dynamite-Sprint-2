using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MomsAndPopsPizzaria
{
    public partial class FormCustomPizza : Form
    {
        private readonly string AdditionalToppings = "Additional toppings: ";
        private Pizza pizza;
        private float toppingPrice;
        FormController Parent;

        /// <summary>
        /// Constructor for the FormCustomPizza class
        /// </summary>
        /// <param name="Parent">The parent FormController</param>
        public FormCustomPizza(FormController Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
        }

        /// <summary>
        /// Called when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCustomPizza_Load(object sender, EventArgs e)
        {
            pizza = new Pizza();
            templatePage1.ChangeName("Pizza");

            int i = 0;
            foreach(TemplatePizzaTopping template in ToppingsLayoutPanel.Controls)
            {
                string toppingName = "";

                switch (i)
                {
                    case (int)Pizza.Toppings.cheese:
                        toppingName = "Cheese";
                        break;
                    case (int)Pizza.Toppings.pepperoni:
                        toppingName = "Pepperoni";
                        break;
                    case (int)Pizza.Toppings.sausage:
                        toppingName = "Sausage";
                        break;
                    case (int)Pizza.Toppings.ham:
                        toppingName = "Ham";
                        break;
                    case (int)Pizza.Toppings.greenPeppers:
                        toppingName = @"Green Peppers";
                        break;
                    case (int)Pizza.Toppings.onions:
                        toppingName = "Onion";
                        break;
                    case (int)Pizza.Toppings.tomatoes:
                        toppingName = "Tomato";
                        break;
                    case (int)Pizza.Toppings.mushrooms:
                        toppingName = "Mushroom";
                        break;
                    case (int)Pizza.Toppings.pineapple:
                        toppingName = "Pineapple";
                        break;
                }

                template.Topping = new Item(toppingName, 1, toppingPrice);
                template.Setup();
                i++;
            }
        }

        /// <summary>
        /// Adds the current Pizza to the cart
        /// </summary>
        private void updateCart()
        {
            foreach (TemplatePizzaTopping template in ToppingsLayoutPanel.Controls)
            {
                pizza.addTopping(template.Topping);
            }
                Parent.pizzas.Add(pizza);
        }

        /// <summary>
        /// Does not add the pizza to the cart and returns to the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            pizza = null;
            Parent.OpenForm("FormMenu");
        }

        private void SmallSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toppingPrice = 0.50f;
            AdditionalToppingsCostText.Text = AdditionalToppings + "$0.50";
            pizza.SelectedSize = Pizza.Sizes.small;
        }

        private void MeduimSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toppingPrice = 0.75f;
            AdditionalToppingsCostText.Text = AdditionalToppings + "$0.75";
            pizza.SelectedSize = Pizza.Sizes.medium;
        }

        private void LargeSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toppingPrice = 1.00f;
            AdditionalToppingsCostText.Text = AdditionalToppings + "$1.00";
            pizza.SelectedSize = Pizza.Sizes.large;
        }

        private void ExtraLargeSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toppingPrice = 1.25f;
            AdditionalToppingsCostText.Text = AdditionalToppings + "$1.25";
            pizza.SelectedSize = Pizza.Sizes.extraLarge;
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            updateCart();
            Parent.OpenForm("Menu");
        }

        private void ThinCrustRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pizza.SelectedCrust = Pizza.Crusts.thin;
        }

        private void PanCrustRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pizza.SelectedCrust = Pizza.Crusts.thin;
        }

        private void RegularCrustRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pizza.SelectedCrust = Pizza.Crusts.thin;
        }
    }
}
