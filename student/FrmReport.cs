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
    public partial class frmReport : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private bool esc = false;
        public frmReport()
        {
            InitializeComponent();
            SetBind();
           
           
        }

        //----绑定DataGivdView数据
        protected void SetBind()
        {

            try
            {
                sql = "SELECT cjh_teachers_students01.cjh_Sno01 As 学号,cjh_Sname01 As 名字,cjh_Cname01 As 课程名,cjh_Tname01 as 任课教师,cjh_TSsemester01 as 学期 ,cjh_TSscore01 as 成绩 from cjh_Students01, cjh_Teachers_Students01, cjh_Courses01, cjh_teachers01 WHERE "
   + "cjh_students01.cjh_sno01 = cjh_teachers_students01.cjh_sno01"
+ " AND cjh_courses01.cjh_cno01 = cjh_teachers_students01.cjh_cno01"
+ " AND cjh_teachers01.cjh_tno01 = cjh_teachers_students01.cjh_tno01 "
+ " order by cjh_TSscore01 DESC";
                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //-----绑定下拉框数据
     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string order = esc ? "ASC" : "DESC";
            try
            {
                if (course.Text == "" && (semester.Text != "所有" && semester.Text != ""))
                {
                    sql = "SELECT cjh_teachers_students01.cjh_Sno01 As 学号,cjh_Sname01 As 名字,cjh_Cname01 As 课程名,cjh_Tname01 as 任课教师,cjh_TSsemester01 as 学期 ,cjh_TSscore01 as 成绩 from cjh_Students01, cjh_Teachers_Students01, cjh_Courses01, cjh_teachers01 WHERE "
                         + "cjh_students01.cjh_sno01 = cjh_teachers_students01.cjh_sno01"
    + " AND cjh_courses01.cjh_cno01 = cjh_teachers_students01.cjh_cno01"
    + " AND cjh_teachers01.cjh_tno01 = cjh_teachers_students01.cjh_tno01"
    + " AND cjh_TSsemester01 = '" + semester.Text + "'"
    + " order by cjh_TSscore01 " + order;
                }
                else if ((semester.Text == "所有" || semester.Text == "") && course.Text != "")
                {
                    sql = "SELECT cjh_teachers_students01.cjh_Sno01 As 学号,cjh_Sname01 As 名字,cjh_Cname01 As 课程名,cjh_Tname01 as 任课教师,cjh_TSsemester01 as 学期 ,cjh_TSscore01 as 成绩 from cjh_Students01, cjh_Teachers_Students01, cjh_Courses01, cjh_teachers01 WHERE "
                         + "cjh_students01.cjh_sno01 = cjh_teachers_students01.cjh_sno01"
    + " AND cjh_courses01.cjh_cno01 = cjh_teachers_students01.cjh_cno01"
    + " AND cjh_teachers01.cjh_tno01 = cjh_teachers_students01.cjh_tno01"
    + " AND cjh_Cname01 = '" + course.Text + "'"
    + " order by cjh_TSscore01 " + order;
                }
                else if (course.Text != "" && (semester.Text != "所有" && semester.Text != ""))
                {
                    sql = "SELECT cjh_teachers_students01.cjh_Sno01 As 学号,cjh_Sname01 As 名字,cjh_Cname01 As 课程名,cjh_Tname01 as 任课教师,cjh_TSsemester01 as 学期 ,cjh_TSscore01 as 成绩 from cjh_Students01, cjh_Teachers_Students01, cjh_Courses01, cjh_teachers01 WHERE "
                         + "cjh_students01.cjh_sno01 = cjh_teachers_students01.cjh_sno01"
    + " AND cjh_courses01.cjh_cno01 = cjh_teachers_students01.cjh_cno01"
    + " AND cjh_teachers01.cjh_tno01 = cjh_teachers_students01.cjh_tno01"
    + " AND cjh_Cname01 = '" + course.Text + "'"
    + " AND cjh_TSsemester01 = '" + semester.Text + "'"
    + " order by cjh_TSscore01 " + order;
                }
                else if (course.Text == "" && (semester.Text == "所有" || semester.Text == ""))
                {
                    sql = "SELECT cjh_teachers_students01.cjh_Sno01 As 学号,cjh_Sname01 As 名字,cjh_Cname01 As 课程名,cjh_Tname01 as 任课教师,cjh_TSsemester01 as 学期 ,cjh_TSscore01 as 成绩 from cjh_Students01, cjh_Teachers_Students01, cjh_Courses01, cjh_teachers01 WHERE "
           + "cjh_students01.cjh_sno01 = cjh_teachers_students01.cjh_sno01"
        + " AND cjh_courses01.cjh_cno01 = cjh_teachers_students01.cjh_cno01"
        + " AND cjh_teachers01.cjh_tno01 = cjh_teachers_students01.cjh_tno01 "
        + " order by cjh_TSscore01 " + order;
                }
                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch (Exception)
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            esc = esc ? false : true;
            
        }
    }
}
