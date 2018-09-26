using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS.SQLHelper;
using System.Data.SQLite;

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
            SetEnable();
            ClearText();
        }

        private void TSB_edit_Click(object sender, EventArgs e)
        {
            SetEnable();
        }

        private void TSB_save_Click(object sender, EventArgs e)
        {
            string code = TB_code.Text.Trim();
            string name = TB_name.Text.Trim();
            SQLiteParameter[] sQLiteParameter = new SQLiteParameter[2];
            sQLiteParameter[0] = new SQLiteParameter("@code", code);
            sQLiteParameter[1] = new SQLiteParameter("@name", name);
            string selectSQL = @"select code from supplier where code=@code";
            int selectCode = SqlExecute.SelectCode(code, "@code", selectSQL);
            string saveSQL = string.Empty; 
            switch(selectCode)
            {
                case 0:
                    saveSQL = @"insert into supplier(code,name) values(@code,@name)";
                    break;
                case 1:
                    saveSQL = @"update supplier set code=@code,name=@name where code=@code";
                    break;
            }
            int result = SqlExecute.Execute(sQLiteParameter,saveSQL);
            switch(result)
            {
                case 0:
                    MessageBox.Show("保存失败");
                    break;
                case 1:
                    MessageBox.Show("保存成功");
                    break;
            }
        }

        private void TSB_cancel_Click(object sender, EventArgs e)
        {
            SetUnable();
        }

        private void TSB_delete_Click(object sender, EventArgs e)
        {
            int rowsNmber = DGV_supplier.CurrentRow.Index;
            string code = DGV_supplier.Rows[rowsNmber].Cells[0].Value.ToString().Trim();
            string deleteSQL = @"delete from supplier where code=@code";
            SQLiteParameter[] sQLiteParameter = new SQLiteParameter[1];
            sQLiteParameter[0] = new SQLiteParameter("@code", code);
            int result = SqlExecute.Execute(sQLiteParameter, deleteSQL);
            switch(result)
            {
                case 0:
                    MessageBox.Show("删除失败");
                    break;
                case 1:
                    MessageBox.Show("删除成功");
                    break;
            }
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
