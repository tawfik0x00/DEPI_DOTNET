using System;
using System.Collections.Generic;
using Task1.Models;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a track
            Track webTrack = new Track("Full Stack .NET", 9);

            // Create courses
            ProgrammingCourse c1 = new ProgrammingCourse("C#", 40, "C#", "Beginner");
            ProgrammingCourse c2 = new ProgrammingCourse("ASP.NET MVC", 45, "C#", "Intermediate");
            MathCourse c3 = new MathCourse("Discrete Math", 30, "Medium");
            DesignCourse c4 = new DesignCourse(
                "UI Design",
                25,
                new List<string> { "Figma", "Photoshop" },
                "UI/UX"
            );

            // Add courses to track
            webTrack.AddCourse(c1);
            webTrack.AddCourse(c2);
            webTrack.AddCourse(c3);
            webTrack.AddCourse(c4);

            Console.WriteLine("=== Display Track Info ===");
            webTrack.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("=== Access course using indexer ===");
            webTrack[1].DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("=== Replace a course using indexer ===");
            webTrack[2] = new MathCourse("Linear Algebra", 35, "Hard");
            webTrack[2].DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("=== Display all track info after replacement ===");
            webTrack.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("=== Test polymorphism ===");
            Course[] testCourses = new Course[]
            {
                new ProgrammingCourse("Python", 20, "Python", "Beginner"),
                new MathCourse("Statistics", 18, "Easy"),
                new DesignCourse("Graphic Design", 22, new List<string> { "Illustrator", "Canva" }, "Branding")
            };

            foreach (Course course in testCourses)
            {
                course.DisplayInfo();
            }

            Console.WriteLine();
            Console.WriteLine("=== Test invalid index ===");
            try
            {
                webTrack[10].DisplayInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}