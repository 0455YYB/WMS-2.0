using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS.BaseClass;
using WMS.SQLHelper;
using System.Data.SQLite;

namespace WMS.SystemSet
{
    public partial class DepartmentSet : Form
    {
        private static DepartmentSet ds = null;
        SqlExecute SqlExecute = new SqlExecute();
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
            //CB_stop.Enabled = false;
        }

        private void SetEnable()
        {
            TB_code.Enabled = true;
            TB_name.Enabled = true;
            //CB_stop.Enabled = true;
        }

        private void ClearText()
        {
            TB_code.Text = "";
            TB_name.Text = "";
        }

        #region 导航栏功能键
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
            string code = TB_code.Text.ToString().Trim();
            if(code==null)
            {
                MessageBox.Show("编码不能为空");
                return;
            }
            string name = TB_name.Text.ToString().Trim();

            SQLiteParameter[] sQLiteParameters = new SQLiteParameter[2];
            sQLiteParameters[0] = new SQLiteParameter("@code",code);
            sQLiteParameters[1] = new SQLiteParameter("@name",name);

            string selectCode = @"select code from department where code=@code";
            int result = SqlExecute.SelectCode(code, "@code", selectCode);
            string saveString = "";
            switch(result)
            {
                case 1:
                    saveString = @"update department set code=@code,name=@name where code=@code ";
                    break;
                case 0:
                    saveString = @"insert into department (code,name) values(@code,@name)";
                    break;
            }
            int scusess = SqlExecute.Execute(sQLiteParameters, saveString);
            switch(scusess)
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

        }
        #endregion 
    }
}
