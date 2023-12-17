using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_Form.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Course = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Course);
                });

            migrationBuilder.CreateTable(
                name: "Studentcourses",
                columns: table => new
                {
                    StudentsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    coursesCourse = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentcourses", x => new { x.StudentsId, x.coursesCourse });
                    table.ForeignKey(
                        name: "FK_Studentcourses_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Studentcourses_courses_coursesCourse",
                        column: x => x.coursesCourse,
                        principalTable: "courses",
                        principalColumn: "Course",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studentcourses_coursesCourse",
                table: "Studentcourses",
                column: "coursesCourse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studentcourses");

            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}
