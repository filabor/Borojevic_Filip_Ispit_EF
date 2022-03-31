using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string GradeName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Section { get; set; }


        [ForeignKey("StudentID")]
        public Student Student { get; set; }
        public int StudentID { get; set; }

    }
}
