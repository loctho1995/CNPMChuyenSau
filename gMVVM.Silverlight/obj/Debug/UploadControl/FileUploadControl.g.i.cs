﻿#pragma checksum "D:\GSOFT\Project\SCB\Taisandambao\WIP\Program\gAMS_Sacombank.Silverlight\UploadControl\FileUploadControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AE66FCB7BF1BB267338DB8E644840B53"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
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


namespace Gsoft.FileUpload {
    
    
    public partial class FileUploaGsoftontrol : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Border controlBorder;
        
        internal System.Windows.Controls.Grid fileUploadGrid;
        
        internal System.Windows.Controls.ScrollViewer filesScrollViewer;
        
        internal System.Windows.Controls.ItemsControl fileList;
        
        internal System.Windows.Controls.TextBlock countTextBlock;
        
        internal System.Windows.Controls.TextBlock totalSizeTextBlock;
        
        internal System.Windows.Controls.ProgressBar progressBar;
        
        internal System.Windows.Controls.TextBlock timeLeftTextBlock;
        
        internal System.Windows.Controls.Button addFilesButton;
        
        internal System.Windows.Controls.Button uploadButton;
        
        internal System.Windows.Controls.Button clearFilesButton;
        
        internal System.Windows.Controls.CheckBox displayThumbailChckBox;
        
        internal System.Windows.Controls.Button OkFilesButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/gAMS_Sacombank;component/UploadControl/FileUploadControl.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.controlBorder = ((System.Windows.Controls.Border)(this.FindName("controlBorder")));
            this.fileUploadGrid = ((System.Windows.Controls.Grid)(this.FindName("fileUploadGrid")));
            this.filesScrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("filesScrollViewer")));
            this.fileList = ((System.Windows.Controls.ItemsControl)(this.FindName("fileList")));
            this.countTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("countTextBlock")));
            this.totalSizeTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("totalSizeTextBlock")));
            this.progressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar")));
            this.timeLeftTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("timeLeftTextBlock")));
            this.addFilesButton = ((System.Windows.Controls.Button)(this.FindName("addFilesButton")));
            this.uploadButton = ((System.Windows.Controls.Button)(this.FindName("uploadButton")));
            this.clearFilesButton = ((System.Windows.Controls.Button)(this.FindName("clearFilesButton")));
            this.displayThumbailChckBox = ((System.Windows.Controls.CheckBox)(this.FindName("displayThumbailChckBox")));
            this.OkFilesButton = ((System.Windows.Controls.Button)(this.FindName("OkFilesButton")));
        }
    }
}

