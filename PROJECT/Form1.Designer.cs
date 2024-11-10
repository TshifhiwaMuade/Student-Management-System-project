namespace PROJECT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcAdd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpWelccome = new System.Windows.Forms.GroupBox();
            this.grpNewUser = new System.Windows.Forms.GroupBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lblDel = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.TxtAvgAge = new System.Windows.Forms.TextBox();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnAvgAge = new System.Windows.Forms.Button();
            this.TxtCountStudent = new System.Windows.Forms.TextBox();
            this.BtnCountStudent = new System.Windows.Forms.Button();
            this.dgvUpdate = new System.Windows.Forms.DataGridView();
            this.grpAll = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.tbcAdd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpWelccome.SuspendLayout();
            this.grpNewUser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).BeginInit();
            this.grpAll.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(356, 644);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(492, 644);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Update Student";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Management System";
            // 
            // tbcAdd
            // 
            this.tbcAdd.Controls.Add(this.tabPage1);
            this.tbcAdd.Controls.Add(this.tabPage2);
            this.tbcAdd.Controls.Add(this.tabPage3);
            this.tbcAdd.Location = new System.Drawing.Point(27, 12);
            this.tbcAdd.Name = "tbcAdd";
            this.tbcAdd.SelectedIndex = 0;
            this.tbcAdd.Size = new System.Drawing.Size(1296, 729);
            this.tbcAdd.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpWelccome);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1288, 700);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpWelccome
            // 
            this.grpWelccome.Controls.Add(this.grpNewUser);
            this.grpWelccome.Controls.Add(this.panel1);
            this.grpWelccome.Controls.Add(this.lblWelcome);
            this.grpWelccome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWelccome.Location = new System.Drawing.Point(14, 29);
            this.grpWelccome.Name = "grpWelccome";
            this.grpWelccome.Size = new System.Drawing.Size(1254, 654);
            this.grpWelccome.TabIndex = 0;
            this.grpWelccome.TabStop = false;
            // 
            // grpNewUser
            // 
            this.grpNewUser.Controls.Add(this.cmbCourse);
            this.grpNewUser.Controls.Add(this.button1);
            this.grpNewUser.Controls.Add(this.label5);
            this.grpNewUser.Controls.Add(this.label4);
            this.grpNewUser.Controls.Add(this.txtAge);
            this.grpNewUser.Controls.Add(this.label3);
            this.grpNewUser.Controls.Add(this.txtName);
            this.grpNewUser.Controls.Add(this.label2);
            this.grpNewUser.Controls.Add(this.txtID);
            this.grpNewUser.Controls.Add(this.lblAdd);
            this.grpNewUser.Location = new System.Drawing.Point(657, 152);
            this.grpNewUser.Name = "grpNewUser";
            this.grpNewUser.Size = new System.Drawing.Size(502, 449);
            this.grpNewUser.TabIndex = 9;
            this.grpNewUser.TabStop = false;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(211, 252);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(249, 35);
            this.cmbCourse.TabIndex = 20;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(168, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(101, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Course:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(127, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(211, 194);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(249, 33);
            this.txtAge.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(113, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(211, 134);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 33);
            this.txtName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(78, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "StudentID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(211, 72);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(249, 33);
            this.txtID.TabIndex = 10;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(181, 29);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(157, 27);
            this.lblAdd.TabIndex = 7;
            this.lblAdd.Text = "Add New User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::PROJECT.Properties.Resources.studentbackground;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(48, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 457);
            this.panel1.TabIndex = 5;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(23, 38);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1207, 95);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = resources.GetString("lblWelcome.Text");
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.lblDelete);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.grpView);
            this.tabPage2.Controls.Add(this.dgvStudents);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1288, 700);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View & Delete";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.lblDel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(689, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 237);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(192, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 91);
            this.button5.TabIndex = 2;
            this.button5.Text = "Delete Student";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblDel
            // 
            this.lblDel.AutoSize = true;
            this.lblDel.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDel.Location = new System.Drawing.Point(128, 38);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(330, 38);
            this.lblDel.TabIndex = 0;
            this.lblDel.Text = "On your left,\r\nclicking on a cell will delete the selected record.";
            this.lblDel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(932, 356);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(113, 40);
            this.lblDelete.TabIndex = 19;
            this.lblDelete.Text = "Delete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(905, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 40);
            this.label7.TabIndex = 18;
            this.label7.Text = "View All";
            // 
            // grpView
            // 
            this.grpView.Controls.Add(this.button2);
            this.grpView.Controls.Add(this.label6);
            this.grpView.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpView.Location = new System.Drawing.Point(689, 99);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(559, 237);
            this.grpView.TabIndex = 17;
            this.grpView.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(192, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 91);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 57);
            this.label6.TabIndex = 0;
            this.label6.Text = "On your left is the data view,\r\nwhere all student records are displayed for \r\neas" +
    "y browsing and selection.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(31, 45);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(630, 627);
            this.dgvStudents.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.TxtAvgAge);
            this.tabPage3.Controls.Add(this.BtnReport);
            this.tabPage3.Controls.Add(this.BtnAvgAge);
            this.tabPage3.Controls.Add(this.TxtCountStudent);
            this.tabPage3.Controls.Add(this.BtnCountStudent);
            this.tabPage3.Controls.Add(this.dgvUpdate);
            this.tabPage3.Controls.Add(this.grpAll);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1288, 700);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(1177, 323);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button6.Size = new System.Drawing.Size(85, 41);
            this.button6.TabIndex = 7;
            this.button6.Text = "Exit";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TxtAvgAge
            // 
            this.TxtAvgAge.Location = new System.Drawing.Point(890, 112);
            this.TxtAvgAge.Name = "TxtAvgAge";
            this.TxtAvgAge.Size = new System.Drawing.Size(116, 22);
            this.TxtAvgAge.TabIndex = 6;
            // 
            // BtnReport
            // 
            this.BtnReport.Location = new System.Drawing.Point(721, 247);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(290, 50);
            this.BtnReport.TabIndex = 5;
            this.BtnReport.Text = "Generate Report";
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnAvgAge
            // 
            this.BtnAvgAge.Location = new System.Drawing.Point(721, 105);
            this.BtnAvgAge.Name = "BtnAvgAge";
            this.BtnAvgAge.Size = new System.Drawing.Size(116, 36);
            this.BtnAvgAge.TabIndex = 4;
            this.BtnAvgAge.Text = "Average Age";
            this.BtnAvgAge.UseVisualStyleBackColor = true;
            this.BtnAvgAge.Click += new System.EventHandler(this.BtnAvgAge_Click);
            // 
            // TxtCountStudent
            // 
            this.TxtCountStudent.Location = new System.Drawing.Point(890, 48);
            this.TxtCountStudent.Name = "TxtCountStudent";
            this.TxtCountStudent.Size = new System.Drawing.Size(116, 22);
            this.TxtCountStudent.TabIndex = 3;
            this.TxtCountStudent.TextChanged += new System.EventHandler(this.TxtCountStudent_TextChanged);
            // 
            // BtnCountStudent
            // 
            this.BtnCountStudent.Location = new System.Drawing.Point(721, 42);
            this.BtnCountStudent.Name = "BtnCountStudent";
            this.BtnCountStudent.Size = new System.Drawing.Size(117, 34);
            this.BtnCountStudent.TabIndex = 2;
            this.BtnCountStudent.Text = "Count students";
            this.BtnCountStudent.UseVisualStyleBackColor = true;
            this.BtnCountStudent.Click += new System.EventHandler(this.BtnCountStudent_Click);
            // 
            // dgvUpdate
            // 
            this.dgvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdate.Location = new System.Drawing.Point(26, 21);
            this.dgvUpdate.Name = "dgvUpdate";
            this.dgvUpdate.RowHeadersWidth = 51;
            this.dgvUpdate.RowTemplate.Height = 24;
            this.dgvUpdate.Size = new System.Drawing.Size(639, 357);
            this.dgvUpdate.TabIndex = 1;
            this.dgvUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdate_CellContentClick);
            // 
            // grpAll
            // 
            this.grpAll.Controls.Add(this.groupBox4);
            this.grpAll.Controls.Add(this.groupBox3);
            this.grpAll.Location = new System.Drawing.Point(26, 384);
            this.grpAll.Name = "grpAll";
            this.grpAll.Size = new System.Drawing.Size(1236, 294);
            this.grpAll.TabIndex = 0;
            this.grpAll.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.txtShow);
            this.groupBox4.Controls.Add(this.lblUpdate);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(354, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(851, 244);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(322, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(262, 51);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(266, 71);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(379, 30);
            this.txtShow.TabIndex = 1;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(278, 31);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(331, 25);
            this.lblUpdate.TabIndex = 0;
            this.lblUpdate.Text = "Click on the cell you want to update";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.lblRefresh);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 244);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(49, 107);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(211, 73);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh/Load";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblRefresh
            // 
            this.lblRefresh.AutoSize = true;
            this.lblRefresh.Location = new System.Drawing.Point(6, 44);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(274, 25);
            this.lblRefresh.TabIndex = 0;
            this.lblRefresh.Text = "Refresh or load you database";
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 753);
            this.Controls.Add(this.tbcAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcAdd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpWelccome.ResumeLayout(false);
            this.grpWelccome.PerformLayout();
            this.grpNewUser.ResumeLayout(false);
            this.grpNewUser.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpView.ResumeLayout(false);
            this.grpView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).EndInit();
            this.grpAll.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcAdd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpWelccome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpNewUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblDel;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvUpdate;
        private System.Windows.Forms.GroupBox grpAll;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.TextBox TxtCountStudent;
        private System.Windows.Forms.Button BtnCountStudent;
        private System.Windows.Forms.TextBox TxtAvgAge;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnAvgAge;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cmbCourse;
    }
}

