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

            students = students.Where(s => s.StudentID != studentID).ToList();

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.StudentID} | {student.Name} | {student.StudentAge} | {student.Course}");
                }
            }
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

            if (!File.Exists(filePath)) return students;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 4 && int.TryParse(parts[0], out int studentID) && int.TryParse(parts[2], out int studentAge))
                {
                    students.Add(new StudentInfo
                    {
                        StudentID = studentID,
                        Name = parts[1],
                        StudentAge = studentAge,
                        Course = parts[3]
                    });
                }
                else
                {
                    // Log or handle invalid data here if needed
                    Console.WriteLine($"Invalid data: {line}");
                }
            }
            return students;
        }

    }
}
        



    