﻿#pragma checksum "E:\GSOFT\Projects\NewCode\gAMS_Sacombank\gAMS_Sacombank.Silverlight\Views\Statistics\Report.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CBF6A4D016130BCA335D71BDA112C119"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace gAMS_Sacombank.Views.Statistics {
    
    
    public partial class Report : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button btn_ReportKHBC05;
        
        internal System.Windows.Controls.Label KHBC05;
        
        internal System.Windows.Controls.TextBox txt_BrandID;
        
        internal System.Windows.Controls.TextBox txt_YEAR;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/gAMS_Sacombank;component/Views/Statistics/Report.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.btn_ReportKHBC05 = ((System.Windows.Controls.Button)(this.FindName("btn_ReportKHBC05")));
            this.KHBC05 = ((System.Windows.Controls.Label)(this.FindName("KHBC05")));
            this.txt_BrandID = ((System.Windows.Controls.TextBox)(this.FindName("txt_BrandID")));
            this.txt_YEAR = ((System.Windows.Controls.TextBox)(this.FindName("txt_YEAR")));
        }
    }
}
