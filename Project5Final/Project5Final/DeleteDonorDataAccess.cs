using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project5Final
{
    internal class DeleteDonorDataAccess
    {
        private readonly object Public;

        //declare the connection
        private SqlConnection bloodbankdataConnection;
        //declare the conn string
        private string bbConnString = ConfigurationManager.ConnectionStrings["Project5Final.Properties.Settings.BBConnString"].ConnectionString;

        //Set up the connection
        public SqlConnection GetConnection()
        {
            if (bloodbankdataConnection == null)
            {
                bloodbankdataConnection = new SqlConnection(bbConnString);
            }
            return bloodbankdataConnection;
        }
        //open the connection
        public void OpenNwConnection()
        {
            if (bloodbankdataConnection.State == ConnectionState.Closed)
            {
                bloodbankdataConnection.Open();
            }//end open Connection
        }
        //close connection
        public void OpenNWConnection()
        {
            bloodbankdataConnection.Close();
        }//end closeNWConnection
        public DataSet DeleteDonorSelectQueryData(string query)
        {
            DataSet bbDataSet = new DataSet();
            try
            {
                //instantiate data adapter:
                SqlDataAdapter bbDataAdapter = new SqlDataAdapter(query, this.GetConnection());
                //open the connection:
                this.OpenNWConnection();
                //fill the data into the data set
                bbDataAdapter.Fill(bbDataSet);
                return bbDataSet;
            }//try
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {
                if (bloodbankdataConnection.State == ConnectionState.Open)
                {
                    bloodbankdataConnection.Close();
                }
            }
        }
    }
}
