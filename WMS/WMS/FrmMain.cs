﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void Usermage_Click(object sender, EventArgs e)
        {
            WMS.SystemSet.UserManage userManage = WMS.SystemSet.UserManage.GetUserManage();
            userManage.MdiParent = this;
            userManage.Dock = DockStyle.Fill;
            userManage.Show();
        }
    }
}
