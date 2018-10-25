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
    public delegate void transEvent(DataTable dt);
    public partial class CheckBatch : Form
    {
        public event transEvent TE;
        DataTable batch;
        string goodscode;
        SqlExecute sqlExecute = new SqlExecute();

        public CheckBatch(string code)
        {
            InitializeComponent();
            goodscode = code;
            LoadBatch(goodscode);
            DGV_batchDetail.AutoGenerateColumns = false;
        }

        private void BT_sureBatch_Click(object sender, EventArgs e)
        {
            for(int i=0;i<DGV_batchDetail.Rows.Count; i++)
            {
                double outAmount = double.Parse(DGV_batchDetail.Rows[i].Cells[4].Value.ToString().Trim());
                if(outAmount>0)
                {
                    DataRow dr = batch.NewRow();
                    dr["detailid"] = DGV_batchDetail.Rows[i].Cells[0].Value.ToString();
                    dr["goodscode"] = DGV_batchDetail.Rows[i].Cells[1].Value.ToString();
                    dr["goodsname"] = DGV_batchDetail.Rows[i].Cells[2].Value.ToString();
                    dr["outamount"] = outAmount;
                    dr["goodsunit"] = DGV_batchDetail.Rows[i].Cells[5].Value.ToString();
                    dr["goodsprice"] = DGV_batchDetail.Rows[i].Cells[6].Value.ToString();
                    batch.Rows.Add(dr);
                }
            }
            TE(batch);
            batch.Clear();
            this.Dispose();
        }

        public void LoadBatch(string goodscode)
        {
            string loadBatchSQL = @"select detailid,goodscode,goodsname,amount,goodsunit,goodsprice from inorderdetail where goodscode=@goodscode and status=1 and amount>0 order by detailid";
            SQLiteParameter[] sQLiteParameter = new SQLiteParameter[1];
            sQLiteParameter[0] = new SQLiteParameter("@goodscode",goodscode);
            batch = sqlExecute.SelectInfo(sQLiteParameter, loadBatchSQL);
            DGV_batchDetail.DataSource = batch;
            DGV_batchDetail.Columns["detailid"].DataPropertyName = batch.Columns["detailid"].ToString();
            DGV_batchDetail.Columns["goodscode1"].DataPropertyName = batch.Columns["goodscode"].ToString();
            DGV_batchDetail.Columns["goodsname"].DataPropertyName = batch.Columns["goodsname"].ToString();
            DGV_batchDetail.Columns["amount"].DataPropertyName = batch.Columns["amount"].ToString();
            DGV_batchDetail.Columns["goodsunit"].DataPropertyName = batch.Columns["goodsunit"].ToString();
            DGV_batchDetail.Columns["goodsprice"].DataPropertyName = batch.Columns["goodsprice"].ToString();
        }
    }
}
