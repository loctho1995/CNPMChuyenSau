using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace gMVVM.CommonClass
{
    public class AccountingData
    {
        public string Content
        { get; set; }

        //Tài khoản có
        public string CreditAccount
        { get; set; }

        //Tài khoản nợ
        public string DebitAccount
        { get; set; }
    }
}
