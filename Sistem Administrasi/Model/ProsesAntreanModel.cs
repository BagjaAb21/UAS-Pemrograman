using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistem_Administrasi.Model
{

    public class ProsesAntreanModel
    {
        private ModelTemplate model = new ModelTemplate();

        public int Id_antrean { get; set; }
        public string Nama_pasien { get; set; }
        public string Tanggal { get; set; }
        public string Nomor { get; set; }
        public int Id_spesialis { get; set; }
        public string Nama_dokter { get; set; }
        public string Alamat { get; set; }
        public string Keluhan { get; set; }

        public DataSet GetAllSpesialis()
        {
            DataSet ds = model.CustomSelect("spesialis", "SELECT * " +
                                                         "FROM spesialis " +
                                                         "ORDER BY id_spesialis");

            return ds;
        }

        public DataSet GetAllDokter()
        {
            DataSet ds = model.Select("dokter", "id_spesialis = '" + Id_spesialis + "'");

            return ds;
        }

        public bool Update()
        {
            bool[] result = { false, false, false, false };

            // update data pasien
            result[0] = model.CustomUpdate("pasien", "UPDATE pasien " +
                                                     "SET nama_pasien = '" + Nama_pasien + "', " +
                                                         "tl_pasien = '" + Tanggal + "', " +
                                                         "tlp_pasien = '" + Nomor + "', " +
                                                         "alamat_pasien = '" + Alamat + "' " +
                                                     "FROM antrean " +
                                                     "INNER JOIN pasien " +
                                                        "ON antrean.id_pasien = pasien.id_pasien " +
                                                     "WHERE antrean.id_antrean = " + Id_antrean);

            // update status antrean
            result[1] = model.CustomUpdate("antrean", "UPDATE antrean " +
                                                      "SET status_antrean = 1 " +
                                                      "FROM antrean " +
                                                      "WHERE id_antrean = " + Id_antrean);

            // update id dokter
            result[2] = model.CustomUpdate("antrean", "UPDATE antrean " +
                                                      "SET id_dokter = (" +
                                                                        "SELECT id_dokter " +
                                                                        "FROM dokter " +
                                                                        "WHERE nama_dokter = '" + Nama_dokter + "'" +
                                                                       ") " +
                                                      "FROM antrean " +
                                                      "WHERE id_antrean = " + Id_antrean);

            // update keluhan
            result[3] = model.CustomUpdate("antrean", "UPDATE keluhan " +
                                                      "SET keluhan = '" + Keluhan + "' " +
                                                      "FROM antrean a " +
                                                      "INNER JOIN keluhan k " +
                                                        "ON a.id_keluhan = k.id_keluhan " +
                                                      "WHERE id_antrean = '" + Id_antrean + "'");

            // return
            return result[0] &&
                   result[1] &&
                   result[2] &&
                   result[3];
        }

        public bool delete()
        {
            return model.Delete("antrean", "id_antrean = '" + Id_antrean + "'");
        }
    }
}