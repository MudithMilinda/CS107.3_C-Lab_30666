using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Q01
{
    internal class Program
    {
        // Create a class called Course.
        public class Course
        {
            // Private fields.
            private string courseName;
            private string instructorName;
            private double grade;

            // Public properties.
            public string CourseName
            {
                get
                {
                    return courseName;
                }
                set
                {
                    courseName = value;
                }
            }

            public double Grade
            {
                get
                {
                    return grade;
                }
                set
                {
                    if (value < 0 || value > 100)
                    {
                        throw new ArgumentException("Grade must be between 0 and 100.");
                    }
                    grade = value;
                }
            }

            // Public method SetInstructorName to set the instructor's name
            public void SetInstructorName(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Instructor name cannot be empty.");
                }
            }

            // Private method CalculateLetterGrade to calculate the grade letter
            private string CalculateLetterGrade()
            {
                if (grade <= 100 && grade >= 75)
                {
                    return "A";
                }
                else if (grade > 75 && grade <= 65)
                {
                    return "B";
                }
                else if (grade > 65 && grade <= 55)
                {
                    return "C";
                }
                else if (grade > 55 && grade <= 40)
                {
                    return "S";
                }
                else
                {
                    return "F";
                }
            }

            // Public method PrintCourseInfo to displays the course name, instructor name, and letter grade
            public void PrintCourseInfo()
            {
                string gradeLetter = CalculateLetterGrade();
                Console.WriteLine($"Course Name: {courseName}");
                Console.WriteLine($"Instructor Name: {instructorName}");
                Console.WriteLine($"Grade: {gradeLetter}");
            }

            public Course(string courseName, string instructorName, double grade)
            {
                this.courseName = courseName;
                SetInstructorName(instructorName);
                Grade = grade;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Course course1 = new Course("Math", "Mr. Edward", 85);
                course1.PrintCourseInfo();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

        Console.ReadLine();
        }
    }
}
