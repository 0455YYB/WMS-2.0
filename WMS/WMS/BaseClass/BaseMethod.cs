using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using WMS.SQLHelper;
using System.Data.SQLite;

namespace WMS.BaseClass
{
    class BaseMethod
    {
        static SqlExecute  sqlExecute = new SqlExecute();
        public static void LoadStop(ComboBox comboBox)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("code");
            dt.Columns.Add("name");
            DataRow dr = dt.NewRow();
            dr["code"] = 0;
            dr["name"] = "否";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1["code"] = 1;
            dr1["name"] = "是";
            dt.Rows.Add(dr1);
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "code";
            comboBox.DataSource = dt;
        }

        public void LoadDataGridView(DataGridView dgv,string loadString)
        {

        }

        public static string GreateOrderNmber(string sign)
        {
            SqlExecute sqlExecute = new SqlExecute();
            string orderNmber = string.Empty;
            string dateNmber = DateTime.Now.ToString("yyyyMMdd");
            string selectCurrentOrderNmb = @"select count(1) from instockorder t where t.ordercode like '%"+dateNmber+"%' ";
            int rowsNmb =1+ sqlExecute.GetRows(selectCurrentOrderNmb);
            return orderNmber=sign+dateNmber+rowsNmb.ToString().PadLeft(3,'0');
        }

        public static void LoadCombobox(ComboBox comboBox,string sqlstring)
        {
            DataTable dataTable = sqlExecute.LoadInfo(sqlstring);
            if(dataTable!=null)
            {
                comboBox.DisplayMember = "name";
                comboBox.ValueMember = "code";
                comboBox.DataSource = dataTable;
            }
        }
    }
}
