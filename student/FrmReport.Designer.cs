namespace student
{
    partial class frmReport
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.lCreit = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.semester = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.course = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(640, 427);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 32);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "退  出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(497, 49);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 32);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "查  询";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lCreit
            // 
            this.lCreit.AutoSize = true;
            this.lCreit.Location = new System.Drawing.Point(127, 66);
            this.lCreit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCreit.Name = "lCreit";
            this.lCreit.Size = new System.Drawing.Size(68, 15);
            this.lCreit.TabIndex = 17;
            this.lCreit.Text = "学  期：";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(127, 19);
            this.lname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(68, 15);
            this.lname.TabIndex = 14;
            this.lname.Text = "课  程：";
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(41, 126);
            this.dataGView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 51;
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(681, 293);
            this.dataGView.TabIndex = 12;
            // 
            // semester
            // 
            this.semester.FormattingEnabled = true;
            this.semester.Items.AddRange(new object[] {
            "大一上",
            "大一下",
            "大二上",
            "大二下",
            "所有"});
            this.semester.Location = new System.Drawing.Point(218, 58);
            this.semester.Margin = new System.Windows.Forms.Padding(4);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(117, 23);
            this.semester.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.course);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.semester);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.lCreit);
            this.panel1.Location = new System.Drawing.Point(36, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 94);
            this.panel1.TabIndex = 24;
            // 
            // course
            // 
            this.course.Location = new System.Drawing.Point(218, 16);
            this.course.Margin = new System.Windows.Forms.Padding(4);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(117, 25);
            this.course.TabIndex = 24;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(511, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "升序排列";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩查询窗体";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lCreit;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.ComboBox semester;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}