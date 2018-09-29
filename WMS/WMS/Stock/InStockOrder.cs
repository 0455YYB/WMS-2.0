using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WMS.Stock
{
    public partial class InStockOrder : Form
    {
        private static InStockOrder inStockOrder;
        private InStockOrder()
        {
            InitializeComponent();
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
            }
        }
    }
}
