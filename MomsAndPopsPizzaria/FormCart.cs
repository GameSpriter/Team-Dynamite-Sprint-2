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
    public partial class FormCart : Form
    {
        FormController Parent;

        public FormCart(FormController Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {

        }

        private void DrinksAppetizersCartDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
