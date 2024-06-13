using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace student
{
    public class Identity
    {
        public static string id;
        public static string No;
    }
    public partial class FrmLogin : Form
    {

        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        public DataSet ds2 = new DataSet();
        private string sql;

        public FrmLogin()
        {
            
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            //SetBind();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {           
            if (txtName.Text == "" || txtPwd.Text == "")
                MessageBox.Show("用户名或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            else
            {
                string sql = "select cjh_identity01  from cjh_Register01 where cjh_User01='" + txtName.Text + "'and cjh_password01='" + txtPwd.Text + "'";
               
                string identity = null;
               
                
                ds = con.Getds(sql);
               
     
                if (ds.Tables[0].Rows.Count>0)
                {   
                   
                    identity = ds.Tables[0].Rows[0][0].ToString();
                    
                    
                }
                
                if (identity != null)
                {
                    Identity.id= identity;
                    Identity.No = txtName.Text;
                    MessageBox.Show("登录验证成功");
                    frmMain fmain = new frmMain();
                    fmain.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("输入的身份、账号或密码有误！请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtPwd.Clear();

                }
                
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
