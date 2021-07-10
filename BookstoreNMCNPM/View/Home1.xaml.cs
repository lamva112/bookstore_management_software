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
using System.Windows.Shapes;

namespace BookstoreNMCNPM.View
{
    
    public partial class Home1 : Window
    {
        public Home1()
        {
            InitializeComponent();
            Check();
        }
        public void Check()
        {
            if(Login.loai == 0)
            {
                btnReport.IsEnabled = false;
                btnSetting.IsEnabled = false;
            }
        }
        private void Reset()
        {
            btnBook.Foreground = Brushes.Blue;
            btnData.Foreground = Brushes.Blue;
            btnCustomer.Foreground = Brushes.Blue;
            btnSetting.Foreground = Brushes.Blue;
            btnReport.Foreground = Brushes.Blue;
            btnSearch.Foreground = Brushes.Blue;
            btnHomeMenu.Foreground = Brushes.Blue;
            Switcher.Switch1(new view());
            Switcher.Switch(new view());
            pnlView.Background = Brushes.LightYellow;
        }
        private void btnHomeMenu_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            Switcher.Switch(new HomeMenu());
            txtTieuDe.Text = "";
            btnHomeMenu.Foreground = Brushes.Orange;
        }
        private void btnData_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            Switcher.Switch(new BookInfo());
            txtTieuDe.Text = "Thể loại và Tác giả";            
            btnData.Foreground = Brushes.Orange;
        }
        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            Switcher.Switch1(new ControlBook());
            txtTieuDe.Text = "Quản lý Sách";
            btnBook.Foreground = Brushes.Orange;
        }
        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            Switcher.Switch1(new ControlCustomer());
            txtTieuDe.Text = "Quản lý Khách hàng ";
            btnCustomer.Foreground = Brushes.Orange;
        }
        private void btnSetting_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            Switcher.Switch(new Setting());
            txtTieuDe.Text = "";
            btnSetting.Foreground = Brushes.Orange;
        }
        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            Switcher.Switch(new Report());
            txtTieuDe.Text = "";
            btnReport.Foreground = Brushes.Orange;
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            Switcher.Switch1(new ControlSearch());
            txtTieuDe.Text = "";
            btnSearch.Foreground = Brushes.Orange;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnMinisize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void btnMaxsize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
                this.WindowState = WindowState.Maximized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
