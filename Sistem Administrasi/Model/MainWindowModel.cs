using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace Sistem_Administrasi.Model
{
    class MainWindowModel
    {
        public int id { get; set; }
        Model.ModelTemplate model;
        
        public MainWindowModel()
        {
            model = new Model.ModelTemplate();
        }

        public DataSet getUserInfo()
        {
            DataSet ds = new DataSet();
            ds = model.CustomSelect("users", "SELECT nama_pgw, " +
                                                    "foto " +
                                             "FROM users " +
                                             "INNER JOIN pegawai " +
                                                "ON users.id_pgw = pegawai.id_pgw " +
                                             "WHERE id_user = '" + id + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds;
            }

            return null;
        }
    }
}