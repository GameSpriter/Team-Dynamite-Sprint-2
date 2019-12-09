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
        private Pizza pizza;
        private float toppingPrice;
        private bool hasSelectedSize = false;
        private bool hasSelectedCrust = false;
        FormController Parent;

        /// <summary>
        /// Constructor for FormCustomPizza
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

            //Setup for Template toppings
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

                template.Topping = new Item(toppingName, 0, 0);
                template.Setup();

                template.ToppingCheckBox.CheckedChanged += new EventHandler(ToppingTextBox_CheckChanged);
                template.ToppingExtraCheckBox.CheckedChanged += new EventHandler(ToppingTextBox_CheckChanged);

                i++;
            }
        }

        /// <summary>
        /// Adds the current Pizza to the cart
        /// </summary>
        private void updateCart()
        {
            Parent.pizzas.Add(pizza);
        }

        private void ToppingTextBox_CheckChanged(object sender, EventArgs e)
        {
            updatePrice();
        }

        /// <summary>
        /// Updates the price on the page
        /// </summary>
        private void updatePrice()
        {
            pizza.updatePrice();
            float price = pizza.price;
            int numberOfToppings = 0;
            foreach (TemplatePizzaTopping template in ToppingsLayoutPanel.Controls)
            {
                if(template.Topping.Count == 2)
                {
                    numberOfToppings++;
                    numberOfToppings++;
                }
                else if(template.Topping.Count == 1)
                {
                    numberOfToppings++;
                }
            }
            price = price + ((numberOfToppings - 2) * toppingPrice);

            //Validation of price not being lower than it's supposed to be
            if(price < pizza.price)
            {
                price = pizza.price;
            }

            TotalCostText.Text = "$" + string.Format("{0:0.00}", price);
            pizza.price = price;
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

        /// <summary>
        /// Adds the pizza to the cart and returns to the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            //Validation for entering Size and Crust
            if(!pageComplete())
            {
                return;
            }

            //Add the toppings to the pizza
            foreach (TemplatePizzaTopping template in ToppingsLayoutPanel.Controls)
            {
                pizza.addTopping(template.Topping);
            }
            updateCart();
            updatePrice();

            Parent.OpenForm("Menu");
        }

        /// <summary>
        /// Validates that a size and crust have been selected
        /// </summary>
        /// <returns>True if a size and crust have been selected</returns>
        private bool pageComplete()
        {
            if (!hasSelectedSize)
            {
                SizeGroupBox.ForeColor = Color.Red;
                return false;
            }
            if (!hasSelectedCrust)
            {
                CrustGroupBox.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        #region Size Radio Buttons

        /// <summary>
        /// Handels radio button changes for size
        /// </summary>
        /// <param name="size">The size the pizza is changed to</param>
        private void SizeRadioButton_CheckedChanged(int size)
        {
            //Handeling of if the size has been selected or not
            hasSelectedSize = true;
            SizeGroupBox.ForeColor = Color.Black;
            
            //Setting up the pizza size
            pizza.SelectedSize = Pizza.Sizes.small;
            toppingPrice = 0.50f + (0.25f * size);
            ToppingCostText.Text = string.Format("${0:0.00}", toppingPrice);
            updatePrice();
        }

        private void SmallSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SizeRadioButton_CheckedChanged(0);
        }

        private void MeduimSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SizeRadioButton_CheckedChanged(1);
        }

        private void LargeSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SizeRadioButton_CheckedChanged(2);
        }

        private void ExtraLargeSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SizeRadioButton_CheckedChanged(3);
        }
        #endregion

        
        #region Crust Radio Buttons
        private void ThinCrustRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pizza.SelectedCrust = Pizza.Crusts.thin;
            hasSelectedCrust = true;
        }

        private void PanCrustRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pizza.SelectedCrust = Pizza.Crusts.pan;
            hasSelectedCrust = true;
        }

        private void RegularCrustRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pizza.SelectedCrust = Pizza.Crusts.regular;
            hasSelectedCrust = true;
        }

        #endregion

    }
}
