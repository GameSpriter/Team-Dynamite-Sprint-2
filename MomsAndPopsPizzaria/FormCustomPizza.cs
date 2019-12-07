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
        FormController Parent;

        public FormCustomPizza(FormController Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
        }

        private void updateCart()
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void SmallSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MeduimSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LargeSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ExtraLargeSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

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
