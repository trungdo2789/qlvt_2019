﻿#pragma checksum "..\..\AddHoaDon.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C97C5B0AD6BDEECDFB1D59514C3EA6820929C12B62FA04F0AB74A7128B58DEA8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// AddHoaDon
    /// </summary>
    public partial class AddHoaDon : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\AddHoaDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblTitle;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddHoaDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxKho;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddHoaDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgKho;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddHoaDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxKhachHang;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddHoaDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgKhachhang;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddHoaDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbVT;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddHoaDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgMatHang;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AddHoaDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCTAdd;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AddHoaDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCTRemove;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\AddHoaDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCTHD;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\AddHoaDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/addhoadon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddHoaDon.xaml"
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
            this.tblTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.tbxKho = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\AddHoaDon.xaml"
            this.tbxKho.KeyUp += new System.Windows.Input.KeyEventHandler(this.tbxKho_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgKho = ((System.Windows.Controls.DataGrid)(target));
            
            #line 17 "..\..\AddHoaDon.xaml"
            this.dgKho.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgKho_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbxKhachHang = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\AddHoaDon.xaml"
            this.tbxKhachHang.KeyUp += new System.Windows.Input.KeyEventHandler(this.tbxKhachHang_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgKhachhang = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\AddHoaDon.xaml"
            this.dgKhachhang.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgKhachhang_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txbVT = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\AddHoaDon.xaml"
            this.txbVT.KeyUp += new System.Windows.Input.KeyEventHandler(this.txbVT_KeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dgMatHang = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.btnCTAdd = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\AddHoaDon.xaml"
            this.btnCTAdd.Click += new System.Windows.RoutedEventHandler(this.btnCTAdd_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnCTRemove = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\AddHoaDon.xaml"
            this.btnCTRemove.Click += new System.Windows.RoutedEventHandler(this.btnCTRemove_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dgCTHD = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\AddHoaDon.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.btnOk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

