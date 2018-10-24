using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WMS.Stock
{
    public partial class OutStockOrder : Form
    {
        private static OutStockOrder outStockOrder;
        DataTable minusIDAndAmount=null;

        private OutStockOrder()
        {
            InitializeComponent();
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
        }


 

      

        //查询药品时弹出datagirdview显示当前有库存的批次按时间排序，填好数确认之后将扣减明细id和数量存放到minusIDAndAmount
    }
}
