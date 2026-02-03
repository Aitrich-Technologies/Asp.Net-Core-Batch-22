using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class Jobseekerupdatedinmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeeker_SystemUser_SystemUserId1",
                table: "JobSeeker");

            migrationBuilder.DropIndex(
                name: "IX_JobSeeker_SystemUserId1",
                table: "JobSeeker");

            migrationBuilder.RenameColumn(
                name: "SystemUserId1",
                table: "JobSeeker",
                newName: "SystemUserId1NavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeeker_SystemUserId1NavigationId",
                table: "JobSeeker",
                column: "SystemUserId1NavigationId",
                unique: true,
                filter: "[SystemUserId1NavigationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeeker_SystemUser_SystemUserId1NavigationId",
                table: "JobSeeker",
                column: "SystemUserId1NavigationId",
                principalTable: "SystemUser",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeeker_SystemUser_SystemUserId1NavigationId",
                table: "JobSeeker");

            migrationBuilder.DropIndex(
                name: "IX_JobSeeker_SystemUserId1NavigationId",
                table: "JobSeeker");

            migrationBuilder.RenameColumn(
                name: "SystemUserId1NavigationId",
                table: "JobSeeker",
                newName: "SystemUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeeker_SystemUserId1",
                table: "JobSeeker",
                column: "SystemUserId1",
                unique: true,
                filter: "([SystemUserId1] IS NOT NULL)");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeeker_SystemUser_SystemUserId1",
                table: "JobSeeker",
                column: "SystemUserId1",
                principalTable: "SystemUser",
                principalColumn: "Id");
        }
    }
}
