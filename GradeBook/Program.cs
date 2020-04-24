using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Jan Gosses Grade Book");
            book.AddGrade(89.1F);
            book.AddGrade(90.5F);
            book.AddGrade(77.5F);
            Statistics stats = book.GetStatistics();

            Console.WriteLine("The highest grade is: {0:F2}", stats.High);
            Console.WriteLine("The lowest grade is: {0:F2}", stats.Low);
            Console.WriteLine("The average is: {0:F2}", stats.Average);
            Console.ReadKey();
        }
    }
}
