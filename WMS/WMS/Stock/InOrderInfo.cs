using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS.storge
{
    public partial class OrderInfo : Form
    {
        private static OrderInfo orderInfo;
        private OrderInfo()
        {
            InitializeComponent();
        }

        public static OrderInfo  GetInOrderInfo()
        {
            if(orderInfo==null||orderInfo.IsDisposed)
            {
                orderInfo = new OrderInfo();
                return orderInfo;
            }
            return orderInfo;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
