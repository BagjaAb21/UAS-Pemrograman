using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistem_Administrasi.Model
{
    class ProfileModel
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string telp { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string foto { get; set; }

        Model.ModelTemplate model;

        public ProfileModel()
        {
            model = new Model.ModelTemplate(); ;
        }

        public DataSet select()
        {
            DataSet ds = new DataSet();
            ds = model.CustomSelect("users", "SELECT pegawai.nama_pgw, pegawai.alamat_pgw, pegawai.tlp_pgw, pegawai.email_pgw, users.username, users.password FROM users INNER JOIN pegawai ON users.id_pgw = pegawai.id_pgw WHERE id_user = '" + id + "'");

            if (ds != null)
            {
                return ds;
            }
            return null;
        }

        public bool update()
        {
            bool result1 = false, result2 = false;
            
            // tabel users
            result1 = model.Update("users",
                                   "users.username = '" + username + "', users.password = '" + password + "' ",
                                   "users.id_user = " + id);

            // tabel pegawai
            result2 = model.Update("pegawai", 
                                   "pegawai.nama_pgw = '" + nama + "', " +
                                   "pegawai.alamat_pgw ='" + alamat + "', " +
                                   "pegawai.tlp_pgw = '" + telp + "', " +
                                   "pegawai.email_pgw = '" + email + "' " + 
                                   "FROM pegawai " +
                                   "INNER JOIN users " +
                                        "ON pegawai.id_pgw = users.id_pgw"
                                   ,
                                   "users.id_user = " + id);
            
            return result1 && result2;
        }
    }
}