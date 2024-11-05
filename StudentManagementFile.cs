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
            using (StreamWriter writer = new StreamWriter("Students.txt", append: true))
            {
                writer.WriteLine($"Name: {student.Name} | Student ID: {student.StudentID} | Age: {student.StudentAge} | Course: {student.Course}");
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
                    writer.WriteLine($"Name: {student.Name} | Student ID: {student.StudentID} | Age: {student.StudentAge} | Course: {student.Course}");
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
                
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string text;
            while ((text = sr.ReadLine()) != null)
            {
                string[] strings = text.Split('|');
                StudentInfo newstudent = new StudentInfo();
                if (strings.Length == 4)
                {
                    if (int.TryParse(strings[1], out int studentID) && int.TryParse(strings[2], out int studentAge))
                    {
                        students.Add(new StudentInfo
                        {
                            Name = strings[0],
                            StudentID = studentID,
                            StudentAge = studentAge,
                            Course = strings[3]
                        });
                    }
                    else
                    {
                        // Handle invalid data format, e.g., log or skip the entry
                        Console.WriteLine($"Warning: Skipping line with invalid data: {text}");
                    }
                }

                    students.Add(newstudent);
            }
            fs.Close();
            sr.Close();

            return students;
        }



        
    }
}
        



    