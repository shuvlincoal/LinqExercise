using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */



            //--------------------------------------------------------------
            //TODO: Print the Sum of numbers

            int sumOfPositives = numbers.Where(x => x > 0).Sum();
            Console.WriteLine(sumOfPositives);
            Console.WriteLine($"Task#1 Average Of Numbers: {sumOfPositives}");
            Console.WriteLine("\n");
            Console.WriteLine("Press return> ");
            Console.ReadLine();


            //--------------------------------------------------------------
            //TODO: Print the Average of numbers
            var avgOfNumbers = numbers.Average();
            Console.WriteLine($"Task#2 Average Of Numbers: {avgOfNumbers}");
            Console.WriteLine("\n");
            Console.WriteLine("Press return> ");
            Console.ReadLine();




            //--------------------------------------------------------------
            //TODO: Order numbers in ascending order and print to the console
            var orderNumbers = numbers.OrderBy(x => x);
            foreach (var num in orderNumbers)
            {
                Console.WriteLine($"Task#3 Order Ascending {num}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press return> ");
            Console.ReadLine();




            //--------------------------------------------------------------
            //TODO: Order numbers in descending order and print to the console
            var orderNbrDescend1 = numbers.OrderByDescending(x => x);
            foreach (var num in orderNbrDescend1)
            {
                Console.WriteLine($"Task#4 Order Descending {num}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press return> ");
            Console.ReadLine();





            //--------------------------------------------------------------
            //TODO: Print to the console only the numbers greater than 6
            var onlyGreat6 = numbers.Where((x) => x > 6);
            foreach (var num in onlyGreat6)
            {
                Console.WriteLine($"Task#5 Greater than 6 {num}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press return> ");
            Console.ReadLine();





            //--------------------------------------------------------------
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var orderNbrsAscending2 = numbers.Take(4).OrderBy(x => x);
            //var count4 = orderNbrsAscending2.TakeLast(4);
            foreach (var num in orderNbrsAscending2)
            {
                Console.WriteLine($"Task#6 Order Ascending, 4count only {num}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press return> ");
            Console.ReadLine();






            //--------------------------------------------------------------
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 21;
            var orderNbrDescend2 = numbers.OrderByDescending(x => x);
            foreach (var num in orderNbrDescend2)
            {
                Console.WriteLine($"Task#7 Order Descending with index4 change {num}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press return> ");
            Console.ReadLine();


            //--------------------------------------------------------------
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the
            //console only if their FirstName starts with a C OR an S
            //and order this in ascending order by FirstName.
            var empNameCS = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S"));
            foreach (var emp in empNameCS)
            {
                Console.WriteLine($"Task#8a Employee 1st Name begins \"C\" & \"S\"  {emp.FirstName}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press return> ");
            Console.ReadLine();



            //--------------------------------------------------------------
            //TODO: Print all the employees' FullName and Age who are over the age
            //26 to the console and order this by Age first and then by FirstName
            //in the same result.
            //var empDesc = employees.OrderBy(x => x.Age).OrderBy(x => x.FirstName).Where(x => x.Age > 26);
            var empDesc = employees.OrderBy(x => x.FirstName).Where(x => x.Age > 26);
            foreach (var emp in empDesc)
            {
                Console.WriteLine($"Task#9 Employee List over age 26 {emp.FullName},\t\t{emp.Age}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press return> ");
            Console.ReadLine();



            //------------------------------------------------------------------
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35.
            var sumYOE = employees.Where(x => x.YearsOfExperience <= 10).Where(x => x.Age > 35).Sum(x => x.YearsOfExperience);
            var cntYOE = employees.Where(x => x.YearsOfExperience <= 10).Where(x => x.Age > 35).Count();
            decimal avgYOE = sumYOE / cntYOE;
            Console.WriteLine($"Task#10a Sum age between 10 & 35 {sumYOE}");
            Console.WriteLine($"Task#10b Avg age between 10 & 35 {avgYOE}");
            Console.WriteLine("\n");
            Console.WriteLine("Press return> ");
            Console.ReadLine();


            //--------------------------------------------------------------
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees.Add(new Employee("Bart", "Simpson", 11, 5));
            var allEmployee = employees.OrderBy(x => x.LastName);
            foreach (var emp in allEmployee)
            {
                Console.WriteLine($"Task#11 Employee List:  {emp.LastName}, {emp.FirstName}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press return> ");
            Console.ReadLine();
        }


        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz",    "Sanchez", 25, 10));
            employees.Add(new Employee("Steven",  "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel",  "Walsh", 72, 22));
            employees.Add(new Employee("Jill",    "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke",  "Urameshi", 14, 1));
            employees.Add(new Employee("Big",     "Boss", 23, 14));
            employees.Add(new Employee("Solid",   "Snake", 18, 3));
            employees.Add(new Employee("Chris",   "Redfield", 44, 7));
            employees.Add(new Employee("Faye",    "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
