﻿#pragma checksum "..\..\..\View\Books.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E60FFD61AF80CE277F24013E830B9B4854F8C33595243C3B70C307F99EB61B9F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BookstoreNMCNPM.View;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BookstoreNMCNPM.View {
    
    
    /// <summary>
    /// Books
    /// </summary>
    public partial class Books : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 32 "..\..\..\View\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMaSach;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\View\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTenSach;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\View\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTacGia;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\View\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTheLoai;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\View\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbNhaXuatBan;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\View\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\View\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\View\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataBooks;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BookstoreNMCNPM;component/view/books.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Books.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\View\Books.xaml"
            ((BookstoreNMCNPM.View.Books)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Books_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbMaSach = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbTenSach = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbTacGia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cbTheLoai = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cbNhaXuatBan = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\View\Books.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnaddBook_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\View\Books.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnsaveBook_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\View\Books.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnupdateBook_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dataBooks = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 11:
            
            #line 82 "..\..\..\View\Books.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btndeleteBook_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

