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
using BookstoreNMCNPM.Model;

namespace BookstoreNMCNPM.View
{
    /// <summary>
    /// Interaction logic for Cash.xaml
    /// </summary>
    public partial class Cash : UserControl
    {
        public Cash()
        {
            InitializeComponent();
        }
        QLNSEntities context = new QLNSEntities();
        private ObservableCollection<PHIEUTHUTIEN> getphieuthutien()
        {
            return new ObservableCollection<PHIEUTHUTIEN>(context.PHIEUTHUTIENs);
        }
        private ObservableCollection<KHACHHANG> getkhachhang()
        {
            return new ObservableCollection<KHACHHANG>(context.KHACHHANGs);
        }
        private void Cash_Loaded(object sender, RoutedEventArgs e)
        {
            dataCash.ItemsSource = getphieuthutien();
            cbKhachHang.ItemsSource = getkhachhang();
            cbKhachHang.DisplayMemberPath = "TenKhachHang";
        }
        private void setEnable()
        {
            btnAdd.IsEnabled = false;
            btnSave.IsEnabled = true;
            cbKhachHang.IsEnabled = true;
            tbTienThu.IsEnabled = true;
        }
        private void setMutable()
        {
            btnAdd.IsEnabled = true;
            btnSave.IsEnabled = false;
            cbKhachHang.IsEnabled = false;
            tbTienThu.IsEnabled = false;
            tbTienNo.IsEnabled = false;
            tbMaPT.IsEnabled = false;
            tbMaKH.IsEnabled = false;
        }
        private void setClear()
        {
            cbKhachHang.SelectedItem = null;
            tbMaKH.Text = "";
            tbMaPT.Text = "";
            tbTienNo.Text = "";
            tbTienThu.Text = "";
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            setClear();
            setEnable();
            tbMaPT.Text = (getphieuthutien().Count + 1).ToString();
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            PHIEUTHUTIEN pt = new PHIEUTHUTIEN();
            KHACHHANG kh = new KHACHHANG();
            kh = context.KHACHHANGs.Find(Convert.ToInt32(tbMaKH.Text));
            if (Convert.ToInt32(tbTienThu.Text) > Convert.ToInt32(tbTienNo.Text))
            {
                MessageBox.Show("Số tiền thu phải nhỏ hơn số tiền nợ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                setMutable();
                pt.SoPT = Convert.ToInt32(tbMaPT.Text);
                pt.MaKhachHang = Convert.ToInt32(tbMaKH.Text);
                pt.NgayLap = DateTime.Now;
                pt.SoTienThu = Convert.ToInt32(tbTienThu.Text);
                kh.SoTienNo -= pt.SoTienThu;
                context.PHIEUTHUTIENs.Add(pt);
                context.SaveChanges();
                dataCash.ItemsSource = getphieuthutien();
            }
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
