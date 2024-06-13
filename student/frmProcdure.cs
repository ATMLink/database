using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace student
{
    public partial class frmProcdure : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        
        public frmProcdure()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e){
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {          
           try {
                string sql = "CALL proc_re('" + txtCno.Text + "');";
                 string sql2 = "SELECT* from cjh_proc01; ";
                //  Console.WriteLine(sql);
                // sqlConnect conn=new sqlConnect(); 
                con.OperateData(sql);
                ds = con.BindDataGridView(dataGView, sql2);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false; 
           }catch {
               MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
        }

        private void search(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "CALL proc_STU('"+textname.Text+"',@TSno01);";
                string sql2 = "SELECT* from cjh_proc02; ";
                con.OperateData(sql1);
                ds = con.Getds(sql2);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    textBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                    textBox1.ReadOnly = true;
                }
                else {
                    MessageBox.Show("未知道该同学的学号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

