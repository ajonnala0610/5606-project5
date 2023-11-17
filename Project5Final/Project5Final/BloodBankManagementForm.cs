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
            AboutBox1 aboutBox1 = new AboutBox1();
            //2. Make the about box as a child form to the main form
            aboutBox1.MdiParent = this;
            //3. show the about box
            aboutBox1.Show();
        }

        private void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
