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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnPendaftaran_MouseDown(null, null);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnPendaftaran_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new PendaftaranPage();
        }

        private void btnJadwalDokter_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new JadwalDokterPage();
        }
    }
}
