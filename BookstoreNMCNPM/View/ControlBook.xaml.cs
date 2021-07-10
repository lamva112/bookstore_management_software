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
    /// Interaction logic for ControlBook.xaml
    /// </summary>
    public partial class ControlBook : UserControl
    {
        public ControlBook()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            btnSach.Foreground = Brushes.Blue;
            btnNhapsach.Foreground = Brushes.Blue;
            btnBansach.Foreground = Brushes.Blue;
        }
        private void btnSach_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            btnSach.Foreground = Brushes.Orange;
            Switcher.Switch(new Books());
        }
        private void btnNhapSach_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            btnNhapsach.Foreground = Brushes.Orange;
            Switcher.Switch(new ImportBook());
        }
        private void btnBanSach_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            btnBansach.Foreground = Brushes.Orange;
            Switcher.Switch(new SellBook());
        }
    }
}
