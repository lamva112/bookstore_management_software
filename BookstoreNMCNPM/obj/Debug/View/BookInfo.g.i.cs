﻿#pragma checksum "..\..\..\View\BookInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CA90B8C482D6B6A2B1F12B7EBE3438E0BEC3541D3534EA4F317FBE008282E88C"
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
    /// BookInfo
    /// </summary>
    public partial class BookInfo : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 25 "..\..\..\View\BookInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataTheLoai;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\View\BookInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataNhaXuatBan;
        
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
            System.Uri resourceLocater = new System.Uri("/BookstoreNMCNPM;component/view/bookinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\BookInfo.xaml"
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
            this.dataTheLoai = ((System.Windows.Controls.DataGrid)(target));
            
            #line 26 "..\..\..\View\BookInfo.xaml"
            this.dataTheLoai.Loaded += new System.Windows.RoutedEventHandler(this.theLoai_Loaded);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\View\BookInfo.xaml"
            this.dataTheLoai.CellEditEnding += new System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>(this.theLoai_CellEditEnding);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\View\BookInfo.xaml"
            this.dataTheLoai.AddingNewItem += new System.EventHandler<System.Windows.Controls.AddingNewItemEventArgs>(this.theLoai_AddingNewItem);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\View\BookInfo.xaml"
            this.dataTheLoai.BeginningEdit += new System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>(this.theLoai_BeginningEdit);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataNhaXuatBan = ((System.Windows.Controls.DataGrid)(target));
            
            #line 52 "..\..\..\View\BookInfo.xaml"
            this.dataNhaXuatBan.Loaded += new System.Windows.RoutedEventHandler(this.nhaXuatBan_Loaded);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\View\BookInfo.xaml"
            this.dataNhaXuatBan.CellEditEnding += new System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>(this.nhaXuatBan_CellEditEnding);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\View\BookInfo.xaml"
            this.dataNhaXuatBan.AddingNewItem += new System.EventHandler<System.Windows.Controls.AddingNewItemEventArgs>(this.nhaXuatBan_AddingNewItem);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\View\BookInfo.xaml"
            this.dataNhaXuatBan.BeginningEdit += new System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>(this.nhaXuatBan_BeginningEdit);
            
            #line default
            #line hidden
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
            case 2:
            
            #line 37 "..\..\..\View\BookInfo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.deleteTheLoai);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 63 "..\..\..\View\BookInfo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.deleteNhaXuatBan);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

