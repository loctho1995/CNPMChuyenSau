﻿using gMVVM.ViewModels.AssCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace gMVVM.Views.AssCommon
{
    public partial class ArgumentEdit : UserControl
    {
        private ArgumentEditViewModel viewModel = new ArgumentEditViewModel();
        public ArgumentEdit()
        {
            InitializeComponent();
            this.Loaded += (s, e) => { this.DataContext = this.viewModel; };
        }
    }
}