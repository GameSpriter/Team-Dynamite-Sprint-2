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

        public void Setup(string ToppingName)
        {
            ToppingImageBox.Image = Image.FromFile(ToppingName);
        }
    }
}
