namespace Task1_LINQ
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Location { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Id- {this.Id}  FirstName- {this.FirstName} LastName- {this.LastName} Age- {this.Age} Location- " +
                   $"{this.Location}";
            
        }
    }
    class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, FirstName = "Ali",    LastName = "Hassan",  Age = 19, Location = "Cairo" },
                new Student { Id = 2, FirstName = "Mona",   LastName = "Fathy",   Age = 21, Location = "Alex" },
                new Student { Id = 3, FirstName = "Youssef",LastName = "Omar",    Age = 22, Location = "Cairo" },
                new Student { Id = 4, FirstName = "Sara",   LastName = "Mostafa", Age = 18, Location = "Giza" },
                new Student { Id = 5, FirstName = "Khaled", LastName = "Adel",    Age = 23, Location = "Mansoura" },
                new Student { Id = 6, FirstName = "Nada",   LastName = "Hany",    Age = 20, Location = "Cairo" },
                new Student { Id = 7, FirstName = "Omar",   LastName = "Hussein", Age = 24, Location = "Alex" },
            };

            // 1. Filter students aged above 20
            Console.WriteLine("Students Above 20 years.");
            var result = students.Where(s => s.Age > 20);
            foreach(var s in result)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("------------------------");

            
            // 2. Find the first student from Cairo
            var  CairoStudent = students.First(s => s.Location == "Cairo");
            Console.WriteLine(CairoStudent);
            Console.WriteLine("------------------------");

            // 3. Get total age of all students
            var TotalAge = students.Sum(s => s.Age);
            Console.WriteLine("Total Age is: " + TotalAge);
            Console.WriteLine("------------------------");

            // 4. Return students sorted by Age, then by FirstName
            Console.WriteLine("Sorted Students by Age then By FirstName");
            var SortedAgeFirstName = students.OrderBy(s => s.Age).ThenBy(s => s.FirstName);
            foreach(var s in SortedAgeFirstName)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("------------------------");

            // 5. Project only Id and FirstName into a new anonymous object
            Console.WriteLine("Only Id With Frist Name using Projection.");
            var IdFirstName = students.Select(sn => new {sID = sn.Id, sFirstName=sn.FirstName});
            foreach (var item in IdFirstName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            
            // 6. Check if any student is from Alex
            bool isFromAlex = students.Any(s => s.Location == "Alex");
            if (isFromAlex)
                Console.WriteLine("Yes we have Students from Alex");
            Console.WriteLine("------------------------");

            // 7. Check if all students are aged 18 or above
            bool isAllStudentsAge18 = students.All(s => s.Age >= 18);
            if (isAllStudentsAge18)
                Console.WriteLine("Yes all Students meet the age condition");
            Console.WriteLine("------------------------");

            // 8. Get student with Id == 5 using Single
            var Id5 = students.SingleOrDefault(s => s.Id == 5);
            Console.WriteLine("------------------------");

            // 9. Get distinct Locations from the student list
            Console.WriteLine("Distinct Locations");
            var DistinctLocations = students.DistinctBy(s => s.Location).Select(s => s.Location);
            foreach(var Location in DistinctLocations)
            {
                Console.WriteLine(Location);
            }
            Console.WriteLine("------------------------");
            
            // 10. Convert students list into a Dictionary with key = Id
            var studentDict = students.ToDictionary(s => s.Id, s => s);
            foreach (var student in studentDict)
            {
                Console.WriteLine($"{student.Key} - {student.Value.FirstName}");
            }
            // 11. Group students by Location and print FirstNames
            var StudentsBasedOnLocation = students.GroupBy(s => s.Location);
            foreach (var group in StudentsBasedOnLocation)
            {
                Console.WriteLine($"Students in: {group.Key}");
                foreach (var student in group)
                {
                    Console.Write(student.FirstName + ", ");
                }
                Console.WriteLine();
            }
            // 13. Find student(s) with the maximum age
            var MaxAge = students.Max(s => s.Age);
            var MaxAgeStudents = students.Where(s => s.Age == MaxAge);
            foreach (var student in MaxAgeStudents)
            {
                Console.WriteLine(student);
            }
            // 14. Count how many students are in each Location
            var Locations = students.GroupBy(s => s.Location);
            foreach (var group in Locations)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
            }
            
        }
    }
}
