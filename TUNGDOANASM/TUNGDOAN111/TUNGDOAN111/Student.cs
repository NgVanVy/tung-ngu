using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUNGDOAN111
{
    public class Student
    {
        private string name;
        private int age;
        private string email;
        private string studentCode;

        public Student(string name, int age, string email, string studentCode)
        {
            Name = name;
            Age = age;
            Email = email;
            StudentCode = studentCode;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string StudentCode
        {
            get { return studentCode; }
            set { studentCode = value; }
        }



        public void DisplayInfo()
        {
            Console.WriteLine($"Student Information:");
            Console.WriteLine($"Full Name: {Name}\nAge: {Age}\nEmail: {Email}\nStudent Code: {StudentCode}");
        }
    }
}

 
