namespace Task1.Models
{
    internal class Course
    {
        private static int counter = 0;

        public int CourseId { get; }
        public string CourseName { get; set; }
        public int Hours { get; set; }

        public Course()
        {
            CourseId = ++counter;
            CourseName = "Unknown Course";
            Hours = 0;
        }

        public Course(string courseName) : this()
        {
            CourseName = courseName;
        }

        public Course(string courseName, int hours) : this(courseName)
        {
            Hours = hours;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Course ID: {CourseId}, Name: {CourseName}, Hours: {Hours}");
        }
    }
}