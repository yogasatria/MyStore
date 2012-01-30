using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Barang
{
    public class JenisBarang
    {
        private int kodeJns;
        private string keteranganJns;
        SqlConnection conn = new SqlConnection();

        public int KodeJenis 
        {
            get 
            {
                return kodeJns;
            }
            set 
            {
                kodeJns = value;
            }
        }

        public string KeteranganJenis
        {
            get
            {
                return keteranganJns;
            }
            set
            {
                keteranganJns = value;
            }
        }

        public void OpenConnection()
        {
            conn.ConnectionString = "integrated security=SSPI;data source=MTPC485;persist security info=False;initial catalog=MyStoreDB";
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public Boolean DoSave(JenisBarang jnsBarang)
        {
            try
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO JenisBarang VALUES (" + jnsBarang.kodeJns + ",'" + jnsBarang.KeteranganJenis + "')",conn);
                OpenConnection();
                insertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return true;
         
        }

        public int DoCheckExist(JenisBarang jnsBarang)
        {
            int RecordCount = 0;
            try
            {
                SqlCommand SQLCommand = new SqlCommand("SELECT * FROM JenisBarang WHERE KodeJenis = " + jnsBarang.kodeJns, conn);
                OpenConnection();
                RecordCount = (int)SQLCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return RecordCount;
        }
    }
}
