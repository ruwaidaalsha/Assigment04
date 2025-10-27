using Assigment04.Models._01;
using Assigment04.Models._01.Assigment04.Models._01;
using Assigment04.Models._02;
using Assigment04.Models._03;
using Assigment04.Models._04;
using Assigment04.Models._05;

namespace Assigment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //QTicket Booking System1 
            //TicketSystem system = new TicketSystem();


            //system.AddTicket(new Ticket("Concert", "A01", TicketType.Regular));
            //system.AddTicket(new Ticket("Concert", "R02", TicketType.VIP));
            //system.AddTicket(new Ticket("Concert", "C03", TicketType.Backstage));
            //system.AddTicket(new Ticket("Festival", "D04", TicketType.Regular));
            //system.AddTicket(new Ticket("Festival", "E05", TicketType.VIP));


            //Ticket found = system["R02"];
            //Console.WriteLine($"Seat {found.SeatNumber} is  {found.Type} Ticket for {found.EventName}");

            //Console.WriteLine("**********************************************");

            //Console.WriteLine("\n Ticket Count : ");
            //system.CountTicketsByType();

            // =====================================================================================================

            //Q2 Online Course Enrollment System

            //CourseCatalog catalog = new CourseCatalog();


            //catalog.AddCourse(new VideoCourse("C# Basics", "Sara", Level.Beginner, 5));
            //catalog.AddCourse(new VideoCourse("OOP in C#", "Asma", Level.Intermediate, 7));
            //catalog.AddCourse(new LiveSession("Advanced .NET ", "Leema", Level.Advanced, new DateTime(2025, 11, 10)));
            //catalog.AddCourse(new LiveSession("Intro to Programming", "Hanadi", Level.Beginner, new DateTime(2025, 11, 5)));


            //Console.WriteLine("Beginner Courses ");
            //foreach (var c in catalog[Level.Beginner])
            //    c.Show();
            //Console.WriteLine("=============================");

            //Console.WriteLine("\nIntermediate Courses");
            //foreach (var c in catalog[Level.Intermediate])
            //    c.Show();
            //Console.WriteLine("=============================");

            //Console.WriteLine("\nAdvanced Courses");
            //foreach (var c in catalog[Level.Advanced])
            //    c.Show();
            //Console.WriteLine("=============================");

            //---------------------------------------------------------------------------------------------
            //Q3 Smart Home Control Center
            //    SmartHome home = new SmartHome();


            //    home[DeviceType.Light].TurnOn();
            //    home[DeviceType.Fan].TurnOn();

            //    Console.WriteLine("\nDevice Status ");
            //    home[DeviceType.Light].ShowStatus();
            //    home[DeviceType.Fan].ShowStatus();
            //    home[DeviceType.AC].ShowStatus();
            //    home[DeviceType.Heater].ShowStatus();

            //    Console.WriteLine("++++++++++++++++++++++++++++++");

            //    Console.WriteLine("\nTurning OFF...");
            //    home[DeviceType.Fan].TurnOff();
            //    home[DeviceType.Heater].TurnOff();

            //    Console.WriteLine("++++++++++++++++++++++++++++++");

            //    Console.WriteLine("\nUpdated Status ");
            //    foreach (DeviceType type in Enum.GetValues(typeof(DeviceType)))
            //    {
            //        home[type].ShowStatus();
            //    }
            //}

            //--------------------------------------------------------------
            //Q4 Library System with Book Status Tracking
            //Library library = new Library();

            //library.AddBook(new Book("Brave New World", "Aldous Huxley", BookStatus.CheckedOut)); 
            //library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", BookStatus.Reserved)); 
            //library.AddBook(new Book("Thinking, Fast and Slow", "Daniel Kahneman", BookStatus.Available)); 
            //library.AddBook(new Book("Man's Search for Meaning", "Viktor Frankl", BookStatus.CheckedOut)); 
            //library.AddBook(new Book("The Power of Habit", "Charles Duhigg", BookStatus.Available)); 


            //Console.WriteLine("Accessing a specific book:");
            //Console.WriteLine("==========================================");
            //Book foundBook = library["Thinking, Fast and Slow"];
            //foundBook.ShowInfo();

            //Console.WriteLine("==========================================");
            //library.ChangeStatus("Thinking, Fast and Slow", BookStatus.CheckedOut);
            //Console.WriteLine("==========================================");

            //library.ShowBooksByStatus(BookStatus.Available);
            //Console.WriteLine("==========================================");
            //library.ShowBooksByStatus(BookStatus.CheckedOut);
            //Console.WriteLine("==========================================");
            //library.ShowBooksByStatus(BookStatus.Reserved);

            //------------------------------------------------------------------------------
            //Q5 Task Tracker Application
            TaskList myTasks = new TaskList();

            
            myTasks.AddTask(new myTask("Finish Report", "Complete the annual report", TaskPriority.High));
            myTasks.AddTask(new myTask("Email Client", "Send proposal email", TaskPriority.Medium));
            myTasks.AddTask(new myTask("Grocery Shopping", "Buy vegetables and fruits", TaskPriority.Low));
            myTasks.AddTask(new myTask("Team Meeting", "Discuss project progress", TaskPriority.High));
            myTasks.AddTask(new myTask("Read Book", "Read 30 pages of psychology book", TaskPriority.Low));

           
            Console.WriteLine("\nHigh Priority Tasks ");
            foreach (var task in myTasks[TaskPriority.High])
            {
                task.ShowTask();
            }

         
            myTasks.MarkComplete("Email Client");

            
            myTasks.ShowAll();





        }
    }







}



    