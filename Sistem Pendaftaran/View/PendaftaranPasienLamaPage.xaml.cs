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
    /// Interaction logic for PendaftaranPasienLamaPage.xaml
    /// </summary>
    public partial class PendaftaranPasienLamaPage : Page
    {
        Controller.PendaftaranPasienLamaController controller;

        public PendaftaranPasienLamaPage()
        {
            InitializeComponent();
            txtNama.Focus();

            controller = new Controller.PendaftaranPasienLamaController(this);
        }

        private void btnCari_Click(object sender, RoutedEventArgs e)
        {
            if (txtNama.Text != "") controller.Cari();
            else
            {
                MessageBox.Show("Mohon Isi Nama Lengkap Terlebih Dahulu.");
                txtNama.Focus();
            }
        }

        private void txtNama_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                btnCari_Click(txtNama, null);
            }
        }

        private void btnBatal_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Main.Content = new PendaftaranPage();
        }
    }
}
