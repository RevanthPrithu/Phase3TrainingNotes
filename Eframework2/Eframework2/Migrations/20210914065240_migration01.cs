using Microsoft.EntityFrameworkCore.Migrations;

namespace Eframework2.Migrations
{
    public partial class migration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Course = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Fee = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "tblStudents",
                columns: new[] { "Id", "Course", "Fee", "SName" },
                values: new object[] { 1001, "Trainer", 3000f, "Kiran" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblStudents");
        }
    }
}
