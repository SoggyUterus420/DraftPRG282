﻿namespace DraftPRG282
{
    partial class frmStudentManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentManagementForm));
            this.gbStudentData = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbSearchedStudent = new System.Windows.Forms.GroupBox();
            this.lblCourseResult = new System.Windows.Forms.Label();
            this.lblAgeResult = new System.Windows.Forms.Label();
            this.lblStudentIDResult = new System.Windows.Forms.Label();
            this.lblNameResult = new System.Windows.Forms.Label();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.gbSummaryDisplay = new System.Windows.Forms.GroupBox();
            this.btnSummaryResults = new System.Windows.Forms.Button();
            this.lblAverageAgeResult = new System.Windows.Forms.Label();
            this.lblTotalStudentsResults = new System.Windows.Forms.Label();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.btnViewAllStudents = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTotalCourses = new System.Windows.Forms.Label();
            this.lblTotalCoursesResult = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblClearStudentAdd = new System.Windows.Forms.Label();
            this.gbStudentData.SuspendLayout();
            this.gbSearchedStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.gbSummaryDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStudentData
            // 
            this.gbStudentData.BackColor = System.Drawing.Color.White;
            this.gbStudentData.Controls.Add(this.lblClearStudentAdd);
            this.gbStudentData.Controls.Add(this.panel1);
            this.gbStudentData.Controls.Add(this.txtCourse);
            this.gbStudentData.Controls.Add(this.txtAge);
            this.gbStudentData.Controls.Add(this.txtStudentID);
            this.gbStudentData.Controls.Add(this.panel4);
            this.gbStudentData.Controls.Add(this.panel3);
            this.gbStudentData.Controls.Add(this.panel2);
            this.gbStudentData.Controls.Add(this.btnAddStudent);
            this.gbStudentData.Controls.Add(this.lblCourse);
            this.gbStudentData.Controls.Add(this.lblAge);
            this.gbStudentData.Controls.Add(this.txtName);
            this.gbStudentData.Controls.Add(this.lblStudentID);
            this.gbStudentData.Controls.Add(this.lblAddName);
            this.gbStudentData.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentData.ForeColor = System.Drawing.Color.RosyBrown;
            this.gbStudentData.Location = new System.Drawing.Point(25, 64);
            this.gbStudentData.Name = "gbStudentData";
            this.gbStudentData.Size = new System.Drawing.Size(194, 300);
            this.gbStudentData.TabIndex = 0;
            this.gbStudentData.TabStop = false;
            this.gbStudentData.Text = "Add Student";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.Location = new System.Drawing.Point(20, 226);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(148, 31);
            this.btnAddStudent.TabIndex = 9;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(6, 185);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(52, 17);
            this.lblCourse.TabIndex = 7;
            this.lblCourse.Text = "Course:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(6, 136);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(34, 17);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(6, 87);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(72, 17);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtName.Location = new System.Drawing.Point(58, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 15);
            this.txtName.TabIndex = 2;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.Location = new System.Drawing.Point(6, 39);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(46, 17);
            this.lblAddName.TabIndex = 1;
            this.lblAddName.Text = "Name:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblSearch.Location = new System.Drawing.Point(280, 62);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(149, 16);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search Student Number";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtSearchBar.Location = new System.Drawing.Point(435, 60);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(218, 14);
            this.txtSearchBar.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(677, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 21);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(766, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 21);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Search";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // gbSearchedStudent
            // 
            this.gbSearchedStudent.Controls.Add(this.lblCourseResult);
            this.gbSearchedStudent.Controls.Add(this.lblAgeResult);
            this.gbSearchedStudent.Controls.Add(this.lblStudentIDResult);
            this.gbSearchedStudent.Controls.Add(this.lblNameResult);
            this.gbSearchedStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchedStudent.ForeColor = System.Drawing.Color.RosyBrown;
            this.gbSearchedStudent.Location = new System.Drawing.Point(314, 109);
            this.gbSearchedStudent.Name = "gbSearchedStudent";
            this.gbSearchedStudent.Size = new System.Drawing.Size(534, 91);
            this.gbSearchedStudent.TabIndex = 13;
            this.gbSearchedStudent.TabStop = false;
            this.gbSearchedStudent.Text = "Results";
            // 
            // lblCourseResult
            // 
            this.lblCourseResult.AutoSize = true;
            this.lblCourseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseResult.Location = new System.Drawing.Point(421, 46);
            this.lblCourseResult.Name = "lblCourseResult";
            this.lblCourseResult.Size = new System.Drawing.Size(46, 15);
            this.lblCourseResult.TabIndex = 14;
            this.lblCourseResult.Text = "Course";
            // 
            // lblAgeResult
            // 
            this.lblAgeResult.AutoSize = true;
            this.lblAgeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeResult.Location = new System.Drawing.Point(299, 46);
            this.lblAgeResult.Name = "lblAgeResult";
            this.lblAgeResult.Size = new System.Drawing.Size(28, 15);
            this.lblAgeResult.TabIndex = 14;
            this.lblAgeResult.Text = "Age";
            // 
            // lblStudentIDResult
            // 
            this.lblStudentIDResult.AutoSize = true;
            this.lblStudentIDResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentIDResult.Location = new System.Drawing.Point(152, 46);
            this.lblStudentIDResult.Name = "lblStudentIDResult";
            this.lblStudentIDResult.Size = new System.Drawing.Size(61, 15);
            this.lblStudentIDResult.TabIndex = 1;
            this.lblStudentIDResult.Text = "StudentID";
            // 
            // lblNameResult
            // 
            this.lblNameResult.AutoSize = true;
            this.lblNameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameResult.Location = new System.Drawing.Point(32, 46);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(41, 15);
            this.lblNameResult.TabIndex = 0;
            this.lblNameResult.Text = "Name";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(253, 269);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(687, 367);
            this.dgvDisplay.TabIndex = 14;
            // 
            // gbSummaryDisplay
            // 
            this.gbSummaryDisplay.Controls.Add(this.lblTotalCoursesResult);
            this.gbSummaryDisplay.Controls.Add(this.lblTotalCourses);
            this.gbSummaryDisplay.Controls.Add(this.btnSummaryResults);
            this.gbSummaryDisplay.Controls.Add(this.lblAverageAgeResult);
            this.gbSummaryDisplay.Controls.Add(this.lblTotalStudentsResults);
            this.gbSummaryDisplay.Controls.Add(this.lblAverageAge);
            this.gbSummaryDisplay.Controls.Add(this.lblTotalStudents);
            this.gbSummaryDisplay.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSummaryDisplay.ForeColor = System.Drawing.Color.RosyBrown;
            this.gbSummaryDisplay.Location = new System.Drawing.Point(25, 384);
            this.gbSummaryDisplay.Name = "gbSummaryDisplay";
            this.gbSummaryDisplay.Size = new System.Drawing.Size(194, 252);
            this.gbSummaryDisplay.TabIndex = 15;
            this.gbSummaryDisplay.TabStop = false;
            this.gbSummaryDisplay.Text = "Summary Display";
            // 
            // btnSummaryResults
            // 
            this.btnSummaryResults.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSummaryResults.FlatAppearance.BorderSize = 0;
            this.btnSummaryResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummaryResults.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummaryResults.ForeColor = System.Drawing.Color.Black;
            this.btnSummaryResults.Location = new System.Drawing.Point(20, 185);
            this.btnSummaryResults.Name = "btnSummaryResults";
            this.btnSummaryResults.Size = new System.Drawing.Size(148, 31);
            this.btnSummaryResults.TabIndex = 4;
            this.btnSummaryResults.Text = "Generate Summary ";
            this.btnSummaryResults.UseVisualStyleBackColor = false;
            // 
            // lblAverageAgeResult
            // 
            this.lblAverageAgeResult.AutoSize = true;
            this.lblAverageAgeResult.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAgeResult.Location = new System.Drawing.Point(106, 97);
            this.lblAverageAgeResult.Name = "lblAverageAgeResult";
            this.lblAverageAgeResult.Size = new System.Drawing.Size(33, 17);
            this.lblAverageAgeResult.TabIndex = 3;
            this.lblAverageAgeResult.Text = "_____";
            // 
            // lblTotalStudentsResults
            // 
            this.lblTotalStudentsResults.AutoSize = true;
            this.lblTotalStudentsResults.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudentsResults.Location = new System.Drawing.Point(106, 46);
            this.lblTotalStudentsResults.Name = "lblTotalStudentsResults";
            this.lblTotalStudentsResults.Size = new System.Drawing.Size(33, 17);
            this.lblTotalStudentsResults.TabIndex = 2;
            this.lblTotalStudentsResults.Text = "_____";
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAge.Location = new System.Drawing.Point(6, 97);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(86, 17);
            this.lblAverageAge.TabIndex = 1;
            this.lblAverageAge.Text = "Average Age:";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudents.Location = new System.Drawing.Point(6, 48);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(94, 17);
            this.lblTotalStudents.TabIndex = 0;
            this.lblTotalStudents.Text = "Total Students:";
            // 
            // btnViewAllStudents
            // 
            this.btnViewAllStudents.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnViewAllStudents.BackColor = System.Drawing.Color.RosyBrown;
            this.btnViewAllStudents.FlatAppearance.BorderSize = 0;
            this.btnViewAllStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllStudents.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllStudents.Location = new System.Drawing.Point(506, 649);
            this.btnViewAllStudents.Name = "btnViewAllStudents";
            this.btnViewAllStudents.Size = new System.Drawing.Size(170, 32);
            this.btnViewAllStudents.TabIndex = 16;
            this.btnViewAllStudents.Text = "View All Students";
            this.btnViewAllStudents.UseVisualStyleBackColor = false;
            this.btnViewAllStudents.Click += new System.EventHandler(this.btnViewAllStudents_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(9, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(9, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(9, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 1);
            this.panel4.TabIndex = 18;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentID.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtStudentID.Location = new System.Drawing.Point(84, 90);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(94, 15);
            this.txtStudentID.TabIndex = 19;
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAge.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtAge.Location = new System.Drawing.Point(46, 139);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(132, 15);
            this.txtAge.TabIndex = 20;
            // 
            // txtCourse
            // 
            this.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourse.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtCourse.Location = new System.Drawing.Point(64, 188);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(114, 15);
            this.txtCourse.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(9, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 19;
            // 
            // btnClearResults
            // 
            this.btnClearResults.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearResults.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClearResults.FlatAppearance.BorderSize = 0;
            this.btnClearResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearResults.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearResults.Location = new System.Drawing.Point(487, 206);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(189, 32);
            this.btnClearResults.TabIndex = 17;
            this.btnClearResults.Text = "Clear Results";
            this.btnClearResults.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(854, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(189, 32);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update Student Details";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // lblTotalCourses
            // 
            this.lblTotalCourses.AutoSize = true;
            this.lblTotalCourses.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCourses.Location = new System.Drawing.Point(6, 143);
            this.lblTotalCourses.Name = "lblTotalCourses";
            this.lblTotalCourses.Size = new System.Drawing.Size(91, 17);
            this.lblTotalCourses.TabIndex = 5;
            this.lblTotalCourses.Text = "Total Courses:";
            // 
            // lblTotalCoursesResult
            // 
            this.lblTotalCoursesResult.AutoSize = true;
            this.lblTotalCoursesResult.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCoursesResult.Location = new System.Drawing.Point(106, 143);
            this.lblTotalCoursesResult.Name = "lblTotalCoursesResult";
            this.lblTotalCoursesResult.Size = new System.Drawing.Size(33, 17);
            this.lblTotalCoursesResult.TabIndex = 6;
            this.lblTotalCoursesResult.Text = "_____";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteStudent.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteStudent.FlatAppearance.BorderSize = 0;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(854, 123);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(189, 32);
            this.btnDeleteStudent.TabIndex = 19;
            this.btnDeleteStudent.Text = "Delete Student ";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DraftPRG282.Properties.Resources.istockphoto_2113476145_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(864, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblLine.Location = new System.Drawing.Point(432, 64);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(223, 13);
            this.lblLine.TabIndex = 21;
            this.lblLine.Text = "____________________________________";
            // 
            // lblClearStudentAdd
            // 
            this.lblClearStudentAdd.AutoSize = true;
            this.lblClearStudentAdd.Location = new System.Drawing.Point(72, 273);
            this.lblClearStudentAdd.Name = "lblClearStudentAdd";
            this.lblClearStudentAdd.Size = new System.Drawing.Size(44, 19);
            this.lblClearStudentAdd.TabIndex = 22;
            this.lblClearStudentAdd.Text = "Clear";
            this.lblClearStudentAdd.Click += new System.EventHandler(this.lblClearStudentAdd_Click);
            // 
            // frmStudentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 719);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClearResults);
            this.Controls.Add(this.btnViewAllStudents);
            this.Controls.Add(this.gbSummaryDisplay);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.gbSearchedStudent);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gbStudentData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management Form";
            this.Load += new System.EventHandler(this.frmStudentManagementForm_Load);
            this.gbStudentData.ResumeLayout(false);
            this.gbStudentData.PerformLayout();
            this.gbSearchedStudent.ResumeLayout(false);
            this.gbSearchedStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.gbSummaryDisplay.ResumeLayout(false);
            this.gbSummaryDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStudentData;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbSearchedStudent;
        private System.Windows.Forms.Label lblCourseResult;
        private System.Windows.Forms.Label lblAgeResult;
        private System.Windows.Forms.Label lblStudentIDResult;
        private System.Windows.Forms.Label lblNameResult;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.GroupBox gbSummaryDisplay;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Button btnSummaryResults;
        private System.Windows.Forms.Label lblAverageAgeResult;
        private System.Windows.Forms.Label lblTotalStudentsResults;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Button btnViewAllStudents;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTotalCoursesResult;
        private System.Windows.Forms.Label lblTotalCourses;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblClearStudentAdd;
    }
}

