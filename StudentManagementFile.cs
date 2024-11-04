using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace DraftPRG282
{
    internal class StudentManagementFile
    {
        //Creating the file
        string filePath = @"./students.txt";



        //Will allow students to be added, deleted, and updated without overriding the entire file
        public void AddStudent(StudentInfo student)
        {
            using (StreamWriter writer = new StreamWriter("Students.txt", append: true))
            {
                writer.WriteLine($"Name: {student.Name} | Student ID: {student.StudentID} | Age: {student.StudentAge} | Course: {student.Course}");
            }
        }


        
        // Loads all students from the file
        public List<StudentInfo> GetStudents()
        {
            var students = new List<StudentInfo>();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        if (int.TryParse(parts[1], out int studentID) && int.TryParse(parts[2], out int studentAge))
                        {
                            students.Add(new StudentInfo
                            {
                                Name = parts[0],
                                StudentID = studentID,
                                StudentAge = studentAge,
                                Course = parts[3]
                            });
                        }
                        else
                        {
                            // Handle invalid data format, e.g., log or skip the entry
                            Console.WriteLine($"Warning: Skipping line with invalid data: {line}");
                        }
                    }
                }
            }
            return students;
        }

        // Saves all students to the file (overwrites)
        public void SaveAllStudents(List<StudentInfo> students)
        {
            var lines = students.Select(s => $"{s.Name}\t{s.StudentID}\t{s.StudentAge}\t{s.Course}");
            File.WriteAllLines(filePath, lines);
        }
    }
}
        



    