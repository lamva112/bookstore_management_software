using System;
using System.Collections;
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
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : UserControl
    {
        private int tondau, nodau;
        public Report()
        {
            InitializeComponent();
        }
        QLNSEntities context = new QLNSEntities();
        private ObservableCollection<SACH> getsach()
        {
            return new ObservableCollection<SACH>(context.SACHes);
        }
        private ObservableCollection<KHACHHANG> getkhachhang()
        {
            return new ObservableCollection<KHACHHANG>(context.KHACHHANGs);
        }
        private void BaoCao_Loaded(object sender, RoutedEventArgs e)
        {
            var list = new ArrayList(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            cbThang.ItemsSource = list;
            var query = (from b in context.HOADONs
                        select b.NgayLap.Value.Year).Distinct();
            var list1 = new ArrayList();
            foreach (var item in query)
            { 
                    list1.Add(item);
            }
            
            cbNam.ItemsSource = list1;
        }
        private void Select_Change(object sender, SelectionChangedEventArgs e)
        {
            if(cbThang.SelectedItem != null && cbNam.SelectedItem != null)
            {
                if (Convert.ToInt32(cbThang.SelectedItem) <= DateTime.Now.Month)
                {
                    var thang = Convert.ToInt32(cbThang.SelectedItem);
                    var nam = Convert.ToInt32(cbNam.SelectedItem);
                    if (CheckDieuKien(thang,nam) == false)
                    {
                        MessageBox.Show("Chưa có báo cáo", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {

                        var check = (from b in context.BAOCAOTONs
                                  where b.Thang == (thang-1)
                                  && b.Nam == nam
                                  select b).FirstOrDefault<BAOCAOTON>();
                        if (check == null)
                        {
                            nodau = tondau = 0;
                            check = (from b in context.BAOCAOTONs
                                     where b.Thang == thang
                                     && b.Nam == nam
                                     select b).FirstOrDefault<BAOCAOTON>();
                            if (check == null)
                            {
                                foreach (var item in getsach())
                                {
                                    BAOCAOTON baocaoton = new BAOCAOTON();
                                    baocaoton.MaSach = item.MaSach;
                                    baocaoton.TonDau = tondau;
                                    baocaoton.PhatSinh = TinhSoLuongPhatSinh(baocaoton.MaSach, thang, nam);
                                    baocaoton.TonCuoi = baocaoton.TonDau + baocaoton.PhatSinh;
                                    baocaoton.Thang = Convert.ToInt32(cbThang.SelectedItem);
                                    baocaoton.Nam = Convert.ToInt32(cbNam.SelectedItem);
                                    context.BAOCAOTONs.Add(baocaoton);
                                    context.SaveChanges();
                                }
                                foreach (var item in getkhachhang())
                                {
                                    BAOCAOCONGNO baocaocongno = new BAOCAOCONGNO();
                                    baocaocongno.MaKhachHang = item.MaKhachHang;
                                    baocaocongno.NoDau = nodau;
                                    baocaocongno.PhatSinh = TinhTienNoPhatSinh(baocaocongno.MaKhachHang, thang, nam);
                                    baocaocongno.NoCuoi = (int)(baocaocongno.NoDau + baocaocongno.PhatSinh);
                                    baocaocongno.Thang = Convert.ToInt32(cbThang.SelectedItem);
                                    baocaocongno.Nam = Convert.ToInt32(cbNam.SelectedItem);
                                    context.BAOCAOCONGNOes.Add(baocaocongno);
                                    context.SaveChanges();
                                }
                                LoadData(thang, nam);

                            }
                            else
                            {
                                foreach (var item in getsach())
                                {
                                    BAOCAOTON baocaoton = context.BAOCAOTONs.Find(item.MaSach, thang, nam);
                                    if(baocaoton == null)
                                    {
                                        BAOCAOTON baocaoton1 = new BAOCAOTON();
                                        baocaoton1.MaSach = item.MaSach;
                                        baocaoton1.TonDau = tondau;
                                        baocaoton1.PhatSinh = TinhSoLuongPhatSinh(baocaoton1.MaSach, thang, nam);
                                        baocaoton1.TonCuoi = baocaoton1.TonDau + baocaoton1.PhatSinh;
                                        baocaoton1.Thang = Convert.ToInt32(cbThang.SelectedItem);
                                        baocaoton1.Nam = Convert.ToInt32(cbNam.SelectedItem);
                                        context.BAOCAOTONs.Add(baocaoton1);
                                        context.SaveChanges();
                                    }
                                    else
                                    {
                                    baocaoton.PhatSinh = TinhSoLuongPhatSinh(baocaoton.MaSach, thang, nam);
                                    baocaoton.TonCuoi = baocaoton.TonDau + baocaoton.PhatSinh;
                                    context.SaveChanges();
                                    }
                                    
                                }
                                foreach (var item in getkhachhang())
                                {
                                    BAOCAOCONGNO baocaocongno = context.BAOCAOCONGNOes.Find(item.MaKhachHang, thang, nam);
                                    if (baocaocongno == null)
                                    {
                                        BAOCAOCONGNO baocaocongno1 = new BAOCAOCONGNO();
                                        baocaocongno1.MaKhachHang = item.MaKhachHang;
                                        baocaocongno1.NoDau = nodau;
                                        baocaocongno1.PhatSinh = TinhTienNoPhatSinh(baocaocongno1.MaKhachHang, thang, nam);
                                        baocaocongno1.NoCuoi = (int)(baocaocongno1.NoDau + baocaocongno1.PhatSinh);
                                        baocaocongno1.Thang = Convert.ToInt32(cbThang.SelectedItem);
                                        baocaocongno1.Nam = Convert.ToInt32(cbNam.SelectedItem);
                                        context.BAOCAOCONGNOes.Add(baocaocongno1);
                                        context.SaveChanges();
                                    }
                                    else
                                    {
                                        baocaocongno.PhatSinh = TinhTienNoPhatSinh(baocaocongno.MaKhachHang, thang, nam);
                                        baocaocongno.NoCuoi = (int)(baocaocongno.NoDau + baocaocongno.PhatSinh);
                                        context.SaveChanges();
                                    }
                                }
                                LoadData(thang, nam);
                            }
                        }
                        else
                        {
                            var check1 = (from b in context.BAOCAOTONs
                                          where b.Thang == thang
                                          && b.Nam == nam
                                          select b).FirstOrDefault<BAOCAOTON>();
                            if (check1 == null)
                            {
                                foreach (var item in getsach())
                                {
                                    BAOCAOTON baocaoton = new BAOCAOTON();
                                    BAOCAOTON baocaocu = new BAOCAOTON();
                                    baocaocu = context.BAOCAOTONs.Find(item.MaSach, thang - 1, nam);
                                    if (baocaocu == null)
                                    {
                                        tondau = 0;
                                    }
                                    else
                                    {
                                        tondau = baocaocu.TonCuoi;
                                    }
                                    baocaoton.MaSach = item.MaSach;
                                    baocaoton.TonDau = tondau;
                                    baocaoton.PhatSinh = TinhSoLuongPhatSinh(baocaoton.MaSach, thang, nam);
                                    baocaoton.TonCuoi = baocaoton.TonDau + baocaoton.PhatSinh;
                                    baocaoton.Thang = Convert.ToInt32(cbThang.SelectedItem);
                                    baocaoton.Nam = Convert.ToInt32(cbNam.SelectedItem);
                                    context.BAOCAOTONs.Add(baocaoton);
                                    context.SaveChanges();
                                }
                                foreach (var item in getkhachhang())
                                {
                                    BAOCAOCONGNO baocaocongno = new BAOCAOCONGNO();
                                    BAOCAOCONGNO baocaocu = new BAOCAOCONGNO();
                                    baocaocu = context.BAOCAOCONGNOes.Find(item.MaKhachHang, thang - 1, nam);
                                    if (baocaocu == null)
                                    {
                                        nodau = 0;
                                    }
                                    else
                                    {
                                        nodau = baocaocu.NoCuoi;
                                    }
                                    baocaocongno.MaKhachHang = item.MaKhachHang;
                                    baocaocongno.NoDau = nodau;
                                    baocaocongno.PhatSinh = TinhTienNoPhatSinh(baocaocongno.MaKhachHang, thang, nam);
                                    baocaocongno.NoCuoi = (int)(baocaocongno.NoDau + baocaocongno.PhatSinh);
                                    baocaocongno.Thang = Convert.ToInt32(cbThang.SelectedItem);
                                    baocaocongno.Nam = Convert.ToInt32(cbNam.SelectedItem);
                                    context.BAOCAOCONGNOes.Add(baocaocongno);
                                    context.SaveChanges();
                                }
                                LoadData(thang, nam);

                            }
                            else
                            {
                                foreach (var item in getsach())
                                {
                                    BAOCAOTON baocaoton = context.BAOCAOTONs.Find(item.MaSach, thang, nam);
                                    if (baocaoton == null)
                                    {
                                        BAOCAOTON baocaoton1 = new BAOCAOTON();
                                        BAOCAOTON baocaocu1 = new BAOCAOTON();
                                        baocaocu1 = context.BAOCAOTONs.Find(item.MaSach, thang - 1, nam);
                                        if (baocaocu1 == null)
                                        {
                                            tondau = 0;
                                        }
                                        else
                                        {
                                            tondau = baocaocu1.TonCuoi;
                                        }
                                        baocaoton1.MaSach = item.MaSach;
                                        baocaoton1.TonDau = tondau;
                                        baocaoton1.PhatSinh = TinhSoLuongPhatSinh(baocaoton1.MaSach, thang, nam);
                                        baocaoton1.TonCuoi = baocaoton1.TonDau + baocaoton1.PhatSinh;
                                        baocaoton1.Thang = Convert.ToInt32(cbThang.SelectedItem);
                                        baocaoton1.Nam = Convert.ToInt32(cbNam.SelectedItem);
                                        context.BAOCAOTONs.Add(baocaoton1);
                                        context.SaveChanges();
                                    }
                                    else
                                    {
                                        BAOCAOTON baocaocu = new BAOCAOTON();
                                        baocaocu = context.BAOCAOTONs.Find(item.MaSach, thang - 1, nam);
                                        if (baocaocu == null)
                                        {
                                            tondau = 0;
                                        }
                                        else
                                        {
                                            tondau = baocaocu.TonCuoi;
                                        }
                                        baocaoton.PhatSinh = TinhSoLuongPhatSinh(baocaoton.MaSach, thang, nam);
                                        baocaoton.TonCuoi = tondau + baocaoton.PhatSinh;
                                        context.SaveChanges();
                                    }
                                }
                                foreach (var item in getkhachhang())
                                {
                                    BAOCAOCONGNO baocaocongno = context.BAOCAOCONGNOes.Find(item.MaKhachHang, thang, nam);
                                    if (baocaocongno == null)
                                    {
                                        BAOCAOCONGNO baocaocongno1 = new BAOCAOCONGNO();
                                        BAOCAOCONGNO baocaocu1 = new BAOCAOCONGNO();
                                        baocaocu1 = context.BAOCAOCONGNOes.Find(item.MaKhachHang, thang - 1, nam);
                                        if (baocaocu1 == null)
                                        {
                                            nodau = 0;
                                        }
                                        else
                                        {
                                            nodau = baocaocu1.NoCuoi;
                                        }
                                        baocaocongno1.MaKhachHang = item.MaKhachHang;
                                        baocaocongno1.NoDau = nodau;
                                        baocaocongno1.PhatSinh = TinhTienNoPhatSinh(baocaocongno1.MaKhachHang, thang, nam);
                                        baocaocongno1.NoCuoi = (int)(baocaocongno1.NoDau + baocaocongno1.PhatSinh);
                                        baocaocongno1.Thang = Convert.ToInt32(cbThang.SelectedItem);
                                        baocaocongno1.Nam = Convert.ToInt32(cbNam.SelectedItem);
                                        context.BAOCAOCONGNOes.Add(baocaocongno1);
                                        context.SaveChanges();
                                    }
                                    else
                                    {
                                        BAOCAOCONGNO baocaocu = new BAOCAOCONGNO();
                                        baocaocu = context.BAOCAOCONGNOes.Find(item.MaKhachHang, thang - 1, nam);
                                        if (baocaocu == null)
                                        {
                                            nodau = 0;
                                        }
                                        else
                                        {
                                            nodau = baocaocu.NoCuoi;
                                        }
                                        baocaocongno.PhatSinh = TinhTienNoPhatSinh(baocaocongno.MaKhachHang, thang, nam);
                                        baocaocongno.NoCuoi = (int)(nodau + baocaocongno.PhatSinh);
                                        context.SaveChanges();
                                    }
                                }
                                LoadData(thang, nam);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có báo cáo", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }    

            }
            else
            {
                MessageBox.Show("Vui lòng chọn tháng và năm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private int TinhSoLuongPhatSinh(int masach,int thang, int nam)
        {
            int phatsinh=0;
            var query = from b in context.HOADONs 
                        join c in context.CT_HOADON on b.SoHD equals c.SoHD
                        where b.NgayLap.Value.Month == thang &&
                        b.NgayLap.Value.Year == nam &&
                        c.MaSach.Equals(masach)
                        select c.SoLuong;
            
            var query1 = from b in context.PHIEUNHAPSACHes
                         join c in context.CT_PHIEUNHAPSACH on b.SoPNS equals c.SoPNS
                         where b.NgayNhap.Month == thang &&
                         b.NgayNhap.Year == nam &&
                         c.MaSach.Equals(masach)
                         select c.SoLuongNhap;
            foreach (var item in query1)
            {
                phatsinh += item;
            }
            foreach (var item in query)
            {
                phatsinh -= item;
            }

            return phatsinh;
        }
        private int TinhTienNoPhatSinh(int makh, int thang, int nam)
        {
            int phatsinh = 0;
            var query = from b in context.HOADONs
                        join c in context.CT_HOADON on b.SoHD equals c.SoHD
                        where b.NgayLap.Value.Month == thang &&
                        b.NgayLap.Value.Year == nam &&
                        b.MaKhachHang.Equals(makh)
                        select c.ThanhTien;

            var query1 = from b in context.PHIEUTHUTIENs
                         where b.NgayLap.Month == thang &&
                         b.NgayLap.Year.Equals(nam) &&
                         b.MaKhachHang.Equals(makh)
                         select b.SoTienThu;
            foreach (var item in query)
            {
                phatsinh += Convert.ToInt32(item);
            }
            foreach (var item in query1)
            {
                phatsinh -= item;
            }

            return phatsinh;
        }
        private void LoadData(int thang, int nam)
        {
            var bct = from b in context.BAOCAOTONs
                      where b.Thang == thang 
                      && b.Nam == nam
                      select b;
            var bccn = from b in context.BAOCAOCONGNOes
                       where b.Thang == thang 
                      && b.Nam == nam
                       select b;
            ObservableCollection<BAOCAOTON> data = new ObservableCollection<BAOCAOTON>(bct);
            ObservableCollection<BAOCAOCONGNO> data1 = new ObservableCollection<BAOCAOCONGNO>(bccn);
            dataSachTon.ItemsSource = data;
            dataCongNo.ItemsSource = data1;
        }
        private Boolean CheckDieuKien(int thang, int nam)
        {
            var hoadon = from b in context.HOADONs
                         where b.NgayLap.Value.Month == thang
                         && b.NgayLap.Value.Year == nam
                         select b;
            var phieunhap = from b in context.PHIEUNHAPSACHes
                         where b.NgayNhap.Month == thang
                         && b.NgayNhap.Year == nam
                         select b;
            if (hoadon.Count() == 0 || phieunhap.Count() == 0)
            {
                return false;
            }
            return true;
        }
    }
}
