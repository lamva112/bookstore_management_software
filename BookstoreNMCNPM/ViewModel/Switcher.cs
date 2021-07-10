using BookstoreNMCNPM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BookstoreNMCNPM.ViewModel
{
    class Switcher
    {
        public static ViewSwitcher viewSwitcher;
        public static ViewSwitcher1 viewSwitcher1;

        public static void Switch(UserControl newPage)
        {
            viewSwitcher.Trans(newPage);
        }
        public static void Switch1(UserControl newPage)
        {
            viewSwitcher1.Trans1(newPage);
        }
    }
}
