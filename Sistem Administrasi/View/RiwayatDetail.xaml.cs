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
    /// Interaction logic for RiwayatDetail.xaml
    /// </summary>
    public partial class RiwayatDetail : Page
    {
        Controller.RiwayatDetailController controller;

        public RiwayatDetail()
        {
            InitializeComponent();

            controller = new Controller.RiwayatDetailController(this);
        }

        private void btnKembali_Click(object sender, RoutedEventArgs e)
        {
            controller.kembali();
        }
    }
}
