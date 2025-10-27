using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._02
{
    public class LiveSession : Course
    {
        public LiveSession(string name, string instructor, Level level, DateTime schedule) : base(name, instructor, level)
        {
            Schedule = schedule;
        }

        public DateTime Schedule { get; set; }

        public override void Show()
        {
            Console.WriteLine($"[Schedule] {Name}\n - {Instructor} | Level: {Level} | Date: {Schedule} ");
        }

    }
}
