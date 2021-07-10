using BookstoreNMCNPM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Customers.xaml
    /// </summary>
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }
        QLNSEntities context = new QLNSEntities();

        private ObservableCollection<KHACHHANG> getKhachHang()
        {
            return new ObservableCollection<KHACHHANG>(context.KHACHHANGs);
        }
        /// <summary>
        /// Set textbox Enabled
        /// </summary>
        private void setEnabled()
        {
            btnAdd.IsEnabled = false;
            btnEdit.IsEnabled = false;
            btnSave.IsEnabled = true;
            tbTenKH.IsEnabled = true;
            tbDiaChi.IsEnabled = true;
            tbSDT.IsEnabled = true;
            tbEmail.IsEnabled = true;
            
        }

        /// <summary>
        /// Set textbox mutable
        /// </summary>
        private void setMutable()
        {
            btnAdd.IsEnabled = true;
            btnEdit.IsEnabled = true;
            btnSave.IsEnabled = false;
            tbMaKH.IsEnabled = false;
            tbTenKH.IsEnabled = false;
            tbDiaChi.IsEnabled = false;
            tbSDT.IsEnabled = false;
            tbEmail.IsEnabled = false;
            tbTienNo.IsEnabled = false;
        }

        private void setClear()
        {
            tbMaKH.Clear();
            tbTenKH.Clear();
            tbDiaChi.Clear();
            tbSDT.Clear();
            tbEmail.Clear();
            
        }
        /// <summary>
        /// Button thêm sách
        /// </summary>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            dataCustomers.SelectedItem = null;
            if (!tbTenKH.IsEnabled)
            {
                setClear();
                setEnabled();
                tbTienNo.Text = "0";
                tbMaKH.Text = (getKhachHang().Count+1).ToString();
                dataCustomers.IsEnabled = false;
            }
            else
            {
                setMutable();
                dataCustomers.IsEnabled = true;
            }
        }
        /// <summary>
        /// Check textbox null
        /// </summary>
        /// <returns></returns>
        private bool isNull()
        {
            if (!String.IsNullOrEmpty(tbMaKH.Text)
                && !String.IsNullOrEmpty(tbTenKH.Text)
                && !String.IsNullOrEmpty(tbDiaChi.Text)
                && !String.IsNullOrEmpty(tbSDT.Text)
                && !String.IsNullOrEmpty(tbEmail.Text)
                && !String.IsNullOrEmpty(tbTienNo.Text))
                return false;
            return true;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            KHACHHANG khanhhang = new KHACHHANG();
            KHACHHANG test = new KHACHHANG();
            if (!isNull())
            {
                test = context.KHACHHANGs.Find(Convert.ToInt32(tbMaKH.Text));
                if (test==null)
                {
                    var Confirm = MessageBox.Show("Bạn có chắc muốn thêm khách hàng " + tbTenKH.Text + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (Confirm == MessageBoxResult.Yes)
                    {
                        var find = Convert.ToInt32(tbMaKH.Text);
                        if (context.KHACHHANGs.Find(find) == null)
                        {
                            khanhhang.MaKhachHang = Convert.ToInt32(tbMaKH.Text);

                            khanhhang.TenKhachHang = tbTenKH.Text;
                            khanhhang.DiaChi = tbDiaChi.Text;
                            khanhhang.Email = tbEmail.Text;
                            khanhhang.SDT = tbSDT.Text;
                            khanhhang.SoTienNo = Convert.ToInt32(tbTienNo.Text);

                            context.KHACHHANGs.Add(khanhhang);
                            context.SaveChanges();

                            dataCustomers.ItemsSource = getKhachHang();
                            setMutable();
                            dataCustomers.IsEnabled = true;
                        }
                        else
                            MessageBox.Show("Mã khách hàng không được trùng", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    var Confirm = MessageBox.Show("Bạn có chắc muốn sửa khánh hàng " + tbTenKH.Text + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (Confirm == MessageBoxResult.Yes)
                    {
                        khanhhang = context.KHACHHANGs.Find(Convert.ToInt32(tbMaKH.Text));
                        khanhhang.TenKhachHang = tbTenKH.Text;
                        khanhhang.DiaChi = tbDiaChi.Text;
                        khanhhang.Email = tbEmail.Text;
                        khanhhang.SDT = tbSDT.Text;
                        khanhhang.SoTienNo = Convert.ToInt32(tbTienNo.Text);

                        context.SaveChanges();

                        dataCustomers.ItemsSource = getKhachHang();

                        MessageBox.Show("Sửa khách hàng thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);

                        setMutable();
                        dataCustomers.IsEnabled = true;
                    }
                }
                setMutable();
            }
            else
                MessageBox.Show("Không được để trống!", "Khách hàng", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        /// <summary>
        /// Button xóa sách
        /// </summary>
        public void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Button seleted = (Button)sender;
            var item = seleted.DataContext as KHACHHANG;
            var DeleteRecord = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng " + item.TenKhachHang + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (DeleteRecord == MessageBoxResult.Yes)
            {
                try
                {
                    context.KHACHHANGs.Remove(item);
                    context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Không được xóa", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

                dataCustomers.ItemsSource = getKhachHang();
            }
        }

        /// <summary>
        /// Button sửa sách
        /// </summary>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dataCustomers.SelectedItem == null)
                MessageBox.Show("Hãy chọn khách hàng để sửa!", "Khách hàng", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
                setEnabled();
        }

        /// <summary>
        /// Loaded View
        /// </summary>
        private void Customers_Loaded(object sender, RoutedEventArgs e)
        {
            dataCustomers.ItemsSource = getKhachHang();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
