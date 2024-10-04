using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDay1.Migrations
{
    /// <inheritdoc />
    public partial class buildDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentDescription",
                table: "Departments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentDescription",
                table: "Departments");
        }
    }
}
