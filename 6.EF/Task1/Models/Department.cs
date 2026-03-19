

namespace Task1.Models
{
    public class Department
    {
        public int Id {get; set;}
        public string Name {get; set;} = null!;
        public string Building {get; set;} = null!;
        public decimal Budget {get; set;}

        public TeacherDepartment TeacherDepartment = null!;
    
        
    
    }
}