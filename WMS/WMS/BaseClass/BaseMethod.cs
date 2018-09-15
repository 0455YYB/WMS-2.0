using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WMS.BaseClass
{
    class BaseMethod
    {
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
    }
}
