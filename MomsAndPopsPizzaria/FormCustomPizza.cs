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
        FormController Parent;

        public FormCustomPizza(FormController Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
        }

        /// <summary>
        /// On Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCustomPizza_Load(object sender, EventArgs e)
        {
            Control.ControlCollection templatePizzaToppingsCollection = ToppingsLayoutPanel.Controls;
            int i = 0;
            foreach(TemplatePizzaTopping template in templatePizzaToppingsCollection)
            {

                template.Topping = new Item(Enum.GetName(typeof(Pizza.Toppings), i), 1, toppingPrice);
                i++;
            }
        }

        private void updateCart()
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            pizza = null;

        }

        private void SmallSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toppingPrice = 0.50f;
            pizza.SelectedSize = Pizza.Sizes.small;
        }

        private void MeduimSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            toppingPrice = 0.75f;
            pizza.SelectedSize = Pizza.Sizes.medium;
        }

        private void LargeSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            toppingPrice = 1.00f;
            pizza.SelectedSize = Pizza.Sizes.large;
        }

        private void ExtraLargeSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            toppingPrice = 1.25f;
            pizza.SelectedSize = Pizza.Sizes.extraLarge;
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {

        }

        private void ThinCrustRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PanCrustRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RegularCrustRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
