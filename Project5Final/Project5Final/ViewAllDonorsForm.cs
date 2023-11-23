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
    public partial class ViewAllDonorsForm : Form
    {
        public ViewAllDonorsForm()
        {
            InitializeComponent();
        }

        private void ViewAllDonorsForm_Load(object sender, EventArgs e)
        {
            //instantiate intermediary class
            BloodBankIntermediary bloodBankDataIntermediary = new BloodBankIntermediary();
            //get the data from the intermediary class.
            DataSet bbData = bloodBankDataIntermediary.ViewAllDonors();
            //assign the dataset as datasource for the datagridview
            bbDataGridView.DataSource = bbData.Tables[0];
            bbDataGridView.AutoGenerateColumns = true;//better readability
            bbDataGridView.ReadOnly = true;//prevent edits by users.
        }//form the load event

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//form class
}// namespace

