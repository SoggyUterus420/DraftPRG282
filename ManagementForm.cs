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

            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Student ID", typeof(int));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Course", typeof(string));

            dgvDisplay.DataSource = dt;
        }

        
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var student = new StudentInfo
            {
                StudentID = int.Parse(txtStudentID.Text),
                Name = txtName.Text,
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

        
        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {
            dt.Clear(); // Clear any previous rows
            string[] lines = File.ReadAllLines(@"./students.txt");

            foreach (string line in lines)
            {
                string[] values = line.Split('|');
                if (values.Length == 4)
                {
                    dt.Rows.Add(values[1].Trim(), values[0].Trim(), int.Parse(values[2].Trim()), values[3].Trim());
                }
            }

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
            //Checks if row is selected. No row selected will then be null.
            if (dgvDisplay.CurrentRow != null)
            {
                //Obtain position of selected row.
                int rowIndex = dgvDisplay.CurrentCell.RowIndex;

                // Get the student ID from the selected row in the DataGridView
                if (int.TryParse(dgvDisplay.Rows[rowIndex].Cells["Student ID"].Value.ToString(), out int studentID))
                {
                    StudentManagementFile managementFile = new StudentManagementFile();

                    // Delete the student from the file
                    managementFile.DeleteStudent(studentID);

                    // Remove the student from the DataGridView
                    dgvDisplay.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Student deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Unable to retrieve a valid Student ID from the selected row.");
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
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

        private void btnSummaryResults_Click(object sender, EventArgs e)
        {
            //Calculates the amount of rows in the dgv
            int studentCount = dgvDisplay.Rows.Count;
            if (dgvDisplay.AllowUserToAddRows)
            {
                // Subtract 1 if there's an empty row at the end
                studentCount--;
            }
            txtTotalStudentResult.Text = studentCount.ToString();

            //Calculates the average age
            txtAverageAgeResult.Text = Math.Round((from DataGridViewRow row in dgvDisplay.Rows
                                  where row.Cells[2].FormattedValue.ToString() != string.Empty
                                  select Convert.ToInt32(row.Cells[2].FormattedValue)).Average(), 3).ToString();

            //Checks which student it the oldest
            txtOldestStudent.Text = (from DataGridViewRow row in dgvDisplay.Rows
                                        where row.Cells[2].FormattedValue.ToString() != string.Empty
                                        select (row.Cells[2].FormattedValue)).Max().ToString();

            string filePath = "summary.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Summary Results");
                    writer.WriteLine("----------------");
                    writer.WriteLine($"Total Students: {studentCount}");
                    writer.WriteLine($"Average Age: {txtAverageAgeResult.Text}");
                    writer.WriteLine($"Oldest Student Age: {txtOldestStudent.Text}");
                }

                MessageBox.Show("Summary saved to summary.txt", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving summary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
