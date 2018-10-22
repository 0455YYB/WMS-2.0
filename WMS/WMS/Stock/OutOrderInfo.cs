using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS.Stock
{
    public partial class OutOrderInfo : Form
    {
        private static OutOrderInfo outOrderInfo;
        private OutOrderInfo()
        {
            InitializeComponent();
        }

        public static OutOrderInfo GetOutOrderInfo()
        {
            if (outOrderInfo==null||outOrderInfo.IsDisposed)
            {
                outOrderInfo = new OutOrderInfo();
                return outOrderInfo;
            }
            return outOrderInfo;
        }

        private void TSB_createOrder_Click(object sender, EventArgs e)
        {
            OutStockOrder outStockOrder = OutStockOrder.GetOutStockOrder();
            outStockOrder.Show();
        }
    }
}
