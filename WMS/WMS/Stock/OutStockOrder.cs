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
    public partial class OutStockOrder : Form
    {
        private static OutStockOrder outStockOrder;
        DataTable minusIDAndAmount;
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

        //查询药品时弹出datagirdview显示当前有库存的批次按时间排序，填好数确认之后将扣减明细id和数量存放到minusIDAndAmount
    }
}
