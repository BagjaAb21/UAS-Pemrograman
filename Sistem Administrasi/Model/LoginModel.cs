using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;

namespace Sistem_Administrasi.Model
{
    class LoginModel
    {
        public static int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        ModelTemplate model;

        public LoginModel()
        {
            model = new ModelTemplate();
        }

        public bool LoginCheck()
        {
            bool result = false;
            DataSet ds = new DataSet();
            ds = model.CustomSelect("users", "SELECT users.id_user, pegawai.nama_pgw FROM users INNER JOIN pegawai ON users.id_pgw = pegawai.id_pgw WHERE username = '" + username + "' AND password = '" + password + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {
                // id
                string id = ds.Tables[0].Rows[0][0].ToString();
                LoginModel.id = Convert.ToInt32(id);

                result = true;
            }

            return result;
        }
    }
}