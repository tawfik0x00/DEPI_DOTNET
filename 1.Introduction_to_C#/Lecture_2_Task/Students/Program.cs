using System;

namespace Students
{
    class Students
    {
        public string Name;
        public int[] Grades = new int[4];

        public int Total = new int();
    }
    class Program
    {
        public static int Main()
        {
            // First take input in secure way limit user input to 0 through 100 only
            int size = 0;
            while (true)
            {
                Console.Write("Enter the Number of Students: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out size) && size > 0 && size <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid number between 1 and 100.");
                }
                
            }
            // Define a data structure to define the name and four grad
            Students[] students = new Students[size];

            for (int i = 0; i < size; i++)
            {
                students[i] = new Students();

                // Take the name
                while (true)
                {
                    Console.Write($"\nEnter name of the student {i + 1}: ");
                    string input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input))
                    {
                        students[i].Name = input;
                        break;
                    }
                }

                // for each student take 4 grades.
                Console.WriteLine($"\nEnter 4 Grades for {students[i].Name}:");
                for (int j = 0; j < 4; j++)
                {
                    // check for each grade is is valid or not
                    while (true)
                    {
                        Console.Write($"Grade {j + 1}: ");
                        string gradeInput = Console.ReadLine();
                        if (int.TryParse(gradeInput, out int grade) && grade >= 0 && grade <= 100)
                        {
                            students[i].Grades[j] = grade;
                            students[i].Total += grade;
                            break;
                        }

                        // Else Invalid grade
                        Console.WriteLine("Error: Enter invalid grade between 0 and 100");
                    }
                }
                Console.WriteLine($"\nTotal Grades of {students[i].Name}: {students[i].Total}");
                Console.WriteLine("-------------------------------------");
            }

            // Complete here to print the GPA.

            return 0;
        }
    }
}