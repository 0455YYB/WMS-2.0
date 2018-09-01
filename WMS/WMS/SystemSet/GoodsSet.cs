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
    public partial class GoodsSet : Form
    {
        private static GoodsSet gs = null;
        private WMS.BaseClass.GoodsInfo goodsInfo = new BaseClass.GoodsInfo();
        SqlExecute sqlExecute = new SqlExecute();

        private GoodsSet()
        {
            InitializeComponent();
            string selectUnit = "select code,name from unit where status=0 ";
            string selectType = "select code,name from type where status=0";
            string selectSupplier = "select code,name from supplier where status=0";
            SetUnable();
            LoadUnit(CB_unit,selectUnit);
            LoadUnit(CB_type,selectType);
            LoadUnit(CB_supplier,selectSupplier);
        }

        public static GoodsSet GetGoodsSet()
        {
            if(gs==null||gs.IsDisposed)
            {
                gs = new GoodsSet();
            }
            return gs;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetEnable()
        {
            TB_code.Enabled = true;
            TB_name.Enabled = true;
            TB_price.Enabled = true;
            TB_spec.Enabled = true;
            CB_unit.Enabled = true;
            CB_stop.Enabled = true;
            CB_supplier.Enabled = true;
            CB_type.Enabled = true;
        }

        private void ClearText()
        {
            TB_code.Text = null;
            TB_name.Text = null;
            TB_price.Text = null;
            TB_spec.Text = null;
            //CB_unit.Text = null;
            //CB_stop.Text = null;
            //CB_supplier.Text = null;
            //CB_type.Text = null;
        }

        private void SetUnable()
        {
            TB_code.Enabled = false;
            TB_name.Enabled = false;
            TB_price.Enabled = false;
            TB_spec.Enabled = false;
            CB_unit.Enabled = false;
            CB_stop.Enabled = false;
            CB_supplier.Enabled = false;
            CB_type.Enabled = false;
        }

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
            goodsInfo.goodsCode = TB_code.Text.Trim();
            goodsInfo.goodsName = TB_name.Text.Trim();
            goodsInfo.goodsSpec = TB_spec.Text.Trim();
            goodsInfo.goodsUnit = CB_unit.SelectedValue.ToString();
            if(TB_price.Text=="")
            {
                MessageBox.Show("价格输入错误");
                return;
            }
            goodsInfo.goodsPrice = double.Parse(TB_price.Text.Trim());
            goodsInfo.goodsType =CB_type.SelectedValue.ToString().Trim();
            goodsInfo.goodsSupplier = CB_supplier.SelectedValue.ToString().Trim();
            goodsInfo.goodsStop = int.Parse(CB_stop.SelectedValue.ToString().Trim());

            SQLiteParameter[] sQLiteParameters = new SQLiteParameter[10];
            sQLiteParameters[0] = new SQLiteParameter("@goodsCode", goodsInfo.goodsCode);
            sQLiteParameters[1] = new SQLiteParameter("@goodsName", goodsInfo.goodsName);
            sQLiteParameters[2] = new SQLiteParameter("@goodsSpec", goodsInfo.goodsSpec);
            sQLiteParameters[3] = new SQLiteParameter("@goodsUnit", goodsInfo.goodsUnit);
            sQLiteParameters[4] = new SQLiteParameter("@goodsPrice", goodsInfo.goodsPrice);
            sQLiteParameters[5] = new SQLiteParameter("@goodsType", goodsInfo.goodsType);
            sQLiteParameters[6] = new SQLiteParameter("@goodsSupplier", goodsInfo.goodsSupplier);
            sQLiteParameters[7] = new SQLiteParameter("@goodsStop", goodsInfo.goodsStop);


            string ExistCode = @"select t.code from t goods where t.code=@goodsCode";
            int status= sqlExecute.SelectCode(goodsInfo.goodsCode, "@goodsCode", ExistCode);
            int scusess;
            string saveGoodsSql = "";
            if (status==1)
            {
                 saveGoodsSql = @"update goods set name=@goodsName,unit=@goodsUnit,price=@goodsPrice" +
                                       "supplier=@goodsPrice,type=@goodsType,supplier=@goodsSupplier,status=@goodsStop,createdate=datetime('now') where code=@goodsCode";
                scusess = sqlExecute.SaveGoods(goodsInfo.goodsCode, sQLiteParameters, saveGoodsSql);
                if (scusess == 1)
                {
                    MessageBox.Show("更新失败","提示");
                }
                MessageBox.Show("更新成功");        
            }
            else
            {
                saveGoodsSql = @"insert into goods(code,name,unit,price,shengchan,supplier,spec,status,createdate,type)" +
                   "values('@goodsCode','@goodsName','@goodsUnit','@goodsPrice',' ','@goodsSupplier','@goodsSpec',@goodsStop,datetime('now'),'@goodsType')";
                scusess = sqlExecute.SaveGoods(goodsInfo.goodsCode, sQLiteParameters, saveGoodsSql);
            }

        }

        private void TSB_cancle_Click(object sender, EventArgs e)
        {
            SetUnable();
        }

        private void TSB_delete_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 初始化界面绑定下拉列表值
        /// </summary>
        private void LoadUnit(ComboBox cb_B,string sqlString)
        {
            
            DataTable dt = sqlExecute.LoadInfo(sqlString);
            if(dt != null)
            {
                cb_B.DisplayMember = "name";
                cb_B.ValueMember = "code";
                cb_B.DataSource = dt;   
            }
        }
    }
}
