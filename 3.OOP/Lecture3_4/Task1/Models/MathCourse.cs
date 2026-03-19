namespace Task1.Models
{
    internal class MathCourse : Course
    {
        public string Difficulty { get; set; } = null!; // e.g., Easy, Medium, Hard
        // public int Credits { get; set; }

        public MathCourse() : base()
        {
            Difficulty = "Unknown";
        }

        public MathCourse(string courseName, int hours, string difficulty) : base(courseName, hours)
        {
            Difficulty = difficulty;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"Course ID: {CourseId}, Name: {CourseName}, Hours: {Hours}, Difficulty: {Difficulty}");
        }

    }
}