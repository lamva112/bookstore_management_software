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
    /// Interaction logic for Setting.xaml
    /// </summary>
    public partial class Setting : UserControl
    {
        public Setting()
        {
            InitializeComponent();
        }
        QLNSEntities context = new QLNSEntities();
        private ObservableCollection<THAMSO> getThamso()
        {
            return new ObservableCollection<THAMSO>(context.THAMSOes);
        }

        private void ThamSo_Load(object sender, RoutedEventArgs e)
        {
            tbSLNhapToiThieu.Text = getThamso()[0].SoLuongNhapToiThieu.ToString();
            tbSLTonToiDa.Text = getThamso()[0].SoLuongTonToiDa.ToString();
            tbSLTonToiThieu.Text = getThamso()[0].SoLuongTonToiThieu.ToString();
            tbSoTienNoToiDa.Text = getThamso()[0].SoTienNoToiDa.ToString();
            tbMatKhauAdmin.Text = getThamso()[0].MatKhauAdmin.ToString();
            tbMatKhauNV.Text = getThamso()[0].MatKhauNV.ToString();
            setMutable();
        }
        private void setMutable()
        {
            tbSoTienNoToiDa.IsEnabled = false;
            tbSLTonToiThieu.IsEnabled = false;
            tbSLTonToiDa.IsEnabled = false;
            tbSLNhapToiThieu.IsEnabled = false;
            tbMatKhauAdmin.IsEnabled = false;
            tbMatKhauNV.IsEnabled = false;
        }
        private void setEnable()
        {
            tbSoTienNoToiDa.IsEnabled = true;
            tbSLTonToiThieu.IsEnabled = true;
            tbSLTonToiDa.IsEnabled = true;
            tbSLNhapToiThieu.IsEnabled = true;
            tbMatKhauAdmin.IsEnabled = true;
            tbMatKhauNV.IsEnabled = true;
        }
        private bool isNull()
        {
            if (!String.IsNullOrEmpty(tbSLNhapToiThieu.Text)
                && !String.IsNullOrEmpty(tbSLTonToiDa.Text)
                && !String.IsNullOrEmpty(tbSLTonToiThieu.Text)
                && !String.IsNullOrEmpty(tbSoTienNoToiDa.Text)
                && !String.IsNullOrEmpty(tbMatKhauAdmin.Text)
                && !String.IsNullOrEmpty(tbMatKhauNV.Text))
                return false;
            return true;
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            setEnable();
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (isNull())
                MessageBox.Show("Không được để trống quy định nào!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                THAMSO thamso = new THAMSO();
                thamso.ApDungQD4 = "1";
                thamso = context.THAMSOes.Find(thamso.ApDungQD4);
                thamso.SoLuongNhapToiThieu = Convert.ToInt32(tbSLNhapToiThieu.Text);
                thamso.SoLuongTonToiThieu = Convert.ToInt32(tbSLTonToiThieu.Text);
                thamso.SoLuongTonToiDa = Convert.ToInt32(tbSLTonToiDa.Text);
                thamso.SoTienNoToiDa = Convert.ToInt32(tbSoTienNoToiDa.Text);
                thamso.MatKhauAdmin = tbMatKhauAdmin.Text;
                thamso.MatKhauNV = tbMatKhauNV.Text;
                thamso.ApDungQD4 = "1";
                context.SaveChanges();
                setMutable();
                MessageBox.Show("Thay đổi quy định thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


    }
}
