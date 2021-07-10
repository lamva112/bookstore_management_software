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
    /// Interaction logic for SellBook.xaml
    /// </summary>
    public partial class SellBook : UserControl
    {
        private HOADON hoadon;
        private CT_HOADON chitiet;
        private int tong;
        public SellBook()
        {
            InitializeComponent();
        }
        QLNSEntities context = new QLNSEntities();

        private ObservableCollection<HOADON> getHoaDon()
        {
            return new ObservableCollection<HOADON>(context.HOADONs);
        }

        private ObservableCollection<KHACHHANG> getKhachhang()
        {
            return new ObservableCollection<KHACHHANG>(context.KHACHHANGs);
        }

        private ObservableCollection<SACH> getSach()
        {
            return new ObservableCollection<SACH>(context.SACHes);
        }
        private ObservableCollection<THAMSO> getThamso()
        {
            return new ObservableCollection<THAMSO>(context.THAMSOes);
        }
        private void HoaDon_Loaded(object sender, RoutedEventArgs e)
        {
            cbKhachHang.ItemsSource = getKhachhang();
            cbKhachHang.DisplayMemberPath = "TenKhachHang";
            dataBooks.ItemsSource = getSach();
            dataHoaDon.ItemsSource = getHoaDon();
        }
        private void setEnable()
        {

            btnAdd.IsEnabled = false;
            pnlThemSach.IsEnabled = true;
            btnSave.IsEnabled = true;
            btnUpdate.IsEnabled = true;
            pnlBooks.IsEnabled = true;
            pnlHoaDon.IsEnabled = true;
        }

        private void setMutable()
        {
            btnAdd.IsEnabled = true;
            pnlThemSach.IsEnabled = false;
            btnSave.IsEnabled = false;
            btnUpdate.IsEnabled = false;
            pnlBooks.IsEnabled = false;
            
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cbKhachHang.SelectedItem != null)
            {
                var customerID = cbKhachHang.SelectedValue as KHACHHANG;
                if (customerID.SoTienNo > getThamso()[0].SoTienNoToiDa)
                {
                    MessageBox.Show("Khách hàng không thể mua hàng do số tiền nợ vượt mức cho phép!", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else
                {
                    setEnable();
                    btnSave.IsEnabled = false;
                    pnlBooks.IsEnabled = false;
                    dataHoaDon.IsEnabled = true;
                    HOADON hoadon = new HOADON();
                    hoadon.SoHD = getHoaDon().Count + 1;
                    hoadon.MaKhachHang = customerID.MaKhachHang;
                    hoadon.NgayLap = DateTime.Now;
                    hoadon.ThanhToan = 0;
                    context.HOADONs.Add(hoadon);
                    context.SaveChanges();
                    dataHoaDon.ItemsSource = getHoaDon();
                }
            }
            else
                MessageBox.Show("Vui lòng chọn khách hàng trước khi tạo hóa đơn!", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        /// <summary>
        /// Thêm Chi tiết phiếu nhập
        /// </summary>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dataHoaDon.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn hóa đơn để nhập", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                //sửa phiếu nhập
                setEnable();
                btnUpdate.IsEnabled = false;
                hoadon = dataHoaDon.SelectedItem as HOADON;
                tong = Convert.ToInt32(hoadon.ThanhToan);
            }
        }

        /// <summary>
        /// Xóa phiếu nhập
        /// </summary>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Button seleted = (Button)sender;
            var item = seleted.DataContext as HOADON;
            if (item != null)
            {
                var DeleteRecord = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn số " + item.SoHD + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (DeleteRecord == MessageBoxResult.Yes)
                {
                    if (context.HOADONs.Find(item.SoHD) != null)
                    {
                        //xóa Chi tiết.
                        var query = from b in context.CT_HOADON
                                    where b.SoHD.Equals(item.SoHD)
                                    select b;
                        foreach (var delete in query)
                        {
                            context.CT_HOADON.Remove(delete);
                        }
                        context.SaveChanges();


                        //xóa Phiếu
                        context.HOADONs.Remove(item);
                        context.SaveChanges();
                        dataHoaDon.ItemsSource = getHoaDon();
                    }
                    else
                        dataHoaDon.ItemsSource = getHoaDon();
                }
            }
            else
                MessageBox.Show("Có gì đâu mà xóa!", "Phiếu nhập", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Lưu phiếu nhập
        /// </summary>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            setMutable();
            KHACHHANG kh = new KHACHHANG();
            var selected = dataHoaDon.SelectedItem as HOADON;
            kh = context.KHACHHANGs.Find(selected.MaKhachHang);
            if (selected != null)
            {
                tong = 0;
                var query = from b in context.CT_HOADON
                            where b.SoHD.Equals(selected.SoHD)
                            select b;
                foreach (var sum in query)
                {
                    tong += Convert.ToInt32(sum.ThanhTien);
                }
                var changed = context.HOADONs.Find(selected.SoHD);
                changed.ThanhToan = tong;
                kh.SoTienNo += tong;
                context.SaveChanges();
                dataHoaDon.ItemsSource = getHoaDon();
                dataBooks.ItemsSource = getSach();
            }
            else
                MessageBox.Show("Hãy chọn hóa đơn để lưu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void dataHoaDon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = ((DataGrid)sender).SelectedItem as HOADON;
            if (selected != null)
            {
                
                var query = from b in context.CT_HOADON
                            where b.SoHD.Equals(selected.SoHD)
                            select b;
                ObservableCollection<CT_HOADON> data = new ObservableCollection<CT_HOADON>(query);
                dataCT.ItemsSource = data;
            }
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            if (dataBooks.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn sách để thêm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if  (String.IsNullOrEmpty(tbSoLuong.Text))
                {
                    MessageBox.Show("Hãy nhập số lượng ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    chitiet = new CT_HOADON();
                    SACH sach1 = new SACH();
                    var sach = dataBooks.SelectedItem as SACH;
                    chitiet = context.CT_HOADON.Find(sach.MaSach, hoadon.SoHD);
                    sach1 = context.SACHes.Find(sach.MaSach);
                    int count = sach1.SoLuongTon;
                    if (chitiet == null)
                    {
                        count -= Convert.ToInt32(tbSoLuong.Text);
                        if (count > getThamso()[0].SoLuongTonToiThieu)
                        {
                            chitiet = new CT_HOADON();
                            chitiet.SoHD = hoadon.SoHD;
                            chitiet.SACH = sach;
                            chitiet.MaSach = sach.MaSach;
                            chitiet.SoLuong = Convert.ToInt32(tbSoLuong.Text);
                            chitiet.DonGia = Convert.ToInt32(sach1.GiaBan * 1.5);
                            chitiet.ThanhTien = chitiet.SoLuong * chitiet.DonGia;
                            sach1.SoLuongTon -= chitiet.SoLuong;
                            context.CT_HOADON.Add(chitiet);
                            context.SaveChanges();

                            var query = from b in context.CT_HOADON
                                        where b.SoHD.Equals(hoadon.SoHD)
                                        select b;
                            ObservableCollection<CT_HOADON> data = new ObservableCollection<CT_HOADON>(query);
                            dataCT.ItemsSource = data;
                        }
                        else
                        {
                            MessageBox.Show("Số lượng tồn sau khi bán phải lớn hơn: "+ getThamso()[0].SoLuongTonToiThieu, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }    
                    }
                    else
                    {
                        var InsertRecord = MessageBox.Show("Bạn có chắc chắn muốn sửa hóa đơn mã " + hoadon.SoHD + " không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (InsertRecord == MessageBoxResult.Yes)
                        {
                            chitiet.SoLuong = Convert.ToInt32(tbSoLuong.Text);
                            chitiet.DonGia = sach1.GiaBan;
                            chitiet.ThanhTien = chitiet.SoLuong * chitiet.DonGia;
                            sach1.SoLuongTon -= chitiet.SoLuong;
                            context.SaveChanges();

                            var query = from b in context.CT_HOADON
                                        where b.SoHD.Equals(hoadon.SoHD)
                                        select b;
                            ObservableCollection<CT_HOADON> data = new ObservableCollection<CT_HOADON>(query);
                            dataCT.ItemsSource = data;
                        }
                    }
                    tbSoLuong.Text = "";
                }
            }
        }

        private void btnDeleteBook_Click(object sender, RoutedEventArgs e)
        {
            Button seleted = (Button)sender;
            var item = seleted.DataContext as CT_HOADON;
            var DeleteRecord = MessageBox.Show("Bạn có chắc chắn muốn xóa sách " + item.SACH.TenSach + " vừa nhập không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (DeleteRecord == MessageBoxResult.Yes)
            {
                if (context.CT_HOADON.Find(item.SoHD) != null)
                {
                    //xóa chi tiết
                    context.CT_HOADON.Remove(item);
                    context.SaveChanges();
                    var query = from b in context.CT_HOADON
                                where b.SoHD.Equals(hoadon.SoHD)
                                select b;
                    ObservableCollection<CT_HOADON> data = new ObservableCollection<CT_HOADON>(query);
                    dataCT.ItemsSource = data;
                }
            }
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
