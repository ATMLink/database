namespace student
{
    partial class frmTeacher
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lCreit = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.lCname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.Tno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(570, 372);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 32);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "退  出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(466, 372);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(99, 32);
            this.btnChange.TabIndex = 20;
            this.btnChange.Text = "保  存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(360, 372);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 32);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "删  除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(509, 47);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 32);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "插  入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lCreit
            // 
            this.lCreit.AutoSize = true;
            this.lCreit.Location = new System.Drawing.Point(16, 63);
            this.lCreit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCreit.Name = "lCreit";
            this.lCreit.Size = new System.Drawing.Size(52, 15);
            this.lCreit.TabIndex = 17;
            this.lCreit.Text = "年龄：";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(338, 13);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(163, 25);
            this.name.TabIndex = 16;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(13, 16);
            this.lname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(67, 15);
            this.lname.TabIndex = 14;
            this.lname.Text = "教工号：";
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(41, 126);
            this.dataGView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 51;
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(628, 238);
            this.dataGView.TabIndex = 12;
            // 
            // lCname
            // 
            this.lCname.AutoSize = true;
            this.lCname.Location = new System.Drawing.Point(257, 16);
            this.lCname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCname.Name = "lCname";
            this.lCname.Size = new System.Drawing.Size(52, 15);
            this.lCname.TabIndex = 11;
            this.lCname.Text = "姓名：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sex);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.Tno);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.lCname);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.lCreit);
            this.panel1.Location = new System.Drawing.Point(36, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 94);
            this.panel1.TabIndex = 24;
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex.Location = new System.Drawing.Point(196, 13);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(53, 23);
            this.sex.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "联系方式:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "性别：";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(338, 60);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(163, 25);
            this.email.TabIndex = 23;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(76, 63);
            this.age.Margin = new System.Windows.Forms.Padding(4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(60, 25);
            this.age.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "职称：";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(196, 60);
            this.title.Margin = new System.Windows.Forms.Padding(4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(53, 25);
            this.title.TabIndex = 20;
            // 
            // Tno
            // 
            this.Tno.Location = new System.Drawing.Point(76, 12);
            this.Tno.Margin = new System.Windows.Forms.Padding(4);
            this.Tno.Name = "Tno";
            this.Tno.Size = new System.Drawing.Size(60, 25);
            this.Tno.TabIndex = 19;
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师信息录入窗体";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lCreit;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Label lCname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox Tno;
    }
}