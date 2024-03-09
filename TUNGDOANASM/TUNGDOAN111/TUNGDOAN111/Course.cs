using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TUNGDOAN111
{
    public class Course
    {
        public int ID { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>(); // Added Subjects property

        public void DisplayInfo()
        {
            Console.WriteLine($"Course Information:");
            Console.WriteLine($"Course Code: {CourseCode}\nCourse Name: {CourseName}");

          
        }
    }
}
