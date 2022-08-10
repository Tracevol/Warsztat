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

namespace Firma.View
{
    /// <summary>
    /// Interaction logic for KartotekaOsobowa.xaml
    /// </summary>
    public partial class KartotekaOsobowa : UserControl
    {
        public KartotekaOsobowa()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DodajOsobe os1 = new DodajOsobe();
            os1.Show();
            os1.Close();
        }
    }
}
