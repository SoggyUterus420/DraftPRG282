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
        private StudentManagementFile studentFileManager = new StudentManagementFile();
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
            students = studentFileManager.read();

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
            MessageBox.Show("Student added successfully!");

            
        }

        private void lblClearStudentAdd_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtStudentID.Clear();
            txtAge.Clear();
            txtCourse.Clear();
        }

        private void RefreshStudentDataGrid()
        {
            dt.Clear();
            foreach (var student in students)
            {
                dt.Rows.Add(student.StudentID, student.Name, student.StudentAge, student.Course);
            }
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

                
                dt.Rows.Add(row);


            }
            RefreshStudentDataGrid();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchInput = txtSearchBar.Text;
            bool found = false;

            

            foreach (StudentInfo student in students) 
            { 
                if (student.StudentID.ToString().Equals(searchInput, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;

                    txtNameDisplay.Text = student.Name;
                    txtStudentIDResult.Text = student.StudentID.ToString();
                    txtAgeResult.Text = student.StudentAge.ToString();
                    txtCourseResult.Text = student.Course;


                    break;
                }
            }
                if (found == false)
                {
                    MessageBox.Show("No student with that ID exisits.");
                }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchBar.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtCourseResult.Clear();
            txtAgeResult.Clear();
            txtStudentIDResult.Clear();
            txtNameDisplay.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDisplay.Rows[e.RowIndex];

                // Populate TextBoxes with the row data
                txtNameDisplay.Text = row.Cells["Name"].Value?.ToString();
                txtStudentIDResult.Text = row.Cells["Student ID"].Value?.ToString();
                txtAgeResult.Text = row.Cells["Age"].Value?.ToString();
                txtCourseResult.Text = row.Cells["Course"].Value?.ToString();

            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("students.txt");
            int studentCount = lines.Length;
            int ageSum = lines.Sum(line => int.Parse(line.Split(',')[2]));
            double averageAge = (double)ageSum / studentCount;

            //lblStudentCount.Text = $"Total Students: {studentCount}";
            lblAverageAge.Text = $"Average Age: {averageAge:F2}";

            File.WriteAllText("students.txt", $"Total Students: {studentCount}\nAverage Age: {averageAge:F2}");
            MessageBox.Show("Summary report generated!");
        }
    }
}
