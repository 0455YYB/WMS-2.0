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
    public partial class UnitSet : Form
    {
        private static UnitSet us = null;
        private UnitSet()
        {
            InitializeComponent();
        }

        public static UnitSet GetUnitSet()
        {
            if(us==null||us.IsDisposed)
            {
                us = new UnitSet();
            }
            return us;
        }
    }
}
