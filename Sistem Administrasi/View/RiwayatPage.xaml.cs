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

namespace Sistem_Administrasi.View
{
    /// <summary>
    /// Interaction logic for RiwayatPage.xaml
    /// </summary>
    /// 
    public partial class RiwayatPage : Page
    {
        Controller.RiwayatController controller;
        string date = "Tanggal : " + DateTime.Now.ToString("dd/MM/yyyy");

        public RiwayatPage()
        {
            InitializeComponent();

            controller = new Controller.RiwayatController(this);
            lblTanggal.Content = date;
            txtCari.Focus();

            controller.SetDataGrid();
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            controller.RiwayatDetail(e);
        }

        private void txtCari_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.SetDataGrid();
        }
    }
}