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

using System.Collections.ObjectModel;
using BookstoreNMCNPM.Model;

namespace BookstoreNMCNPM.View
{
    
    public partial class BookInfo : UserControl
    {
        QLNSEntities context = new QLNSEntities();
        bool isInsertMode = false;
        bool isBeingEdited = false;

        bool isInsertMode2 = false;
        bool isBeingEdited2 = false;

        public BookInfo()
        {
            InitializeComponent();
        }

       

       

        private void theLoai_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            dataTheLoai.ItemsSource = getTheLoai();
        }

        private ObservableCollection<THELOAI> getTheLoai()
        {
            return new ObservableCollection<THELOAI>(context.THELOAIs);
        }

        private void theLoai_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var selected = e.Row.DataContext as THELOAI;
            if (selected.MaTheLoai == 0)
            {
                THELOAI theloai = new THELOAI();
                selected.MaTheLoai = getTheLoai().Count + 1;
                if (isInsertMode)
                {
                    var InsertRecord = MessageBox.Show("Bạn có chắc chắn muốn thêm thể loại " + selected.TenTheLoai + " không?", "Lưu ý mã thể loại phải khác nhau", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (InsertRecord == MessageBoxResult.Yes)
                    {
                        theloai.MaTheLoai = selected.MaTheLoai;
                        theloai.TenTheLoai = selected.TenTheLoai;

                        if (context.THELOAIs.Find(theloai.MaTheLoai) == null)
                        {
                            context.THELOAIs.Add(theloai);
                            context.SaveChanges();
                            dataTheLoai.ItemsSource = getTheLoai();
                        }
                        else
                        {
                            MessageBox.Show("Mã thể loại không được trùng!", "Thể loại", MessageBoxButton.OK, MessageBoxImage.Warning);
                            dataTheLoai.ItemsSource = getTheLoai();
                        }
                    }
                    else
                        dataTheLoai.ItemsSource = getTheLoai();
                }
            }
            else
            {
                var edit = context.THELOAIs.Find(selected.MaTheLoai);
                if (edit != null)
                {
                    var EditRecord = MessageBox.Show("Bạn có chắc chắn muốn sửa thành " + selected.TenTheLoai + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (EditRecord == MessageBoxResult.Yes)
                    {
                        if (!String.IsNullOrWhiteSpace(selected.TenTheLoai))
                        {
                            edit.TenTheLoai = selected.TenTheLoai;
                            context.SaveChanges();
                            dataTheLoai.ItemsSource = getTheLoai();
                        }
                        else
                        {
                            MessageBox.Show("Tên thể loại không được để trống!", "Thể loại", MessageBoxButton.OK, MessageBoxImage.Warning);
                            dataTheLoai.ItemsSource = getTheLoai();
                        }
                    }
                    else
                        dataTheLoai.ItemsSource = getTheLoai();
                }
            }    
        }

        private void theLoai_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            isBeingEdited = true;
        }

        private void theLoai_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            isInsertMode = true;
        }

        // Xóa
        private void deleteTheLoai(object sender, RoutedEventArgs e)
        {
            Button seleted = (Button)sender;
            var item = seleted.DataContext as THELOAI;
            if (item != null)
            {
                var DeleteRecord = MessageBox.Show("Bạn có chắc chắn muốn xóa " + item.TenTheLoai + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (DeleteRecord == MessageBoxResult.Yes)
                {
                    try
                    {
                        context.THELOAIs.Remove(item);
                        context.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Không xóa được!", "Thể loại", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    dataTheLoai.ItemsSource = getTheLoai();
                }
            }
            else
                MessageBox.Show("Có gì đâu mà xóa!", "Thể loại", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        

        private void nhaXuatBan_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            dataNhaXuatBan.ItemsSource = getNhaXuatBan();
        }

        private ObservableCollection<NHAXUATBAN> getNhaXuatBan()
        {
            return new ObservableCollection<NHAXUATBAN>(context.NHAXUATBANs);
        }

        // Thêm
        private void nhaXuatBan_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var selected = e.Row.DataContext as NHAXUATBAN;
            if (selected.MaNhaXuatBan == 0)
            {
                selected.MaNhaXuatBan = getNhaXuatBan().Count + 1;
                NHAXUATBAN nhaxuatban = new NHAXUATBAN();
                if (isInsertMode2)
                {
                    var InsertRecord = MessageBox.Show("Bạn có chắc chắn muốn thêm nhà xuất bản " + selected.TenNhaXuatBan + " không?", "Lưu ý mã nhà xuất bản phải khác nhau", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (InsertRecord == MessageBoxResult.Yes)
                    {
                        nhaxuatban.MaNhaXuatBan = selected.MaNhaXuatBan;
                        nhaxuatban.TenNhaXuatBan = selected.TenNhaXuatBan;


                        if (context.NHAXUATBANs.Find(nhaxuatban.MaNhaXuatBan) == null)
                        {
                            context.NHAXUATBANs.Add(nhaxuatban);
                            context.SaveChanges();
                            dataNhaXuatBan.ItemsSource = getNhaXuatBan();
                        }
                        else
                        {
                            MessageBox.Show("Mã nhà xuất bản không được trùng!", "Nhà xuất bản", MessageBoxButton.OK, MessageBoxImage.Warning);
                            dataNhaXuatBan.ItemsSource = getNhaXuatBan();
                        }
                    }
                    else
                        dataNhaXuatBan.ItemsSource = getNhaXuatBan();
                }
            }
            else
            {
                var edit = context.NHAXUATBANs.Find(selected.MaNhaXuatBan);
                if (edit != null)
                {
                    var EditRecord = MessageBox.Show("Bạn có chắc chắn muốn sửa thành " + selected.TenNhaXuatBan + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (EditRecord == MessageBoxResult.Yes)
                    {
                        if (!String.IsNullOrWhiteSpace(selected.TenNhaXuatBan))
                        {
                            edit.TenNhaXuatBan = selected.TenNhaXuatBan;
                            context.SaveChanges();
                            dataNhaXuatBan.ItemsSource = getNhaXuatBan();
                        }
                        else
                        {
                            MessageBox.Show("Tên nhà xuất bản không được để trống!", "Nhà xuất bản", MessageBoxButton.OK, MessageBoxImage.Warning);
                            dataNhaXuatBan.ItemsSource = getNhaXuatBan();
                        }
                    }
                    else
                        dataNhaXuatBan.ItemsSource = getNhaXuatBan();

                }
            }    
        }

        private void nhaXuatBan_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            isBeingEdited2 = true;
        }
        private void nhaXuatBan_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            isInsertMode2 = true;
        }

        // Xóa
        private void deleteNhaXuatBan(object sender, RoutedEventArgs e)
        {
            Button seleted = (Button)sender;
            var item = seleted.DataContext as NHAXUATBAN;
            if (item != null)
            {
                var DeleteRecord = MessageBox.Show("Bạn có chắc chắn muốn xóa " + item.TenNhaXuatBan + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (DeleteRecord == MessageBoxResult.Yes)
                {
                    try
                    {
                        context.NHAXUATBANs.Remove(item);
                        context.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Không xóa được!", "Thể loại", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    dataNhaXuatBan.ItemsSource = getNhaXuatBan();
                }
            }
            else
                MessageBox.Show("Có gì đâu mà xóa!", "Nhà Xuất Bản", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
            
}