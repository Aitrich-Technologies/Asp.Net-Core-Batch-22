using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class PRofileQualificationadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_JobSeekerProfile",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_Qualification_JobPostId",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "JobPostId",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "JobseekerProfileId",
                table: "Qualification");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "JobPostId",
                table: "Qualification",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "JobseekerProfileId",
                table: "Qualification",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_JobPostId",
                table: "Qualification",
                column: "JobPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_JobSeekerProfile",
                table: "Qualification",
                column: "JobPostId",
                principalTable: "JobPost",
                principalColumn: "Id");
        }
    }
}
