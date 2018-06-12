namespace WMS
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.But_login = new System.Windows.Forms.Button();
            this.But_cancel = new System.Windows.Forms.Button();
            this.Tex_userName = new System.Windows.Forms.TextBox();
            this.Tex_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账 号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(55, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密 码：";
            // 
            // But_login
            // 
            this.But_login.Location = new System.Drawing.Point(42, 99);
            this.But_login.Name = "But_login";
            this.But_login.Size = new System.Drawing.Size(75, 30);
            this.But_login.TabIndex = 2;
            this.But_login.Text = "登 录";
            this.But_login.UseVisualStyleBackColor = true;
            this.But_login.Click += new System.EventHandler(this.But_login_Click);
            // 
            // But_cancel
            // 
            this.But_cancel.Location = new System.Drawing.Point(155, 99);
            this.But_cancel.Name = "But_cancel";
            this.But_cancel.Size = new System.Drawing.Size(75, 30);
            this.But_cancel.TabIndex = 3;
            this.But_cancel.Text = "取 消";
            this.But_cancel.UseVisualStyleBackColor = true;
            this.But_cancel.Click += new System.EventHandler(this.But_cancel_Click);
            // 
            // Tex_userName
            // 
            this.Tex_userName.Location = new System.Drawing.Point(120, 20);
            this.Tex_userName.Name = "Tex_userName";
            this.Tex_userName.Size = new System.Drawing.Size(100, 21);
            this.Tex_userName.TabIndex = 4;
            // 
            // Tex_password
            // 
            this.Tex_password.Location = new System.Drawing.Point(121, 58);
            this.Tex_password.Name = "Tex_password";
            this.Tex_password.Size = new System.Drawing.Size(100, 21);
            this.Tex_password.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::WMS.Properties.Resources.登录背景;
            this.ClientSize = new System.Drawing.Size(282, 141);
            this.Controls.Add(this.Tex_password);
            this.Controls.Add(this.Tex_userName);
            this.Controls.Add(this.But_cancel);
            this.Controls.Add(this.But_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "登 录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button But_login;
        private System.Windows.Forms.Button But_cancel;
        private System.Windows.Forms.TextBox Tex_userName;
        private System.Windows.Forms.TextBox Tex_password;
    }
}