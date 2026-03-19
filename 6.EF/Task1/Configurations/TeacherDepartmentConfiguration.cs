using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task1.Models;

namespace Task1.Configurations
{
    public class TeacherDepartmentConfiguration: IEntityTypeConfiguration<TeacherDepartment>
    {
        public void Configure (EntityTypeBuilder<TeacherDepartment> builder)
        {
            builder.HasKey(td => new {td.DepartmentId, td.TeacherId});
        }
    }
}