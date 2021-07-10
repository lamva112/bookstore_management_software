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
    /// Interaction logic for ImportBook.xaml
    /// </summary>
    public partial class ImportBook : UserControl
    {
        private PHIEUNHAPSACH phieunhap;
        private CT_PHIEUNHAPSACH chitiet;
        private int tong;
        public ImportBook()
        {
            InitializeComponent();
        }
        QLNSEntities context = new QLNSEntities();

        private ObservableCollection<PHIEUNHAPSACH> getPhieunhap()
        {
            return new ObservableCollection< PHIEUNHAPSACH > (context.PHIEUNHAPSACHes);
        }
        private ObservableCollection<SACH> getSach()
        {
            return new ObservableCollection<SACH>(context.SACHes);
        }
        private ObservableCollection<THAMSO> getThamso()
        {
            return new ObservableCollection<THAMSO>(context.THAMSOes);
        }
        private void setEnabled()
        {
            btnAdd.IsEnabled = false;
            pnlThemSach.IsEnabled = true;
            btnSave.IsEnabled = true;
            btnUpdate.IsEnabled = true;
            pnlBooks.IsEnabled = true;
            pnlPhieuNhap.IsEnabled = true;
        }

        private void setMutable()
        {
            btnAdd.IsEnabled = true;
            pnlThemSach.IsEnabled = false;
            btnSave.IsEnabled = false;
            btnUpdate.IsEnabled = false;
            pnlBooks.IsEnabled = false;
        }
        /// <summary>
        /// Button Thêm phiếu nhập
        /// </summary>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            dataPhieuNhap.IsEnabled = true;
            PHIEUNHAPSACH phieu = new PHIEUNHAPSACH();
            setEnabled();
            btnSave.IsEnabled = false;
            pnlBooks.IsEnabled = false;
            phieu.SoPNS = getPhieunhap().Count +1;
            phieu.NgayNhap = DateTime.Now;
            phieu.TongTien = 0;
            context.PHIEUNHAPSACHes.Add(phieu);
            context.SaveChanges();
            dataPhieuNhap.ItemsSource = getPhieunhap();   
        }

        /// <summary>
        /// Thêm Chi tiết phiếu nhập
        /// </summary>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dataPhieuNhap.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn phiếu để nhập", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                //sửa phiếu nhập
                setEnabled();
                btnUpdate.IsEnabled = false;
                phieunhap = dataPhieuNhap.SelectedItem as PHIEUNHAPSACH;
                tong = Convert.ToInt32(phieunhap.TongTien);
            }
        }

        /// <summary>
        /// Xóa phiếu nhập
        /// </summary>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Button seleted = (Button)sender;
            var item = seleted.DataContext as PHIEUNHAPSACH;
            if (item != null)
            {
                var DeleteRecord = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập số " + item.SoPNS + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (DeleteRecord == MessageBoxResult.Yes)
                {
                    if (context.PHIEUNHAPSACHes.Find(item.SoPNS) != null)
                    {
                        //xóa Chi tiết.
                        var query = from b in context.CT_PHIEUNHAPSACH
                                    where b.SoPNS.Equals(item.SoPNS)
                                    select b;
                        foreach (var delete in query)
                        {
                            context.CT_PHIEUNHAPSACH.Remove(delete);
                        }
                        context.SaveChanges();


                        //xóa Phiếu
                        context.PHIEUNHAPSACHes.Remove(item);
                        context.SaveChanges();
                        dataPhieuNhap.ItemsSource = getPhieunhap();
                    }
                    else
                        dataPhieuNhap.ItemsSource = getPhieunhap();
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
            var selected = dataPhieuNhap.SelectedItem as PHIEUNHAPSACH;
            if (selected != null)
            {
                tong = 0;
                var query = from b in context.CT_PHIEUNHAPSACH
                            where b.SoPNS.Equals(selected.SoPNS)
                            select b;
                foreach (var item in query)
                {
                    tong += Convert.ToInt32(item.ThanhTien);
                }
                var changed = context.PHIEUNHAPSACHes.Find(selected.SoPNS);
                changed.TongTien = tong;
                context.SaveChanges();
                dataPhieuNhap.ItemsSource = getPhieunhap();
                dataBooks.ItemsSource = getSach();
                
            }
            else
                MessageBox.Show("Hãy chọn phiếu để lưu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
        }



        /// <summary>
        /// Thêm phiếu nhập
        /// </summary>
        

        

        private void PhieuNhap_Loaded(object sender, RoutedEventArgs e)
        {
            dataPhieuNhap.ItemsSource = getPhieunhap();

            dataBooks.ItemsSource = getSach();
        }
        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            if (dataBooks.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn sách để thêm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                tbDonGia.Text = tbSoLuong.Text = "";
            }
            else
            {
                if (String.IsNullOrEmpty(tbDonGia.Text) && String.IsNullOrEmpty(tbSoLuong.Text))
                {
                    MessageBox.Show("Hãy nhập số lượng và đơn giá", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    if (Convert.ToInt32(tbSoLuong.Text)>= getThamso()[0].SoLuongNhapToiThieu)
                    {
                        chitiet = new CT_PHIEUNHAPSACH();
                        SACH sach1 = new SACH();
                        var sach = dataBooks.SelectedItem as SACH;
                        chitiet = context.CT_PHIEUNHAPSACH.Find(phieunhap.SoPNS, sach.MaSach);
                        sach1 = context.SACHes.Find(sach.MaSach);
                        if (sach1.SoLuongTon < getThamso()[0].SoLuongTonToiDa)
                        {
                            if (chitiet == null)
                            {
                                chitiet = new CT_PHIEUNHAPSACH();
                                chitiet.SoPNS = phieunhap.SoPNS;
                                chitiet.SACH = dataBooks.SelectedItem as SACH;
                                chitiet.MaSach = chitiet.SACH.MaSach;
                                chitiet.SoLuongNhap = Convert.ToInt32(tbSoLuong.Text);
                                chitiet.DonGiaNhap = Convert.ToInt32(tbDonGia.Text);
                                chitiet.ThanhTien = chitiet.SoLuongNhap * chitiet.DonGiaNhap;

                                context.CT_PHIEUNHAPSACH.Add(chitiet);
                                sach1.SoLuongTon += chitiet.SoLuongNhap;
                                sach1.GiaBan = chitiet.DonGiaNhap;
                                context.SaveChanges();

                                var query = from b in context.CT_PHIEUNHAPSACH
                                            where b.SoPNS.Equals(phieunhap.SoPNS)
                                            select b;
                                ObservableCollection<CT_PHIEUNHAPSACH> data = new ObservableCollection<CT_PHIEUNHAPSACH>(query);
                                dataCT.ItemsSource = data;
                            }
                            else
                            {
                                var InsertRecord = MessageBox.Show("Bạn có chắc chắn muốn sửa phiếu nhập mã " + phieunhap.SoPNS + " không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                                if (InsertRecord == MessageBoxResult.Yes)
                                {
                                    chitiet.SoLuongNhap = Convert.ToInt32(tbSoLuong.Text);
                                    chitiet.DonGiaNhap = Convert.ToInt32(tbDonGia.Text);
                                    chitiet.ThanhTien = chitiet.SoLuongNhap * chitiet.DonGiaNhap;
                                    sach1.SoLuongTon += chitiet.SoLuongNhap;
                                    sach1.GiaBan = chitiet.DonGiaNhap;
                                    context.SaveChanges();

                                    var query = from b in context.CT_PHIEUNHAPSACH
                                                where b.SoPNS.Equals(phieunhap.SoPNS)
                                                select b;
                                    ObservableCollection<CT_PHIEUNHAPSACH> data = new ObservableCollection<CT_PHIEUNHAPSACH>(query);
                                    dataCT.ItemsSource = data;
                                }
                            }
                            tbDonGia.Text = tbSoLuong.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Không phải nhập do số lượng tồn lớn hơn " + getThamso()[0].SoLuongTonToiDa , "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng nhập tối thiểu là "+ getThamso()[0].SoLuongNhapToiThieu, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }


       
        private void btnDeleteBook_Click(object sender, RoutedEventArgs e)
        {
            Button seleted = (Button)sender;
            var item = seleted.DataContext as CT_PHIEUNHAPSACH;
            var DeleteRecord = MessageBox.Show("Bạn có chắc chắn muốn xóa sách " + item.SACH.TenSach + " vừa nhập không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (DeleteRecord == MessageBoxResult.Yes)
            {
                if (context.CT_PHIEUNHAPSACH.Find(item.SoPNS) != null)
                {
                    //xóa chi tiết
                    context.CT_PHIEUNHAPSACH.Remove(item);
                    context.SaveChanges();
                    var query = from b in context.CT_PHIEUNHAPSACH
                                where b.SoPNS.Equals(phieunhap.SoPNS)
                                select b;
                    ObservableCollection<CT_PHIEUNHAPSACH> data = new ObservableCollection<CT_PHIEUNHAPSACH>(query);
                    dataCT.ItemsSource = data;
                }
            }
        }

       
        private void dataPhieuNhap_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = ((DataGrid)sender).SelectedItem as PHIEUNHAPSACH;
            if (selected != null)
            {
                //chọn chi tiết trùng với id
                var query = from b in context.CT_PHIEUNHAPSACH
                            where b.SoPNS.Equals(selected.SoPNS)
                            select b;
                ObservableCollection<CT_PHIEUNHAPSACH> data = new ObservableCollection<CT_PHIEUNHAPSACH>(query);
                dataCT.ItemsSource = data;
            }
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }


}

