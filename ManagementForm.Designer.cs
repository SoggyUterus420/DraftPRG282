namespace DraftPRG282
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
            this.lblClearStudentAdd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbSearchedStudent = new System.Windows.Forms.GroupBox();
            this.lblStudentIDDisplay = new System.Windows.Forms.Label();
            this.lblCourseDisplay = new System.Windows.Forms.Label();
            this.lblAgeDisplay = new System.Windows.Forms.Label();
            this.lblNameDisplay = new System.Windows.Forms.Label();
            this.txtCourseResult = new System.Windows.Forms.TextBox();
            this.txtAgeResult = new System.Windows.Forms.TextBox();
            this.txtStudentIDResult = new System.Windows.Forms.TextBox();
            this.txtNameDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.gbSummaryDisplay = new System.Windows.Forms.GroupBox();
            this.txtOldestStudent = new System.Windows.Forms.TextBox();
            this.txtAverageAgeResult = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTotalStudentResult = new System.Windows.Forms.TextBox();
            this.lblOldestStudent = new System.Windows.Forms.Label();
            this.btnSummaryResults = new System.Windows.Forms.Button();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.btnViewAllStudents = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.gbStudentData.Location = new System.Drawing.Point(38, 98);
            this.gbStudentData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStudentData.Name = "gbStudentData";
            this.gbStudentData.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStudentData.Size = new System.Drawing.Size(291, 462);
            this.gbStudentData.TabIndex = 0;
            this.gbStudentData.TabStop = false;
            this.gbStudentData.Text = "Add Student";
            // 
            // lblClearStudentAdd
            // 
            this.lblClearStudentAdd.AutoSize = true;
            this.lblClearStudentAdd.Location = new System.Drawing.Point(108, 420);
            this.lblClearStudentAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClearStudentAdd.Name = "lblClearStudentAdd";
            this.lblClearStudentAdd.Size = new System.Drawing.Size(63, 27);
            this.lblClearStudentAdd.TabIndex = 22;
            this.lblClearStudentAdd.Text = "Clear";
            this.lblClearStudentAdd.Click += new System.EventHandler(this.lblClearStudentAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(14, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 2);
            this.panel1.TabIndex = 19;
            // 
            // txtCourse
            // 
            this.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourse.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtCourse.Location = new System.Drawing.Point(96, 289);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(171, 22);
            this.txtCourse.TabIndex = 21;
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAge.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtAge.Location = new System.Drawing.Point(69, 214);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(198, 22);
            this.txtAge.TabIndex = 20;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentID.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtStudentID.Location = new System.Drawing.Point(126, 138);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(141, 22);
            this.txtStudentID.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(14, 315);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 2);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(14, 240);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 2);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(14, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 2);
            this.panel2.TabIndex = 18;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.Location = new System.Drawing.Point(30, 348);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(222, 48);
            this.btnAddStudent.TabIndex = 9;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(9, 285);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(73, 24);
            this.lblCourse.TabIndex = 7;
            this.lblCourse.Text = "Course:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(9, 209);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(49, 24);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtName.Location = new System.Drawing.Point(87, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(9, 134);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(106, 24);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.Location = new System.Drawing.Point(9, 60);
            this.lblAddName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(66, 24);
            this.lblAddName.TabIndex = 1;
            this.lblAddName.Text = "Name:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblSearch.Location = new System.Drawing.Point(420, 95);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(222, 25);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search Student Number";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtSearchBar.Location = new System.Drawing.Point(652, 92);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(327, 21);
            this.txtSearchBar.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1016, 92);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1149, 92);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 32);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Search";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbSearchedStudent
            // 
            this.gbSearchedStudent.Controls.Add(this.lblStudentIDDisplay);
            this.gbSearchedStudent.Controls.Add(this.lblCourseDisplay);
            this.gbSearchedStudent.Controls.Add(this.lblAgeDisplay);
            this.gbSearchedStudent.Controls.Add(this.lblNameDisplay);
            this.gbSearchedStudent.Controls.Add(this.txtCourseResult);
            this.gbSearchedStudent.Controls.Add(this.txtAgeResult);
            this.gbSearchedStudent.Controls.Add(this.txtStudentIDResult);
            this.gbSearchedStudent.Controls.Add(this.txtNameDisplay);
            this.gbSearchedStudent.Controls.Add(this.label1);
            this.gbSearchedStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchedStudent.ForeColor = System.Drawing.Color.RosyBrown;
            this.gbSearchedStudent.Location = new System.Drawing.Point(414, 168);
            this.gbSearchedStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearchedStudent.Name = "gbSearchedStudent";
            this.gbSearchedStudent.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearchedStudent.Size = new System.Drawing.Size(975, 140);
            this.gbSearchedStudent.TabIndex = 13;
            this.gbSearchedStudent.TabStop = false;
            this.gbSearchedStudent.Text = "Results";
            // 
            // lblStudentIDDisplay
            // 
            this.lblStudentIDDisplay.AutoSize = true;
            this.lblStudentIDDisplay.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentIDDisplay.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblStudentIDDisplay.Location = new System.Drawing.Point(255, 48);
            this.lblStudentIDDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentIDDisplay.Name = "lblStudentIDDisplay";
            this.lblStudentIDDisplay.Size = new System.Drawing.Size(89, 21);
            this.lblStudentIDDisplay.TabIndex = 29;
            this.lblStudentIDDisplay.Text = "Student ID";
            // 
            // lblCourseDisplay
            // 
            this.lblCourseDisplay.AutoSize = true;
            this.lblCourseDisplay.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDisplay.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCourseDisplay.Location = new System.Drawing.Point(714, 48);
            this.lblCourseDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseDisplay.Name = "lblCourseDisplay";
            this.lblCourseDisplay.Size = new System.Drawing.Size(64, 21);
            this.lblCourseDisplay.TabIndex = 28;
            this.lblCourseDisplay.Text = "Course";
            // 
            // lblAgeDisplay
            // 
            this.lblAgeDisplay.AutoSize = true;
            this.lblAgeDisplay.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeDisplay.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblAgeDisplay.Location = new System.Drawing.Point(489, 48);
            this.lblAgeDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgeDisplay.Name = "lblAgeDisplay";
            this.lblAgeDisplay.Size = new System.Drawing.Size(39, 21);
            this.lblAgeDisplay.TabIndex = 27;
            this.lblAgeDisplay.Text = "Age";
            // 
            // lblNameDisplay
            // 
            this.lblNameDisplay.AutoSize = true;
            this.lblNameDisplay.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDisplay.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblNameDisplay.Location = new System.Drawing.Point(40, 48);
            this.lblNameDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameDisplay.Name = "lblNameDisplay";
            this.lblNameDisplay.Size = new System.Drawing.Size(55, 21);
            this.lblNameDisplay.TabIndex = 23;
            this.lblNameDisplay.Text = "Name";
            // 
            // txtCourseResult
            // 
            this.txtCourseResult.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseResult.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtCourseResult.Location = new System.Drawing.Point(718, 72);
            this.txtCourseResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseResult.Name = "txtCourseResult";
            this.txtCourseResult.Size = new System.Drawing.Size(151, 29);
            this.txtCourseResult.TabIndex = 26;
            // 
            // txtAgeResult
            // 
            this.txtAgeResult.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeResult.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtAgeResult.Location = new System.Drawing.Point(494, 72);
            this.txtAgeResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAgeResult.Name = "txtAgeResult";
            this.txtAgeResult.Size = new System.Drawing.Size(151, 29);
            this.txtAgeResult.TabIndex = 25;
            // 
            // txtStudentIDResult
            // 
            this.txtStudentIDResult.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentIDResult.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtStudentIDResult.Location = new System.Drawing.Point(260, 72);
            this.txtStudentIDResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentIDResult.Name = "txtStudentIDResult";
            this.txtStudentIDResult.Size = new System.Drawing.Size(151, 29);
            this.txtStudentIDResult.TabIndex = 24;
            // 
            // txtNameDisplay
            // 
            this.txtNameDisplay.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameDisplay.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtNameDisplay.Location = new System.Drawing.Point(45, 72);
            this.txtNameDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameDisplay.Name = "txtNameDisplay";
            this.txtNameDisplay.Size = new System.Drawing.Size(151, 29);
            this.txtNameDisplay.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(902, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Clear";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(380, 414);
            this.dgvDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersWidth = 62;
            this.dgvDisplay.Size = new System.Drawing.Size(1030, 565);
            this.dgvDisplay.TabIndex = 14;
            this.dgvDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellClick);
            // 
            // gbSummaryDisplay
            // 
            this.gbSummaryDisplay.Controls.Add(this.txtOldestStudent);
            this.gbSummaryDisplay.Controls.Add(this.txtAverageAgeResult);
            this.gbSummaryDisplay.Controls.Add(this.panel6);
            this.gbSummaryDisplay.Controls.Add(this.panel7);
            this.gbSummaryDisplay.Controls.Add(this.panel5);
            this.gbSummaryDisplay.Controls.Add(this.txtTotalStudentResult);
            this.gbSummaryDisplay.Controls.Add(this.lblOldestStudent);
            this.gbSummaryDisplay.Controls.Add(this.btnSummaryResults);
            this.gbSummaryDisplay.Controls.Add(this.lblAverageAge);
            this.gbSummaryDisplay.Controls.Add(this.lblTotalStudents);
            this.gbSummaryDisplay.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSummaryDisplay.ForeColor = System.Drawing.Color.RosyBrown;
            this.gbSummaryDisplay.Location = new System.Drawing.Point(38, 591);
            this.gbSummaryDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSummaryDisplay.Name = "gbSummaryDisplay";
            this.gbSummaryDisplay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSummaryDisplay.Size = new System.Drawing.Size(291, 388);
            this.gbSummaryDisplay.TabIndex = 15;
            this.gbSummaryDisplay.TabStop = false;
            this.gbSummaryDisplay.Text = "Summary Display";
            // 
            // txtOldestStudent
            // 
            this.txtOldestStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldestStudent.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldestStudent.Location = new System.Drawing.Point(159, 214);
            this.txtOldestStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldestStudent.Name = "txtOldestStudent";
            this.txtOldestStudent.Size = new System.Drawing.Size(93, 26);
            this.txtOldestStudent.TabIndex = 26;
            // 
            // txtAverageAgeResult
            // 
            this.txtAverageAgeResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAverageAgeResult.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverageAgeResult.Location = new System.Drawing.Point(159, 143);
            this.txtAverageAgeResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAverageAgeResult.Name = "txtAverageAgeResult";
            this.txtAverageAgeResult.Size = new System.Drawing.Size(93, 26);
            this.txtAverageAgeResult.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(14, 245);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(354, 2);
            this.panel6.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(14, 174);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(354, 2);
            this.panel7.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(14, 98);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(354, 2);
            this.panel5.TabIndex = 19;
            // 
            // txtTotalStudentResult
            // 
            this.txtTotalStudentResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalStudentResult.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalStudentResult.Location = new System.Drawing.Point(159, 68);
            this.txtTotalStudentResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalStudentResult.Name = "txtTotalStudentResult";
            this.txtTotalStudentResult.Size = new System.Drawing.Size(93, 26);
            this.txtTotalStudentResult.TabIndex = 24;
            // 
            // lblOldestStudent
            // 
            this.lblOldestStudent.AutoSize = true;
            this.lblOldestStudent.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldestStudent.Location = new System.Drawing.Point(9, 220);
            this.lblOldestStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldestStudent.Name = "lblOldestStudent";
            this.lblOldestStudent.Size = new System.Drawing.Size(121, 24);
            this.lblOldestStudent.TabIndex = 5;
            this.lblOldestStudent.Text = "Highest Age:";
            // 
            // btnSummaryResults
            // 
            this.btnSummaryResults.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSummaryResults.FlatAppearance.BorderSize = 0;
            this.btnSummaryResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummaryResults.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummaryResults.ForeColor = System.Drawing.Color.Black;
            this.btnSummaryResults.Location = new System.Drawing.Point(30, 309);
            this.btnSummaryResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSummaryResults.Name = "btnSummaryResults";
            this.btnSummaryResults.Size = new System.Drawing.Size(222, 48);
            this.btnSummaryResults.TabIndex = 4;
            this.btnSummaryResults.Text = "Generate Summary ";
            this.btnSummaryResults.UseVisualStyleBackColor = false;
            this.btnSummaryResults.Click += new System.EventHandler(this.btnSummaryResults_Click);
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAge.Location = new System.Drawing.Point(9, 149);
            this.lblAverageAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(125, 24);
            this.lblAverageAge.TabIndex = 1;
            this.lblAverageAge.Text = "Average Age:";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudents.Location = new System.Drawing.Point(9, 74);
            this.lblTotalStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(138, 24);
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
            this.btnViewAllStudents.Location = new System.Drawing.Point(760, 988);
            this.btnViewAllStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewAllStudents.Name = "btnViewAllStudents";
            this.btnViewAllStudents.Size = new System.Drawing.Size(255, 49);
            this.btnViewAllStudents.TabIndex = 16;
            this.btnViewAllStudents.Text = "View All Students";
            this.btnViewAllStudents.UseVisualStyleBackColor = false;
            this.btnViewAllStudents.Click += new System.EventHandler(this.btnViewAllStudents_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(543, 355);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(284, 49);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update Student Details";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteStudent.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteStudent.FlatAppearance.BorderSize = 0;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(908, 355);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(284, 49);
            this.btnDeleteStudent.TabIndex = 19;
            this.btnDeleteStudent.Text = "Delete Student ";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DraftPRG282.Properties.Resources.istockphoto_2113476145_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(1296, 446);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblLine.Location = new System.Drawing.Point(648, 98);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(333, 20);
            this.lblLine.TabIndex = 21;
            this.lblLine.Text = "____________________________________";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1407, 1023);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 49);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStudentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1624, 1106);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdate);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.GroupBox gbSummaryDisplay;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Button btnSummaryResults;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Button btnViewAllStudents;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblOldestStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblClearStudentAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNameDisplay;
        private System.Windows.Forms.TextBox txtCourseResult;
        private System.Windows.Forms.TextBox txtAgeResult;
        private System.Windows.Forms.TextBox txtStudentIDResult;
        private System.Windows.Forms.Label lblStudentIDDisplay;
        private System.Windows.Forms.Label lblCourseDisplay;
        private System.Windows.Forms.Label lblAgeDisplay;
        private System.Windows.Forms.Label lblNameDisplay;
        private System.Windows.Forms.TextBox txtTotalStudentResult;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtOldestStudent;
        private System.Windows.Forms.TextBox txtAverageAgeResult;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}

