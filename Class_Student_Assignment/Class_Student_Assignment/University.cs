using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class_Student_Assignment
{
    class University
    {
  
        public int findNumberOfStudents()
        {
            // input number of students to be created

            bool successfullyParsed = false;
            int numberOfStudents;
            do
            {
                Console.WriteLine("Input number of students to be created: ");

                successfullyParsed = int.TryParse(Console.ReadLine(), out numberOfStudents);

                if (!successfullyParsed)
                {
                    Console.WriteLine("Please add a valid number !");
                }

            } while (!successfullyParsed);

            return numberOfStudents;
        }

        private int getStudentAge(int studentIndex)
        {
            // input age validation
            bool successfullyParsed = false;
            int out_age;

            do
            {
                Console.WriteLine($"Input age for student {studentIndex + 1}: ");

                successfullyParsed = int.TryParse(Console.ReadLine(), out out_age);

                if (!successfullyParsed)
                {
                    Console.WriteLine("Please add a valid number !");
                }

            } while (!successfullyParsed);

            return out_age;

        }

        private string getStudentName(int studentIndex)
        {
            Regex pattern = new Regex(@"^[a-zA-Z ]*$");
            string out_name;
            bool successfullyParsed = false;

            // input name validation with regex

            do
            {
                Console.WriteLine($"Input name for student {studentIndex + 1}: ");
                out_name = Console.ReadLine();
                if (!pattern.IsMatch(out_name))
                {
                    successfullyParsed = false;
                    Console.WriteLine("Enter a valid text format !");
                }
                else
                {
                    successfullyParsed = true;
                }

            } while (!successfullyParsed);

            return out_name;
        }

        private void addMark(Student student, int studentIndex)
        {
            // input mark 

            bool successfullyParsed = false;
            int mark;

            Console.WriteLine($"Input mark for student {studentIndex + 1}: ");

            successfullyParsed = int.TryParse(Console.ReadLine(), out mark);

            if (!successfullyParsed)
            {
                Console.WriteLine("Mark will be null !");

            }
            else
            {
                student.Mark = mark;
            }
        }

        public List<Student> batchAddStudents(int numberOfStudents)
        {
            var listOfStudents = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
               int age = getStudentAge(i);
               string name = getStudentName(i);
               var student = new Student(age, name);

               addMark(student, i);

                listOfStudents.Add(student);
            }

            return listOfStudents;

        }

        public double getAverageMark(int numberOfStudents, List<Student>listOfStudents)
        {
            // compute average of marks of all students created
            int accumulator = 0;

            foreach (var student in listOfStudents)
            {
                if (student.Mark != null)
                {
                    accumulator += (int)student.Mark;
                }
            }

            double averageMarks = (double)accumulator / numberOfStudents;
            return averageMarks;
        }
    }
}
