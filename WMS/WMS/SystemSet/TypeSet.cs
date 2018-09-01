using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WMS.SystemSet
{
    public partial class TypeSet : Form
    {
        private static TypeSet ts = null;
        private WMS.SQLHelper.SqlExecute SqlExecute = new SQLHelper.SqlExecute();

        private  TypeSet()
        {
            InitializeComponent();
            LoadDGV_type();
        }

        public static TypeSet GetTypeSet()
        {
            if(ts==null||ts.IsDisposed)
            {
                ts = new TypeSet();
            }
            return ts;
        }

        #region 页面控件可有用性控制
        private void ClearTxet()
        {
            TB_code.Text = string.Empty;
            TB_name.Text = string.Empty;
        }

        private void SetEable()
        {
            TB_code.Enabled = true;
            TB_name.Enabled = true;
        }
        private void SetUnable()
        {
            TB_code.Enabled = false;
            TB_name.Enabled = false;
        }
        #endregion

        #region 界面导航功能按钮
        private void TSB_add_Click(object sender, EventArgs e)
        {
            SetEable();
            ClearTxet();
        }

        private void TBS_edit_Click(object sender, EventArgs e)
        {
            SetEable();
        }

        private void TSB_save_Click(object sender, EventArgs e)
        {
            if(!TB_code.Enabled)
            {
                MessageBox.Show("非编辑状态无法修改");
                return;
            }
            string typeCode = TB_code.Text.ToString().Trim();
            string typeName = TB_name.Text.ToString().Trim();

            SQLiteParameter[] sQLiteParameters = new SQLiteParameter[2];
            sQLiteParameters[0] = new SQLiteParameter("@typeCode", typeCode);
            sQLiteParameters[1] = new SQLiteParameter("@typeName", typeName);

            string selectCode = @"select code from type where code=@typeCode";
            string saveString="";
            int result = SqlExecute.SelectCode(typeCode, "@typeCode",selectCode);
            switch(result)
            {
                case 0:
                    saveString = @"insert into type(code,name) values(@typeCode,@typeName)";
                    break;
                case 1:
                    saveString = @"update type set code=@typeCode,name=@typeName where code=@typeCode";
                    break;
            }
            int saveResult = SqlExecute.SaveGoods(typeCode, sQLiteParameters, saveString);
            if (saveResult==0)
            {
                MessageBox.Show("保存失败");
            }
            else
            {
                MessageBox.Show("保存成功");
            }
            SetUnable();
            LoadDGV_type();


        }

        private void TSB_cancle_Click(object sender, EventArgs e)
        {
            SetUnable();
        }

        private void TSB_delete_Click(object sender, EventArgs e)
        {
            int currenRow = DGV_type.CurrentRow.Index;
            string type_code = DGV_type.Rows[currenRow].Cells[0].Value.ToString();
            SQLiteParameter[] sQLiteParameters = new SQLiteParameter[1];
            sQLiteParameters[0] = new SQLiteParameter("@type_code", type_code);
            string strDeleteType = @"delete from type where code = @type_code";
            int result = SqlExecute.SaveGoods(type_code, sQLiteParameters, strDeleteType);
            switch(result)
            {
                case 0:
                    MessageBox.Show("保存失败");
                    break;
                case 1:
                    MessageBox.Show("保存成功");
                    break;
            }
            LoadDGV_type();
        }
        #endregion

        #region
        private void LoadDGV_type()
        {
            string selectTypeInfo = @"select code '编号',name '名称' from type where status=0 order by code desc";
            DataTable dt_type = SqlExecute.LoadInfo(selectTypeInfo);
            DGV_type.DataSource = dt_type;
            DGV_type.Columns[0].HeaderText = "编号";
            DGV_type.Columns[1].HeaderText = "名称";
        }
        #endregion


    }
}
