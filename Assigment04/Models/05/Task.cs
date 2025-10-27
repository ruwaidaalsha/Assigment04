using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._05
{
    public class myTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskPriority Priority { get; set; }
        public bool IsCompleted { get; set; } = false;

        public myTask(string title, string description, TaskPriority priority)
        {
            Title = title;
            Description = description;
            Priority = priority;
        }

        public void ShowTask()
        {
            Console.WriteLine($"Title: {Title}, Priority: {Priority}, Completed: {IsCompleted}");
            Console.WriteLine($"Description: {Description}\n");
        }
    }
}
