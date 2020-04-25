using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("Jan Gosses Grade Book");
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);

            Statistics stats = book.GetStatistics();

            Console.WriteLine("For the book named {0}", book.Name);
            Console.WriteLine("The highest grade is: {0}", stats.High);
            Console.WriteLine("The lowest grade is: {0}", stats.Low);
            Console.WriteLine("The average grade is: {0}", stats.Average);
            Console.WriteLine("The letter grade is: {0}", stats.Letter);
            Console.ReadKey();
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    double grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
