using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Task1.Models
{
    public class Student
    {
        [Key]
        public int StudentId {get; set;}

        [Required]
        public string FirstName {get; set;} = null!;
        [Required]
        public string LastName  {get; set;}= null!;

        [Required]
        public int Age {get; set;}
        [Required]
        public string Email {get; set;} = null!;

        // Set Default Value Current Time of Created Object
        public DateTime EnrollmentDate {get; set;} = DateTime.Now;

        // Forigen Keys
        public int DepartmentId {get; set;}
        public int TeacherId {get; set;}

        // Set Navigation Property
        public Department Department {get; set;} = null!;
        public Teacher Teacher  {get; set;}= null!;

    }
}