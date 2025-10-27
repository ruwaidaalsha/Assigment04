using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._05
{
    public class TaskList
    {
        private List<myTask> tasks = new List<myTask>();

        public void AddTask(myTask task)
        {
            tasks.Add(task);
            Console.WriteLine($" Task : {task.Title}\nadded.");
        }

        
        public List<myTask> this[TaskPriority priority]
        {
            get
            {
                return tasks.Where(t => t.Priority == priority).ToList();
            }
        }

        
        public void MarkComplete(string taskTitle)
        {
            myTask task = tasks.FirstOrDefault(t => t.Title == taskTitle);
            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine($"Task:{taskTitle}\n marked as complete.");
            }
            else
            {
                Console.WriteLine($"Task :{taskTitle}\nnot found.");
            }
        }

        
        public void ShowAll()
        {
            Console.WriteLine("\nAll Tasks ");
            foreach (var t in tasks)
            {
                t.ShowTask();
            }
        }
    }
}
