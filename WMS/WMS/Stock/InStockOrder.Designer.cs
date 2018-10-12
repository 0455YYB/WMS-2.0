namespace WMS.Stock
{
    partial class In_StockOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(In_StockOrder));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_update = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_print = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DGV_orderDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_batch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.TB_unit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_acount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_price = new System.Windows.Forms.TextBox();
            this.Commit = new System.Windows.Forms.Button();
            this.SavePicture = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.PB_order = new System.Windows.Forms.PictureBox();
            this.CB_instockType = new System.Windows.Forms.ComboBox();
            this.CB_searchCode = new System.Windows.Forms.ComboBox();
            this.CB_supplier = new System.Windows.Forms.ComboBox();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_orderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_order)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_save,
            this.toolStripSeparator2,
            this.TSB_update,
            this.toolStripSeparator3,
            this.TSB_print,
            this.toolStripSeparator4,
            this.TSB_delete,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_update
            // 
            this.TSB_update.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_update.Image = ((System.Drawing.Image)(resources.GetObject("TSB_update.Image")));
            this.TSB_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_update.Name = "TSB_update";
            this.TSB_update.Size = new System.Drawing.Size(62, 22);
            this.TSB_update.Text = "修 改";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // DGV_orderDetail
            // 
            this.DGV_orderDetail.AllowUserToAddRows = false;
            this.DGV_orderDetail.AllowUserToDeleteRows = false;
            this.DGV_orderDetail.AllowUserToOrderColumns = true;
            this.DGV_orderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_orderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail,
            this.code,
            this.name,
            this.acount,
            this.unit,
            this.price,
            this.batch});
            this.DGV_orderDetail.Location = new System.Drawing.Point(7, 72);
            this.DGV_orderDetail.Name = "DGV_orderDetail";
            this.DGV_orderDetail.RowTemplate.Height = 23;
            this.DGV_orderDetail.Size = new System.Drawing.Size(787, 204);
            this.DGV_orderDetail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "供应商：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(220, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "入库批次：";
            // 
            // TB_batch
            // 
            this.TB_batch.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_batch.Location = new System.Drawing.Point(304, 34);
            this.TB_batch.Name = "TB_batch";
            this.TB_batch.Size = new System.Drawing.Size(100, 23);
            this.TB_batch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(465, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "入库类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "编 码：";
            // 
            // TB_code
            // 
            this.TB_code.Enabled = false;
            this.TB_code.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_code.Location = new System.Drawing.Point(73, 336);
            this.TB_code.Name = "TB_code";
            this.TB_code.Size = new System.Drawing.Size(100, 23);
            this.TB_code.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(223, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "名 称：";
            // 
            // TB_name
            // 
            this.TB_name.Enabled = false;
            this.TB_name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_name.Location = new System.Drawing.Point(282, 336);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(175, 23);
            this.TB_name.TabIndex = 11;
            // 
            // TB_unit
            // 
            this.TB_unit.Enabled = false;
            this.TB_unit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_unit.Location = new System.Drawing.Point(673, 335);
            this.TB_unit.Name = "TB_unit";
            this.TB_unit.Size = new System.Drawing.Size(63, 23);
            this.TB_unit.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(521, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "数量：";
            // 
            // TB_acount
            // 
            this.TB_acount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_acount.Location = new System.Drawing.Point(567, 335);
            this.TB_acount.Name = "TB_acount";
            this.TB_acount.Size = new System.Drawing.Size(100, 23);
            this.TB_acount.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(16, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "购入价";
            // 
            // TB_price
            // 
            this.TB_price.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_price.Location = new System.Drawing.Point(75, 387);
            this.TB_price.Name = "TB_price";
            this.TB_price.Size = new System.Drawing.Size(100, 23);
            this.TB_price.TabIndex = 17;
            // 
            // Commit
            // 
            this.Commit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Commit.Location = new System.Drawing.Point(137, 460);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(75, 29);
            this.Commit.TabIndex = 18;
            this.Commit.Text = "确 定";
            this.Commit.UseVisualStyleBackColor = true;
            this.Commit.Click += new System.EventHandler(this.Commit_Click);
            // 
            // SavePicture
            // 
            this.SavePicture.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SavePicture.Location = new System.Drawing.Point(250, 460);
            this.SavePicture.Name = "SavePicture";
            this.SavePicture.Size = new System.Drawing.Size(75, 28);
            this.SavePicture.TabIndex = 19;
            this.SavePicture.Text = "导入图片";
            this.SavePicture.UseVisualStyleBackColor = true;
            this.SavePicture.Click += new System.EventHandler(this.SavePicture_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(16, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 21;
            this.label9.Text = "查询码：";
            // 
            // PB_order
            // 
            this.PB_order.Location = new System.Drawing.Point(411, 390);
            this.PB_order.Name = "PB_order";
            this.PB_order.Size = new System.Drawing.Size(197, 117);
            this.PB_order.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_order.TabIndex = 22;
            this.PB_order.TabStop = false;
            // 
            // CB_instockType
            // 
            this.CB_instockType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_instockType.FormattingEnabled = true;
            this.CB_instockType.Items.AddRange(new object[] {
            "购买入库",
            "院内转借",
            "科室退回"});
            this.CB_instockType.Location = new System.Drawing.Point(537, 35);
            this.CB_instockType.Name = "CB_instockType";
            this.CB_instockType.Size = new System.Drawing.Size(121, 22);
            this.CB_instockType.TabIndex = 23;
            // 
            // CB_searchCode
            // 
            this.CB_searchCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CB_searchCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_searchCode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_searchCode.FormattingEnabled = true;
            this.CB_searchCode.Location = new System.Drawing.Point(86, 295);
            this.CB_searchCode.Name = "CB_searchCode";
            this.CB_searchCode.Size = new System.Drawing.Size(267, 22);
            this.CB_searchCode.TabIndex = 24;
            this.CB_searchCode.SelectedIndexChanged += new System.EventHandler(this.CB_search_ChoiceItem);
            this.CB_searchCode.TextUpdate += new System.EventHandler(this.TextChang);
            // 
            // CB_supplier
            // 
            this.CB_supplier.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_supplier.FormattingEnabled = true;
            this.CB_supplier.Location = new System.Drawing.Point(75, 34);
            this.CB_supplier.Name = "CB_supplier";
            this.CB_supplier.Size = new System.Drawing.Size(121, 22);
            this.CB_supplier.TabIndex = 25;
            // 
            // detail
            // 
            this.detail.HeaderText = "ID";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            // 
            // code
            // 
            this.code.HeaderText = "编号";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // acount
            // 
            this.acount.HeaderText = "数量";
            this.acount.Name = "acount";
            // 
            // unit
            // 
            this.unit.HeaderText = "单位";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "价格";
            this.price.Name = "price";
            // 
            // batch
            // 
            this.batch.HeaderText = "批次";
            this.batch.Name = "batch";
            this.batch.ReadOnly = true;
            // 
            // In_StockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.CB_supplier);
            this.Controls.Add(this.CB_searchCode);
            this.Controls.Add(this.CB_instockType);
            this.Controls.Add(this.PB_order);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SavePicture);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.TB_price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_acount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_unit);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_batch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_orderDetail);
            this.Controls.Add(this.toolStrip1);
            this.Name = "In_StockOrder";
            this.Text = "入库单据";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_orderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSB_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSB_print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridView DGV_orderDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_batch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.TextBox TB_unit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_acount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_price;
        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.Button SavePicture;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox PB_order;
        private System.Windows.Forms.ComboBox CB_instockType;
        private System.Windows.Forms.ComboBox CB_searchCode;
        private System.Windows.Forms.ComboBox CB_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn acount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn batch;
    }
}