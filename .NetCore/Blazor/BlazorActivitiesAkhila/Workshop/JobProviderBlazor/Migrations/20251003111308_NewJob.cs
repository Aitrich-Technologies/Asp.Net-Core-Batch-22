using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobProviderBlazor.Migrations
{
    /// <inheritdoc />
    public partial class NewJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Loction",
                table: "Jobs",
                newName: "Location");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Jobs",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Jobs",
                newName: "Loction");

            migrationBuilder.AlterColumn<long>(
                name: "Salary",
                table: "Jobs",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
