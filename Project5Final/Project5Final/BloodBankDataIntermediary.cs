using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5Final
{
    internal class BloodBankDataIntermediary
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
    }
}



                

            