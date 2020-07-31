using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Console.WriteLine("This is the solution");



        }

        // access returnType name 

        void Variables()
        {   // dataType name value
            string noVal;
            string fName = "Chris";
            int age = 34;
            float f = 99.98f;
            decimal d = 99.98m;

            bool found = true;

            Console.WriteLine("________");
            System.Console.WriteLine(age + 1);
            System.Console.WriteLine(age - 10);
            System.Console.WriteLine(age * 10);
            System.Console.WriteLine(age / 2);
            System.Console.WriteLine(age % 2);

            for (int i = 0; i < 10; i++)
            {
                if (i != 5 && i != 7)
                {
                    System.Console.WriteLine(i);
                }

            }

            for (int j = 20; j >= 0; j--)
            {
                System.Console.WriteLine(j);
            }

            string[] students = new string[50];
            students[0] = "Student 1";
            students[1] = "another";


            List<string> animals = new List<string>();
            animals.Add("Lion");
            animals.Add("Tiger");

            string first = animals[0];

            for (int k = 0; k < animals.Count; k++)
            {
                System.Console.WriteLine(animals[k]);
            }

        }

        class Pro
        {
            public void HomeWork(List<int> numbers)
            {
                new Pro().HomeWork(numbers);

                List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 123, 567, 123, 78, 16, 723, 10, 135, 2, 46, 78 };

                int[] array1 = { 1, 3, 5, 7 };

                int sum1 = array1.Sum();
                int sum2 = nums.Sum();

                //print the sum of all numbers
                Console.WriteLine(sum1);
                Console.WriteLine(sum2);

                //print only even numbers
                int a = 2, sum = 0, b;

                //condition to check if the number is not 0
                while (a != 0)
                {
                    b = a % 10;       //extract a digit
                    sum = sum + b;   //adding the digits
                    a = a / 10;      //remained number
                }

                Console.WriteLine("The sum of the digits is: " + sum);

            }
        }

    }
}

