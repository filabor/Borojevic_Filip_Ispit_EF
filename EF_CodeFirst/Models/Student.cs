using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string StudentName { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Height { get; set; }

        public float? Weight { get; set; }

    }
}
