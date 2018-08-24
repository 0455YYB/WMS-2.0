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
    public partial class OrganizationSet : Form
    {
        private static OrganizationSet os = null;
        private OrganizationSet()
        {
            InitializeComponent();
        }

        public static OrganizationSet GetOrganizationSet()
        {
            if(os==null||os.IsDisposed)
            {
                os = new OrganizationSet();
            }
            return os;
        }

    }
}
