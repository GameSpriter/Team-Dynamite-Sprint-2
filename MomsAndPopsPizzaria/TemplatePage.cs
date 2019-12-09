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
    public partial class TemplatePage : UserControl
    {
        public TemplatePage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Title click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageTitle_Click(object sender, EventArgs e)
        {
                
        }

        /// <summary>
        /// Template page title
        /// </summary>
        protected void TemplatePageTitle()
        {
            PageTitle.Font = new Font("Arial", 24);
        }
        /// <summary>
        /// Template page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TemplatePage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
