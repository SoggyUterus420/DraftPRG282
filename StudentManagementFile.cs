using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DraftPRG282
{
    internal class StudentManagementFile
    {
        //Creating the file
        string filePath = @"./students.txt";


        
        //Will allow students to be added, deleted, and updated without overriding the entire file
        public void AddStudent(StudentInfo student)
        {
            File.AppendAllText(filePath, student.ToString() + Environment.NewLine);
        }


        //Creating a method to load the new student to the text file.
        public List<StudentInfo> GetStudents() 
        { 
            var students = new List<StudentInfo>();
            if (File.Exists(filePath)) 
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('\t');
                    if (parts.Length == 4)
                    {
                        students.Add(new StudentInfo
                        {
                            Name = parts[0],
                            StudentID = int.Parse(parts[1]),
                            StudentAge = int.Parse(parts[2]),
                            Course = parts[3]
                        });
                    }

                }

                
            }
            return students;
        }

        //Saves the text file, even after close for delete, update, and adding.
        public void SaveAllStudents(List<StudentInfo> students)
        {
            var lines = students.Select(s => s.ToString());
            File.WriteAllLines(filePath, lines);
        }
    }
}
