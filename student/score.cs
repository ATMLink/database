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
    public partial class score : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        public score()
        {
            InitializeComponent();
            SetBind();
        }
        protected void SetBind()
        {
            try
            {
                sql = "SELECT DISTINCT cjh_Tname01 AS 教师名, cjh_Cname01 AS 课程名, cjh_tsscore01 AS 成绩 FROM cjh_students01, cjh_Courses01, cjh_teachers01, cjh_courses_classroom01, cjh_teachers_students01 WHERE"
    + " cjh_teachers_students01.cjh_sno01 = '" + Identity.No + "'"
    + " AND cjh_courses01.cjh_cno01 = cjh_teachers_students01.cjh_cno01"
    + " AND cjh_teachers01.cjh_tno01 = cjh_teachers_students01.cjh_tno01"
    + " AND cjh_courses01.cjh_cno01 = cjh_courses_classroom01.cjh_cno01";
                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
