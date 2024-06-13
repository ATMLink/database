using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace student
{
    public partial class frmStudent : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();        
        private string sql;
       
        public frmStudent()
        {
            InitializeComponent();
          //  ComBoxBind();
            SetBind();           
        }
      
        //----绑定DataGivdView数据
        protected void SetBind()
        {           
            sql = "SELECT cjh_Sno01 as 学号,cjh_Sname01 as 姓名,cjh_Sage01 as 年龄,cjh_Ssex01 as 性别,cjh_Sgrade01 as 年级,cjh_Sdepartment as 系名,cjh_Scredit01 as 学分  FROM cjh_Students01 ";
            try{
                ds = con.BindDataGridView(dataGView, sql);              
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }catch(Exception e){
                Console.Write(e);
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                        
        }

        //----插入数据项
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!Identity.id.Contains("管理员"))
            {
                MessageBox.Show("你不具有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                sql = "INSERT INTO cjh_Students01 VALUES ( '" + no.Text + "','" + name.Text + "','" + age.Text + "','" + sex.Text + "','" +place.Text+ "','" +credit.Text+ "','" +grade.Text+ "','" + depart.Text + "','" +email.Text+ "');";
                con.OperateData(sql);
                SetBind();
            }
            catch {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        //----关闭窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //----删除当前行
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Identity.id.Contains("管理员")) {
                MessageBox.Show("你不具有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string Sno = dataGView.CurrentRow.Cells[0].Value.ToString();                  
                    sql = "DELETE FROM cjh_Students01 WHERE cjh_Sno01= '" + Sno + "'";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                }catch {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                }                                
            }
            else    return;
                  
        }



        //----修改当前行
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!Identity.id.Contains("管理员"))
            {
                MessageBox.Show("你不具有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            try
            {
               // sql = "SELECT Dno FROM Depts WHERE Dname='" + dataGView.CurrentRow.Cells[2].Value.ToString() + "'";
              //  ds = con.Getds(sql);
                sql = "update cjh_Students01 set cjh_Sname01='" + dataGView.CurrentRow.Cells[1].Value.ToString() +
                   "',cjh_Sage01='" + dataGView.CurrentRow.Cells[2].Value.ToString() + "',cjh_Ssex01='" + dataGView.CurrentRow.Cells[3].Value.ToString() + "',cjh_Sgrade01='" + dataGView.CurrentRow.Cells[4].Value.ToString() + "',cjh_Sdepartment='" + dataGView.CurrentRow.Cells[5].Value.ToString() + "',cjh_Scredit01='" + dataGView.CurrentRow.Cells[6].Value.ToString() + 
                "' where cjh_Sno01='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();
            }
            catch{
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
                    
        }
       
      
    }
}
