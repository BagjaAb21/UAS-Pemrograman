using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace Sistem_Pendaftaran.Model
{
    class PendaftaranModel
    {
        ModelTemplate model;

        public int id_pasien;
        public string nama_pasien;
        public string tanggal_lahir;
        public char jenis_kelamin;
        public string nomor;
        public string alamat_pasien;
        
        public int id_spesialis;
        public int id_dokter;
        public string nama_dokter;
        
        public int id_keluhan;
        public string keluhan;
        
        public string tanggalHariIni = DateTime.Now.ToString("yyyy-MM-dd");
        public int nomor_antrean = 1;
        public char status_antrean = '0';

        public PendaftaranModel()
        {
            model = new ModelTemplate();
        }

        public DataSet GetSpesialis()
        {
            DataSet ds = model.CustomSelect("spesialis", "SELECT * " +
                                                         "FROM spesialis " +
                                                         "ORDER BY id_spesialis");

            return ds;
        }

        public DataSet GetDokter()
        {
            DataSet ds = model.Select("dokter", "id_spesialis = '" + id_spesialis + "'");

            return ds;
        }

        public bool Insert()
        {
            bool insertPasien = false, insertKeluhan = false, insertAntrean = false;
            DataSet ds;

            // get nomor antrean terakhir hari ini
            ds = model.CustomSelect("antrean", "SELECT MAX(nomor_antrean) AS nomor_terbesar " +
                                          "FROM antrean " +
                                          "WHERE tanggal = '" + tanggalHariIni + "'");

            if(ds.Tables[0].Rows[0][0].ToString() != "")
            {
                nomor_antrean = Int32.Parse(ds.Tables[0].Rows[0][0].ToString()) + 1;
            }

            // insert pasien
            insertPasien = model.Insert("pasien", "INSERT INTO pasien " +
                                                  "VALUES ('" + nama_pasien + "', '" + jenis_kelamin + "', '" + tanggal_lahir + "', '" + nomor +"', '" + alamat_pasien +"');");
            
            // insert keluhan
            insertKeluhan = model.Insert("keluhan", "INSERT INTO keluhan " +
                                                    "VALUES('" + keluhan + "')");

            // insert antrean

            // get id pasien 
            ds = model.CustomSelect("pasien", "SELECT id_pasien " +
                                                      "FROM pasien " +
                                                      "WHERE nama_pasien = '" + nama_pasien + "' " +
                                                      "AND tlp_pasien = '" + nomor + "'");
            id_pasien = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            
            // get id dokter
            ds = model.CustomSelect("dokter", "SELECT id_dokter " +
                                              "FROM dokter " +
                                              "WHERE nama_dokter = '" + nama_dokter + "'");
            id_dokter = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            
            // get id keluhan
            ds = model.CustomSelect("keluhan", "SELECT id_keluhan " +
                                               "FROM keluhan " +
                                               "WHERE keluhan = '" + keluhan + "'");
            id_keluhan = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            
            // insert antrean
            insertAntrean = model.Insert("antrean", "INSERT INTO antrean " +
                                                    "VALUES (" + nomor_antrean + ", 0, '" + tanggalHariIni + "', " + id_pasien + ", " + id_dokter + ", " + id_keluhan + ")");


            return insertPasien && insertKeluhan && insertAntrean;
        }

        public DataSet Cari()
        {
            DataSet ds = model.Select("pasien", "nama_pasien = '" + nama_pasien + "'");
            return ds;
        }
    }
}