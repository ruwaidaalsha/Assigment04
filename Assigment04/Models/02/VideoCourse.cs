using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._02
{
    public class VideoCourse:Course
    {
        public VideoCourse(string name, string instructor, Level level, double duration) : base(name, instructor, level)
        {
            Duration = duration;
        }

        public double Duration { get; set; }

        public override void Show()
        {
            Console.WriteLine($"[Video Course] {Name}\n - {Instructor} | Level: {Level} | Duration: {Duration} hours");
        }
    }
}
