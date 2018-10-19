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
            DGV_order.AutoGenerateColumns = false;
            DGV_orderDetail.AutoGenerateColumns = false;
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
            string status = DGV_order.Rows[rowsNmb].Cells[1].Value.ToString();
            if(status!="新制")
            {
                MessageBox.Show("非新制单据无法修改");
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

            string searchSQL=String.Empty;
            SQLiteParameter[] sQLiteParameters = new SQLiteParameter[3];
            sQLiteParameters[0] = new SQLiteParameter("@startime", starTime);
            sQLiteParameters[1] = new SQLiteParameter("@endtime", endTime);
            sQLiteParameters[2] = new SQLiteParameter("@ordertype",DbType.String);
            string type=CB_type.Text.ToString();
            if(type=="")
            {
                searchSQL = @"select ordercode,(case status when 0 then '新制'  when 1 then '审核'   end)  status from instockorder where createtime between @startime and @endtime and status in (0,1);";
            }
            else
            {
                sQLiteParameters[2].Value = type;
                searchSQL = @"select ordercode,(case status when 0 then '新制'  when 1 then '审核'   end)  status from instockorder where createtime between @startime and @endtime and status in (0,1)  and type=@ordertype;";
            }
            DataTable orderInfo = sqlExecute.SelectInfo(sQLiteParameters, searchSQL);
            if(orderInfo!=null)
            {
                DGV_order.DataSource = orderInfo;
                DGV_order.Columns["column1"].DataPropertyName = orderInfo.Columns["ordercode"].ToString();
                DGV_order.Columns["column2"].DataPropertyName = orderInfo.Columns["status"].ToString();

                string ordercode = orderInfo.Rows[0][0].ToString();
                LoadDGV_orderDetail(ordercode);
            }
            else
            {
                MessageBox.Show("未查到符合条件的单据");
                return;
            }

        }

        private void DGV_order_CellClick(object sender,EventArgs args)
        {
            int rowNum = DGV_order.CurrentRow.Index;
            string ordercode = DGV_order.Rows[rowNum].Cells[0].Value.ToString();
            LoadDGV_orderDetail(ordercode);
        }

        private void LoadDGV_orderDetail(string ordercode)
        {
            string loadOrderDetail = @"select goodscode,goodsname,amount,goodsunit,goodsprice,batch from inorderdetail where ordercode='" + ordercode + "'; ";
            DataTable detailInfo = sqlExecute.LoadInfo(loadOrderDetail);
            DGV_orderDetail.AutoGenerateColumns = false;
            DGV_orderDetail.DataSource = detailInfo;
            DGV_orderDetail.Columns["goodscode"].DataPropertyName = detailInfo.Columns["goodscode"].ToString();
            DGV_orderDetail.Columns["goodsname"].DataPropertyName = detailInfo.Columns["goodsname"].ToString();
            DGV_orderDetail.Columns["amount"].DataPropertyName = detailInfo.Columns["amount"].ToString();
            DGV_orderDetail.Columns["goodsunit"].DataPropertyName = detailInfo.Columns["goodsunit"].ToString();
            DGV_orderDetail.Columns["goodsprice"].DataPropertyName = detailInfo.Columns["goodsprice"].ToString();
            DGV_orderDetail.Columns["batch"].DataPropertyName = detailInfo.Columns["batch"].ToString();

            Double sumPrice = 0;
            for (int i = 0; i < detailInfo.Rows.Count; i++)
            {
                Double price = Double.Parse(detailInfo.Rows[i]["goodsprice"].ToString());
                Double amount = Double.Parse(detailInfo.Rows[i]["amount"].ToString());
                sumPrice += price * amount;
            }
            TB_sumPrice.Text = sumPrice.ToString();
        }

        private void TSB_auditing_Click(object sender, EventArgs e)
        {
            int rowsNum = DGV_order.CurrentRow.Index;
            string ordercode = string.Empty;
            if (rowsNum!=-1)
            {
                ordercode = DGV_order.Rows[rowsNum].Cells[0].Value.ToString();
                SQLiteParameter[] sQLiteParameters = new SQLiteParameter[1];
                sQLiteParameters[0] = new SQLiteParameter("@ordercode", ordercode);
                string auditingSQL = @"update inorderdetail set status=1 where ordercode=@ordercode";
                int updateDetail = sqlExecute.Execute(sQLiteParameters, auditingSQL);
                if(updateDetail!=0)
                {
                    auditingSQL = @"update instockorder set status =1 where ordercode=@ordercode";
                    int a = sqlExecute.Execute(sQLiteParameters, auditingSQL);
                }
                else
                {
                    MessageBox.Show("审核失败");
                }
            }
            else
            {
                MessageBox.Show("请选择需要审核的入库单");
            }
        }
    }
}
