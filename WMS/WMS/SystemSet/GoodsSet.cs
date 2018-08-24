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
    public partial class GoodsSet : Form
    {
        private static GoodsSet gs = null;
        private GoodsSet()
        {
            InitializeComponent();
        }

        public static GoodsSet GetGoodsSet()
        {
            if(gs==null||gs.IsDisposed)
            {
                gs = new GoodsSet();
            }
            return gs;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
