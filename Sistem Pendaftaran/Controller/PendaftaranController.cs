using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace Sistem_Pendaftaran.Controller
{
    class PendaftaranController
    {
        Model.PendaftaranModel model;
        View.PendaftaranPage view;
        private DataSet pasienLama;

        public PendaftaranController(View.PendaftaranPage view)
        {
            this.view = view;
            model = new Model.PendaftaranModel();

            if (PendaftaranPasienLamaController.ds == null)
            {
                SetData();
            }
            else
            {
                SetDataPasienLama();
            }
        }
        
        public void SetData()
        {
            SetItemSpesialis();
            SetItemDokter();
            view.rdbLaki.IsChecked = true;
        }

        public void SetDataPasienLama()
        {
            SetData();
            pasienLama = PendaftaranPasienLamaController.ds;

            // set nama
            view.txtNama.Text = pasienLama.Tables[0].Rows[0][1].ToString();
            
            // set jenis kel
            if(pasienLama.Tables[0].Rows[0][2].ToString() == "P")
            {
                view.rdbPerempuan.IsChecked = true;
            }
            
            // set tgl lahir 
            DateTime oDate = Convert.ToDateTime(pasienLama.Tables[0].Rows[0][3].ToString());
            string iDate = oDate.Day + "/" + oDate.Month + "/" + oDate.Year;
            view.dtpTanggalLahir.SelectedDate = oDate;

            // set nomor telp
            view.txtNomor.Text = pasienLama.Tables[0].Rows[0][4].ToString();

            // set alamat
            view.txtAlamat.Text = pasienLama.Tables[0].Rows[0][5].ToString();
        }

        public void SetItemSpesialis()
        {
            DataSet ds = model.GetSpesialis();

            view.cmbSpesialis.ItemsSource = ds.Tables[0].DefaultView;
            view.cmbSpesialis.DisplayMemberPath = "spesialis";
            view.cmbSpesialis.SelectedIndex = 0;
        }

        public void SetItemDokter()
        {
            if (view.cmbDokter.SelectedIndex != -1)
                model.id_spesialis = view.cmbSpesialis.SelectedIndex + 1;
            else
                model.id_spesialis = 1;

            DataSet ds = model.GetDokter();

            view.cmbDokter.ItemsSource = ds.Tables[0].DefaultView;
            view.cmbDokter.DisplayMemberPath = "nama_dokter";
            view.cmbDokter.SelectedIndex = 0;
        }

        public void Insert()
        {
            // set model
            model.nama_pasien = view.txtNama.Text;
            DateTime oDate = (DateTime)view.dtpTanggalLahir.SelectedDate;
            string iDate = oDate.Year + "/" + oDate.Month + "/" + oDate.Day;
            model.tanggal_lahir = iDate;
            model.nomor = view.txtNomor.Text;
            model.alamat_pasien = view.txtAlamat.Text;
            if (view.rdbLaki.IsChecked == true)
            {
                model.jenis_kelamin = 'L';
            }
            else
            {
                model.jenis_kelamin = 'P';
            }
            model.id_spesialis = view.cmbSpesialis.SelectedIndex + 1;
            model.nama_dokter = view.cmbDokter.Text;
            
            model.keluhan = view.txtKeluhan.Text;

            // Insert
            if(model.Insert())
            {
                MessageBox.Show("Pendaftaran Berhasil.");
                PendaftaranPasienLamaController.ds = null;

                View.MainWindow mainWindow = (View.MainWindow)Window.GetWindow(view);
                mainWindow.Main.Content = new View.PendaftaranPage();
            }
            else
            {
                MessageBox.Show("Pendaftaran Gagal.");
            }
        }
    }
}