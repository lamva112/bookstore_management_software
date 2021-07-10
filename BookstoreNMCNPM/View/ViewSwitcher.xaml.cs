﻿using BookstoreNMCNPM.ViewModel;
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
    /// Interaction logic for ViewSwitcher.xaml
    /// </summary>
    public partial class ViewSwitcher : UserControl
    {
        public ViewSwitcher()
        {
            InitializeComponent();
            Switcher.viewSwitcher = this;

            /// Startup View
            Switcher.Switch(new view());
        }
        public void Trans(UserControl nextView)
        {
            this.Content = nextView;
        }
    }
}
