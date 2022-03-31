using Microsoft.EntityFrameworkCore;
using EF_CodeFirst.Models;


namespace EF_CodeFirst.Database
{
    public class StudentContext : DbContext
    {

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentID = 78,
                    StudentName = "Marko Marić",
                    DateOfBirth = new DateTime(1995, 12, 31),
                    Height = 187.58m,
                    Weight = 83
                },
                new Student
                {
                    StudentID = 84,
                    StudentName = "Iva Ivić",
                    DateOfBirth = new DateTime(1996, 5, 23),
                    Height = 172.64m,
                    Weight = 75
                },
                new Student
                {
                    StudentID = 90,
                    StudentName = "Pero Perić",
                    DateOfBirth = new DateTime(1997, 3, 14),
                    Height = 179.43m,
                    Weight = 86
                },
                new Student
                {
                    StudentID = 112,
                    StudentName = "Ivana Perić",
                    DateOfBirth = new DateTime(1998, 5, 14),
                    Height = 168.8m,
                    Weight = 52,
                },
                new Student
                {
                    StudentID = 134,
                    StudentName = "Lovro Lovrić" ,
                    DateOfBirth = new DateTime(1998, 10, 28),
                    Height = 170.56m,
                    Weight = 64,
                },
                new Student
                {
                    StudentID = 146,
                    StudentName = "Ana Anić",
                    DateOfBirth = new DateTime(1999, 4, 7),
                    Height = 165.86m,
                    Weight = 62,
                },
                new Student
                {
                    StudentID = 153,
                    StudentName = "Ivan Ivanić",
                    DateOfBirth = new DateTime(2000, 12, 24),
                    Height = 169.78m,
                    Weight = 60,
                }
            );

            modelBuilder.Entity<Grade>().HasData(
                new Grade
                {
                    GradeId = 258,
                    StudentID = 153,
                    GradeName = "1. razred",
                    Section = "B"
                },
                new Grade
                {
                    GradeId = 358 ,
                    StudentID = 146,
                    GradeName = "2. razred",
                    Section = "G"
                },
                new Grade
                {
                    GradeId = 458,
                    StudentID = 134,
                    GradeName = "3. razred",
                    Section = "C"
                },
                new Grade
                {
                    GradeId = 558,
                    StudentID = 112,
                    GradeName = "4. razred",
                    Section = "F"
                },
                new Grade
                {
                     GradeId = 658,
                     StudentID = 90,
                     GradeName = "5. razred",
                     Section = "D"
                },
                new Grade
                {
                     GradeId = 758,
                     StudentID = 84,
                     GradeName = "6. razred",
                     Section = "B"
                },
                new Grade
                {
                     GradeId = 858,
                     StudentID = 78,
                     GradeName = "7. razred",
                     Section = "G"
                }
            );
        }
    }

}
