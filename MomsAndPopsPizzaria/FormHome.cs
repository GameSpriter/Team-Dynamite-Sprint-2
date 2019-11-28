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
        public FormHome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes the user to the login form
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
                this.Hide();
            }

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
