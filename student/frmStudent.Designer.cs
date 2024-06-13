namespace student
{
    partial class frmStudent
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.sno = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.IName = new System.Windows.Forms.Label();
            this.Sdepart = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.depart = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.email = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.Splace = new System.Windows.Forms.Label();
            this.Ssex = new System.Windows.Forms.Label();
            this.Sgrade = new System.Windows.Forms.Label();
            this.Scredit = new System.Windows.Forms.Label();
            this.Sage = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.credit = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGView
            // 
            this.dataGView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(23, 121);
            this.dataGView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 51;
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(995, 538);
            this.dataGView.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(892, 55);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 32);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "插  入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(628, 609);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删  除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(760, 609);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(88, 32);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "保  存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(887, 609);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "退  出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // sno
            // 
            this.sno.AutoSize = true;
            this.sno.Location = new System.Drawing.Point(41, 15);
            this.sno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(68, 15);
            this.sno.TabIndex = 5;
            this.sno.Text = "学  号：";
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(119, 11);
            this.no.Margin = new System.Windows.Forms.Padding(4);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(107, 25);
            this.no.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(310, 11);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(163, 25);
            this.name.TabIndex = 8;
            // 
            // IName
            // 
            this.IName.AutoSize = true;
            this.IName.Location = new System.Drawing.Point(234, 15);
            this.IName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IName.Name = "IName";
            this.IName.Size = new System.Drawing.Size(68, 15);
            this.IName.TabIndex = 7;
            this.IName.Text = "姓  名：";
            // 
            // Sdepart
            // 
            this.Sdepart.AutoSize = true;
            this.Sdepart.Location = new System.Drawing.Point(41, 60);
            this.Sdepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sdepart.Name = "Sdepart";
            this.Sdepart.Size = new System.Drawing.Size(68, 15);
            this.Sdepart.TabIndex = 9;
            this.Sdepart.Text = "系  别：";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(234, 55);
            this.lEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lEmail.Size = new System.Drawing.Size(82, 15);
            this.lEmail.TabIndex = 10;
            this.lEmail.Text = "联系方式：";
            // 
            // depart
            // 
            this.depart.FormattingEnabled = true;
            this.depart.Items.AddRange(new object[] {
            "计算机",
            "理学院",
            "人文",
            "机械",
            "信息"});
            this.depart.Location = new System.Drawing.Point(117, 52);
            this.depart.Margin = new System.Windows.Forms.Padding(4);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(108, 23);
            this.depart.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.sex);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.depart);
            this.panel1.Controls.Add(this.sno);
            this.panel1.Controls.Add(this.no);
            this.panel1.Controls.Add(this.lEmail);
            this.panel1.Controls.Add(this.Splace);
            this.panel1.Controls.Add(this.Ssex);
            this.panel1.Controls.Add(this.Sgrade);
            this.panel1.Controls.Add(this.Scredit);
            this.panel1.Controls.Add(this.Sage);
            this.panel1.Controls.Add(this.IName);
            this.panel1.Controls.Add(this.Sdepart);
            this.panel1.Controls.Add(this.place);
            this.panel1.Controls.Add(this.grade);
            this.panel1.Controls.Add(this.credit);
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(23, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 93);
            this.panel1.TabIndex = 13;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(310, 51);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(164, 25);
            this.email.TabIndex = 14;
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex.Location = new System.Drawing.Point(892, 8);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(68, 23);
            this.sex.TabIndex = 13;
            // 
            // Splace
            // 
            this.Splace.AutoSize = true;
            this.Splace.Location = new System.Drawing.Point(625, 60);
            this.Splace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Splace.Name = "Splace";
            this.Splace.Size = new System.Drawing.Size(91, 15);
            this.Splace.TabIndex = 7;
            this.Splace.Text = "生 源 地 ：";
            // 
            // Ssex
            // 
            this.Ssex.AutoSize = true;
            this.Ssex.Location = new System.Drawing.Point(812, 11);
            this.Ssex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ssex.Name = "Ssex";
            this.Ssex.Size = new System.Drawing.Size(68, 15);
            this.Ssex.TabIndex = 7;
            this.Ssex.Text = "性  别：";
            // 
            // Sgrade
            // 
            this.Sgrade.AutoSize = true;
            this.Sgrade.Location = new System.Drawing.Point(636, 11);
            this.Sgrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sgrade.Name = "Sgrade";
            this.Sgrade.Size = new System.Drawing.Size(68, 15);
            this.Sgrade.TabIndex = 7;
            this.Sgrade.Text = "年  级：";
            // 
            // Scredit
            // 
            this.Scredit.AutoSize = true;
            this.Scredit.Location = new System.Drawing.Point(481, 55);
            this.Scredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Scredit.Name = "Scredit";
            this.Scredit.Size = new System.Drawing.Size(68, 15);
            this.Scredit.TabIndex = 7;
            this.Scredit.Text = "学  分：";
            // 
            // Sage
            // 
            this.Sage.AutoSize = true;
            this.Sage.Location = new System.Drawing.Point(481, 15);
            this.Sage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sage.Name = "Sage";
            this.Sage.Size = new System.Drawing.Size(68, 15);
            this.Sage.TabIndex = 7;
            this.Sage.Text = "年  龄：";
            // 
            // place
            // 
            this.place.Location = new System.Drawing.Point(724, 52);
            this.place.Margin = new System.Windows.Forms.Padding(4);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(80, 25);
            this.place.TabIndex = 8;
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(724, 5);
            this.grade.Margin = new System.Windows.Forms.Padding(4);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(80, 25);
            this.grade.TabIndex = 8;
            // 
            // credit
            // 
            this.credit.Location = new System.Drawing.Point(557, 52);
            this.credit.Margin = new System.Windows.Forms.Padding(4);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(60, 25);
            this.credit.TabIndex = 8;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(557, 5);
            this.age.Margin = new System.Windows.Forms.Padding(4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(60, 25);
            this.age.TabIndex = 8;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息输入窗体";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label sno;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label IName;
        private System.Windows.Forms.Label Sdepart;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.ComboBox depart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label Splace;
        private System.Windows.Forms.Label Ssex;
        private System.Windows.Forms.Label Sgrade;
        private System.Windows.Forms.Label Scredit;
        private System.Windows.Forms.Label Sage;
        private System.Windows.Forms.TextBox place;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.TextBox credit;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox email;
    }
}