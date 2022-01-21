using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistem_Pendaftaran.Model
{
    class JadwalDokterModel
    {
        ModelTemplate model = new ModelTemplate();
        public string cari = "";

        public DataSet GetJadwalDokter()
        {
            DataSet ds = model.CustomSelect("jadwal_dokter", "SELECT nama_dokter, " +
                                                                    "email_dokter, " +
                                                                    "hari, " +
                                                                    "shift, " +
                                                                    "spesialis " +
                                                             "FROM jadwal_dokter " +
                                                             "INNER JOIN dokter " +
                                                                "ON jadwal_dokter.id_dokter = dokter.id_dokter " +
                                                             "INNER JOIN spesialis " +
                                                                "ON dokter.id_spesialis = spesialis.id_spesialis " +
                                                             "WHERE nama_dokter LIKE '%" + cari + "%' OR " +
                                                                   "email_dokter LIKE '%" + cari + "%' OR " +
                                                                   "hari LIKE '%" + cari + "%' OR " +
                                                                   "shift LIKE '%" + cari + "%' OR " +
                                                                   "spesialis LIKE '%" + cari + "%' " +
                                                             "ORDER BY spesialis");

            return ds;
        }
    }
}
