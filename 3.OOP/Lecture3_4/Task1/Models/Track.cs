namespace Task1.Models
{
    internal class Track
    {
        private static int counter = 0;

        public int TrackId { get; }
        public string TrackName { get; set; }
        public int DurationInMonths { get; set; }

        private List<Course> courses;
        public int CourseCount => courses.Count;

        public Track()
        {
            TrackId = ++counter;
            TrackName = "Unknown Track";
            DurationInMonths = 0;
            courses = new List<Course>();
        }

        public Track(string trackName, int durationInMonths) : this()
        {
            TrackName = trackName;
            DurationInMonths = durationInMonths;
        }

        public Course this[int index]
        {
            get
            {
                if (index < 0 || index >= courses.Count)
                    throw new IndexOutOfRangeException("Invalid course index.");

                return courses[index];
            }
            set
            {
                if (index < 0 || index >= courses.Count)
                    throw new IndexOutOfRangeException("Invalid course index.");

                courses[index] = value;
            }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
                throw new ArgumentNullException(nameof(course));

            courses.Add(course);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Track ID: {TrackId}, Track Name: {TrackName}, Duration: {DurationInMonths} months");

            foreach (Course course in courses)
            {
                course.DisplayInfo();
            }
        }
    }
}