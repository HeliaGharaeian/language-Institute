using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace languageInstituteProject.Migrations
{
    public partial class changeClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassNumber",
                table: "classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassNumber",
                table: "classes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
