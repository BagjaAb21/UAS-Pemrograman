using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace Sistem_Administrasi.Controller
{
    class RiwayatDetailController
    {
        View.RiwayatDetail view;
        Model.RiwayatDetailModel model;
        DataRowView drv;

        public RiwayatDetailController(View.RiwayatDetail view)
        {
            this.view = view;
            model = new Model.RiwayatDetailModel();
            drv = RiwayatController.drv;

            SetDataGrid();
        }

        public void SetDataGrid()
        {
            // set label
            view.lblNama.Content = drv["nama_pasien"].ToString();
            view.lblAlamat.Content = drv["alamat_pasien"].ToString();
            view.lblNomor.Content = drv["tlp_pasien"].ToString();
            view.lblJumlahBerobat.Content = drv["jumlah_berobat"].ToString();
            DateTime oDate = Convert.ToDateTime(drv["tl_pasien"].ToString());
            string iDate = oDate.Day + "/" + oDate.Month + "/" + oDate.Year;
            view.lblTanggalLahir.Content = iDate;

            // set datagrid
            model.id_pasien = (int)drv["id_pasien"];
            DataSet ds = model.getDetail();

            view.dataGrid.ItemsSource = ds.Tables[0].DefaultView;
        }

        public void kembali()
        {
            View.MainWindow mainWindow = (View.MainWindow)Window.GetWindow(view);
            mainWindow.Main.Content = new View.RiwayatPage();
        }
    }
}