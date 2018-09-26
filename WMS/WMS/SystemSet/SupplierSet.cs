using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS.SQLHelper;

namespace WMS.SystemSet
{
    public partial class SupplierSet : Form
    {
        private static SupplierSet ss = null;
        SqlExecute SqlExecute = new SqlExecute();

        private SupplierSet()
        {
            InitializeComponent();
            Load_DGV_supplier();
        }

        public static SupplierSet GetSupplierSet()
        {
            if(ss==null||ss.IsDisposed)
            {
                ss = new SupplierSet();
            }
            return ss;
        }

        #region 导航栏
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

        private void TSB_search_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 文本框控制
        private void SetEnable()
        {
            this.TB_code.Enabled = true;
            this.TB_name.Enabled = true;
        }

        private void ClearText()
        {
            this.TB_code.Text = string.Empty;
            this.TB_name.Text = string.Empty;
        }

        private void SetUnable()
        {
            this.TB_code.Enabled = false;
            this.TB_name.Enabled = false;
        }
        #endregion

        #region 加载函数
        private void Load_DGV_supplier()
        {
            string loadSQL = @"select code as '编码',name as '名称' from supplier where status=0";
            DataTable supplierInfo;
            supplierInfo = SqlExecute.LoadInfo(loadSQL);
            DGV_supplier.DataSource = supplierInfo;
        }
        #endregion

        private void Cell_Click(object sender,DataGridViewCellEventArgs e)
        {
            int rowsNmber = DGV_supplier.CurrentRow.Index;
            string code = DGV_supplier.Rows[rowsNmber].Cells[0].Value.ToString().Trim();
            string name = DGV_supplier.Rows[rowsNmber].Cells[1].Value.ToString().Trim();

            TB_code.Text = code;
            TB_name.Text = name;
        }
    }
}
