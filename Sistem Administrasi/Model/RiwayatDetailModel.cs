using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistem_Administrasi.Model
{
    class RiwayatDetailModel
    {
        ModelTemplate model = new ModelTemplate();
        public int id_pasien;

        public DataSet getDetail()
        {
            DataSet ds = model.CustomSelect("antrean", "SELECT k.keluhan, " +
                                                              "s.spesialis, " +
                                                              "d.nama_dokter, " +
                                                              "a.tanggal " +
                                                       "FROM antrean a " +
                                                       "INNER JOIN dokter d " +
                                                            "ON a.id_dokter = d.id_dokter " +
                                                       "INNER JOIN spesialis s " +
                                                            "ON d.id_spesialis = s.id_spesialis " +
                                                       "INNER JOIN keluhan k " +
                                                            "ON a.id_keluhan = k.id_keluhan " +
                                                       "WHERE a.id_pasien = " + id_pasien + " " +
                                                       "ORDER BY tanggal DESC");

            return ds;
        }
    }
}
