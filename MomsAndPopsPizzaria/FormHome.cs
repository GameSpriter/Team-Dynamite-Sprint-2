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
    public partial class FormHome : Form
    {
        FormLogin loginForm = new FormLogin();
        FormMenu menuForm = new FormMenu();
        public FormHome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes the user to the Login screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                loginForm.Show();

            }
            catch (ObjectDisposedException ex)
            {
                throw ex;
            }
            finally
            {
                //this.Hide();
            }
        }

        /// <summary>
        /// Takes the user to the Menu screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                menuForm.Show();
            }
            catch (ObjectDisposedException ex)
            {
                throw ex;
            }
            finally
            {
                //this.Hide();
            }
        }

        private void pageTemplate1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
