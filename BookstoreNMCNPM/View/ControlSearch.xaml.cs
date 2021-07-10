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
    /// Interaction logic for ControlSearch.xaml
    /// </summary>
    public partial class ControlSearch : UserControl
    {
        public ControlSearch()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            btnKhachHang.Foreground = Brushes.Blue;
            btnSach.Foreground = Brushes.Blue;
        }
        private void btnSach_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            btnSach.Foreground = Brushes.Orange;
            Switcher.Switch(new SearchBook());
        }
        private void btnKhachHang_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            btnKhachHang.Foreground = Brushes.Orange;
            Switcher.Switch(new SearchCustomer());
        }
    }
}
