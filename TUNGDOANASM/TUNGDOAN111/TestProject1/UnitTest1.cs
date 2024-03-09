using NUnit.Framework;

namespace TUNGDOAN111.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void TestTeacherInitialization()
        {
            // Arrange
            Teacher teacher = new Teacher("Dinh Van Dong", 40, "xxxxxx@fpt.edu.vn", "FPI", "Computer Science");

            // Assert
            Assert.AreEqual("Dinh Van Dong", teacher.Name);
            Assert.AreEqual(40, teacher.Age);
            Assert.AreEqual("xxxxxx@fpt.edu.vn", teacher.Email);
            Assert.AreEqual("FPI", teacher.Department);
            Assert.AreEqual("Computer Science", teacher.Subject);
        }

        [Test]
        public void TestStudentInitialization()
        {
            // Arrange
            Student student = new Student("Dao Doan Tung", 20, "tungddbh01121@fpt.edu.vn", "BH01121");

            // Assert
            Assert.AreEqual("Dao Doan Tung", student.Name);
            Assert.AreEqual(20, student.Age);
            Assert.AreEqual("tungddbh01121@fpt.edu.vn", student.Email);
            Assert.AreEqual("BH01121", student.StudentID);

        }

        [Test]
        public void TestCourseInitialization()
        {
            // Arrange
            Course course = new Course { ID = 3, CourseCode = "SP2024", CourseName = "SPRING 2024" };

            // Assert
            Assert.AreEqual(3, course.ID);
            Assert.AreEqual("SP2024", course.CourseCode);
            Assert.AreEqual("SPRING 2024", course.CourseName);
        }

        [Test]
        public void TestSubjectInitialization()
        {
            // Arrange
            Subject subject = new Subject
            {
                ID = 4,
                SubjectCode = "7429",
                SubjectName = "Advanced Programming and Principles Design",
                TeacherName = "Dinh Van Dong"
            };

            // Assert
            Assert.AreEqual(4, subject.ID);
            Assert.AreEqual("7429", subject.SubjectCode);
            Assert.AreEqual("Advanced Programming and Principles Design", subject.SubjectName);
            Assert.AreEqual("Dinh Van Dong", subject.TeacherName);
        }

        internal class Subject
        {
            public string SubjectCode { get; internal set; }
            public string SubjectName { get; internal set; }
            public string TeacherName { get; internal set; }
            public int ID { get; internal set; }
        }

        internal class Course
        {
            public string CourseCode { get; internal set; }
            public string CourseName { get; internal set; }
            public int ID { get; internal set; }
        }

        internal class Teacher
        {
            public string Name { get; internal set; }
            public int Age { get; internal set; }
            public string Email { get; internal set; }
            public string Department { get; internal set; }
            public string Subject { get; internal set; }

            public Teacher(string name, int age, string email, string department, string subject)
            {
                Name = name;
                Age = age;
                Email = email;
                Department = department;
                Subject = subject;
            }
        }

        internal class Student
        {
            public string Name { get; internal set; }
            public int Age { get; internal set; }
            public string Email { get; internal set; }
            public string StudentID { get; internal set; }

            public Student(string name, int age, string email, string studentID)
            {
                Name = name;
                Age = age;
                Email = email;
                StudentID = studentID;
            }
        }
    }
}
