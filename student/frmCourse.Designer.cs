namespace student
{
    partial class frmCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.lCno = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lCreit = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lCname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(32, 126);
            this.dataGView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 51;
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(801, 403);
            this.dataGView.TabIndex = 1;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(107, 10);
            this.txtCno.Margin = new System.Windows.Forms.Padding(4);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(104, 25);
            this.txtCno.TabIndex = 2;
            // 
            // lCno
            // 
            this.lCno.AutoSize = true;
            this.lCno.Location = new System.Drawing.Point(21, 21);
            this.lCno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCno.Name = "lCno";
            this.lCno.Size = new System.Drawing.Size(67, 15);
            this.lCno.TabIndex = 3;
            this.lCno.Text = "课程号：";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(107, 59);
            this.txtCredit.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(104, 25);
            this.txtCredit.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(305, 11);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 25);
            this.txtName.TabIndex = 5;
            // 
            // lCreit
            // 
            this.lCreit.AutoSize = true;
            this.lCreit.Location = new System.Drawing.Point(21, 66);
            this.lCreit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCreit.Name = "lCreit";
            this.lCreit.Size = new System.Drawing.Size(68, 15);
            this.lCreit.TabIndex = 6;
            this.lCreit.Text = "学  分：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(719, 479);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 32);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "退  出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(605, 479);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(96, 32);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "保  存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(507, 479);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删  除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(661, 52);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(124, 32);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "插  入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hour);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.check);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCno);
            this.panel1.Controls.Add(this.lCname);
            this.panel1.Controls.Add(this.lCno);
            this.panel1.Controls.Add(this.txtCredit);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lCreit);
            this.panel1.Location = new System.Drawing.Point(32, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 96);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "开课时间：";
            // 
            // check
            // 
            this.check.FormattingEnabled = true;
            this.check.Items.AddRange(new object[] {
            "考试",
            "考察"});
            this.check.Location = new System.Drawing.Point(519, 13);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(121, 23);
            this.check.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "考察模式：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(305, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 25);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lCname
            // 
            this.lCname.AutoSize = true;
            this.lCname.Location = new System.Drawing.Point(230, 20);
            this.lCname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCname.Name = "lCname";
            this.lCname.Size = new System.Drawing.Size(67, 15);
            this.lCname.TabIndex = 0;
            this.lCname.Text = "课程名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "学  时：";
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(519, 63);
            this.hour.Margin = new System.Windows.Forms.Padding(4);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(123, 25);
            this.hour.TabIndex = 14;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程信息输入窗体";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Label lCno;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lCreit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox check;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lCname;
    }
}