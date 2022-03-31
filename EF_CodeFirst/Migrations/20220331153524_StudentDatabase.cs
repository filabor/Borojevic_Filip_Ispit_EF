using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CodeFirst.Migrations
{
    public partial class StudentDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "Date", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeId);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[,]
                {
                    { 78, new DateTime(1995, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 187.58m, "Marko Marić", 83f },
                    { 84, new DateTime(1996, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 172.64m, "Iva Ivić", 75f },
                    { 90, new DateTime(1997, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 179.43m, "Pero Perić", 86f },
                    { 112, new DateTime(1998, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 168.8m, "Ivana Perić", 52f },
                    { 134, new DateTime(1998, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 170.56m, "Lovro Lovrić", 64f },
                    { 146, new DateTime(1999, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 165.86m, "Ana Anić", 62f },
                    { 153, new DateTime(2000, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 169.78m, "Ivan Ivanić", 60f }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeId", "GradeName", "Section", "StudentID" },
                values: new object[,]
                {
                    { 258, "1. razred", "B", 153 },
                    { 358, "2. razred", "G", 146 },
                    { 458, "3. razred", "C", 134 },
                    { 558, "4. razred", "F", 112 },
                    { 658, "5. razred", "D", 90 },
                    { 758, "6. razred", "B", 84 },
                    { 858, "7. razred", "G", 78 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentID",
                table: "Grades",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
