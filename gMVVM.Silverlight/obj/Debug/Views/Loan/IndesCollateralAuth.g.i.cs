﻿#pragma checksum "E:\GSOFT\Projects\Asset Management\WIP\Program\mvvmSilverlight\SilverlightProject1\Views\Loan\IndesCollateralAuth.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6E7D0332F48BCB60FFC99C5ABDD10677"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EduBanking.Silverlight;
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


namespace EduBanking.Silverlight.Views.Loan {
    
    
    public partial class IndesCollateralAuth : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid front;
        
        internal EduBanking.Silverlight.ChangeDate ShortDate;
        
        internal EduBanking.Silverlight.ChangeText FormatPrice;
        
        internal System.Windows.Controls.StackPanel splHeader;
        
        internal DataGrid dgdCL_TRAN;
        
        internal System.Windows.Controls.Grid back;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AssetManagement;component/Views/Loan/IndesCollateralAuth.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.front = ((System.Windows.Controls.Grid)(this.FindName("front")));
            this.ShortDate = ((EduBanking.Silverlight.ChangeDate)(this.FindName("ShortDate")));
            this.FormatPrice = ((EduBanking.Silverlight.ChangeText)(this.FindName("FormatPrice")));
            this.splHeader = ((System.Windows.Controls.StackPanel)(this.FindName("splHeader")));
            this.dgdCL_TRAN = ((DataGrid)(this.FindName("dgdCL_TRAN")));
            this.back = ((System.Windows.Controls.Grid)(this.FindName("back")));
        }
    }
}

