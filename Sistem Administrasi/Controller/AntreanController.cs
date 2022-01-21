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
    class AntreanController
    {
        View.AntreanPage view;
        Model.AntreanModel model;

        public static DataRowView dataRowView = null;

        public AntreanController(View.AntreanPage view)
        {
            this.view = view;
            model = new Model.AntreanModel();
        }

        public void SetDataGrid()
        {
            model.cari = view.txtCari.Text;
            DataSet ds = model.GetAntrean();

            if (ds != null)
                view.antreanGrid.DataContext = ds.Tables["pasien"].DefaultView;
        }

        public void ProsesAntrean(RoutedEventArgs e)
        {
            try
            {
                dataRowView = (DataRowView)((Button)e.Source).DataContext;

                View.MainWindow mainWindow = (View.MainWindow)Window.GetWindow(view);
                mainWindow.Main.Content = new View.ProsesAntreanPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}