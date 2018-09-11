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
    public partial class UnitSet : Form
    {
        private static UnitSet us = null;
        private SqlExecute SqlExecute = new SqlExecute();
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

        #region 输入文本框控制
        private void SetEnable()
        {
            TB_code.Enabled = true;
            TB_name.Enabled = true;
        }

        private void SetUnable()
        {
            TB_code.Enabled = false;
            TB_name.Enabled = false;
        }

        private void ClearText()
        {
            TB_code.Text = "";
            TB_name.Text = "";
        }
        #endregion

        #region 功能导航栏
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
            string unitCode = TB_code.Text.Trim();
            string unitName = TB_name.Text.Trim();
            if(unitCode==null|| unitName==null)
            {
                MessageBox.Show("编号或者名称不能为空");
            }
            SQLiteParameter[] sQLiteParameters = new SQLiteParameter[2];
            sQLiteParameters[0] = new SQLiteParameter("@unitCode", unitCode);
            sQLiteParameters[1] = new SQLiteParameter("@unitName", unitName);

            string selectCode = @"select code from unit where code=@unitCode";
            int haveCode = SqlExecute.SelectCode(unitCode, "@unitCode", selectCode);
            string saveString = "";
            switch(haveCode)
            {
                case 0:
                    saveString = @"insert into unit (code,name) values(@unitCode,@unitName)";
                    break;
                case 1:
                    saveString = @"update unit set code=@unitCode,name=@unitName where code=@unitCode";
                    break;
            }
            int result = SqlExecute.Execute(sQLiteParameters, saveString);
            if(result==1)
            {
                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("保存失败");
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

        private void LoadDGV_unit()
        {
            string selectUnit = @"select code '编号',name '名称' from unit where status=0 order by code desc";
            DataTable unitInfo = null;
            unitInfo = SqlExecute.LoadInfo(selectUnit);
        }
    }
}
