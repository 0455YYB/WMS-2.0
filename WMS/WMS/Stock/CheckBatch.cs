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
    public delegate void transEvent(DataTable dt);
    public partial class CheckBatch : Form
    {
        public event transEvent te;
        DataTable
        public CheckBatch()
        {
            InitializeComponent();
        }
    }
}
