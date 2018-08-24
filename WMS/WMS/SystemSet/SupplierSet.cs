using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS.SystemSet
{
    public partial class SupplierSet : Form
    {
        private static SupplierSet ss = null;
        private SupplierSet()
        {
            InitializeComponent();
        }

        public static SupplierSet GetSupplierSet()
        {
            if(ss==null||ss.IsDisposed)
            {
                ss = new SupplierSet();
            }
            return ss;
        }
    }
}
