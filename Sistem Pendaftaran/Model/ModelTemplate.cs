using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Data;

namespace Sistem_Pendaftaran.Model
{
    class ModelTemplate
    {
        private static SqlConnection conn;
        private SqlCommand command;
        bool result;

        public ModelTemplate() 
        {
            GetConnection();
        }

        public static SqlConnection GetConnection() 
        {
            string ConnectionString = "Data Source = DESKTOP-5UCA0QN;" +
                                      "Initial Catalog = mengsehat;" +
                                      "Integrated Security = True";
            conn = new SqlConnection(ConnectionString);

            return conn;
        }

        public void cekKoneksi()
        {
            try
            {
                conn.Open();
                MessageBox.Show("berhasil");
            }
            catch (SqlException se)
            {
                MessageBox.Show("gagal " + se);
            }
        }

        public DataSet Select(string tabel, string kondisi)
        {
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                if (kondisi == null)
                {
                    command.CommandText = "SELECT * FROM " + tabel;
                }
                else
                {
                    command.CommandText = "SELECT * FROM " + tabel + " WHERE " + kondisi;
                }
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, tabel);
            }
            catch (SqlException)
            {
                ds = null;
            }
            conn.Close();
            return ds;
        }

        public Boolean Insert(string tabel, string data)
        {
            result = false;
            try
            {
                string query = data;
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            conn.Close();
            return result;
        }

        public Boolean Update(string tabel, string data, string kondisi)
        {
            result = false;
            try
            {
                string query = "UPDATE " + tabel + " SET " + data + " WHERE " + kondisi;
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                result = false;
            }
            conn.Close();
            return result;
        }

        public Boolean Delete(string tabel, string kondisi)
        {
            result = false;
            try
            {
                string query = "DELETE FROM " + tabel + " WHERE " + kondisi;
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            conn.Close();
            return result;
        }

        public DataSet CustomSelect(string tabel, string query)
        {
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;

                command.CommandText = query;

                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, tabel);
            }
            catch (SqlException)
            {
                ds = null;
            }
            conn.Close();

            return ds;
        }

        public Boolean CustomUpdate(string tabel, string query)
        {
            result = false;
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                result = false;
            }
            conn.Close();

            return result;
        }
    }
}