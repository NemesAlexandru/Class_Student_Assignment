using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Class_Student_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

           var university = new University();
           int numberOfStudents = university.findNumberOfStudents();

           var listOfStudents = university.batchAddStudents(numberOfStudents);
           var averageMark = university.getAverageMark(numberOfStudents, listOfStudents);

            Console.WriteLine($"Average Mark = {averageMark}");
     
        }
    }
}
