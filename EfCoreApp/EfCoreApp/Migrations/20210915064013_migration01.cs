using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreApp.Migrations
{
    public partial class migration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Job = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "tblEmployees",
                columns: new[] { "Id", "EName", "Job", "Salary" },
                values: new object[] { 1001, "Shivani", "Manager", 10000.0 });

            migrationBuilder.InsertData(
                table: "tblEmployees",
                columns: new[] { "Id", "EName", "Job", "Salary" },
                values: new object[] { 1002, "Yuvaraj", "Developer", 9000.0 });

            migrationBuilder.InsertData(
                table: "tblEmployees",
                columns: new[] { "Id", "EName", "Job", "Salary" },
                values: new object[] { 1003, "Kiran", "Trainer", 85000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEmployees");
        }
    }
}
