﻿using gMVVM;
using mvvmCommon;
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

namespace gMVVM.Views
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            ActionMenuButton.actionControl.SetAllDisable();
        }

    }     
        
}
