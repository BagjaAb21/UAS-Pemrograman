using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace Sistem_Administrasi.Model
{
    class AntreanModel
    {
        ModelTemplate model;
        public string cari;

        public AntreanModel()
        {
            model = new ModelTemplate();
        }

        public DataSet GetAntrean()
        {
            String tanggalHariIni = DateTime.Now.ToString("yyyy-MM-dd");

            DataSet ds = new DataSet();
            ds = model.CustomSelect("pasien", "SELECT id_antrean, " +
                                                     "nomor_antrean, " +
                                                     "nama_pasien, " +
                                                     "tl_pasien, " +
                                                     "tlp_pasien, " +
                                                     "alamat_pasien, " +
                                                     "d.id_spesialis, " +
                                                     "spesialis, " +
                                                     "nama_dokter, " +
                                                     "keluhan " +
                                              "FROM antrean a " +
                                              "INNER JOIN pasien p " +
                                                "ON a.id_pasien = p.id_pasien	" +
                                              "INNER JOIN dokter d " +
                                                "ON a.id_dokter = d.id_dokter	" +
                                              "INNER JOIN spesialis s " +
                                                "ON d.id_spesialis = s.id_spesialis " +
                                              "INNER JOIN keluhan k	" +
                                                "ON a.id_keluhan = k.id_keluhan " +
                                              "WHERE tanggal = '" + tanggalHariIni + "' AND " +
                                                    "status_antrean = '0' AND (" +
                                                    "nomor_antrean LIKE '%" + cari + "%' OR " +
                                                    "nama_pasien LIKE '%" + cari + "%' OR " +
                                                    "tl_pasien LIKE '%" + cari + "%' OR " +
                                                    "tlp_pasien LIKE '%" + cari + "%' OR " +
                                                    "alamat_pasien LIKE '%" + cari + "%' OR " +
                                                    "spesialis LIKE '%" + cari + "%' OR " +
                                                    "nama_dokter LIKE '%" + cari + "%' OR " +
                                                    "keluhan LIKE '%" + cari + "%')");

            return ds;
        }
    }
}