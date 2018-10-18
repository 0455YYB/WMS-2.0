using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using WMS.SQLHelper;

namespace WMS.Stock
{
    public partial class OrderInfo : Form
    {
        private static OrderInfo orderInfo;
        private static SqlExecute sqlExecute = new SqlExecute();
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
            In_StockOrder inStockOrder = In_StockOrder.GetInStockOrder();
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
            In_StockOrder inStockOrder = new In_StockOrder(orderNmb);
            inStockOrder.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string dateNmber = DateTime.Now.ToString("yyyyMMdd");
            string star = DTP_startTime.Value.ToString("yyyy-MM-dd");
            DateTime starTime = DateTime.Parse(star);
            DateTime endTime = DTP_endTime.Value;

            string searchSQL = @"select ordercode,(case status when 0 then '新制'  when 1 then '审核'   end)  status from instockorder where createtime between @startime and @endtime;";
            SQLiteParameter[] sQLiteParameters = new SQLiteParameter[];
        }
    }
}
