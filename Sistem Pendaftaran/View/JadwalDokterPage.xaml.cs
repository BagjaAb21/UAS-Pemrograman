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
    /// Interaction logic for JadwalDokterPage.xaml
    /// </summary>
    public partial class JadwalDokterPage : Page
    {
        Controller.JadwalDokterController controller;

        public JadwalDokterPage()
        {
            InitializeComponent();
            controller = new Controller.JadwalDokterController(this);

            txtCari.Focus();
        }

        private void txtCari_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.SetData();
        }
    }
}
