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
    public partial class BottomBarTemplate : Form
    {
        private Form AboutUsForm, ContactUsForm, LocationForm, PolicyInformationForm, NutritionInformationForm;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Test";
        }

        public BottomBarTemplate()
        {
            InitializeComponent();
        }

        public void ChangePage(Form form)
        {
            form.Parent = this;
            form.Show();
        }
    }
}
