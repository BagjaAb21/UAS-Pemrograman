using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Media.Imaging;

namespace Sistem_Administrasi.Controller
{
    class MainWindowController
    {
        Model.MainWindowModel model;
        View.MainWindow view;

        public MainWindowController(View.MainWindow view)
        {
            this.view = view;
            model = new Model.MainWindowModel();

            // set id pada model
            model.id = Model.LoginModel.id;
        }

        public void setProfile()
        {
            DataSet ds = new DataSet();
            ds = model.getUserInfo();

            if (ds != null)
            {
                view.lblProfile.Content = ds.Tables[0].Rows[0][0].ToString();

                string path = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Sistem Administrasi\\Images\\" + ds.Tables[0].Rows[0][1].ToString();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(path);
                bitmap.EndInit();
                view.ImageProfile.Source = bitmap;
            }
            else
            {
                MessageBox.Show("Koneksi ke database gagal.");
            }
        }
    }
}
