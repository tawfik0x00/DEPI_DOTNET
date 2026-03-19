namespace Task1.Models
{
    internal class ProgrammingCourse : Course
    {
        public string Language {get; set;} = null!;
        public string Level {get; set;} = null!; // Beginner, Intermediate, Advanced


        public ProgrammingCourse() : base()
        {
            Language = "Unkown";
            Level = "Unkown";
        }

        // Set Constructor that take all parameters
        public ProgrammingCourse(string courseName, int hours, string language, string level) 
        : base(courseName, hours)
        {
            Language = language;
            Level = level;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"[Programming] Course ID: {CourseId}, Name: {CourseName}, Hours: {Hours}, Language: {Language}, Level: {Level}");
        }
    }
}