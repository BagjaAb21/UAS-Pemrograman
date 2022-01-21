using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;

namespace Sistem_Pendaftaran.Controller
{
    class PendaftaranPasienLamaController
    {
        View.PendaftaranPasienLamaPage view;
        Model.PendaftaranModel model;

        public static DataSet ds = null;

        public PendaftaranPasienLamaController(View.PendaftaranPasienLamaPage view)
        {
            this.view = view;
            model = new Model.PendaftaranModel();
        }

        public void Cari()
        {
            model.nama_pasien = view.txtNama.Text;
            ds = model.Cari();

            if(ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Data ditemukan.");
                View.MainWindow mainWindow = (View.MainWindow)Window.GetWindow(view);
                mainWindow.Main.Content = new View.PendaftaranPage();
            }
            else
            {
                ds = null; 
                MessageBox.Show("Data tidak ditemukan");
                view.txtNama.Focus();
            }
        }
    }
}
