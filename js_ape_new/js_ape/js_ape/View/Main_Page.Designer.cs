
namespace js_ape
{
    partial class Main_Page
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
            this.btn_DownLoad_File = new System.Windows.Forms.Button();
            this.btn_Pull_File = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_send_File = new System.Windows.Forms.Button();
            this.cb_Teacher = new System.Windows.Forms.ComboBox();
            this.lbl_Teacher = new System.Windows.Forms.Label();
            this.cb_semester = new System.Windows.Forms.ComboBox();
            this.lbl_semester = new System.Windows.Forms.Label();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.lbl_class = new System.Windows.Forms.Label();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.lbl_dept = new System.Windows.Forms.Label();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.ofd_Excel = new System.Windows.Forms.OpenFileDialog();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndWeeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DownLoad_File
            // 
            this.btn_DownLoad_File.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_DownLoad_File.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DownLoad_File.Location = new System.Drawing.Point(24, 211);
            this.btn_DownLoad_File.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DownLoad_File.Name = "btn_DownLoad_File";
            this.btn_DownLoad_File.Size = new System.Drawing.Size(105, 42);
            this.btn_DownLoad_File.TabIndex = 40;
            this.btn_DownLoad_File.Text = "下载文件";
            this.btn_DownLoad_File.UseVisualStyleBackColor = false;
            // 
            // btn_Pull_File
            // 
            this.btn_Pull_File.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Pull_File.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Pull_File.Location = new System.Drawing.Point(24, 141);
            this.btn_Pull_File.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Pull_File.Name = "btn_Pull_File";
            this.btn_Pull_File.Size = new System.Drawing.Size(105, 42);
            this.btn_Pull_File.TabIndex = 39;
            this.btn_Pull_File.Text = "拉取远程数据";
            this.btn_Pull_File.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Exit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.Location = new System.Drawing.Point(24, 460);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(105, 42);
            this.btn_Exit.TabIndex = 38;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_send_File
            // 
            this.btn_send_File.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_send_File.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_send_File.Location = new System.Drawing.Point(24, 74);
            this.btn_send_File.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send_File.Name = "btn_send_File";
            this.btn_send_File.Size = new System.Drawing.Size(105, 42);
            this.btn_send_File.TabIndex = 37;
            this.btn_send_File.Text = "上传本地文件";
            this.btn_send_File.UseVisualStyleBackColor = false;
            this.btn_send_File.Click += new System.EventHandler(this.btn_send_File_Click);
            // 
            // cb_Teacher
            // 
            this.cb_Teacher.DisplayMember = "全部";
            this.cb_Teacher.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_Teacher.FormattingEnabled = true;
            this.cb_Teacher.Items.AddRange(new object[] {
            "全部"});
            this.cb_Teacher.Location = new System.Drawing.Point(671, 22);
            this.cb_Teacher.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Teacher.Name = "cb_Teacher";
            this.cb_Teacher.Size = new System.Drawing.Size(123, 25);
            this.cb_Teacher.TabIndex = 36;
            // 
            // lbl_Teacher
            // 
            this.lbl_Teacher.AutoSize = true;
            this.lbl_Teacher.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Teacher.Location = new System.Drawing.Point(606, 23);
            this.lbl_Teacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Teacher.Name = "lbl_Teacher";
            this.lbl_Teacher.Size = new System.Drawing.Size(46, 21);
            this.lbl_Teacher.TabIndex = 35;
            this.lbl_Teacher.Text = "教师:";
            // 
            // cb_semester
            // 
            this.cb_semester.DisplayMember = "全部";
            this.cb_semester.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_semester.FormattingEnabled = true;
            this.cb_semester.Items.AddRange(new object[] {
            "全部"});
            this.cb_semester.Location = new System.Drawing.Point(876, 22);
            this.cb_semester.Margin = new System.Windows.Forms.Padding(4);
            this.cb_semester.Name = "cb_semester";
            this.cb_semester.Size = new System.Drawing.Size(245, 25);
            this.cb_semester.TabIndex = 34;
            // 
            // lbl_semester
            // 
            this.lbl_semester.AutoSize = true;
            this.lbl_semester.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_semester.Location = new System.Drawing.Point(808, 23);
            this.lbl_semester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_semester.Name = "lbl_semester";
            this.lbl_semester.Size = new System.Drawing.Size(46, 21);
            this.lbl_semester.TabIndex = 33;
            this.lbl_semester.Text = "学期:";
            // 
            // cb_class
            // 
            this.cb_class.DisplayMember = "全部";
            this.cb_class.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Items.AddRange(new object[] {
            "全部"});
            this.cb_class.Location = new System.Drawing.Point(439, 22);
            this.cb_class.Margin = new System.Windows.Forms.Padding(4);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(140, 25);
            this.cb_class.TabIndex = 32;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_class.Location = new System.Drawing.Point(374, 23);
            this.lbl_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(46, 21);
            this.lbl_class.TabIndex = 31;
            this.lbl_class.Text = "班级:";
            // 
            // cb_dept
            // 
            this.cb_dept.DisplayMember = "全部";
            this.cb_dept.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Items.AddRange(new object[] {
            "全部"});
            this.cb_dept.Location = new System.Drawing.Point(210, 22);
            this.cb_dept.Margin = new System.Windows.Forms.Padding(4);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(144, 25);
            this.cb_dept.TabIndex = 30;
            // 
            // lbl_dept
            // 
            this.lbl_dept.AutoSize = true;
            this.lbl_dept.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_dept.Location = new System.Drawing.Point(145, 23);
            this.lbl_dept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(46, 21);
            this.lbl_dept.TabIndex = 29;
            this.lbl_dept.Text = "系别:";
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.ClassName,
            this.courseTitle,
            this.lecturer,
            this.startWeek,
            this.EndWeeks,
            this.WeekSchool,
            this.SectionNum,
            this.Notes});
            this.dgv_data.Location = new System.Drawing.Point(149, 74);
            this.dgv_data.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowTemplate.Height = 23;
            this.dgv_data.Size = new System.Drawing.Size(972, 428);
            this.dgv_data.TabIndex = 28;
            // 
            // ofd_Excel
            // 
            this.ofd_Excel.FileName = "openFileDialog1";
            this.ofd_Excel.Filter = "\"所有文件(*.*)|*.*|Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx\"";
            this.ofd_Excel.Title = "\"请打开符合格式的Excel文件\"";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "学期";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "系别";
            this.Column2.Name = "Column2";
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassName.HeaderText = "班级";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            // 
            // courseTitle
            // 
            this.courseTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseTitle.HeaderText = "课程名称";
            this.courseTitle.MinimumWidth = 6;
            this.courseTitle.Name = "courseTitle";
            // 
            // lecturer
            // 
            this.lecturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lecturer.HeaderText = "主讲教师";
            this.lecturer.MinimumWidth = 6;
            this.lecturer.Name = "lecturer";
            // 
            // startWeek
            // 
            this.startWeek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startWeek.HeaderText = "开始周";
            this.startWeek.MinimumWidth = 6;
            this.startWeek.Name = "startWeek";
            // 
            // EndWeeks
            // 
            this.EndWeeks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndWeeks.HeaderText = "结束周";
            this.EndWeeks.MinimumWidth = 6;
            this.EndWeeks.Name = "EndWeeks";
            // 
            // WeekSchool
            // 
            this.WeekSchool.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WeekSchool.HeaderText = "周学时";
            this.WeekSchool.MinimumWidth = 6;
            this.WeekSchool.Name = "WeekSchool";
            // 
            // SectionNum
            // 
            this.SectionNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SectionNum.HeaderText = "连排节";
            this.SectionNum.MinimumWidth = 6;
            this.SectionNum.Name = "SectionNum";
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notes.HeaderText = "备注";
            this.Notes.Name = "Notes";
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 525);
            this.Controls.Add(this.btn_DownLoad_File);
            this.Controls.Add(this.btn_Pull_File);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_send_File);
            this.Controls.Add(this.cb_Teacher);
            this.Controls.Add(this.lbl_Teacher);
            this.Controls.Add(this.cb_semester);
            this.Controls.Add(this.lbl_semester);
            this.Controls.Add(this.cb_class);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.cb_dept);
            this.Controls.Add(this.lbl_dept);
            this.Controls.Add(this.dgv_data);
            this.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main_Page";
            this.Text = "主页";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DownLoad_File;
        private System.Windows.Forms.Button btn_Pull_File;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_send_File;
        private System.Windows.Forms.ComboBox cb_Teacher;
        private System.Windows.Forms.Label lbl_Teacher;
        private System.Windows.Forms.ComboBox cb_semester;
        private System.Windows.Forms.Label lbl_semester;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.ComboBox cb_dept;
        private System.Windows.Forms.Label lbl_dept;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.OpenFileDialog ofd_Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn startWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndWeeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}