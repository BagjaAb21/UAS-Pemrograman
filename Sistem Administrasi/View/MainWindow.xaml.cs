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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller.MainWindowController controller;

        public MainWindow()
        {
            InitializeComponent();

            // set frame menjadi antrean page
            btnAntrean_MouseDown(null, null);

            controller = new Controller.MainWindowController(this);
            controller.setProfile();
        }

        private void btnAntrean_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new AntreanPage();
        }

        private void btnRiwayat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new View.RiwayatPage();
        }

        private void btnProfile_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (canvasProfile.Visibility == Visibility.Hidden)
                canvasProfile.Visibility = Visibility.Visible;
            else
                canvasProfile.Visibility = Visibility.Hidden;
        }

        private void lblAkun_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ProfileWindow profile = new ProfileWindow();
            profile.Show();
            this.Close();
        }

        private void lblLogout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }
    }
}
