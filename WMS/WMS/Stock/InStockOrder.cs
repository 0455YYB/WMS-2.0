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
    public partial class InStockOrder : Form
    {
        private static InStockOrder inStockOrder;
        private InStockOrder()
        {
            InitializeComponent();
        }

        public static InStockOrder GetInStockOrder()
        {
            if(inStockOrder==null||inStockOrder.IsDisposed)
            {
                inStockOrder = new InStockOrder();
                return inStockOrder;
            }
            return inStockOrder;
        }
    }
}
