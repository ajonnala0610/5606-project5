using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5Final
{
    internal class BloodBankIntermediary : IBloodBankIntermediary
    {
        public string DBError { get; set; }

        public DataSet ViewAllDonors()
        {
            try
            {
                //instantiate the DataAccess class.
                BloodBankDataAccess bloodBankDataAccess = new BloodBankDataAccess();
                //Create the query needed in order to get the data from class.
                string sqlQuery = "SELECT * from Donor;";
                //call the method and supply the sql query to data access class
                DataSet bbViewAllDonors = bloodBankDataAccess.ViewAllDonorsSelectQueryData(sqlQuery);
                //return the data to the form class.
                return bbViewAllDonors;
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
        }

        public DataSet GetBloodGroupStocks()
        {
            try
            {
                //instantiate the DataAccess class.
                BloodBankDataAccess bbDataAccess = new BloodBankDataAccess();
                //Create the query needed in order to get the data from class.
                string sqlQuery = "SELECT Blood_Group, Quantity from Stock";
                //call the method and supply the sql query to data access class
                DataSet bbGetStocks = bbDataAccess.GetBloodGroupStocksSelectQueryData(sqlQuery);
                //return the data to the form class.
                return bbGetStocks;
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
        }

        public int GetStockQuantity(string bloodGroup)
        {
            try
            {
                BloodBankDataAccess bbDataAccess = new BloodBankDataAccess();
                //Create the query needed in order to get the data from class.
                string sqlQuery = $"Select Quantity from Stock where Blood_Group = '{bloodGroup}'";
                //call the method and supply the sql query to data access class
                int dbUnits = bbDataAccess.GetStockQuantitySelectQueryData(sqlQuery, System.Data.CommandType.Text);
                //return the data to the form class.
                return dbUnits;
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return -1;
            }
        }

        public int UpdateQuantity(int quantity, string bloodGroup)
        {
            try
            {
                BloodBankDataAccess bbDataAccess = new BloodBankDataAccess();
                //Create the query needed in order to get the data from class.
                string sqlQuery = $"Update Stock SET Quantity = {quantity} where Blood_Group = '{bloodGroup}'";
                //call the method and supply the sql query to data access class
                int result = bbDataAccess.UpdateStockQuantitySelectQueryData(sqlQuery, System.Data.CommandType.Text);
                //return the data to the form class.
                return result;
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return -1;
            }
        }
    }
}



                

            