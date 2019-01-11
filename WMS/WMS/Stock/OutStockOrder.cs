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
    public partial class OutStockOrder : Form
    {
        private static OutStockOrder outStockOrder;
        DataTable minusIDAndAmount=null;
        DataTable sourceData = null;
        SqlExecute sqlExecute = new SqlExecute();
        private static string sign = "C";

        private OutStockOrder()
        {
            InitializeComponent();
            string loadDeptSql = "select code,name from department where status=0";

        }

        public static OutStockOrder GetOutStockOrder()
        {
            if(outStockOrder==null||outStockOrder.IsDisposed)
            {
                outStockOrder = new OutStockOrder();
                return outStockOrder;
            }
            return outStockOrder;
        }

        public void SearchCodeChang(object sender,EventArgs args)
        {
            string searchCode = CB_searchCode.Text.ToString().Trim();
            string selectBatch = @"select goodscode,goodsname from inorderdetail,instockorder where (goodscode like @searchcode or goodsname like @searchcode) and amount>0 and instockorder.status=1 and inorderdetail.status=1 and instockorder.ordercode=inorderdetail.ordercode order by createtime";
            SQLiteParameter[] sQLiteParameters = new SQLiteParameter[1];
            sQLiteParameters[0] = new SQLiteParameter("@searchcode","%"+ searchCode + "%");
            DataTable detailInfo;
            detailInfo = sqlExecute.SelectInfo(sQLiteParameters, selectBatch);
            int j = detailInfo.Rows.Count;
            if (j > 0)
            {
                CB_searchCode.Items.Clear();
                for (int a = 0; a < j; a++)
                {
                    CB_searchCode.Items.Add(detailInfo.Rows[a]["goodscode"] + "|" + detailInfo.Rows[a]["goodsname"] + "|" );
                }
                CB_searchCode.Focus();
                CB_searchCode.Select(CB_searchCode.Text.Length, 0);
            }
            CB_searchCode.DroppedDown = true;
            CB_searchCode.SelectedIndex = -1;
        }

        public void SelectItem(object sender,EventArgs args)
        {
            if(CB_searchCode.SelectedIndex!=-1)
            {
                string goodsInfo = CB_searchCode.Text.Trim();
                string[] infoArrage = goodsInfo.Split('|');
                string code = infoArrage[0];
                CheckBatch checkBatch = new CheckBatch(code);
                checkBatch.TE += AddTataToTable;
                checkBatch.ShowDialog();
            }
        }

        public void SelectChoice(object sender,EventArgs args)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        private void AddTataToTable(DataTable dataTable)
        {
            if(minusIDAndAmount==null)
            {
                minusIDAndAmount = dataTable.Copy();
            }
            else
            {
                try
                {
                    for(int i=0;i<dataTable.Rows.Count;i++)
                    {
                        minusIDAndAmount.Rows.Add(dataTable.Rows[i].ItemArray);
                    }
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
            for(int i=0;i<dataTable.Rows.Count;i++)
            {
                int newIndex = DGV_outStock.Rows.Add();
                DGV_outStock.Rows[newIndex].Cells[0].Value = dataTable.Rows[i][1].ToString();
                DGV_outStock.Rows[newIndex].Cells[1].Value = dataTable.Rows[i][2].ToString();
                DGV_outStock.Rows[newIndex].Cells[2].Value = dataTable.Rows[i][5].ToString();
                DGV_outStock.Rows[newIndex].Cells[3].Value = dataTable.Rows[i][3].ToString();
                DGV_outStock.Rows[newIndex].Cells[4].Value = dataTable.Rows[i][6].ToString();
            }
            double acountPrice=0;
            for(int i=0;i<DGV_outStock.Rows.Count;i++)
            {
                double amount = double.Parse(DGV_outStock.Rows[i].Cells[3].Value.ToString());
                double price = double.Parse(DGV_outStock.Rows[i].Cells[4].Value.ToString());
                acountPrice += amount * price;
            }
            TB_acountprice.Text = acountPrice + "元";
        }

        private void TSB_save_Click(object sender, EventArgs e)
        {

        }






        //查询药品时弹出datagirdview显示当前有库存的批次按时间排序，填好数确认之后将扣减明细id和数量存放到minusIDAndAmount
    }
}
