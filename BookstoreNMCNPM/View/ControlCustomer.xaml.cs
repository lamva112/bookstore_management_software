using BookstoreNMCNPM.ViewModel;
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

namespace BookstoreNMCNPM.View
{
    /// <summary>
    /// Interaction logic for ControlCustomer.xaml
    /// </summary>
    public partial class ControlCustomer : UserControl
    {
        public ControlCustomer()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            btnKhachhang.Foreground = Brushes.Blue;
            btnPhieuthu.Foreground = Brushes.Blue;
        }
        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            btnKhachhang.Foreground = Brushes.Orange;
            Switcher.Switch(new Customers());
        }
        private void btnCash_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            btnPhieuthu.Foreground = Brushes.Orange;
            Switcher.Switch(new Cash());
        }
    }
}
