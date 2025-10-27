using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._02
{
    public class CourseCatalog
    {
        private List<Course> courses = new List<Course>();


        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

       
        public List<Course> this[Level level]
        {
            get
            {
                return courses.Where(c => c.Level == level).ToList();
            }
        }
    }
}
