using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUNGDOAN111
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Full Name: {Name}\nAge: {Age}\nEmail: {Email}\n");
        }
    }

}
