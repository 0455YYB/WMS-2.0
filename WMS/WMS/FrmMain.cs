using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 作废
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Usermage_Click(object sender, EventArgs e)
        {
            WMS.SystemSet.UserManage userManage = WMS.SystemSet.UserManage.GetUserManage();
            userManage.MdiParent = this;
            userManage.Dock = DockStyle.Fill;
            userManage.Activate();//将当前窗体设置为激活状态
            userManage.Show();
        }

        /// <summary>
        /// 作废
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 类型管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMS.SystemSet.TypeSet typeSet = WMS.SystemSet.TypeSet.GetTypeSet();
            typeSet.MdiParent = this;
            typeSet.Dock = DockStyle.Fill;
            typeSet.TopMost = true;
            typeSet.Activate();
            typeSet.Show();
        }


        private void 物资字典维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMS.SystemSet.GoodsSet goodsSet = WMS.SystemSet.GoodsSet.GetGoodsSet();
            goodsSet.MdiParent = this;
            goodsSet.Dock = DockStyle.Fill;
            goodsSet.Activate();
            goodsSet.Show();
        }

        private void 类型维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMS.SystemSet.TypeSet typeSet = WMS.SystemSet.TypeSet.GetTypeSet();
            typeSet.MdiParent = this;
            typeSet.Dock = DockStyle.Fill;
            typeSet.TopMost = true;
            typeSet.Activate();
            typeSet.Show();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            WMS.SystemSet.UnitSet unitSet = WMS.SystemSet.UnitSet.GetUnitSet();
            unitSet.MdiParent = this;
            unitSet.Dock = DockStyle.Fill;
            unitSet.Activate();
            unitSet.Show();
        }

        private void 部门维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMS.SystemSet.DepartmentSet departmentSet = WMS.SystemSet.DepartmentSet.GetDepartmentSet();
            departmentSet.MdiParent = this;
            departmentSet.Dock = DockStyle.Fill;
            departmentSet.Activate();
            departmentSet.Show();
        }

        private void 供应商维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMS.SystemSet.SupplierSet supplierSet = WMS.SystemSet.SupplierSet.GetSupplierSet();
            supplierSet.MdiParent = this;
            supplierSet.Dock = DockStyle.Fill;
            supplierSet.Activate();
            supplierSet.Show();
        }

        private void 单位信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMS.SystemSet.OrganizationSet organizationSet = WMS.SystemSet.OrganizationSet.GetOrganizationSet();
            organizationSet.MdiParent = this;
            organizationSet.Dock = DockStyle.Fill;
            organizationSet.Activate();
            organizationSet.Show();
        }

        private void 用户维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMS.SystemSet.UserManage userManage = WMS.SystemSet.UserManage.GetUserManage();
            userManage.MdiParent = this;
            userManage.Dock = DockStyle.Fill;
            userManage.Activate();
            userManage.Show();
        }
    }
}
