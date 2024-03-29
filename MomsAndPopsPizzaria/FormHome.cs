﻿using System;
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
        FormController Parent;

        public FormHome(FormController Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
            Parent.Hide(); //Hiding FormController didn't work in FormController's constructor due to timings
        }

        /// <summary>
        /// Takes the user to the Login screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Parent.OpenForm("formLogin");
        }

        /// <summary>
        /// Takes the user to the Menu screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuButton_Click(object sender, EventArgs e)
        {
            Parent.OpenForm("FormMenu");
        }

        private void pageTemplate1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
