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
    public partial class UserManage : Form
    {
        private static UserManage um=null;
        private UserManage()
        {
            {
                InitializeComponent();
            }
        }

        public static UserManage GetUserManage()
        {
            if(um==null||um.IsDisposed)
            {
                um = new UserManage();
            }
            return um;
        }

    }
}
