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
    public partial class frmMain : Form
    {   
        public frmMain()
        {
            InitializeComponent();
        }

        private void 成绩表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport freports = new frmReport();
            freports.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 学生表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent fStudent = new frmStudent();
            fStudent.ShowDialog();
        }

        private void 系别表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass fDept = new frmClass();
            fDept.ShowDialog();
        }

        private void 课程表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse fCourse = new frmCourse();
            fCourse.ShowDialog();
        }

        private void 主细表演示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch fDetail = new frmSearch();
            fDetail.ShowDialog();
        }

        private void 调用存储过程演示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Identity.id.Contains("管理员"))
            {
                MessageBox.Show("你无权限使用此功能");
                return;
            }
            frmProcdure fProcdure = new frmProcdure();
            fProcdure.ShowDialog();
        }

        private void report(object sender, EventArgs e)
        { 
            score sco = new score();
            sco.ShowDialog();
        }

        private void 教师表输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacher fReport = new frmTeacher();
            fReport.ShowDialog();
        }
    }
}
