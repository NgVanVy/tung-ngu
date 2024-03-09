using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUNGDOAN111
{
    public class Subject
    {
        public int ID { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string TeacherName { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Subject Information:");
            Console.WriteLine($"Subject Code: {SubjectCode}\nSubject Name: {SubjectName}\nTeacher Name:{TeacherName}");

        }
    }
}
