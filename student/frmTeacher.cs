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
    public partial class frmTeacher : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();     
        private string sql;
       
        public frmTeacher()
        {
            InitializeComponent();
            SetBind();           
            
        }

        //----绑定DataGivdView数据
        protected void SetBind()
        {
           
            try{
                sql = "select cjh_Tno01 as 教工号 ,cjh_Tname01 as 姓名,cjh_Tsex01   as 性别,cjh_Tyear01 as 年龄 ,cjh_Tposition01 as 职称,cjh_Temail01 as 联系方式 from cjh_Teachers01";
                ds = con.BindDataGridView(dataGView, sql);          
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }  catch  {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //--------插入数据
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try{  
                sql = "insert into cjh_Teachers01 values( '" + Tno.Text + "','" + name.Text + "','" + sex.Text + "','" +age.Text + "','" +title.Text + "','" +email.Text + "')";
                con.OperateData(sql); 
                SetBind();
            }catch{
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
        //--------删除数据
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try {                   
                    sql = "delete from cjh_Teachers01 where cjh_Tno01 ='" + dataGView.CurrentRow.Cells[0].Value.ToString()
                           + "'";
                    con.OperateData(sql);
                    SetBind();
                } catch{
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                }

            }
               
        }

        private void btnChange_Click(object sender, EventArgs e)
        { 
            try {
                sql = "update cjh_Teachers01 set Grade='" + dataGView.CurrentRow.Cells[2].Value.ToString() +
                    "' where Sno='" + dataGView.CurrentRow.Cells[3].Value.ToString() 
                    + "' and Cno='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();
            }catch {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

   
    }
}
