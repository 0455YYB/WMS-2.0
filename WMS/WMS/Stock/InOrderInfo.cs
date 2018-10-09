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

        private void TSB_createOrder_Click(object sender, EventArgs e)
        {
            InStockOrder inStockOrder = InStockOrder.GetInStockOrder();
            inStockOrder.Show();    
        }

        private void TSB_edit_Click(object sender, EventArgs e)
        {
            if(DGV_order.Rows.Count==0)
            {
                MessageBox.Show("当前无入库单信息");
                return;
            }
            int rowsNmb = DGV_order.CurrentRow.Index;
            if (rowsNmb == -1)
            {
                MessageBox.Show("未选中需要修改的入库单");
                return;
            }
            string orderNmb = DGV_order.Rows[rowsNmb].Cells[0].Value.ToString();
            InStockOrder inStockOrder = new InStockOrder(orderNmb);
            inStockOrder.Show();
        }
    }
}
