using System;
using System.Collections.Generic;
using System.Data;
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

namespace Sistem_Administrasi.View
{
    /// <summary>
    /// Interaction logic for ProsesAntreanPage.xaml
    /// </summary>
    public partial class ProsesAntreanPage : Page
    {
        Controller.ProsesAntreanController controller;
        public int id_spesialis { get; set; }
        
        public ProsesAntreanPage()
        {
            InitializeComponent();

            controller = new Controller.ProsesAntreanController(this);
            controller.SetData();
        }

        private void btnKonfirmasi_Click(object sender, RoutedEventArgs e)
        {
            if (txtNama.Text == "" || dtpTanggalLahir.Text == "" || txtNomor.Text == "" || txtAlamat.Text == "" || txtKeluhan.Text == "")
            {
                MessageBox.Show("Mohon lengkapi data terlebih dahulu.");
            }
            else
            {
                controller.Update();
            }
        }

        private void btnBatal_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Main.Content = new AntreanPage();
        }

        private void cmbSpesialis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (controller == null)
                return;

            controller.SetItemDokter();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            cmbSpesialis_SelectionChanged(cmbSpesialis, null);
        }

        private void btnHapus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Hapus Antrean?", "Hapus", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                controller.Hapus();
            }
        }
    }
}