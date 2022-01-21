using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Sistem_Administrasi.Controller
{
    class RiwayatController
    {
        View.RiwayatPage view;
        Model.RiwayatModel model;

        public static DataRowView drv; 

        public RiwayatController(View.RiwayatPage view)
        {
            this.view = view;
            model = new Model.RiwayatModel();
        }

        public void SetDataGrid()
        {
            model.cari = view.txtCari.Text;

            DataSet ds = model.Select();
            if (ds != null)
            {
                view.dataGrid.ItemsSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("dataset null");
            }
        }

        public void RiwayatDetail(RoutedEventArgs e)
        {
            try
            {
                drv = (DataRowView)((Button)e.Source).DataContext;

                View.MainWindow mainWindow = (View.MainWindow)Window.GetWindow(view);
                mainWindow.Main.Content = new View.RiwayatDetail();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
