using SPDM.BLL.BusinessLogic;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //MainForm frm = new MainForm();
           // frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseAllForms()
        {
            Control.ControlCollection ctrls = this.pForm.Controls;
            foreach (Control ct in ctrls)
            {
                Form f = ct as Form;
                f.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            frmCategory myForm = new frmCategory();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pForm.Controls.Add(myForm);
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }

        

        private void roleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            frmRole myForm = new frmRole();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pForm.Controls.Add(myForm);
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            frmUser myForm = new frmUser();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pForm.Controls.Add(myForm);
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }



        //private void userToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    CloseAllForms();
        //    frmRole myForm = new frmRole();
        //    myForm.TopLevel = false;
        //    myForm.AutoScroll = true;
        //    pForm.Controls.Add(myForm);
        //    myForm.WindowState = FormWindowState.Maximized;
        //    myForm.Show();
        //}
    }
}
