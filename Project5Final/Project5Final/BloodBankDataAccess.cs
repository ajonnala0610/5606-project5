using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5Final
{
    internal class BloodBankDataAccess
    {
        //declare the connection
        private SqlConnection bloodbankdataConnection;
        //declare the conn string
        private string bbConnString = ConfigurationManager.ConnectionStrings["Project5Final.Properties.Settings.BBConnString"].ConnectionString;
        //set up the connection
        public SqlConnection GetConnection()
        {
            if (bloodbankdataConnection == null)
                bloodbankdataConnection = new SqlConnection(bbConnString);
            return bloodbankdataConnection;
        }//end GetConnection()

        //open connection
        public void OpenNwConnection()
        {
            if (bloodbankdataConnection.State == ConnectionState.Closed) bloodbankdataConnection.Open();
        }//end openConnection

        public void CloseNwConnection()
        {
            bloodbankdataConnection.Close();
        }//end closeNWConnection()

        public DataSet ViewAllDonorsSelectQueryData(string query)
        {
            DataSet bbDataSet = new DataSet();
            try
            {
                //instantiate data adapter:
                DataAdapter bbDataAdapter = new SqlDataAdapter(query, this.GetConnection());
                //open the connection:
                this.OpenNwConnection();//open connection.
                //fill the data into the data set
                bbDataAdapter.Fill(bbDataSet);
                return bbDataSet;

            }//try
            catch (Exception ex)
            {
                throw ex.InnerException;
            }//try //catch
            finally
            {
                //close the connection
                this.CloseNwConnection();
            }//try //catch //finally
        }//viewalldonorsdata
    }//bbdataaccess class
}//namespace


        

    

