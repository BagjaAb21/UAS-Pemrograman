using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Sistem_Administrasi.Controller
{
    class ProfileController
    {
        // deklarasi view
        View.ProfileWindow view;

        // deklarasi model
        Model.ProfileModel model;

        public ProfileController(View.ProfileWindow view)
        {
            this.view = view;
            model = new Model.ProfileModel();
        }

        public void SetData()
        {
            model.id = Model.LoginModel.id;

            DataSet ds = new DataSet();
            ds = model.select();

            if(ds != null)
            {
                view.txtNama.Text = ds.Tables[0].Rows[0][0].ToString();
                view.txtAlamat.Text = ds.Tables[0].Rows[0][1].ToString();
                view.txtNomor.Text = ds.Tables[0].Rows[0][2].ToString();
                view.txtEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                view.txtUsername.Text = ds.Tables[0].Rows[0][4].ToString();
                view.txtPassword.Password = ds.Tables[0].Rows[0][5].ToString();

                string path = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + 
                                                            "\\Sistem Administrasi\\Images\\" + view.txtUsername.Text + ".jpg";
                if (System.IO.File.Exists(path))
                {
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(path);
                    bitmap.EndInit();
                    view.ImageProfile.Source = bitmap;
                }
                else
                {
                    string foto = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                    "\\Foto\\Profile.png";
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(foto);
                    bitmap.EndInit();
                    view.ImageProfile.Source = bitmap;
                }
            }
        }

        public void Update()
        {
            model.nama = view.txtNama.Text;
            model.alamat = view.txtAlamat.Text;
            model.telp = view.txtNomor.Text;
            model.email = view.txtEmail.Text;
            model.username = view.txtUsername.Text;
            model.password = view.txtPassword.Password;
            model.foto = view.txtUsername.Text + ".jpg";

            if(model.update())
            {
                MessageBox.Show("Berhasil Ubah Profile.");
            }
            else
            {
                MessageBox.Show("Gagal Ubah Profile.");
            }

            Close();
        }

        public void Close()
        {
            View.MainWindow main = new View.MainWindow();
            main.Show();
            view.Close();
        }
    }
}