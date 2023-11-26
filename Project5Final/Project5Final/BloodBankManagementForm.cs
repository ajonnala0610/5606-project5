using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5Final
{
    public partial class BloodBankManagementForm : Form
    {
        public BloodBankManagementForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //brings up the about box.
            //1. instantiate the about form
            AboutBox1 aboutBox1 = AboutBox1.AboutBox1Form();
            //2. Make the about box as a child form to the main form
            aboutBox1.MdiParent = this;
            //3. show the about box
            aboutBox1.Show();
        }

        private void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewAllDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instantiate the view all donors form
            ViewAllDonorsForm viewalldonorlabel = new ViewAllDonorsForm();
            //Make the view all donor form as a child form to the main form
            viewalldonorlabel.MdiParent = this;
            //show the view all donor form
            viewalldonorlabel.Show();
        }

        private void stockIncreaseDecreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instantiate the view all donors form
            StockManagementForm stockManagementForm = StockManagementForm.GetStockManagementForm();
            //Make the view all donor form as a child form to the main form
            stockManagementForm.MdiParent = this;
            //show the view all donor form
            stockManagementForm.Show();
        }

        private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDonorForm dd=new DeleteDonorForm();
            dd.Show();
        }
    }

      
    }

