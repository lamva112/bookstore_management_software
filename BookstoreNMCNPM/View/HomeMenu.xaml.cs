using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using BookstoreNMCNPM.Model;

namespace BookstoreNMCNPM.View
{
    /// <summary>
    /// Interaction logic for HomeMenu.xaml
    /// </summary>
    public partial class HomeMenu : UserControl
    {
        public HomeMenu()
        {
            InitializeComponent();
        }
        QLNSEntities context = new QLNSEntities();
        private void BestSeller_Loaded(object sender, RoutedEventArgs e)
        {
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            var query = (from a in context.SACHes
                         let thanhtien = (from b in context.HOADONs
                                          join c in context.CT_HOADON on b.SoHD equals c.SoHD
                                          where c.MaSach == a.MaSach
                                          && b.NgayLap.Value.Month == thang
                                          && b.NgayLap.Value.Year == nam
                                          select c.ThanhTien).Sum()
                         where thanhtien > 0
                         orderby thanhtien descending
                         select a).Take(5);
            ObservableCollection<SACH> data = new ObservableCollection<SACH>(query);
            dataSachBanChay.ItemsSource = data;
            tbThang.Text = tbThang.Text +" "+ thang;
            tbNam.Text = tbNam.Text +" "+ nam;
        }
    }
}
