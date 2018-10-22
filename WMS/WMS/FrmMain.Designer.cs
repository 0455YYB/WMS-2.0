using System;

namespace WMS
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Dic_set = new System.Windows.Forms.ToolStripMenuItem();
            this.物资字典维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.类型维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.部门维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供应商维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单位信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.物资入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物资出库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Usermage = new System.Windows.Forms.ToolStripMenuItem();
            this.类型管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dic_set,
            this.toolStripMenuItem1,
            this.库存报表ToolStripMenuItem,
            this.系统管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1285, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Dic_set
            // 
            this.Dic_set.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.物资字典维护ToolStripMenuItem,
            this.类型维护ToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.部门维护ToolStripMenuItem,
            this.供应商维护ToolStripMenuItem,
            this.单位信息维护ToolStripMenuItem,
            this.用户维护ToolStripMenuItem});
            this.Dic_set.Name = "Dic_set";
            this.Dic_set.Size = new System.Drawing.Size(68, 21);
            this.Dic_set.Text = "字典维护";
            // 
            // 物资字典维护ToolStripMenuItem
            // 
            this.物资字典维护ToolStripMenuItem.Name = "物资字典维护ToolStripMenuItem";
            this.物资字典维护ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.物资字典维护ToolStripMenuItem.Text = "物资字典维护";
            this.物资字典维护ToolStripMenuItem.Click += new System.EventHandler(this.物资字典维护ToolStripMenuItem_Click);
            // 
            // 类型维护ToolStripMenuItem
            // 
            this.类型维护ToolStripMenuItem.Name = "类型维护ToolStripMenuItem";
            this.类型维护ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.类型维护ToolStripMenuItem.Text = "类型维护";
            this.类型维护ToolStripMenuItem.Click += new System.EventHandler(this.类型维护ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem2.Text = "物资单位维护";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // 部门维护ToolStripMenuItem
            // 
            this.部门维护ToolStripMenuItem.Name = "部门维护ToolStripMenuItem";
            this.部门维护ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.部门维护ToolStripMenuItem.Text = "部门维护";
            this.部门维护ToolStripMenuItem.Click += new System.EventHandler(this.部门维护ToolStripMenuItem_Click);
            // 
            // 供应商维护ToolStripMenuItem
            // 
            this.供应商维护ToolStripMenuItem.Name = "供应商维护ToolStripMenuItem";
            this.供应商维护ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.供应商维护ToolStripMenuItem.Text = "供应商维护";
            this.供应商维护ToolStripMenuItem.Click += new System.EventHandler(this.供应商维护ToolStripMenuItem_Click);
            // 
            // 单位信息维护ToolStripMenuItem
            // 
            this.单位信息维护ToolStripMenuItem.Name = "单位信息维护ToolStripMenuItem";
            this.单位信息维护ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.单位信息维护ToolStripMenuItem.Text = "机构信息维护";
            this.单位信息维护ToolStripMenuItem.Click += new System.EventHandler(this.单位信息维护ToolStripMenuItem_Click);
            // 
            // 用户维护ToolStripMenuItem
            // 
            this.用户维护ToolStripMenuItem.Name = "用户维护ToolStripMenuItem";
            this.用户维护ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.用户维护ToolStripMenuItem.Text = "用户维护";
            this.用户维护ToolStripMenuItem.Click += new System.EventHandler(this.用户维护ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.物资入库ToolStripMenuItem,
            this.物资出库ToolStripMenuItem,
            this.库存查询ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "库存管理";
            // 
            // 物资入库ToolStripMenuItem
            // 
            this.物资入库ToolStripMenuItem.Name = "物资入库ToolStripMenuItem";
            this.物资入库ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.物资入库ToolStripMenuItem.Text = "物资入库";
            this.物资入库ToolStripMenuItem.Click += new System.EventHandler(this.物资入库ToolStripMenuItem_Click);
            // 
            // 物资出库ToolStripMenuItem
            // 
            this.物资出库ToolStripMenuItem.Name = "物资出库ToolStripMenuItem";
            this.物资出库ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.物资出库ToolStripMenuItem.Text = "物资出库";
            this.物资出库ToolStripMenuItem.Click += new System.EventHandler(this.物资出库ToolStripMenuItem_Click);
            // 
            // 库存查询ToolStripMenuItem
            // 
            this.库存查询ToolStripMenuItem.Name = "库存查询ToolStripMenuItem";
            this.库存查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.库存查询ToolStripMenuItem.Text = "库存查询";
            // 
            // 库存报表ToolStripMenuItem
            // 
            this.库存报表ToolStripMenuItem.Name = "库存报表ToolStripMenuItem";
            this.库存报表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.库存报表ToolStripMenuItem.Text = "库存报表";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.Usermage,
            this.类型管理ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // Usermage
            // 
            this.Usermage.Name = "Usermage";
            this.Usermage.Size = new System.Drawing.Size(124, 22);
            this.Usermage.Text = "用户管理";
            this.Usermage.Click += new System.EventHandler(this.Usermage_Click);
            // 
            // 类型管理ToolStripMenuItem
            // 
            this.类型管理ToolStripMenuItem.Name = "类型管理ToolStripMenuItem";
            this.类型管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.类型管理ToolStripMenuItem.Text = "类型管理";
            this.类型管理ToolStripMenuItem.Click += new System.EventHandler(this.类型管理ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 699);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "仓库管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Dic_set;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 库存报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Usermage;
        private System.Windows.Forms.ToolStripMenuItem 类型管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物资字典维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 类型维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供应商维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单位信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 物资入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物资出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存查询ToolStripMenuItem;
    }
}

