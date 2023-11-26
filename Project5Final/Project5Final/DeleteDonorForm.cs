using System;
using System.Collections;
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
    public partial class DeleteDonorForm : Form
    {
        readonly function fn = new function();
        String query;

        public DeleteDonorForm()
        {
            InitializeComponent();
        }

        private void DeleteDonorForm_Load(object sender, EventArgs e)
        {
            //instantiate intermediary class
            DeleteDonorIntermediary deletedonorIntermediary = new DeleteDonorIntermediary();
            //get the data from the intermediary class.
            DataSet bbData = deletedonorIntermediary.DeleteDonor();
            //assign the dataset as datasource for the datagridview
            dataGridView1.DataSource = bbData.Tables[0];
            dataGridView1.AutoGenerateColumns = true;//better readability
            dataGridView1.ReadOnly = true;//prevent edits by users.
        }//form the load event

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (donorIDTextBox.Text != "")
            {
                query = "select * from newDonor where did=" + donorIDTextBox.Text + "";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    nameTextBox.Text = ds.Tables[0].Rows[0][1].ToString();
                    fatherNameTextBox.Text = ds.Tables[0].Rows[0][2].ToString();
                    motherNameTextBox.Text = ds.Tables[0].Rows[0][3].ToString();
                    dobTextBox.Text = ds.Tables[0].Rows[0][4].ToString();
                    mobileNumberTextBox.Text = ds.Tables[0].Rows[0][5].ToString();
                    genderComboBox.Text = ds.Tables[0].Rows[0][6].ToString();
                    emailTextBox.Text = ds.Tables[0].Rows[0][7].ToString();
                    bloodGroupComboBox.Text = ds.Tables[0].Rows[0][8].ToString();
                    cityTextBox.Text = ds.Tables[0].Rows[0][9].ToString();
                    addressRichTextBox.Text = ds.Tables[0].Rows[0][10].ToString();
                }
                else
                {
                    MessageBox.Show("No Record exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    donorIDTextBox.Clear();
                }
            }
        }

        internal class function
        {
            internal DataSet getData(string query)
            {
                throw new NotImplementedException();
            }

            internal object setData(string query)
            {
                throw new NotImplementedException();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                query = "delete from newDonor where did = " + nameTextBox.Text + "";
                fn.setData(query);
            }
        }

        private void donorIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (donorIDTextBox.Text == "")
            {
                nameTextBox.Clear();
                fatherNameTextBox.Clear();
                motherNameTextBox.Clear();
                dobTextBox.Clear();
                mobileNumberTextBox.Clear();
                genderComboBox.Enabled = false;
                emailTextBox.Clear();
                bloodGroupComboBox.Enabled = false;
                cityTextBox.Clear();
                addressRichTextBox.Clear();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            donorIDTextBox.Clear();
        }
    }
}

              