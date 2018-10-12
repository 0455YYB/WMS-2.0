using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS.SQLHelper;
using WMS.BaseClass;
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
            BaseMethod.LoadStop(this.CB_stop);
            LoadDGV_goods();
        }

        public static GoodsSet GetGoodsSet()
        {
            if(gs==null||gs.IsDisposed)
            {
                gs = new GoodsSet();
            }
            return gs;
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
                MessageBox.Show("请输入价格");
                return;
            }
            goodsInfo.goodsPrice = double.Parse(TB_price.Text.Trim());
            goodsInfo.goodsType =CB_type.SelectedValue.ToString().Trim();
            goodsInfo.goodsSupplier = CB_supplier.SelectedValue.ToString().Trim();
            goodsInfo.goodsStop = int.Parse(CB_stop.SelectedValue.ToString().Trim());

            SQLiteParameter[] sQLiteParameters = new SQLiteParameter[8];
            sQLiteParameters[0] = new SQLiteParameter("@goodsCode", goodsInfo.goodsCode);
            sQLiteParameters[1] = new SQLiteParameter("@goodsName", goodsInfo.goodsName);
            sQLiteParameters[2] = new SQLiteParameter("@goodsSpec", goodsInfo.goodsSpec);
            sQLiteParameters[3] = new SQLiteParameter("@goodsUnit", goodsInfo.goodsUnit);
            sQLiteParameters[4] = new SQLiteParameter("@goodsPrice", goodsInfo.goodsPrice);
            sQLiteParameters[5] = new SQLiteParameter("@goodsType", goodsInfo.goodsType);
            sQLiteParameters[6] = new SQLiteParameter("@goodsSupplier", goodsInfo.goodsSupplier);
            sQLiteParameters[7] = new SQLiteParameter("@goodsStop", goodsInfo.goodsStop);


            string ExistCode = @"select t.code from  goods t where t.code=@goodsCode";
            int status= sqlExecute.SelectCode(goodsInfo.goodsCode, "@goodsCode", ExistCode);
            int scusess;
            string saveGoodsSql = "";
            switch(status)
            {
                case 0:
                    saveGoodsSql = @"insert into goods(code,name,unit,price,shengchan,supplier,spec,status,createdate,type)" +
                    "values(@goodsCode,@goodsName,@goodsUnit,@goodsPrice,' ',@goodsSupplier,@goodsSpec,@goodsStop,datetime('now'),@goodsType)";
                    scusess = sqlExecute.SaveGoods(goodsInfo.goodsCode, sQLiteParameters, saveGoodsSql);
                    if(scusess==1)
                    {
                        MessageBox.Show("修改成功");
                        LoadDGV_goods();
                    }
                    else
                    {
                        MessageBox.Show("修改失败，");
                    }
                    break;
                case 1:
                    saveGoodsSql = @"update goods set name=@goodsName,unit=@goodsUnit,price=@goodsPrice" +
                                   "supplier=@goodsPrice,type=@goodsType,supplier=@goodsSupplier,status=@goodsStop,createdate=datetime('now') where code=@goodsCode";
                    scusess = sqlExecute.SaveGoods(goodsInfo.goodsCode, sQLiteParameters, saveGoodsSql);
                    if (scusess == 1)
                    {
                        MessageBox.Show("添加成功");
                        LoadDGV_goods();
                    }
                    else
                    {
                        MessageBox.Show("添加失败，");
                    }
                    break;
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

        private void LoadDGV_goods()
        {
            string selectGoods = @"select a.code '编号',a.name '名称',a.spec '规格',c.name '单位',a.price '价格',b.name '类型',d.name '供应商',
                                 a.status '停用' from goods a,type b,unit c,supplier d where a.type=b.code and a.unit=c.code and a.supplier=d.code";
            DataTable goodsInfo = sqlExecute.LoadInfo(selectGoods);
            DGV_goods.DataSource = goodsInfo;
        }

        private void DGV_goods_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            int rowsNumber = DGV_goods.CurrentRow.Index;
            string code = DGV_goods.Rows[rowsNumber].Cells[0].Value.ToString();
            string selectString = @"select code,name,spec,unit,price,type,supplier,status from goods where code=@code";
            SQLiteParameter[] sQLiteParameters = new SQLiteParameter[1];
            sQLiteParameters[0] = new SQLiteParameter("@code",code);

            DataTable dt = sqlExecute.SelectInfo(sQLiteParameters, selectString);
            if (dt!=null)
            {
                TB_code.Text = dt.Rows[0][0].ToString();
                TB_name.Text = dt.Rows[0][1].ToString();
                TB_spec.Text = dt.Rows[0][2].ToString();
                CB_unit.SelectedValue = dt.Rows[0][3].ToString();
                TB_price.Text = dt.Rows[0][4].ToString();
                CB_type.SelectedValue = dt.Rows[0][5].ToString();
                CB_supplier.SelectedValue = dt.Rows[0][6].ToString();
                CB_stop.SelectedValue = dt.Rows[0][7].ToString();
            }
        }


    }
}
