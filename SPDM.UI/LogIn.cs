﻿using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDM.UI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            DoLogIn();
        }

        public bool IsValid()
        {
            //lblValidation.Text = String.Empty;
            if (txtUserName.Text == String.Empty)
            {
                txtUserName.Focus();
                lblValidation.Text = "User Name cant be empty";
                return false;
            }

            if(txtPassword.Text == String.Empty)
            {
                txtPassword.Focus();
                lblValidation.Text = "Password cant be empty";
                return false;
            }
            return true;
        }

        public void DoLogIn()
        {
            if (IsValid())
            {
                UserBLL userBLL = new UserBLL();
                bool isExist = userBLL.UserExist(txtUserName.Text, txtPassword.Text);
                if (isExist)
                {
                    ClearField();
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Show();

                }
                else
                {
                    lblValidation.Text = "User Name and Password are invalid.";
                }
            }
            
        }

        public void ClearField()
        {
            txtUserName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            lblValidation.Text = String.Empty;
        }
    }
}