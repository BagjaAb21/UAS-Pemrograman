using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sistem_Administrasi.View
{
    /// <summary>
    /// Interaction logic for ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        Controller.ProfileController controller;

        // deklarasi openFileDialog
        Microsoft.Win32.OpenFileDialog openFileDialog;
        bool ubahFoto = false;

        public ProfileWindow()
        {
            InitializeComponent();
            controller = new Controller.ProfileController(this);
            openFileDialog = new Microsoft.Win32.OpenFileDialog();

            controller.SetData();
        }

        private void btnBatal_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void btnKonfirmasi_Click(object sender, RoutedEventArgs e)
        {
            if(txtNama.Text == "" || txtAlamat.Text == "" || txtEmail.Text == "" || txtNomor.Text == "" || txtUsername.Text == "" || txtPassword.Password == "")
            {
                MessageBox.Show("Mohon lengkapi data terlebih dahulu.");
            }
            else
            {
                if(ubahFoto)
                {
                    //replace gambar ke direktori yg sudah diset
                    string filename = txtUsername.Text + ".jpg";
                    string path = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                                                "\\Sistem Administrasi\\Images\\" + filename;

                    if (System.IO.File.Exists(path))
                    {
                        try
                        {
                            System.IO.File.Copy(openFileDialog.FileName, path, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                controller.Update();
            }
        }

        private void btnBrowse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                ubahFoto = true;

                string selectedName = openFileDialog.FileName;
                //MessageBox.Show(selectedName);
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedName);
                bitmap.EndInit();
                ImageProfile.Source = bitmap;
            }
        }
    }
}