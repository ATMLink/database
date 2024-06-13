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
    public partial class frmSearch : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        
        private string sql;
        private string SelSno="";
        private int selNo = 0;

        public frmSearch(){
          InitializeComponent();
            if (Identity.id.Contains("学生")) 
            {
                
                BindS(); 
            }
            else if (Identity.id.Contains("教师")) {  BindP(); }
            else {
                
                BindS();
                BindP();
            }
        }


        //----绑定DataGivdView数据
        protected void BindS(){          
          try {
                sql = "SELECT *FROM cjh_STC_View; ";
                ds = con.BindDataGridView(DgvS, sql);               
                if(ds.Tables[0].Rows.Count!=0){                
                 DgvS.Columns[0].ReadOnly = true;             
                 DgvS.AllowUserToAddRows = false;                 
                 SelSno = DgvS.Rows[0].Cells[0].Value.ToString();
               } 
            }catch{
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void BindP()
        {
            sql = "SELECT *FROM  cjh_SC_View; ";
            //sql = "select Sno as 学号,Cname  as 课程名称,Grade as 成绩 ,Courses.Cno from Courses,Reports  where  Reports.Cno=Courses.Cno and Sno='"+SelSno+"'";
            try
            {
                ds = con.BindDataGridView(DgvT, sql);            
                DgvT.Columns[0].ReadOnly = true;
              
                DgvT.AllowUserToAddRows = false;
            }catch{
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void search(object sender, EventArgs e)
        {   if (!Identity.id.Contains("教师"))
            {
                sql = "SELECT 课程名,上课时间,教室编号,教师名 FROM  cjh_STC_View where 名字='" + Sname.Text + "'";
            }
            
            ds = con.BindDataGridView(DgvS, sql);
            if (ds.Tables[0].Rows.Count != 0)
            {
                DgvS.Columns[0].ReadOnly = true;
                DgvS.AllowUserToAddRows = false;
            }
        }
        private void search2(object sender, EventArgs e)
        {
            if (!Identity.id.Contains("学生"))
            {
                sql = "SELECT 课程名,上课时间,教室编号 FROM  cjh_SC_View where 教师名='" + Tname.Text + "'";
            }
            
            ds = con.BindDataGridView(DgvT, sql);
            if (ds.Tables[0].Rows.Count != 0)
            {
                DgvT.Columns[0].ReadOnly = true;
                DgvT.AllowUserToAddRows = false;
            }
        }
    }
}
