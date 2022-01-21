using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistem_Pendaftaran.Controller
{
    class JadwalDokterController
    {
        View.JadwalDokterPage view;
        Model.JadwalDokterModel model;

        public JadwalDokterController(View.JadwalDokterPage view)
        {
            this.view = view;
            model = new Model.JadwalDokterModel();

            SetData();
        }

        public void SetData()
        {
            model.cari = view.txtCari.Text;

            DataSet ds = model.GetJadwalDokter();
            view.dataGrid.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}