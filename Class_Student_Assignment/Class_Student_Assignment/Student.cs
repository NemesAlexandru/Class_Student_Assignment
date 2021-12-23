using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student_Assignment
{
    class Student
    {
        const int MIN_AGE = 18;
        const int MAX_AGE = 99;

        private int age;
        private string name;
        private Nullable<int> mark = null;

        public Student(int age, string name)
        {
            this.age = setAge(age);
            this.name = name;
        }

        public int Age
        {
            get => age;
            set => age = setAge(value);

    }

        public string Name {
            get => name;
            set => name = value;
        }

        public Nullable<int> Mark
        {
            get => mark;
            set => mark = value;
        }

        // a readonly dynamic property named Info, combining name and age in one string

        public string NameAndAge
        {
            get => $"name: {name}, age: {age}";
        }

        private int setAge(int inputAge) {
            {
                if (inputAge > MAX_AGE)
                {             
                    Console.WriteLine($"Age can't be greater than {MAX_AGE} !");
                    return this.age;
                }
                else if (inputAge < MIN_AGE)
                {
                    Console.WriteLine($"Age can't be lower than {MIN_AGE} !");
                    return this.age;
                }
                else
                {
                    return inputAge;
                }

            }
        }
    }
}
