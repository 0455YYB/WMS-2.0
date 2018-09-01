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

        private void TSB_add_Click(object sender, EventArgs e)
        {
            ClearText();
            SetEnable();
        }

        /// <summary>
        /// 设置控件可用
        /// </summary>
        private void SetEnable()
        {       
            TB_code.Enabled = true;           
            TB_name.Enabled = true;        
            TB_IDcard.Enabled = true;          
            TB_sex.Enabled = true;          
            TB_age.Enabled = true;          
            CB_department.Enabled = true; 
            CB_stop.Enabled = true;
        }

        /// <summary>
        /// 设置控件不可用用
        /// </summary>
        private void SetUnenable()
        {
            TB_code.Enabled = false;
            TB_name.Enabled = false;
            TB_IDcard.Enabled = false;
            TB_sex.Enabled = false;
            TB_age.Enabled = false;
            CB_department.Enabled = false;
            CB_stop.Enabled = false;
        }

        /// <summary>
        /// 控件清零
        /// </summary>
        private void ClearText()
        {
            TB_code.Text = null;
            TB_name.Text = null;
            TB_IDcard.Text = null;
            TB_sex.Text = null;
            TB_age.Text = null;
            CB_department.Text = null;
            CB_stop.Text = null;
        }

        private void TSB_edit_Click(object sender, EventArgs e)
        {
            SetEnable();
        }

        private void TSB_cancle_Click(object sender, EventArgs e)
        {
            SetUnenable();
        }

        private void TSB_delete_Click(object sender, EventArgs e)
        {
            SetUnenable();
        }

        private void TSB_save_Click(object sender, EventArgs e)
        {

            SetUnenable();
        }
    }
}
