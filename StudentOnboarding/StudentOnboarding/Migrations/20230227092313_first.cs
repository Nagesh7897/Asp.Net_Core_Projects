using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentOnboarding.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    GenerateUID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SFirstName = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    SLastName = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    SEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SMobileNo = table.Column<int>(type: "int", nullable: false),
                    ABCID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FMobile = table.Column<int>(type: "int", nullable: false),
                    FEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MMobile = table.Column<int>(type: "int", nullable: false),
                    MEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    Cluster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Other1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Other2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Other3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Other4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Other5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Other6 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.GenerateUID);
                });

            migrationBuilder.CreateTable(
                name: "StdEducations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Education = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    SchoolorCollege = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    StudentDetailsGenerateUID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StdEducations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StdEducations_Students_StudentDetailsGenerateUID",
                        column: x => x.StudentDetailsGenerateUID,
                        principalTable: "Students",
                        principalColumn: "GenerateUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StdEducations_StudentDetailsGenerateUID",
                table: "StdEducations",
                column: "StudentDetailsGenerateUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StdEducations");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
