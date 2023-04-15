using System;


namespace Daily_Report_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report:");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string currentPage = Console.ReadLine();
            int currentPageNum = Convert.ToInt32(currentPage);
            Console.WriteLine("Do you need help with anythin? Please answer true or false.");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study?");
            string studyHours = Console.ReadLine();
            int hoursStudy = Convert.ToInt32(studyHours);
            Console.WriteLine("Thank You for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}
