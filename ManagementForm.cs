using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DraftPRG282
{
    public partial class frmStudentManagementForm : Form
    {
        private StudentManagementFile studentFileManager;
        private List<StudentInfo> students = new List<StudentInfo>();


        public frmStudentManagementForm()
        {
            InitializeComponent();
            studentFileManager = new StudentManagementFile();
            students = studentFileManager.read(); 
            
        }

        DataTable dt = new DataTable();
        private void frmStudentManagementForm_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Student ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(string));
            dt.Columns.Add("Course", typeof(string));

            dgvDisplay.DataSource = dt;
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
            students.Add(student);
            //studentFileManager.AddStudent(student);
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
            string[] lines = File.ReadAllLines(@"./students.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                //dataGridView1.Rows.Add(row);
                dt.Rows.Add(row);


            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtStudentID.Text, out int studentID))
            {
                StudentManagementFile managementFile = new StudentManagementFile();

                managementFile.DeleteStudent(studentID);

                MessageBox.Show("Student deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID.");
            }
        }
    }
}
