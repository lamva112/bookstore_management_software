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
using BookstoreNMCNPM.View;
using BookstoreNMCNPM.Model;
using System.Collections.ObjectModel;

namespace BookstoreNMCNPM.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string useradmin = "admin", usernv="nhanvien";
        public static int loai ;
        public Login()
        {
            InitializeComponent();
        }
        QLNSEntities context = new QLNSEntities();
        private ObservableCollection<THAMSO> getThamso()
        {
            return new ObservableCollection<THAMSO>(context.THAMSOes);
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbUser.Text != "" && tbPass.Password != "")
            {
                if (tbUser.Text == useradmin && tbPass.Password == getThamso()[0].MatKhauAdmin)
                {
                    loai = 1;
                    this.Hide();
                    Home1 home1 = new Home1();
                    home1.ShowDialog();
                }
                else if (tbUser.Text == usernv && tbPass.Password == getThamso()[0].MatKhauNV)
                {
                    loai = 0;
                    this.Hide();
                    Home1 home1 = new Home1();
                    home1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }    
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }
        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Maxsize(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
                this.WindowState = WindowState.Maximized;

        }

        private void Minisize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                // your event handler here
                e.Handled = true;
                btnLogin_Click(sender, e);
            }
        }

    }
}
