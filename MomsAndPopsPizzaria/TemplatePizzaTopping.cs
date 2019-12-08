using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MomsAndPopsPizzaria
{
    public partial class TemplatePizzaTopping : UserControl
    {
        public Item Topping;

        public TemplatePizzaTopping()
        {
            InitializeComponent();
        }

        public void Setup()
        {
            ToppingImageBox.Image = (Image) Properties.Resources.ResourceManager.GetObject(Topping.Name.Replace(' ', '_'));
            ToppingCheckBox.Text = Topping.Name;
            ToppingExtraCheckBox.Text = "Extra\n" + Topping.Name;
        }

        private void ToppingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ToppingCheckBox.Checked)
            {

            }
        }

        private void ToppingExtraCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
