using BookstoreNMCNPM.ViewModel;
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

namespace BookstoreNMCNPM.View
{
    /// <summary>
    /// Interaction logic for ViewSwitcher1.xaml
    /// </summary>
    public partial class ViewSwitcher1 : UserControl
    {
        public ViewSwitcher1()
        {
            InitializeComponent();
            Switcher.viewSwitcher1 = this;

            /// Startup View
            Switcher.Switch1(new view());
        }
        public void Trans1(UserControl nextView)
        {
            this.Content = nextView;
        }
    }
}
