using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistem_Administrasi.Model
{
    class RiwayatModel
    {
        ModelTemplate model = new Model.ModelTemplate();
		public string cari = "";

        public DataSet Select()
        {
            DataSet ds = null;
            ds = model.CustomSelect("antrean", "SELECT a.id_pasien, " +
													  "nama_pasien, " +
													  "alamat_pasien, " +
													  "tl_pasien, " +
													  "tlp_pasien, " +
													  "c.jumlah_berobat, " +
													  "c.terakhir_berobat " +
											    "FROM" +
													"(" +
													    "SELECT a.id_pasien, " +
													    		"COUNT(a.id_pasien) AS jumlah_berobat, " +
													    		"MAX(a.tanggal) AS terakhir_berobat " +
													    "FROM antrean a " +
													    "INNER JOIN pasien p " +
													    	"ON a.id_pasien = p.id_pasien " +
													    "GROUP BY a.id_pasien " +
													 ") c " +
												"INNER JOIN antrean a " +
													"ON c.id_pasien = a.id_pasien AND " +
													   "c.terakhir_berobat = a.tanggal " +
												"INNER JOIN pasien p " +
													"ON a.id_pasien = p.id_pasien " +
												"WHERE a.status_antrean = '1' AND ( " +
													  "nama_pasien LIKE '%" + cari + "%' OR " +
													  "alamat_pasien LIKE '%" + cari + "%' OR " +
													  "tl_pasien LIKE '%" + cari + "%' OR " +
													  "tlp_pasien LIKE '%" + cari + "%' OR " +
													  "c.jumlah_berobat LIKE '%" + cari + "%' OR " +
													  "c.terakhir_berobat LIKE '%" + cari + "%' )");

            return ds;
        }
    }
}