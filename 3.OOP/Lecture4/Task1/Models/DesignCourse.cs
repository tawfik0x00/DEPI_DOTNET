using System.Collections.Generic;
namespace Task1.Models
{
    internal class DesignCourse : Course
    {
        public List<string> Tools {get; set;} = null!;
        public string Specialization {get; set;} = null!;   

        // Set Constructors using chaining
        public DesignCourse() : base()
        {
            Tools = new List<string>();
            Specialization = "Unkown";
        }

        public DesignCourse(string courseName, int hours, List<string> tools, string specializaiton) 
        : base (courseName, hours)
        {
            Tools = tools;
            Specialization = specializaiton;
        }

         public override void DisplayInfo()
        {
            // Join all tools
            string toolsText = Tools.Count > 0 ? string.Join(", ", Tools) : "No tools";
            Console.WriteLine(
                $"[Design] Course ID: {CourseId}, Name: {CourseName}, Hours: {Hours}, Tools: {toolsText}, Specialization: {Specialization}");
        }

    }
}