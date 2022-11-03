using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NGUYENVANHUUBTH2.Migrations
{
    public partial class Create_Employee_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "Person",
                newName: "namsinh");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    Number = table.Column<string>(type: "TEXT", nullable: true),
                    Office = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.RenameColumn(
                name: "namsinh",
                table: "Person",
                newName: "Birthday");
        }
    }
}
