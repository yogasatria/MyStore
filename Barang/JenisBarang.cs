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
        private int kodeJenis;
        private string keteranganJenis;
        SqlConnection conn = new SqlConnection();

        public int KodeJenis 
        {
            get 
            {
                return kodeJenis;
            }
            set 
            {
                kodeJenis = value;
            }
        }

        public string KeteranganJenis
        {
            get
            {
                return keteranganJenis;
            }
            set
            {
                keteranganJenis = value;
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

        public Boolean DoSave(JenisBarang jenisBarang)
        {
            try
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO JenisBarang VALUES (" + jenisBarang.kodeJenis + ",'" + jenisBarang.KeteranganJenis + "')",conn);
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

        public int DoCheckExist(JenisBarang jenisBarang)
        {
            int RecordCount = 0;
            try
            {
                SqlCommand SQLCommand = new SqlCommand("SELECT * FROM JenisBarang WHERE KodeJenis = " + jenisBarang.kodeJenis, conn);
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
