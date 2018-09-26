namespace WMS.SystemSet
{
    partial class DepartmentSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentSet));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_cancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_delete = new System.Windows.Forms.ToolStripButton();
            this.DGV_department = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_code = new System.Windows.Forms.TextBox();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_department)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_add,
            this.toolStripSeparator1,
            this.TSB_edit,
            this.toolStripSeparator2,
            this.TSB_save,
            this.toolStripSeparator3,
            this.TSB_cancel,
            this.toolStripSeparator4,
            this.TSB_delete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(559, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_add
            // 
            this.TSB_add.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_add.Image = ((System.Drawing.Image)(resources.GetObject("TSB_add.Image")));
            this.TSB_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_add.Name = "TSB_add";
            this.TSB_add.Size = new System.Drawing.Size(66, 24);
            this.TSB_add.Text = "添 加";
            this.TSB_add.Click += new System.EventHandler(this.TSB_add_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // TSB_edit
            // 
            this.TSB_edit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_edit.Image = ((System.Drawing.Image)(resources.GetObject("TSB_edit.Image")));
            this.TSB_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_edit.Name = "TSB_edit";
            this.TSB_edit.Size = new System.Drawing.Size(66, 24);
            this.TSB_edit.Text = "修 改";
            this.TSB_edit.Click += new System.EventHandler(this.TSB_edit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // TSB_save
            // 
            this.TSB_save.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_save.Image = ((System.Drawing.Image)(resources.GetObject("TSB_save.Image")));
            this.TSB_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_save.Name = "TSB_save";
            this.TSB_save.Size = new System.Drawing.Size(66, 24);
            this.TSB_save.Text = "保 存";
            this.TSB_save.Click += new System.EventHandler(this.TSB_save_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // TSB_cancel
            // 
            this.TSB_cancel.Image = ((System.Drawing.Image)(resources.GetObject("TSB_cancel.Image")));
            this.TSB_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_cancel.Name = "TSB_cancel";
            this.TSB_cancel.Size = new System.Drawing.Size(60, 24);
            this.TSB_cancel.Text = "取 消";
            this.TSB_cancel.Click += new System.EventHandler(this.TSB_cancel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // TSB_delete
            // 
            this.TSB_delete.Image = ((System.Drawing.Image)(resources.GetObject("TSB_delete.Image")));
            this.TSB_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_delete.Name = "TSB_delete";
            this.TSB_delete.Size = new System.Drawing.Size(60, 24);
            this.TSB_delete.Text = "删 除";
            this.TSB_delete.Click += new System.EventHandler(this.TSB_delete_Click);
            // 
            // DGV_department
            // 
            this.DGV_department.AllowUserToAddRows = false;
            this.DGV_department.AllowUserToDeleteRows = false;
            this.DGV_department.AllowUserToOrderColumns = true;
            this.DGV_department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_department.Location = new System.Drawing.Point(10, 33);
            this.DGV_department.Name = "DGV_department";
            this.DGV_department.ReadOnly = true;
            this.DGV_department.RowTemplate.Height = 23;
            this.DGV_department.Size = new System.Drawing.Size(238, 413);
            this.DGV_department.TabIndex = 1;
            this.DGV_department.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_departmentCell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "部门编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "部门名称：";
            // 
            // TB_code
            // 
            this.TB_code.Enabled = false;
            this.TB_code.Location = new System.Drawing.Point(341, 90);
            this.TB_code.Name = "TB_code";
            this.TB_code.Size = new System.Drawing.Size(131, 23);
            this.TB_code.TabIndex = 5;
            // 
            // TB_name
            // 
            this.TB_name.Enabled = false;
            this.TB_name.Location = new System.Drawing.Point(341, 155);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(131, 23);
            this.TB_name.TabIndex = 6;
            // 
            // DepartmentSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 449);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.TB_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_department);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartmentSet";
            this.Text = "部门维护";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_department)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSB_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSB_cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TSB_delete;
        private System.Windows.Forms.DataGridView DGV_department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_code;
        private System.Windows.Forms.TextBox TB_name;
    }
}