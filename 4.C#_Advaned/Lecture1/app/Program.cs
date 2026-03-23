using UserServices;

namespace app
{
    class Student: Person
    {
        public double Grade {get; set;}
    }

    class Teacher : Person
    {
        public string Subject {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create Teacher
            Teacher teacher = new Teacher
            {
                Id = 1,
                Name = "Ahmed",
                Age = 40,
                Email = "ahmed@test.com",
                Subject = "Math",
                Password = "123456"
            };

            // Check Teacher Password
            Console.WriteLine("=== Teacher ===");
            Console.WriteLine($"Name: {teacher.Name}");
            Console.WriteLine($"Password Correct? {teacher.VerifyPassword("123456")}");
            Console.WriteLine($"Password Correct? {teacher.VerifyPassword("wrong")}");

            Console.WriteLine();

            // Create Student
            Student student = new Student
            {
                Id = 2,
                Name = "Ali",
                Age = 20,
                Email = "ali@test.com",
                Grade = 90,
                Password = "pass123"
            };

            // Check Student Password
            Console.WriteLine("=== Student ===");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Password Correct? {student.VerifyPassword("pass123")}");
            Console.WriteLine($"Password Correct? {student.VerifyPassword("123")}");

            Console.WriteLine();

            Console.WriteLine("Program Finished...");
        }

    }
}