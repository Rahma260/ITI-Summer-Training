using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace program.Migrations
{
    /// <inheritdoc />
    public partial class done : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeePhone",
                table: "employees",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyStartDate",
                table: "companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "09/24/2018 11:39:19",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "09/20/2018 18:31:09");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeePhone",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyStartDate",
                table: "companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "09/20/2018 18:31:09",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "09/24/2018 11:39:19");
        }
    }
}
