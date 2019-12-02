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
    public partial class FormLogin : Form
    {
        FormSignUp signUpForm = new FormSignUp();
        FormResetPassword forgotPassword = new FormResetPassword();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Takes the user to the sign up screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                signUpForm.Show();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                //this.Hide();    
            }
        }

        private void ForgotEmailPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                forgotPassword.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //this.Hide();
            }
        }

        /// <summary>
        /// Name of the textfield
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailText_Click(object sender, EventArgs e)
        {
            EmailText.Text = "Username/Email";
        }

        /// <summary>
        /// Takes the input of the textfield and assigns it to the string 'userName'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            string userName = EmailTextBox.Text;
            
        }

        /// <summary>
        /// Takes the input of the textfield and assigns it to the string 'password'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;
        }
    }
}
