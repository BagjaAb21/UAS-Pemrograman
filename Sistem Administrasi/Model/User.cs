using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Administrasi.Model
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string nama_pegawai { get; set; }

        public User(int id, string username, string password, string nama)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.nama_pegawai = nama;
        }
    }
}
