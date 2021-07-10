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
    /// Interaction logic for SearchBook.xaml
    /// </summary>
    public partial class SearchBook : UserControl
    {
        public SearchBook()
        {
            InitializeComponent();
        }

        QLNSEntities context = new QLNSEntities();
        private void btnSearch_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var search = from b in context.SACHes
                         where b.TenSach.Contains(tbSearch.Text)
                         select b;
            ObservableCollection<SACH> data = new ObservableCollection<SACH>(search);
            dataSearch.ItemsSource = data;
        }
    }
}
