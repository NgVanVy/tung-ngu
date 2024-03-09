using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUNGDOAN111
{
    public class Teacher
    {
        private int v1;
        private string v2;
        private int v3;
        private string v4;
        private string v5;
        private string v6;

        public Teacher( string name, int age, string email, string teacherCode, string specialization)
        {
           
            Name = name;
            Age = age;
            Email = email;
            TeacherCode = teacherCode;
            Specialization = specialization;
        }

      
        public string Name { get; set; }
        public int Age  { get; set; }
        public string Email { get; set; }
        public string TeacherCode { get; set; }
        public string Specialization { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Teacher Information:");
            Console.WriteLine($"Full Name: {Name}\nAge: {Age}\nEmail: {Email}\nTeacher Code: {TeacherCode}\nSpecialization: {Specialization}\n");
        }
    }
}

