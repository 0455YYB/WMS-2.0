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
        #region 字段
        ListBox listBox = null;
        #endregion

        #region 窗口初始化参数
        private static In_StockOrder inStockOrder;
        private static string sign = "R";
        private static string orderCode;
        private static string newCreateOrder;
        SQLHelper.SqlExecute sqlExecute = new SQLHelper.SqlExecute();
        private static string iniString=@"select code,name from supplier where status=0";
        #endregion

        private In_StockOrder()
        {
            InitializeComponent();
            orderCode = BaseClass.BaseMethod.GreateOrderNmber(sign);
            BaseClass.BaseMethod.LoadCombobox(CB_supplier,iniString);
            newCreateOrder = "0";
            TextChang_new();


        }

        public In_StockOrder(string order)
        {
            InitializeComponent();
            orderCode = order;
            BaseClass.BaseMethod.LoadCombobox(CB_supplier, iniString);
            this.DGV_orderDetail.AutoGenerateColumns = false;
            newCreateOrder = "1";
            LoadDGV_orderDetail(orderCode);
            TextChang_new();
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
            #region 初始化判断
            if (CB_supplier.Text.Trim()==null)
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
            #endregion 
            int rowsNmb = DGV_orderDetail.RowCount;
            if(rowsNmb<=0)
            {
                MessageBox.Show("单据无数据");
                return;
            }
            else
            {
                if (newCreateOrder == "0")
                {
                    string createOrderCodeSQL = @"insert into instockorder(ordercode,createtime,supplier,type) values(@ordercode,datetime('now'),@supplier,@type)";
                    SQLiteParameter[] sQLiteParameters = new SQLiteParameter[3];
                    sQLiteParameters[0] = new SQLiteParameter("@ordercode", orderCode);
                    sQLiteParameters[1] = new SQLiteParameter("@supplier", CB_supplier.Text.ToString());
                    sQLiteParameters[2] = new SQLiteParameter("@type", CB_instockType.Text.ToString());
                    int b = sqlExecute.Execute(sQLiteParameters, createOrderCodeSQL);
                    if(b!=1)
                    {
                        MessageBox.Show("保存单号失败");
                        return;
                    }
                } //是否需要新增单据 修改单据自动跳过
                int result = 1;
                for (int i=0; i<rowsNmb; i++)
                {
                    try
                    {
                        string saveSQL = string.Empty;
                        SQLiteParameter[] sQLiteParameters = new SQLiteParameter[7];
                        string ID = DGV_orderDetail.Rows[i].Cells[0].Value.ToString().Trim();
                        //sQLiteParameters[0] = new SQLiteParameter("@ID", int.Parse(DGV_orderDetail.Rows[i].Cells[0].Value.ToString()));
                        sQLiteParameters[0] = new SQLiteParameter("@ID", DbType.Int32,"");
                        sQLiteParameters[1] = new SQLiteParameter("@goodscode", DGV_orderDetail.Rows[i].Cells[1].Value.ToString());
                        sQLiteParameters[2] = new SQLiteParameter("@goodsname", DGV_orderDetail.Rows[i].Cells[2].Value.ToString());
                        sQLiteParameters[3] = new SQLiteParameter("@amount", double.Parse(DGV_orderDetail.Rows[i].Cells[3].Value.ToString()));
                        sQLiteParameters[4] = new SQLiteParameter("@goodsunit", DGV_orderDetail.Rows[i].Cells[4].Value.ToString());
                        sQLiteParameters[5] = new SQLiteParameter("@goodsprice", double.Parse(DGV_orderDetail.Rows[i].Cells[5].Value.ToString()));
                        sQLiteParameters[6] = new SQLiteParameter("@batch", DGV_orderDetail.Rows[i].Cells[6].Value.ToString());
                        if (ID == "")
                        {
                            saveSQL = @"insert into inorderdetail(goodscode,goodsname,amount,goodsunit,goodsprice,batch,ordercode) values(@goodscode,@goodsname,@amount,@goodsunit,@goodsprice,@batch,'"+orderCode+"')";
                            int a = sqlExecute.Execute(sQLiteParameters, saveSQL);
                            if(a==0)
                            {
                                MessageBox.Show("添加"+ DGV_orderDetail.Rows[i].Cells[2].Value.ToString()+"数据失败");
                            }
                        }
                        else
                        {
                            sQLiteParameters[0].Value = int.Parse(ID);
                            saveSQL = @"update inorderdetail set goodscode=@goodscode,goodsname=@goodsname,amount=@amount,goodsunit=@goodsunit,goodsprice=@goodsprice,batch=@batch where detailid=@ID";
                            int a = sqlExecute.Execute(sQLiteParameters, saveSQL);
                            if (a == 0)
                            {
                                MessageBox.Show("修改" + DGV_orderDetail.Rows[i].Cells[2].Value.ToString() + "数据失败");
                            }
                        }
                        

                    }catch(Exception ex)
                    {
                        result = 0;
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        
                    }

                } //数据写入数据库
                switch(result)
                {
                    case 1:
                        MessageBox.Show("保存成功");
                        break;
                    case 0:
                        MessageBox.Show("保存失败请核查入库单据是否有错");
                        break;
                }
            }
            
        }

        private void TextChang(object sender,EventArgs e)
        {
            try
            {
                string searchCode = CB_searchCode.Text.Trim();
                if(searchCode==string.Empty)
                {
                    return;
                }
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
                    
                    //CB_searchCode.SelectedIndex = -1;
                    CB_searchCode.Focus();
                    CB_searchCode.Select(CB_searchCode.Text.Length, 0);
                    this.CB_searchCode.DroppedDown = true;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }           
        }

        private void TextUpdate(object sender,EventArgs e)
        {
            DataGridView searchResult = new DataGridView();
            
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

        private void TSB_delete_Click(object sender, EventArgs e)
        {
            if(DGV_orderDetail.Rows.Count<0)
            {
                MessageBox.Show("入库单为空");
                return;
            }
            int rowsNmb = DGV_orderDetail.CurrentRow.Index;
            if (rowsNmb==-1)
            {
                MessageBox.Show("请选中需要删除的行");
                return;
            }
            string id = DGV_orderDetail.Rows[rowsNmb].Cells[0].Value.ToString().Trim();
            if(id=="")
            {
                DGV_orderDetail.Rows.RemoveAt(rowsNmb);
                return;
            }
            else
            {
                try
                {
                    int orderID = int.Parse(id);
                    string deleteSQL = @"delete from inorderdetail where detailid=@orderID";
                    SQLiteParameter[] sQLiteParameters = new SQLiteParameter[1];
                    sQLiteParameters[0] = new SQLiteParameter("@orderID", orderID);
                    int result = sqlExecute.Execute(sQLiteParameters, deleteSQL);
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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
            
        }

        private void LoadDGV_orderDetail(string ordercode)
        {
            string loadOrderDetail = @"select detailid, goodscode,goodsname,amount,goodsunit,goodsprice,batch from inorderdetail where ordercode='" + ordercode + "'; ";
            DataTable detailInfo = sqlExecute.LoadInfo(loadOrderDetail);
            DGV_orderDetail.AutoGenerateColumns = false;
            DGV_orderDetail.DataSource = detailInfo;
            DGV_orderDetail.Columns["detailid"].DataPropertyName = detailInfo.Columns["detailid"].ToString();
            DGV_orderDetail.Columns["code"].DataPropertyName = detailInfo.Columns["goodscode"].ToString();
            DGV_orderDetail.Columns["name"].DataPropertyName = detailInfo.Columns["goodsname"].ToString();
            DGV_orderDetail.Columns["amount"].DataPropertyName = detailInfo.Columns["amount"].ToString();
            DGV_orderDetail.Columns["unit"].DataPropertyName = detailInfo.Columns["goodsunit"].ToString();
            DGV_orderDetail.Columns["price"].DataPropertyName = detailInfo.Columns["goodsprice"].ToString();
            DGV_orderDetail.Columns["batch"].DataPropertyName = detailInfo.Columns["batch"].ToString();
        }

        private void TextChang_new()
        {
            if(listBox==null)
            {
                listBox = new ListBox();
                listBox.FormattingEnabled = true;
                listBox.Left = CB_searchCode.Left;
                listBox.Top = CB_searchCode.Top + CB_searchCode.Height;
                listBox.Size = new Size(100, 50);
                //listBox.Visible = true;
                //listBox.BringToFront();
            }
        }
    }
}
