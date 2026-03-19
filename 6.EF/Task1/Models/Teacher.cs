

namespace Task1.Models
{
    public class Teacher
    {
        public int TeacherId {get; set;}
        public string FirstName {get; set;} = null!;
        public string LastName {get; set;} = null!;
        public string Email {get; set;} = null!;
        public DateTime HireDate {get; set;} = DateTime.Now;
        public string OfficeNumber {get; set;} = null!;
        
    
        // Navigation Property
        public TeacherDepartment TeacherDepartment = null!;
    

    }
}