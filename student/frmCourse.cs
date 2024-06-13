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
    public partial class frmCourse : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        public frmCourse(){
            InitializeComponent();
            SetBind();
        }

        //----绑定DataGivdView数据
        protected void SetBind()
        {    
            try {
                sql = "select cjh_Cno01 as 课程号,cjh_Cname01 as 课程名称,cjh_Copentime01 as 开课时间,cjh_Ccredittime01 as 学时, cjh_Ccheck01 as考核模式,cjh_Ccredit01 as 学分 from cjh_Courses01";
                ds = con.BindDataGridView(dataGView, sql);              
                dataGView.Columns[0].ReadOnly = true;                
                dataGView.AllowUserToAddRows = false;
            }catch{
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


      //---插入数据
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!Identity.id.Contains("管理员"))
            {
                MessageBox.Show("你不具有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {                
                sql = "INSERT INTO cjh_Courses01 VALUES( '" + txtCno.Text + "','"  + txtName.Text + "','" + dateTimePicker1.Value.ToString() + "','" +hour.Text + "','" +check.Text+ "','" + txtCredit.Text + "');" ;
                con.OperateData(sql);
                SetBind();
            }catch {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
           
        }
        //--------修改记录
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!Identity.id.Contains("管理员"))
            {
                MessageBox.Show("你不具有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                sql = "update cjh_Courses01 set cjh_Cname01='" + dataGView.CurrentRow.Cells[1].Value.ToString() +
                    "',cjh_Copentime01='" + dataGView.CurrentRow.Cells[2].Value.ToString() + "',cjh_Ccredittime01='" + dataGView.CurrentRow.Cells[3].Value.ToString()+ "',cjh_Ccheck01='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "',cjh_Ccredit01='" + dataGView.CurrentRow.Cells[5].Value.ToString()+
                    "' where cjh_Cno01='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();
            }catch{
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }          
        }
        //---删除记录
        private void btnDelete_Click(object sender, EventArgs e){
            if (!Identity.id.Contains("管理员"))
            {
                MessageBox.Show("你不具有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
              try {                                
                    sql = "delete from cjh_Courses01 where cjh_Cno01='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
                   }catch{
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                }
            }               
        }
       //---关闭窗口
        private void btnCancel_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}