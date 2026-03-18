/*
Task 02
A company wants to build a simple Employee Management System to manage its employees
Create a class named Employee contains Id,FullName,salary,Department
in a main method create array of Employees
*/

using System;

namespace Mangage
{
    class Employee
    {
        public int Id { set; get; }
        public string FullName { set; get; }

        public float Salary { set; get; }

        public string Department { set; get; }

        // Create some Constructors
        public Employee()
        {
            Id = 0;
            FullName = "Default Name";
            Salary = 0;
            Department = "Not Set";
        }
        public Employee(int _id)
        {
            Id = _id;
        }

        public Employee(int _id, string _fullName)
        {
            Id = _id;
            FullName = _fullName;
        }

        public Employee(int _id, string _fullName, float _salary)
        {
            Id = _id;
            FullName = _fullName;
            Salary = _salary;
        }


        public Employee(int _id, string _fullName, float _salary, string _department)
        {
            Id = _id;
            FullName = _fullName;
            Salary = _salary;
            Department = _department;
        }

        // Create a Method to Display infor for each Employee
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Id: {Id} Name: {FullName}    Salary :{Salary}  Department:{Department}");
        }


   
    }
    class Program
    {
        public static void Main()
        {
            const int size = 5;
            
            // Create an array of employees
            Employee[] emps = new Employee[size];

            Console.WriteLine("\nWelcome to Emplyee Record Panel!\n");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter Data for Employee -> {i + 1}");

                emps[i] = new Employee();
                // Read Id
                Console.Write($"Id: ");
                emps[i].Id = int.Parse(Console.ReadLine());

                Console.Write($"Full Name: ");
                emps[i].FullName = Console.ReadLine();

                Console.Write($"Salary: ");
                emps[i].Salary = float.Parse(Console.ReadLine());

                Console.Write($"Department: ");
                emps[i].Department = Console.ReadLine();

                // take a new line
                Console.WriteLine();

            }


            foreach (Employee emp in emps)
            {
                emp.DisplayInfo();
            }


        }

    }
}