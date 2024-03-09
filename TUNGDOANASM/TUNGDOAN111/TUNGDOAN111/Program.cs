using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUNGDOAN111
{
    class Program
    {
        static void Main()
        {
            // Tạo đối tượng Teacher với ID
            Teacher teacher = new Teacher( "Dinh Van Dong", 40, "xxxxxx@fpt.edu.vn", "FPI", "Computer Science");
            Teacher teacher1 = new Teacher( "Ta Quang Hieu", 35, "xxxxxx@fpt.edu.vn", "FPI", "Computer Science");



            // Tạo đối tượng Student với ID
            Student student = new Student( "Dao Doan Tung", 20, "tungddbh01121@fpt.edu.vn", "BH01121");
            Student student1 = new Student("Dao Doan Tung", 20, "tungddbh01121@fpt.edu.vn", "BH01121");

            // Tạo đối tượng Course với ID
            Course course = new Course { ID = 3, CourseCode = "SP2024", CourseName = "SPRING 2024" };
            Course course1 = new Course { ID = 3, CourseCode = "SP2024", CourseName = "SPRING 2024" };


            // Tạo đối tượng Subject với ID
            Subject subject = new Subject {ID = 4, SubjectCode = "7429", SubjectName = "Advanced Programming and Principles Design", TeacherName = " Dinh Van Dong " };

            Subject subject1 = new Subject { ID = 4, SubjectCode = "7428", SubjectName = "Discrete Mathematics", TeacherName = " Ta Quang Hieu " };






            // Sinh viên đăng ký khóa học và môn học

            course.Subjects.Add(subject);

            // Hiển thị thông tin
            teacher.DisplayInfo(); Console.WriteLine(); student.DisplayInfo();course.DisplayInfo();subject.DisplayInfo(); Console.WriteLine(); Console.WriteLine(); 
            teacher1.DisplayInfo(); Console.WriteLine(); student1.DisplayInfo();course1.DisplayInfo();subject1.DisplayInfo(); Console.WriteLine(); Console.WriteLine();




        }
    }
}
