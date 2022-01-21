using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sistem_Administrasi.Controller
{
    class ProsesAntreanController
    {
        // view
        View.ProsesAntreanPage view;
        
        // model
        Model.ProsesAntreanModel model;

        // datarow utk menampung data user yg dipilih pd datagridview
        public DataRowView dataRow;

        public ProsesAntreanController(View.ProsesAntreanPage view)
        {
            this.view = view;
            model = new Model.ProsesAntreanModel();
        }

        public void SetData()
        {
            dataRow = AntreanController.dataRowView;

            // set textbox
            view.txtNama.Text = dataRow["nama_pasien"].ToString();
            view.txtNomor.Text = dataRow["tlp_pasien"].ToString();
            view.txtAlamat.Text = dataRow["alamat_pasien"].ToString();
            view.txtKeluhan.Text = dataRow["keluhan"].ToString();

            // set tgl lahir
            DateTime oDate = Convert.ToDateTime(dataRow["tl_pasien"].ToString());
            string iDate = oDate.Day + "/" + oDate.Month + "/" + oDate.Year;
            view.dtpTanggalLahir.SelectedDate = oDate;

            // set combobox spesialis
            SetItemSpesialis();
            
            // set combobox dokter
            SetItemDokter();
        }

        public void SetItemSpesialis()
        {
            // utk menyimpan semua spesialis
            DataSet ds = model.GetAllSpesialis();

            if (ds != null)
            {
                // items source spesialis
                view.cmbSpesialis.ItemsSource = ds.Tables[0].DefaultView;
                view.cmbSpesialis.DisplayMemberPath = "spesialis";

                // set selected index di view (-1 karena combobox dimulai dari 0)
                view.cmbSpesialis.SelectedIndex = (int)dataRow["id_spesialis"] - 1;
            }
        }

        public void SetItemDokter()
        {
            // ambil index dari spesialis yang dipilih set ke model
            model.Id_spesialis = view.cmbSpesialis.SelectedIndex + 1;

            // utk menyimpan semua dokter
            DataSet ds = model.GetAllDokter();

            if (ds != null)
            {
                // items source combobox dokter
                view.cmbDokter.ItemsSource = ds.Tables[0].DefaultView;
                view.cmbDokter.DisplayMemberPath = "nama_dokter";

                // kalau combobox spesialis yang diselect sesuai sama yg user pilih saat daftar,
                // maka tampilkan dokter sesuai yang dipilih user saat daftar
                if(view.cmbSpesialis.SelectedIndex == (int)dataRow["id_spesialis"] - 1)
                {
                    int i = 0;
                    foreach (var item in view.cmbDokter.Items)
                    {
                        string x = ((DataRowView)item)["nama_dokter"].ToString();
                        if (x == dataRow["nama_dokter"].ToString())
                        {
                            view.cmbDokter.SelectedIndex = i;
                        }
                        i++;
                    }
                }
                // jika spesialis berbeda maka select dokter index pertama
                else
                {
                    view.cmbDokter.SelectedIndex = 0;
                }
            }
        }

        public void Update()
        {
            // id antrean
            model.Id_antrean = (int)dataRow["id_antrean"];

            // nama pasien
            model.Nama_pasien = view.txtNama.Text;

            // Tanggal lahir 
            DateTime oDate = Convert.ToDateTime(view.dtpTanggalLahir.SelectedDate);
            string iDate = oDate.Year + "/" + oDate.Month + "/" + oDate.Day;
            model.Tanggal = iDate;

            // nomor telp
            model.Nomor = view.txtNomor.Text;

            // alamat
            model.Alamat = view.txtAlamat.Text;

            // id spesialis tidak perlu diset, karena sudah terset pada fungsi getAllDokter
            // model.id_spesialis = view.cmbSpesialis.SelectedIndex + 1;

            // nama dokter
            model.Nama_dokter = view.cmbDokter.Text;

            // keluhan
            model.Keluhan = view.txtKeluhan.Text;

            if (model.Update() == true)
            {
                MessageBox.Show("Berhasil Verifikasi");

                View.MainWindow mainWindow = (View.MainWindow)Window.GetWindow(view);
                mainWindow.Main.Content = new View.AntreanPage();
            }
            else
            {
                MessageBox.Show("Gagal Verifikasi");
            }
        }

        public void Hapus()
        {
            // id antrean
            model.Id_antrean = (int)dataRow["id_antrean"];

            if(model.delete())
            {
                MessageBox.Show("Berhasil Menghapus data.");

                View.MainWindow mainWindow = (View.MainWindow)Window.GetWindow(view);
                mainWindow.Main.Content = new View.AntreanPage();
            }
        }
    }
}