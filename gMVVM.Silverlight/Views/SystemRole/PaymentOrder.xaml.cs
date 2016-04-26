using gMVVM.CommonClass;
using gMVVM.ViewModels.SystemRole;
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

namespace gMVVM.Views.SystemRole
{
    public partial class PaymentOrder:UserControl
    {
        private PaymentOrderViewModel viewModel;
        public PaymentOrder()
        {
            InitializeComponent();

            List<AccountingData> data = new List<AccountingData>();
            data.Add(new AccountingData { Content = "content 1", CreditAccount = "Credit 1", DebitAccount = "Debit 1" });

            dataGrid.ItemsSource = data;
            

            PageAnimation.SetObject(front, back);
            viewModel = new PaymentOrderViewModel();
            this.Loaded += (s, e) => { this.DataContext = this.viewModel; };
        }
    }
}
