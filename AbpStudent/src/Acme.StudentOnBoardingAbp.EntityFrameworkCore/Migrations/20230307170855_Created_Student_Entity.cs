using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.StudentOnBoardingAbp.Migrations
{
    /// <inheritdoc />
    public partial class CreatedStudentEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appstudents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenerateUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SMobileNo = table.Column<int>(type: "int", nullable: false),
                    ABCID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FMobile = table.Column<int>(type: "int", nullable: false),
                    FEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MMobile = table.Column<int>(type: "int", nullable: false),
                    MEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    Cluster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appstudents", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appstudents");
        }
    }
}
