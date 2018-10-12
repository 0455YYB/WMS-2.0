using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace WMS.Stock
{
    public partial class In_StockOrder : Form
    {
        #region 窗口初始化参数
        private static In_StockOrder inStockOrder;
        private static string sign = "R";
        private static string orderCode;
        SQLHelper.SqlExecute sqlExecute = new SQLHelper.SqlExecute();
        private static string iniString=@"select code,name from supplier where status=0";
        #endregion

        private In_StockOrder()
        {
            InitializeComponent();
            orderCode = BaseClass.BaseMethod.GreateOrderNmber(sign);
            BaseClass.BaseMethod.LoadCombobox(CB_supplier,iniString);
        }

        public In_StockOrder(string order)
        {
            InitializeComponent();
            orderCode = order;
        }

        public static In_StockOrder GetInStockOrder()
        {
            if(inStockOrder==null||inStockOrder.IsDisposed)
            {
                inStockOrder = new In_StockOrder();
                return inStockOrder;
            }
            return inStockOrder;
        }

        private void SavePicture_Click(object sender, EventArgs e)
        {
            try
            {
                string picPath = "";
                OpenFileDialog picFile = new OpenFileDialog();
                if (picFile.ShowDialog() == DialogResult.OK)
                {
                    string picName = picFile.FileName;
                    File.Copy(picName, Application.StartupPath + "\\GoodsPicture\\" + Path.GetFileName(picFile.FileName));
                    if (orderCode != null)
                    {
                        File.Move(Application.StartupPath + "\\GoodsPicture\\" + Path.GetFileName(picFile.FileName), Application.StartupPath + "\\GoodsPicture\\" + orderCode + ".jpg");
                        PB_order.ImageLocation = Application.StartupPath + "\\GoodsPicture\\" + orderCode + ".jpg";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void TSB_save_Click(object sender, EventArgs e)
        {
            if(CB_supplier.Text.Trim()==null)
            {
                MessageBox.Show("请选择供应商");
                return;
            }
            if(TB_batch.Text.Trim()==null)
            {
                MessageBox.Show("请输入批号");
                return;
            }
            if(CB_instockType.Text==null)
            {
                MessageBox.Show("请选择入库类型");
                return;
            }

        }

        private void TextChang(object sender,EventArgs e)
        {
            try
            {
                string searchCode = CB_searchCode.Text.Trim();
                string selectSQL = @"select goods.code,goods.name,unit.name  from goods,unit where goods.unit=unit.code and (goods.code like @searchCode  or goods.name like  @searchCode)";
                SQLiteParameter[] sQLiteParameter = new SQLiteParameter[1];
                sQLiteParameter[0] = new SQLiteParameter("@searchCode", "%" + searchCode + "%");
                DataTable goodsInfo;
                goodsInfo = sqlExecute.SelectInfo(sQLiteParameter, selectSQL);
                int j = goodsInfo.Rows.Count;
                if (j > 0)
                {
                    CB_searchCode.Items.Clear();
                    for (int a = 0; a < j; a++)
                    {
                        CB_searchCode.Items.Add(goodsInfo.Rows[a]["code"] + "|" + goodsInfo.Rows[a]["name"] + "|" + goodsInfo.Rows[a]["name1"]);
                    }
                    CB_searchCode.Focus();
                    CB_searchCode.Select(CB_searchCode.Text.Length, 0);
                }
                else
                {
                    return;
                }
                this.CB_searchCode.DroppedDown = true;
                CB_searchCode.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }           
        }

        private void CB_search_ChoiceItem(object sender,EventArgs e)
        {
            if(CB_searchCode.SelectedIndex!=-1)
            {
                string info = CB_searchCode.Text.Trim();
                string[] goodsInfo = info.Split('|');
                TB_code.Text = goodsInfo[0].ToString().Trim();
                TB_name.Text = goodsInfo[1].ToString().Trim();
                TB_unit.Text = goodsInfo[2].ToString().Trim();
            }
            else
            {
                return;
            }
            
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            #region 控制输入数量和金额为正确数值
            double a;
            if(TB_acount.Text.Trim()=="")
            {
                MessageBox.Show("请输入入库数量");
                return;
            }
            else if(!double.TryParse(TB_acount.Text.Trim().ToString(),out a ))
            {
                MessageBox.Show("请输入有效数值");
                return;
            }
            if(TB_price.Text.Trim()=="")
            {
                MessageBox.Show("请输入金额");
                return;
            }
            if (!double.TryParse(TB_price.Text.Trim().ToString(), out a))
            {
                MessageBox.Show("请输入有效金额");
                return;
            }
            #endregion  

            string[] valuse = {"",
                                TB_code.Text.Trim(),
                                TB_name.Text.Trim(),
                                TB_acount.Text.Trim(),
                                TB_unit.Text.Trim(),
                                TB_price.Text.Trim(),
                                TB_batch.Text.Trim() };

            DGV_orderDetail.Rows.Add(valuse);
        }
    }
}
