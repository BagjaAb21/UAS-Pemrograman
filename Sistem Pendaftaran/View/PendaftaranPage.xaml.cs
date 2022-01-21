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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sistem_Pendaftaran.View
{
    /// <summary>
    /// Interaction logic for Pendaftaran.xaml
    /// </summary>
    public partial class PendaftaranPage : Page
    {
        Controller.PendaftaranController controller;

        public PendaftaranPage()
        {
            InitializeComponent();
            controller = new Controller.PendaftaranController(this);

            txtNama.Focus();
        }

        private void btnDaftar_Click(object sender, RoutedEventArgs e)
        {
            if(txtNama.Text == "" || dtpTanggalLahir.Text == "" || txtNomor.Text == "" || txtAlamat.Text == "" || txtKeluhan.Text == "")
            {
                MessageBox.Show("Mohon lengkapi data terlebih dahulu.");
            }
            else
            {
                controller.Insert();
            }
        }

        private void btnBatal_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Batalkan Pendaftaran?", "Konfirmasi Pembatalan", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Controller.PendaftaranPasienLamaController.ds = null;
                MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
                mainWindow.Main.Content = new PendaftaranPage();
            }
        }

        private void cmbSpesialis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (controller == null)
                return;

            controller.SetItemDokter();
        }

        private void btnPasienLama_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Main.Content = new PendaftaranPasienLamaPage();
        }
    }
}
