using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GradeBooks
    {
       

public class GradeBook  // Class to hold the dictionary and methods
    {
        private Dictionary<string, string> _studentGrades; // Private field

        public GradeBook() // Constructor to initialize the dictionary
        {
            _studentGrades = new Dictionary<string, string>();
        }

        public void AddStudentGrade(string studentName, string grade)
        {
            _studentGrades.Add(studentName, grade);
        }


        public string GetGrade(string studentName)
        {
            if (_studentGrades.ContainsKey(studentName))
            {
                return _studentGrades[studentName];
            }
            else
            {
                return null; // Or throw an exception 
            }
        }

        public string GetGradeSafe(string studentName)
        {
            if (_studentGrades.TryGetValue(studentName, out string grade))
            {
                return grade;
            }
            else
            {
                return null; // Or throw an exception
            }
        }

        public void DisplayAllGrades()
        {
            Console.WriteLine("\nAll Students and Grades:");
            foreach (var student in _studentGrades)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
        }
    }


 
}
}
