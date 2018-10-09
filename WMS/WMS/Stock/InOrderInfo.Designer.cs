namespace WMS.Stock
{
    partial class OrderInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInfo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TSB_type = new System.Windows.Forms.ToolStripComboBox();
            this.TSB_createOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_auditing = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_delete = new System.Windows.Forms.ToolStripButton();
            this.TSB_print = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.Button();
            this.DTP_endTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_type = new System.Windows.Forms.ComboBox();
            this.DTP_startTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_order = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_orderDetail = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_order)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_orderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.TSB_type,
            this.TSB_createOrder,
            this.toolStripSeparator1,
            this.TSB_edit,
            this.toolStripSeparator2,
            this.TSB_save,
            this.toolStripSeparator3,
            this.TSB_auditing,
            this.toolStripSeparator4,
            this.TSB_delete,
            this.TSB_print});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(849, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "入库类型：";
            // 
            // TSB_type
            // 
            this.TSB_type.Name = "TSB_type";
            this.TSB_type.Size = new System.Drawing.Size(104, 25);
            // 
            // TSB_createOrder
            // 
            this.TSB_createOrder.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_createOrder.Image = ((System.Drawing.Image)(resources.GetObject("TSB_createOrder.Image")));
            this.TSB_createOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_createOrder.Name = "TSB_createOrder";
            this.TSB_createOrder.Size = new System.Drawing.Size(97, 22);
            this.TSB_createOrder.Text = "新增入库单";
            this.TSB_createOrder.Click += new System.EventHandler(this.TSB_createOrder_Click);
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
            this.TSB_edit.Size = new System.Drawing.Size(55, 22);
            this.TSB_edit.Text = "修改";
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
            this.TSB_save.Size = new System.Drawing.Size(55, 22);
            this.TSB_save.Text = "保存";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // TSB_auditing
            // 
            this.TSB_auditing.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_auditing.Image = ((System.Drawing.Image)(resources.GetObject("TSB_auditing.Image")));
            this.TSB_auditing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_auditing.Name = "TSB_auditing";
            this.TSB_auditing.Size = new System.Drawing.Size(55, 22);
            this.TSB_auditing.Text = "审核";
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
            this.TSB_delete.Size = new System.Drawing.Size(55, 22);
            this.TSB_delete.Text = "删除";
            // 
            // TSB_print
            // 
            this.TSB_print.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSB_print.Image = ((System.Drawing.Image)(resources.GetObject("TSB_print.Image")));
            this.TSB_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_print.Name = "TSB_print";
            this.TSB_print.Size = new System.Drawing.Size(55, 22);
            this.TSB_print.Text = "打印";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.DTP_endTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CB_type);
            this.groupBox1.Controls.Add(this.DTP_startTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DGV_order);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 572);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单 据";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.Location = new System.Drawing.Point(159, 136);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(94, 32);
            this.Search.TabIndex = 6;
            this.Search.Text = "查 询";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // DTP_endTime
            // 
            this.DTP_endTime.Location = new System.Drawing.Point(55, 94);
            this.DTP_endTime.Name = "DTP_endTime";
            this.DTP_endTime.Size = new System.Drawing.Size(200, 23);
            this.DTP_endTime.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "时 间:";
            // 
            // CB_type
            // 
            this.CB_type.FormattingEnabled = true;
            this.CB_type.Location = new System.Drawing.Point(53, 23);
            this.CB_type.Name = "CB_type";
            this.CB_type.Size = new System.Drawing.Size(121, 22);
            this.CB_type.TabIndex = 3;
            // 
            // DTP_startTime
            // 
            this.DTP_startTime.Location = new System.Drawing.Point(55, 57);
            this.DTP_startTime.Name = "DTP_startTime";
            this.DTP_startTime.Size = new System.Drawing.Size(200, 23);
            this.DTP_startTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "类 型：";
            // 
            // DGV_order
            // 
            this.DGV_order.AllowUserToAddRows = false;
            this.DGV_order.AllowUserToDeleteRows = false;
            this.DGV_order.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_order.Location = new System.Drawing.Point(5, 226);
            this.DGV_order.Name = "DGV_order";
            this.DGV_order.ReadOnly = true;
            this.DGV_order.RowTemplate.Height = 23;
            this.DGV_order.Size = new System.Drawing.Size(248, 382);
            this.DGV_order.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "单号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "状态";
            this.Column2.Name = "Column2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DGV_orderDetail);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(283, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 570);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "单据详细信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "[金额]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "单据总金额：";
            // 
            // DGV_orderDetail
            // 
            this.DGV_orderDetail.AllowUserToOrderColumns = true;
            this.DGV_orderDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_orderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_orderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DGV_orderDetail.Location = new System.Drawing.Point(6, 22);
            this.DGV_orderDetail.Name = "DGV_orderDetail";
            this.DGV_orderDetail.RowTemplate.Height = 23;
            this.DGV_orderDetail.Size = new System.Drawing.Size(554, 514);
            this.DGV_orderDetail.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "编号";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "名称";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "单位";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "数量";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "批次";
            this.Column7.Name = "Column7";
            // 
            // OrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Gigi", 8.25F);
            this.Name = "OrderInfo";
            this.Text = "物资入库";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_order)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_orderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox TSB_type;
        private System.Windows.Forms.ToolStripButton TSB_createOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSB_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSB_auditing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TSB_delete;
        private System.Windows.Forms.ToolStripButton TSB_print;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DateTimePicker DTP_endTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_type;
        private System.Windows.Forms.DateTimePicker DTP_startTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_orderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}