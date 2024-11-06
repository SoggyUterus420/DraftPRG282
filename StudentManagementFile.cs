using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO.Ports;

namespace DraftPRG282
{
    internal class StudentManagementFile
    {
        //Creating the file
        string filePath = @"./students.txt";



        //Will allow students to be added, deleted, and updated without overriding the entire file
        public void AddStudent(StudentInfo student)
        {
            using (StreamWriter writer = new StreamWriter("students.txt", append: true))
            {
                writer.WriteLine($"{student.StudentID} | {student.Name} | {student.StudentAge} | {student.Course}");
            }
        }

        public void DeleteStudent(int studentID)
        {
            List<StudentInfo> students = read();

            var updatedStudents = students.Where(s => s.StudentID != studentID).ToList();

            if (updatedStudents.Count == students.Count)
            {
                Console.WriteLine("No student found with the specified ID.");
                return;
            }


            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var student in updatedStudents)
                {
                    writer.WriteLine($"Name: {student.Name} | Student ID: {student.StudentID} | Age: {student.StudentAge} | Course: {student.Course}");
                }
            }

            Console.WriteLine($"Student with ID {studentID} deleted successfully.");
        }

        public void Write(List<StudentInfo> students)
        {

            FileStream fs = new FileStream(filePath, FileMode.Create);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                string text;
                foreach (StudentInfo student in students)
                {
                    text = student.Name;
                    sw.WriteLine(text);
                }
            }

            fs.Close();
            Console.WriteLine("Data saved successfully");
            Console.ReadLine();
        }

        public List<StudentInfo> read()
        {
            List<StudentInfo> students = new List<StudentInfo>();

            // Ensure the file exists before attempting to read
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist.");
                return students;
            }

            // Open the file to read data
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Split by " | " to get each component
                    string[] parts = line.Split('|');

                    if (parts.Length == 4)
                    {
                        try
                        {
                            // Extract each field value after ": "
                            string name = parts[0].Split(':')[1].Trim();
                            int studentID = int.Parse(parts[1].Split(':')[1].Trim());
                            int age = int.Parse(parts[2].Split(':')[1].Trim());
                            string course = parts[3].Split(':')[1].Trim();

                            // Create new student and add to the list
                            students.Add(new StudentInfo
                            {
                                Name = name,
                                StudentID = studentID,
                                StudentAge = age,
                                Course = course
                            });
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error parsing line: {line}. Exception: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Skipping improperly formatted line: {line}");
                    }
                }
            }
            return students;
        }


    }
}
        



    