using System;
using Microsoft.EntityFrameworkCore;
using Task1.Models;
using Task1.Context;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            using (SchoolDbContext context = new SchoolDbContext())
            {
                context.Database.EnsureCreated();

                // Set Seed Data to the Database
                Seed(context);

                PerformCrudOperations(context);
            }
        }

        public static void Seed(SchoolDbContext context)
        {
            // Create some departments
            if (!context.Departments.Any())
            {
                List<Department> departments = new List<Department>()
                {
                    new Department() { Name = "Computer Science", Building = "Building A", Budget = 100000 },
                    new Department() { Name = "Mathematics", Building = "Building B", Budget = 80000 },
                    new Department() { Name = "Physics", Building = "Building C", Budget = 90000 },
                    new Department() { Name = "Chemistry", Building = "Building D", Budget = 95000 },
                    new Department() { Name = "Biology", Building = "Building E", Budget = 85000 },
                    new Department() { Name = "History", Building = "Building F", Budget = 70000 },
                    new Department() { Name = "Literature", Building = "Building G", Budget = 60000 },
                    new Department() { Name = "Philosophy", Building = "Building H", Budget = 50000 },
                    new Department() { Name = "Economics", Building = "Building I", Budget = 75000 },
                    new Department() { Name = "Psychology", Building = "Building J", Budget = 65000 }
                };
                context.Departments.AddRange(departments);
                context.SaveChanges();
            }

            // Create some teachers
            if (!context.Teachers.Any())
            {
                List<Teacher> teachers = new List<Teacher>()
                {
                    new Teacher() { FirstName = "John", LastName = "Doe", Email = "john.doe@school.com", OfficeNumber = "A101" },
                    new Teacher() { FirstName = "Jane", LastName = "Smith", Email = "jane.smith@school.com", OfficeNumber = "B202" },
                    new Teacher() { FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@school.com", OfficeNumber = "C303" },
                    new Teacher() { FirstName = "Alice", LastName = "Williams", Email = "alice.williams@school.com", OfficeNumber = "D404" },
                    new Teacher() { FirstName = "Charlie", LastName = "Brown", Email = "charlie.brown@school.com", OfficeNumber = "E505" }
                };
                context.Teachers.AddRange(teachers);
                context.SaveChanges();
            }

            // Create some students
            if (!context.Students.Any())
            {
                List<Student> students = new List<Student>()
                {
                    new Student() { FirstName = "Tom", LastName = "Miller", Age = 20, Email = "tom.miller@student.com", DepartmentId = 1, TeacherId = 1 },
                    new Student() { FirstName = "Sara", LastName = "Davis", Age = 21, Email = "sara.davis@student.com", DepartmentId = 2, TeacherId = 2 },
                    new Student() { FirstName = "Mike", LastName = "Wilson", Age = 19, Email = "mike.wilson@student.com", DepartmentId = 1, TeacherId = 1 },
                    new Student() { FirstName = "Emma", LastName = "Moore", Age = 22, Email = "emma.moore@student.com", DepartmentId = 3, TeacherId = 3 },
                    new Student() { FirstName = "David", LastName = "Taylor", Age = 20, Email = "david.taylor@student.com", DepartmentId = 2, TeacherId = 2 }
                };
                context.Students.AddRange(students);
                context.SaveChanges();
            }

            // Create teacher-department relationships
            if (!context.Set<TeacherDepartment>().Any())
            {
                List<TeacherDepartment> teacherDepartments = new List<TeacherDepartment>()
                {
                    new TeacherDepartment() { TeacherId = 1, DepartmentId = 1 },
                    new TeacherDepartment() { TeacherId = 2, DepartmentId = 2 },
                    new TeacherDepartment() { TeacherId = 3, DepartmentId = 3 },
                    new TeacherDepartment() { TeacherId = 4, DepartmentId = 4 },
                    new TeacherDepartment() { TeacherId = 5, DepartmentId = 5 }
                };
                context.Set<TeacherDepartment>().AddRange(teacherDepartments);
                context.SaveChanges();
            }
        }

        public static void PerformCrudOperations(SchoolDbContext context)
        {
            Console.WriteLine("Performing CRUD Operations...\n");

            // CREATE
            Console.WriteLine("--- CREATE ---");
            var newDepartment = new Department { Name = "New Department", Building = "New Building", Budget = 50000 };
            context.Departments.Add(newDepartment);
            context.SaveChanges();
            Console.WriteLine($"Created department: {newDepartment.Name}");

            var newTeacher = new Teacher { FirstName = "New", LastName = "Teacher", Email = "new.teacher@school.com", OfficeNumber = "N101" };
            context.Teachers.Add(newTeacher);
            context.SaveChanges();
            Console.WriteLine($"Created teacher: {newTeacher.FirstName} {newTeacher.LastName}");

            var newStudent = new Student { FirstName = "New", LastName = "Student", Age = 18, Email = "new.student@student.com", DepartmentId = 1, TeacherId = 1 };
            context.Students.Add(newStudent);
            context.SaveChanges();
            Console.WriteLine($"Created student: {newStudent.FirstName} {newStudent.LastName}");

            // READ
            Console.WriteLine("\n--- READ ---");
            var departments = context.Departments.ToList();
            Console.WriteLine($"Total departments: {departments.Count}");
            foreach (var dept in departments.Take(3))
            {
                Console.WriteLine($"Department: {dept.Name}, Building: {dept.Building}, Budget: {dept.Budget}");
            }

            var teachers = context.Teachers.ToList();
            Console.WriteLine($"Total teachers: {teachers.Count}");
            foreach (var teacher in teachers.Take(3))
            {
                Console.WriteLine($"Teacher: {teacher.FirstName} {teacher.LastName}, Email: {teacher.Email}");
            }

            var students = context.Students.Include(s => s.Department).Include(s => s.Teacher).ToList();
            Console.WriteLine($"Total students: {students.Count}");
            foreach (var student in students.Take(3))
            {
                Console.WriteLine($"Student: {student.FirstName} {student.LastName}, Department: {student.Department.Name}, Teacher: {student.Teacher.FirstName} {student.Teacher.LastName}");
            }

            // UPDATE
            Console.WriteLine("\n--- UPDATE ---");
            var deptToUpdate = context.Departments.FirstOrDefault(d => d.Name == "New Department");
            if (deptToUpdate != null)
            {
                deptToUpdate.Budget = 60000;
                context.SaveChanges();
                Console.WriteLine($"Updated department budget to: {deptToUpdate.Budget}");
            }

            var teacherToUpdate = context.Teachers.FirstOrDefault(t => t.FirstName == "New");
            if (teacherToUpdate != null)
            {
                teacherToUpdate.OfficeNumber = "N102";
                context.SaveChanges();
                Console.WriteLine($"Updated teacher office to: {teacherToUpdate.OfficeNumber}");
            }

            var studentToUpdate = context.Students.FirstOrDefault(s => s.FirstName == "New");
            if (studentToUpdate != null)
            {
                studentToUpdate.Age = 19;
                context.SaveChanges();
                Console.WriteLine($"Updated student age to: {studentToUpdate.Age}");
            }

            // DELETE
            Console.WriteLine("\n--- DELETE ---");
            var deptToDelete = context.Departments.FirstOrDefault(d => d.Name == "New Department");
            if (deptToDelete != null)
            {
                context.Departments.Remove(deptToDelete);
                context.SaveChanges();
                Console.WriteLine("Deleted department: New Department");
            }

            var teacherToDelete = context.Teachers.FirstOrDefault(t => t.FirstName == "New");
            if (teacherToDelete != null)
            {
                context.Teachers.Remove(teacherToDelete);
                context.SaveChanges();
                Console.WriteLine("Deleted teacher: New Teacher");
            }

            var studentToDelete = context.Students.FirstOrDefault(s => s.FirstName == "New");
            if (studentToDelete != null)
            {
                context.Students.Remove(studentToDelete);
                context.SaveChanges();
                Console.WriteLine("Deleted student: New Student");
            }

            Console.WriteLine("\nCRUD Operations completed.");
        }
    }
}