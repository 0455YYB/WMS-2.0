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
    public partial class TypeSet : Form
    {
        private static TypeSet ts = null;
        private  TypeSet()
        {
            InitializeComponent();
        }

        public static TypeSet GetTypeSet()
        {
            if(ts==null||ts.IsDisposed)
            {
                ts = new TypeSet();
            }
            return ts;
        }
    }
}
