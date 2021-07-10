using BookstoreNMCNPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookstoreNMCNPM.View
{
    
    public partial class Books : UserControl
    {
        public Books()
        {
            InitializeComponent();
        }
        QLNSEntities context = new QLNSEntities();

        private ObservableCollection<SACH> getBooks()
        {
            return new ObservableCollection<SACH>(context.SACHes);
        }

        private ObservableCollection<THELOAI> getTheLoai()
        {
            return new ObservableCollection<THELOAI>(context.THELOAIs);
        }

        private ObservableCollection<NHAXUATBAN> getNhaXuatBan()
        {
            return new ObservableCollection<NHAXUATBAN>(context.NHAXUATBANs);
        }



        private void setEnabled()
        {
            btnAdd.IsEnabled = false;
            btnEdit.IsEnabled = false;
            btnSave.IsEnabled = true;
            tbTenSach.IsEnabled = true;
            tbTacGia.IsEnabled = true;
            cbTheLoai.IsEnabled = true;
            cbNhaXuatBan.IsEnabled = true;
        }

        
        private void setMutable()
        {
            btnAdd.IsEnabled = true;
            btnEdit.IsEnabled = true;
            btnSave.IsEnabled = false;
            tbTenSach.IsEnabled = false;
            tbTacGia.IsEnabled = false;
            cbTheLoai.IsEnabled = false;
            cbNhaXuatBan.IsEnabled = false;
        }

        private void setClear()
        {
            tbMaSach.Clear();
            tbTenSach.Clear();
            tbTacGia.Clear();
            cbTheLoai.Text = "";
            cbNhaXuatBan.Text = "";
        }

       
        private void btnaddBook_Click(object sender, RoutedEventArgs e)
        {
            dataBooks.SelectedItem = null;
            if (!tbTenSach.IsEnabled)
            {
                
                setClear();
                setEnabled();
                tbMaSach.Text = (getBooks().Count).ToString();
                dataBooks.IsEnabled = false;
            }
            else
            {
                setMutable();
                dataBooks.IsEnabled = true;
            }
        }

        
        private bool isNull()
        {
            if (!String.IsNullOrEmpty(tbMaSach.Text)
                && !String.IsNullOrEmpty(tbTenSach.Text)
                && !String.IsNullOrEmpty(tbTacGia.Text)
                && !String.IsNullOrEmpty(cbTheLoai.Text)
                && !String.IsNullOrEmpty(cbNhaXuatBan.Text))
                return false;
            return true;
        }

        
        private void btnsaveBook_Click(object sender, RoutedEventArgs e)
        {
            SACH sach = new SACH();
            SACH text = new SACH();
            if (!isNull())
            {
                text = context.SACHes.Find(Convert.ToInt32(tbMaSach.Text));
                if (text == null)
                {
                    var Confirm = MessageBox.Show("Bạn có chắc muốn thêm sách " + tbTenSach.Text + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (Confirm == MessageBoxResult.Yes)
                    {
                        var find = Convert.ToInt32(tbMaSach.Text);
                        if (context.SACHes.Find(find) == null)
                        {
                            sach.MaSach = Convert.ToInt32(tbMaSach.Text);

                            sach.TenSach = tbTenSach.Text;
                            sach.TacGia = tbTacGia.Text;

                            sach.THELOAI = cbTheLoai.SelectedValue as THELOAI;
                            sach.NHAXUATBAN = cbNhaXuatBan.SelectedValue as NHAXUATBAN;

                            context.SACHes.Add(sach);
                            context.SaveChanges();

                            dataBooks.ItemsSource = getBooks();
                            setMutable();
                            dataBooks.IsEnabled = true;
                        }
                        else
                            MessageBox.Show("Mã sách không được trùng", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    var Confirm = MessageBox.Show("Bạn có chắc muốn sửa sách " + tbTenSach.Text + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (Confirm == MessageBoxResult.Yes)
                    {
                        sach = context.SACHes.Find(Convert.ToInt32(tbMaSach.Text));

                        sach.TenSach = tbTenSach.Text;
                        sach.TacGia = tbTacGia.Text;

                        sach.THELOAI = cbTheLoai.SelectedValue as THELOAI;
                        sach.NHAXUATBAN = cbNhaXuatBan.SelectedValue as NHAXUATBAN;

                        context.SaveChanges();

                        dataBooks.ItemsSource = getBooks();

                        MessageBox.Show("Sửa sách thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);

                        setMutable();
                        dataBooks.IsEnabled = true;
                    }
                }
                setMutable();
            }
            else
                MessageBox.Show("Không được để trống!", "Sách", MessageBoxButton.OK, MessageBoxImage.Information);
        }

      
        private void btndeleteBook_Click(object sender, RoutedEventArgs e)
        {
            Button seleted = (Button)sender;
            var item = seleted.DataContext as SACH;
            var DeleteRecord = MessageBox.Show("Bạn có chắc chắn muốn xóa sách " + item.TenSach + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (DeleteRecord == MessageBoxResult.Yes)
            {
                try
                {
                    context.SACHes.Remove(item);
                    context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Không được xóa", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

                
                dataBooks.ItemsSource = getBooks();
                }
        }

       
        private void btnupdateBook_Click(object sender, RoutedEventArgs e)
        {
            if (dataBooks.SelectedItem == null)
                MessageBox.Show("Hãy chọn sách để sửa!", "Sách", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
                setEnabled();
        }

        
        private void Books_Loaded(object sender, RoutedEventArgs e)
        {
            dataBooks.ItemsSource = getBooks();

            cbTheLoai.ItemsSource = getTheLoai();
            cbTheLoai.DisplayMemberPath = "TenTheLoai";

            cbNhaXuatBan.ItemsSource = getNhaXuatBan();
            cbNhaXuatBan.DisplayMemberPath = "TenNhaXuatBan";
        }
    }
}
