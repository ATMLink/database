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
    public partial class frmClass : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();     
        private string sql;

        public frmClass()
        {
            InitializeComponent();
            SetBind();
        }
        //----绑定DataGivdView数据
        protected void SetBind()
        {  
            try
            {
                sql = "select cjh_Cno01 as 班级编号,cjh_Cgrade01 as 年级 from cjh_Class01";
                ds = con.BindDataGridView(dataGView, sql);                
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }catch {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //----插入数据
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!Identity.id.Contains("管理员"))
            {
                MessageBox.Show("你不具有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {                
                sql = "insert into cjh_Class01 values( '" + txtno.Text + "','" + txtName.Text + "')";            
                con.OperateData(sql);
                SetBind();
            }catch{
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
        }
        //----修改数据
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!Identity.id.Contains("管理员"))
            {
                MessageBox.Show("你不具有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                sql = "update cjh_Class01 set cjh_Cgrade01='" + dataGView.CurrentRow.Cells[1].Value.ToString() +
                    "' where cjh_Cno01='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();
            }catch{
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);              
            }          
        }
        //---------删除数据
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Identity.id.Contains("管理员"))
            {
                MessageBox.Show("你不具有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK){               
                try {
                    sql = "delete from cjh_Class01 where cjh_Cno01='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
                }
                catch{
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);          
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e){
            this.Close();
        }

        private void lDno_Click(object sender, EventArgs e)
        {

        }
    }
}
