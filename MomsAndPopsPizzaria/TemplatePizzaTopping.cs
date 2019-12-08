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
            ToppingImageBox.Image = Properties.Resources.Pepperoni;
            Console.WriteLine(ToppingImageBox.Image.Height);
            ToppingCheckBox.Text = Topping.Name;
            ToppingExtraCheckBox.Text = "Extra " + Topping.Name;
        }
    }
}
