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
        private SqlConnection bbDataConnection;
        //declare the conn string
        private string bbConnString = ConfigurationManager.ConnectionStrings["Project5Final.Properties.Settings.BBConnString"].ConnectionString;
        //set up the connection
        public SqlConnection GetConnection()
        {
            if (bbDataConnection == null)
                bbDataConnection = new SqlConnection(bbConnString);
            return bbDataConnection;
        }//end GetConnection()

        //open connection
        public void OpenNWConnection()
        {
            if (bbDataConnection.State == ConnectionState.Closed) bbDataConnection.Open();
        }//end openConnection

        public void CloseNWConnection()
        {
            bbDataConnection.Close();
        }//end closeNWConnection()

        public DataSet ViewAllDonorsSelectQueryData(string query)
        {
            DataSet bbDataSet = new DataSet();
            try
            {
                //instantiate data adapter:
                DataAdapter bbDataAdapter = new SqlDataAdapter(query, this.GetConnection());
                //open the connection:
                this.OpenNWConnection();//open connection.
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
                this.CloseNWConnection();
            }//try //catch //finally
        }//viewalldonorsdata


        public DataSet GetBloodGroupStocksSelectQueryData(string query)
        {
            DataSet stockDataSet = new DataSet();
            try
            {
                //instantiate data adapter
                DataAdapter stockDataAdapter = new SqlDataAdapter(query, this.GetConnection());
                //open the connection
                this.OpenNWConnection();

                //fill the data into the data set
                stockDataAdapter.Fill(stockDataSet);
                return stockDataSet;
            }//end of try
            catch (Exception ex)
            {
                throw ex.InnerException;
            }//end of catch
            finally
            {
                this.CloseNWConnection();
            }//end of finally

        }

        public int GetStockQuantitySelectQueryData(string query,CommandType cmdType)
        {
            SqlCommand getQuantityCommand = new SqlCommand(query, this.GetConnection());
            getQuantityCommand.CommandType = cmdType;
            int quantity = 0;
            try
            {
                //open the connection
                this.OpenNWConnection();
                Object result = getQuantityCommand.ExecuteScalar();

                if(result != null)
                {
                    quantity = Convert.ToInt32(result);
                }

                return quantity;

            }//end of try
            catch (Exception ex)
            {
                throw ex.InnerException;
            }//end of catch
            finally
            {
                this.CloseNWConnection();
            }//end of finally
        }


        public int UpdateStockQuantitySelectQueryData(string query, CommandType cmdType) 
        { 
            SqlCommand updateQuantityCommand = new SqlCommand( query, this.GetConnection());
            updateQuantityCommand.CommandType = cmdType;
            try
            {
                //open the connection
                this.OpenNWConnection();
                int result = updateQuantityCommand.ExecuteNonQuery();
                return result;

            }//end of try
            catch (Exception ex)
            {
                throw ex.InnerException;
            }//end of catch
            finally
            {
                this.CloseNWConnection();
            }

        }
    }//bbdataaccess class
}//namespace


        

    

