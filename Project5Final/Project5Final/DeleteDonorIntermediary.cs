using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5Final
{
    internal class DeleteDonorIntermediary
    {
        private object bbDataAccess;

        public string DBError { get; set; }
        public DataSet DeleteDonor()
        {
            try
            {
                //instantiate the DATA ACCESS CLASS.
                DeleteDonorDataAccess deleteDonorDataAccess = new DeleteDonorDataAccess();
                //create the query needed in order to get the data from the class
                string sqlQuery = "SELECT * FROM DeleteDonor;";
                //call the method and supply the sql query to data access class
                DataSet bbDeleteDonors = bbDataAccess.DeleteDonorSelectQueryData(sqlQuery);
                //return the data to the form class.
                return bbDeleteDonors;
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
        }
    }
}
    
