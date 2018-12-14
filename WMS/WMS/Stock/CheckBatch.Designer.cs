namespace WMS.Stock
{
    partial class CheckBatch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_batchDetail = new System.Windows.Forms.DataGridView();
            this.BT_sureBatch = new System.Windows.Forms.Button();
            this.BT_close = new System.Windows.Forms.Button();
            this.detailid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodscode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_batchDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_batchDetail
            // 
            this.DGV_batchDetail.AllowUserToAddRows = false;
            this.DGV_batchDetail.AllowUserToDeleteRows = false;
            this.DGV_batchDetail.AllowUserToOrderColumns = true;
            this.DGV_batchDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_batchDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailid,
            this.goodscode1,
            this.goodsname,
            this.amount,
            this.outamount,
            this.goodsunit,
            this.goodsprice});
            this.DGV_batchDetail.Location = new System.Drawing.Point(1, 1);
            this.DGV_batchDetail.Name = "DGV_batchDetail";
            this.DGV_batchDetail.RowTemplate.Height = 23;
            this.DGV_batchDetail.Size = new System.Drawing.Size(766, 322);
            this.DGV_batchDetail.TabIndex = 0;
            // 
            // BT_sureBatch
            // 
            this.BT_sureBatch.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BT_sureBatch.Location = new System.Drawing.Point(291, 329);
            this.BT_sureBatch.Name = "BT_sureBatch";
            this.BT_sureBatch.Size = new System.Drawing.Size(82, 37);
            this.BT_sureBatch.TabIndex = 1;
            this.BT_sureBatch.Text = "确 定";
            this.BT_sureBatch.UseVisualStyleBackColor = true;
            this.BT_sureBatch.Click += new System.EventHandler(this.BT_sureBatch_Click);
            // 
            // BT_close
            // 
            this.BT_close.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BT_close.Location = new System.Drawing.Point(406, 329);
            this.BT_close.Name = "BT_close";
            this.BT_close.Size = new System.Drawing.Size(78, 37);
            this.BT_close.TabIndex = 2;
            this.BT_close.Text = "取 消";
            this.BT_close.UseVisualStyleBackColor = true;
            this.BT_close.Click += new System.EventHandler(this.BT_close_Click);
            // 
            // detailid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.detailid.DefaultCellStyle = dataGridViewCellStyle1;
            this.detailid.HeaderText = "库存号";
            this.detailid.Name = "detailid";
            this.detailid.ReadOnly = true;
            // 
            // goodscode1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goodscode1.DefaultCellStyle = dataGridViewCellStyle2;
            this.goodscode1.HeaderText = "编号";
            this.goodscode1.Name = "goodscode1";
            this.goodscode1.ReadOnly = true;
            // 
            // goodsname
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goodsname.DefaultCellStyle = dataGridViewCellStyle3;
            this.goodsname.HeaderText = "名称";
            this.goodsname.Name = "goodsname";
            this.goodsname.ReadOnly = true;
            // 
            // amount
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.amount.HeaderText = "数量";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // outamount
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outamount.DefaultCellStyle = dataGridViewCellStyle5;
            this.outamount.HeaderText = "出库数";
            this.outamount.Name = "outamount";
            // 
            // goodsunit
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goodsunit.DefaultCellStyle = dataGridViewCellStyle6;
            this.goodsunit.HeaderText = "单位";
            this.goodsunit.Name = "goodsunit";
            this.goodsunit.ReadOnly = true;
            // 
            // goodsprice
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goodsprice.DefaultCellStyle = dataGridViewCellStyle7;
            this.goodsprice.HeaderText = "价格";
            this.goodsprice.Name = "goodsprice";
            this.goodsprice.ReadOnly = true;
            // 
            // CheckBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 378);
            this.Controls.Add(this.BT_close);
            this.Controls.Add(this.BT_sureBatch);
            this.Controls.Add(this.DGV_batchDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckBatch";
            this.Text = "CheckBatch";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_batchDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_batchDetail;
        private System.Windows.Forms.Button BT_sureBatch;
        private System.Windows.Forms.Button BT_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailid;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodscode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsname;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn outamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsprice;
    }
}