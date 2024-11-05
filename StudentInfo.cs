using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftPRG282
{
    public class StudentInfo
    {
        //Fields
        string studentName;
        int studentID;
        int studentAge;
        string course;

        //Constructors
        public StudentInfo() { }
        public StudentInfo(string name, int studentID, int studentAge, string course)
        {
            this.Name = name;
            this.StudentID = studentID;
            this.StudentAge = studentAge;
            this.Course = course;
        }

        //Properties
        public string Name { get => studentName; set => studentName = value; }
        public int StudentID { get => studentID; set => studentID = value; }
        public int StudentAge { get => studentAge; set => studentAge = value; }
        public string Course { get => course; set => course = value; }


        //How it will look in the text file
        public override string ToString() 
        { 
            return $" {studentID} | {studentName} | {studentAge} | {course}";
        }
    }
}
