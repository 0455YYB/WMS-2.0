using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS.BaseClass;

namespace WMS.SystemSet
{
    public partial class DepartmentSet : Form
    {
        private static DepartmentSet ds = null;
        private  DepartmentSet()
        {
            InitializeComponent();
        }

        public static DepartmentSet GetDepartmentSet()
        {
            if(ds==null||ds.IsDisposed)
            {
                ds = new DepartmentSet();
            }
            return ds;
        }

        private void SetUnable()
        {
            TB_code.Enabled = false;
            TB_name.Enabled = false;
            CB_stop.Enabled = false;
        }

        private void SetEnable()
        {
            TB_code.Enabled = true;
            TB_name.Enabled = true;
            CB_stop.Enabled = true;
        }

        private void ClearText()
        {
            TB_code.Text = "";
            TB_name.Text = "";
        }
        #region
        private void TSB_add_Click(object sender, EventArgs e)
        {

        }

        private void TSB_edit_Click(object sender, EventArgs e)
        {

        }

        private void TSB_save_Click(object sender, EventArgs e)
        {

        }

        private void TSB_cancel_Click(object sender, EventArgs e)
        {

        }

        private void TSB_delete_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
