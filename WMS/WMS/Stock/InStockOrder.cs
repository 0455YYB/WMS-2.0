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
    public partial class InStockOrder : Form
    {
        private static InStockOrder inStockOrder;
        private static string sign = "R";
        private static string orderCode;
        SQLHelper.SqlExecute sqlExecute = new SQLHelper.SqlExecute();
        private InStockOrder()
        {
            InitializeComponent();
            orderCode = BaseClass.BaseMethod.GreateOrderNmber(sign);
        }

        public InStockOrder(string order)
        {
            InitializeComponent();
            orderCode = order;
        }

        public static InStockOrder GetInStockOrder()
        {
            if(inStockOrder==null||inStockOrder.IsDisposed)
            {
                inStockOrder = new InStockOrder();
                return inStockOrder;
            }
            return inStockOrder;
        }

        private void SavePicture_Click(object sender, EventArgs e)
        {
            string picPath = "";
            OpenFileDialog picFile = new OpenFileDialog();
            if(picFile.ShowDialog()==DialogResult.OK)
            {
                string picName = picFile.FileName;
                File.Copy(picName, Application.StartupPath + "\\GoodsPicture\\"+ Path.GetFileName(picFile.FileName));
                if(orderCode!=null)
                {
                    File.Move(Application.StartupPath + "\\GoodsPicture\\" + Path.GetFileName(picFile.FileName), Application.StartupPath+ "\\GoodsPicture\\" + orderCode + ".jpg");
                    PB_order.ImageLocation = Application.StartupPath + "\\GoodsPicture\\" + orderCode + ".jpg";
                }          
            }
        }

        private void TSB_save_Click(object sender, EventArgs e)
        {
            if(CB_instockType.Text==null)
            {
                MessageBox.Show("请选择入库类型");
            }
        }

        private void TextChang(object sender,EventArgs e)
        {
            string searchCode = CB_searchCode.Text;
            //string selectSQL = @"select goods.code,goods.name,unit.name from goods,unit where goods.unit=unit.code and (goods.code like "+"'%"+"||"+@"@searchCode"+"||"+"%'" + " or goods.name like " +"'%"+"||"+@"@searchCode"+"||"+"%')";
            string selectSQL = @"select goods.code,goods.name,unit.name from goods,unit where goods.unit=unit.code and (goods.code like '%1%' or goods.name like '%1%')" ;
            SQLiteParameter[] sQLiteParameter = new SQLiteParameter[1];
            sQLiteParameter[0] = new SQLiteParameter("@searchCode", searchCode);
            DataTable goodsInfo;
            goodsInfo = sqlExecute.SelectInfo(sQLiteParameter, selectSQL);
            CB_searchCode.DataSource = goodsInfo;
            CB_searchCode.DisplayMember = "name";
            CB_searchCode.ValueMember = "code";
            this.CB_searchCode.DroppedDown =true;

        }
    }
}
