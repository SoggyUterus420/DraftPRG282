using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftPRG282
{
    public partial class frmStudentManagementForm : Form
    {
        private StudentManagementFile studentFileManager;
        

        public frmStudentManagementForm()
        {
            InitializeComponent();
            studentFileManager = new StudentManagementFile();
        }

        private void frmStudentManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var student = new StudentInfo
            {
                Name = txtName.Text,
                StudentID = int.Parse(txtStudentID.Text),
                StudentAge = int.Parse(txtAge.Text),
                Course = txtCourse.Text,
            };

            studentFileManager.AddStudent(student);
            MessageBox.Show("Student added successfully!");
        }

        private void lblClearStudentAdd_Click(object sender, EventArgs e)
        {
            txtName.Visible = false;
            txtStudentID.Visible = false;
            txtCourse.Visible = false;
            txtAge.Visible = false;
        }

        
        

        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
