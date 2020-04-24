using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<float>();
            Name = name;
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            Statistics result = new Statistics();
            result.Average = 0.0F;
            result.High = float.MinValue;
            result.Low = float.MaxValue;

            foreach (float grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }

        private List<float> grades;
        public string Name;
    }
}
