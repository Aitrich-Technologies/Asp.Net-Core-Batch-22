using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class Modelclassesupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeeker_SystemUser_SystemUserId1NavigationId",
                table: "JobSeeker");

            migrationBuilder.DropIndex(
                name: "IX_JobSeeker_SystemUserId1NavigationId",
                table: "JobSeeker");

            migrationBuilder.DropColumn(
                name: "SystemUserId1NavigationId",
                table: "JobSeeker");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "SystemUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "SystemUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "SystemUser",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AddColumn<Guid>(
                name: "JobPostId",
                table: "Skill",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "JobPost",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobSummary",
                table: "JobPost",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skill_JobPostId",
                table: "Skill",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSaved_JobPostId",
                table: "JobSaved",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSaved_JobSeekerProfileId",
                table: "JobSaved",
                column: "JobSeekerProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSaved_JobPost_JobPostId",
                table: "JobSaved",
                column: "JobPostId",
                principalTable: "JobPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSaved_JobSeekerProfile_JobSeekerProfileId",
                table: "JobSaved",
                column: "JobSeekerProfileId",
                principalTable: "JobSeekerProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_JobPost_JobPostId",
                table: "Skill",
                column: "JobPostId",
                principalTable: "JobPost",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSaved_JobPost_JobPostId",
                table: "JobSaved");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSaved_JobSeekerProfile_JobSeekerProfileId",
                table: "JobSaved");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_JobPost_JobPostId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Skill_JobPostId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_JobSaved_JobPostId",
                table: "JobSaved");

            migrationBuilder.DropIndex(
                name: "IX_JobSaved_JobSeekerProfileId",
                table: "JobSaved");

            migrationBuilder.DropColumn(
                name: "JobPostId",
                table: "Skill");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "SystemUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "SystemUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "SystemUser",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SystemUserId1NavigationId",
                table: "JobSeeker",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "JobPost",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "JobSummary",
                table: "JobPost",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
