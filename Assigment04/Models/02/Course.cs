using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._02
{
    public class Course
    {
        public string Name { get; set; }
        public string Instructor { get; set; }
        public Level Level { get; set; }

        public Course(string name, string instructor, Level level)
        {
            Name = name;
            Instructor = instructor;
            Level = level;
        }

        
        public virtual void Show()
        {
            Console.WriteLine($"Course: {Name}, Instructor: {Instructor}, Level: {Level}");
        }
    }
}
