﻿namespace WMS.Stock
{
    partial class OutStockOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutStockOrder));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_print = new System.Windows.Forms.ToolStripButton();
            this.DGV_outStock = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_acountprice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_searchCode = new System.Windows.Forms.ComboBox();
            this.lable = new System.Windows.Forms.Label();
            this.CB_outType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_outDept = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_outStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.TSB_save,
            this.toolStripSeparator3,
            this.TSB_delete,
            this.toolStripSeparator5,
            this.TSB_print});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1171, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // TSB_delete
            // 
            this.TSB_delete.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_delete.Image = ((System.Drawing.Image)(resources.GetObject("TSB_delete.Image")));
            this.TSB_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_delete.Name = "TSB_delete";
            this.TSB_delete.Size = new System.Drawing.Size(62, 22);
            this.TSB_delete.Text = "删 除";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_print
            // 
            this.TSB_print.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_print.Image = ((System.Drawing.Image)(resources.GetObject("TSB_print.Image")));
            this.TSB_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_print.Name = "TSB_print";
            this.TSB_print.Size = new System.Drawing.Size(62, 22);
            this.TSB_print.Text = "打 印";
            // 
            // DGV_outStock
            // 
            this.DGV_outStock.AllowUserToAddRows = false;
            this.DGV_outStock.AllowUserToOrderColumns = true;
            this.DGV_outStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_outStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DGV_outStock.Location = new System.Drawing.Point(6, 87);
            this.DGV_outStock.Name = "DGV_outStock";
            this.DGV_outStock.RowTemplate.Height = 23;
            this.DGV_outStock.Size = new System.Drawing.Size(944, 296);
            this.DGV_outStock.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "编码";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "名称";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "单位";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "数量";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "价格";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(378, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "单据总金额：";
            // 
            // TB_acountprice
            // 
            this.TB_acountprice.AutoSize = true;
            this.TB_acountprice.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_acountprice.Location = new System.Drawing.Point(475, 473);
            this.TB_acountprice.Name = "TB_acountprice";
            this.TB_acountprice.Size = new System.Drawing.Size(49, 14);
            this.TB_acountprice.TabIndex = 2;
            this.TB_acountprice.Text = "[金额]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_acountprice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DGV_outStock);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CB_searchCode);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(14, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1145, 499);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "单据详细信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "查询码：";
            // 
            // CB_searchCode
            // 
            this.CB_searchCode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_searchCode.FormattingEnabled = true;
            this.CB_searchCode.Location = new System.Drawing.Point(74, 36);
            this.CB_searchCode.Name = "CB_searchCode";
            this.CB_searchCode.Size = new System.Drawing.Size(121, 22);
            this.CB_searchCode.TabIndex = 4;
            this.CB_searchCode.SelectedIndexChanged += new System.EventHandler(this.SelectItem);
            this.CB_searchCode.TextUpdate += new System.EventHandler(this.SearchCodeChang);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable.Location = new System.Drawing.Point(42, 58);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(63, 14);
            this.lable.TabIndex = 5;
            this.lable.Text = "出库类型";
            // 
            // CB_outType
            // 
            this.CB_outType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_outType.FormattingEnabled = true;
            this.CB_outType.Items.AddRange(new object[] {
            "正常出库",
            "科室借调",
            "损耗出库",
            "退供应商"});
            this.CB_outType.Location = new System.Drawing.Point(112, 56);
            this.CB_outType.Name = "CB_outType";
            this.CB_outType.Size = new System.Drawing.Size(121, 22);
            this.CB_outType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(287, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "出库科室";
            // 
            // CB_outDept
            // 
            this.CB_outDept.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_outDept.FormattingEnabled = true;
            this.CB_outDept.Items.AddRange(new object[] {
            "正常出库",
            "科室借调",
            "损耗出库",
            "退供应商"});
            this.CB_outDept.Location = new System.Drawing.Point(352, 56);
            this.CB_outDept.Name = "CB_outDept";
            this.CB_outDept.Size = new System.Drawing.Size(121, 22);
            this.CB_outDept.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(553, 58);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "备注";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(592, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 23);
            this.textBox1.TabIndex = 10;
            // 
            // OutStockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 615);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_outDept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_outType);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OutStockOrder";
            this.Text = "出库单";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_outStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSB_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSB_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton TSB_print;
        private System.Windows.Forms.DataGridView DGV_outStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TB_acountprice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_searchCode;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ComboBox CB_outType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_outDept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}