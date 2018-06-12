using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WMS
{
    public partial class FrmLogin : Form
    {
        WMS.SQLHelper.SQLHelper sh = new SQLHelper.SQLHelper();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void But_login_Click(object sender, EventArgs e)
        {
            try
            {
                if(Tex_userName.Text.Trim()==string.Empty)
                {
                    MessageBox.Show("请输入用户名和密码");
                }
                else
                {
                    if(Tex_password.Text.Trim()==string.Empty)
                    {
                        MessageBox.Show("请输入密码");
                    }
                    else
                    {
                        SQLiteDataReader userInfo = sh.GetLoginInfo(this.Tex_userName.Text.Trim());
                        userInfo.Read();
                        if((string)userInfo["password"]==Tex_password.Text.Trim())
                        {
                            FrmMain frmMain = new FrmMain();
                            frmMain.Owner = this;
                            frmMain.Show();
                            this.Hide();
                        }
                    }
                                    
                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sh.sqliteCon.Close();
            }

        }
        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void But_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
