namespace WMS.SystemSet
{
    partial class SupplierSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierSet));
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
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_search = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_supplier = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_add,
            this.toolStripSeparator1,
            this.TSB_edit,
            this.toolStripSeparator2,
            this.TSB_save,
            this.toolStripSeparator3,
            this.TSB_cancel,
            this.toolStripSeparator4,
            this.TSB_delete,
            this.toolStripSeparator5,
            this.toolStripComboBox1,
            this.toolStripSeparator6,
            this.TSB_search});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(565, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_add
            // 
            this.TSB_add.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_add.Image = ((System.Drawing.Image)(resources.GetObject("TSB_add.Image")));
            this.TSB_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_add.Name = "TSB_add";
            this.TSB_add.Size = new System.Drawing.Size(62, 22);
            this.TSB_add.Text = "添 加";
            this.TSB_add.Click += new System.EventHandler(this.TSB_add_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_edit
            // 
            this.TSB_edit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_edit.Image = ((System.Drawing.Image)(resources.GetObject("TSB_edit.Image")));
            this.TSB_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_edit.Name = "TSB_edit";
            this.TSB_edit.Size = new System.Drawing.Size(62, 22);
            this.TSB_edit.Text = "修 改";
            this.TSB_edit.Click += new System.EventHandler(this.TSB_edit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_save
            // 
            this.TSB_save.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_save.Image = ((System.Drawing.Image)(resources.GetObject("TSB_save.Image")));
            this.TSB_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_save.Name = "TSB_save";
            this.TSB_save.Size = new System.Drawing.Size(62, 22);
            this.TSB_save.Text = "保 存";
            this.TSB_save.Click += new System.EventHandler(this.TSB_save_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_cancel
            // 
            this.TSB_cancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_cancel.Image = ((System.Drawing.Image)(resources.GetObject("TSB_cancel.Image")));
            this.TSB_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_cancel.Name = "TSB_cancel";
            this.TSB_cancel.Size = new System.Drawing.Size(62, 22);
            this.TSB_cancel.Text = "取 消";
            this.TSB_cancel.Click += new System.EventHandler(this.TSB_cancel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_delete
            // 
            this.TSB_delete.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_delete.Image = ((System.Drawing.Image)(resources.GetObject("TSB_delete.Image")));
            this.TSB_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_delete.Name = "TSB_delete";
            this.TSB_delete.Size = new System.Drawing.Size(62, 22);
            this.TSB_delete.Text = "删 除";
            this.TSB_delete.Click += new System.EventHandler(this.TSB_delete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_search
            // 
            this.TSB_search.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_search.Image = ((System.Drawing.Image)(resources.GetObject("TSB_search.Image")));
            this.TSB_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_search.Name = "TSB_search";
            this.TSB_search.Size = new System.Drawing.Size(62, 22);
            this.TSB_search.Text = "查 询";
            this.TSB_search.Click += new System.EventHandler(this.TSB_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_code);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DGV_supplier);
            this.groupBox1.Location = new System.Drawing.Point(0, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 484);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "供应商信息";
            this.DGV_supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_Click);
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(302, 39);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(214, 23);
            this.TB_name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "名 称:";
            // 
            // TB_code
            // 
            this.TB_code.Location = new System.Drawing.Point(89, 39);
            this.TB_code.Name = "TB_code";
            this.TB_code.Size = new System.Drawing.Size(100, 23);
            this.TB_code.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "编 号：";
            // 
            // DGV_supplier
            // 
            this.DGV_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_supplier.Location = new System.Drawing.Point(6, 151);
            this.DGV_supplier.Name = "DGV_supplier";
            this.DGV_supplier.RowTemplate.Height = 23;
            this.DGV_supplier.Size = new System.Drawing.Size(525, 150);
            this.DGV_supplier.TabIndex = 0;
            // 
            // SupplierSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierSet";
            this.Text = "供应商设置";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_supplier)).EndInit();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton TSB_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_supplier;
    }
}