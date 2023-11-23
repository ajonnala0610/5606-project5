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
    public partial class StockManagementForm : Form
    {
        private static StockManagementForm stockManagementFormInstance;
        int stockAction;
        private StockManagementForm()
        {
            InitializeComponent();
        }

        public static StockManagementForm GetStockManagementForm()
        {
            if (stockManagementFormInstance == null)
            {
                stockManagementFormInstance = new StockManagementForm();
            }
            return stockManagementFormInstance;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            stockManagementFormInstance = null;
            this.Close();
        }

        private void StockManagementForm_Load(object sender, EventArgs e)
        {
            //instantiate intermediary class
            BloodBankIntermediary bbIntermediary = new BloodBankIntermediary();

            //get data from the intermediary class.
            DataSet rnrData = bbIntermediary.GetBloodGroupStocks();

            //assign the dataset as datasource for the dgv
            stocksDataGridView.DataSource = rnrData.Tables[0];
            stocksDataGridView.AutoGenerateColumns = true;
            stocksDataGridView.ReadOnly = true;
        }

        private void increaseDecreaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            RadioButton selectedRadio = (RadioButton)sender;
            if (selectedRadio.Name == "increaseRadioButton") stockAction = (int)StockManagement.Increase;
            else stockAction = (int)StockManagement.Decrease;
        }

        private void manageStockButton_Click(object sender, EventArgs e)
        {
            string bloodGroup;
            int inputUnits;
           // string selectedUnits;
            int dbUnits;
            int quantity = 0;
            int updateResult;
            errorProvider1.Clear();
            if (bloodGroupComboBox.SelectedIndex != -1)
            {
                bloodGroup = bloodGroupComboBox.SelectedItem.ToString();
                //selectedUnits = unitsComboBox.SelectedItem.ToString();
                if (unitsComboBox.SelectedIndex != -1)
                {

                    int.TryParse(unitsComboBox.SelectedItem.ToString(), out inputUnits);

                    //if (unitsComboBox.SelectedIndex != -1)
                    //{
                    if (stockAction > 0)
                    {

                        BloodBankIntermediary bbIntermediary = new BloodBankIntermediary();
                        dbUnits = bbIntermediary.GetStockQuantity(bloodGroup);

                        if (stockAction == (int)StockManagement.Increase)
                        {
                            StockIncrease stockIncreaseAction = new StockIncrease(bloodGroup, inputUnits, dbUnits, stockAction);
                            quantity = stockIncreaseAction.CalculateQuantity(stockIncreaseAction);

                        }
                        else if (stockAction == (int)StockManagement.Decrease)
                        {
                            StockDecrease stockDecreaseAction = new StockDecrease(bloodGroup, inputUnits, dbUnits, stockAction);
                            quantity = stockDecreaseAction.CalculateQuantity(stockDecreaseAction);
                        }
                        
                        updateResult = bbIntermediary.UpdateQuantity(quantity, bloodGroup);
                        if (updateResult > 0)
                        {
                            MessageBox.Show("Updated Successsfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataSet rnrData = bbIntermediary.GetBloodGroupStocks();
                            //assign the dataset as datasource for the dgv
                            stocksDataGridView.DataSource = rnrData.Tables[0];
                            stocksDataGridView.AutoGenerateColumns = true;
                            stocksDataGridView.ReadOnly = true;
                        }
                        else
                        {
                            MessageBox.Show("Error while updating the quantity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                   else
                    {
                        errorProvider1.SetError(stockActionGroupBox, "Select the action to be performed");
                    }
                }
                else
                {
                    errorProvider1.SetError(unitsComboBox, "Select number of units");
                }
            }
            else
            {
                errorProvider1.SetError(bloodGroupComboBox, "Select Blood Group");
            }
        }
    }
}
