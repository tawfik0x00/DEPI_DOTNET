namespace Task1.Models
{
    public class TeacherDepartment
    {
        public int TeacherId {get; set;}
        public int DepartmentId {get; set;}


        public List<Department> Departments = new List<Department>();
        public List<Teacher> Teachers = new List<Teacher>();
    }
}