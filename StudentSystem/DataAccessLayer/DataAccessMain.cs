using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAccessMain
    {
        //Getting the DB connection
        public SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=CHAMARA-PC;Initial Catalog=TestDB-Chamara;Integrated Security=True";

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return conn;
        }

        
        public bool ExecuteSqlCommand(SqlCommand comm)
        {
            bool blnResult = false;
            int intResult = 0;

            try
            {
                comm.Connection = GetDBConnection();
                comm.CommandType = CommandType.StoredProcedure;

                intResult = comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            return blnResult;
        }

        //Returning a datatable
        public DataTable GetDataTable(SqlCommand comm)
        {
            DataTable dtDataTable = new DataTable();
            SqlDataReader rdr = null;

            try
            {
                comm.Connection = GetDBConnection();
                comm.CommandType = CommandType.StoredProcedure;
                rdr = comm.ExecuteReader();
                dtDataTable.Load(rdr);
            }
            catch (Exception)
            {
                throw;
            }

            return dtDataTable;
        }

        public int GetScalerValue(SqlCommand comm)
        {
            int intCode = 0;
            //  int? intCode = null;
            try
            {
                comm.Connection = GetDBConnection();
                comm.CommandType = CommandType.StoredProcedure;

                if (!Convert.IsDBNull(comm.ExecuteScalar()))
                {
                    intCode = (int)comm.ExecuteScalar();
                }

            }
            catch (Exception)
            {

                throw;
            }

            return intCode;

        }

    }
}
