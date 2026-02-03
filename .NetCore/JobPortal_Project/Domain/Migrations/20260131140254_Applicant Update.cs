using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class ApplicantUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplication_JobSeekerProfile_JobSeekerProfileId",
                table: "JobApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeeker_SystemUser_SystemUserId",
                table: "JobSeeker");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfile_JobSeekerImage_JobSeekerImageId",
                table: "JobSeekerProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfile_JobSeeker_JobSeekerId",
                table: "JobSeekerProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfile_Resume_ResumeId",
                table: "JobSeekerProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_JobPost_JobPostId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Skill_JobPostId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerProfile_JobSeekerImageId",
                table: "JobSeekerProfile");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerProfile_ResumeId",
                table: "JobSeekerProfile");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerProfile_ResumeId1",
                table: "JobSeekerProfile");

            migrationBuilder.DropColumn(
                name: "JobPostId",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "JobSeekerImageId",
                table: "JobSeekerProfile");

            migrationBuilder.RenameIndex(
                name: "IX_JobSeekerImage_JobSeekerProfileId",
                table: "JobSeekerImage",
                newName: "IX_JobSeekerImage_JobSeekerProfileId1");

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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Skill",
                type: "varchar(500)",
                unicode: false,
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldUnicode: false,
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "SignUpRequest",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newid())");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Qualification",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Qualification",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobResponsibility",
                type: "nchar(200)",
                fixedLength: true,
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "JobResponsibility",
                type: "nchar(500)",
                fixedLength: true,
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "JobPost",
                type: "nchar(100)",
                fixedLength: true,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "JobSummary",
                table: "JobPost",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "Applicant",
                table: "JobApplication",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Resume_id",
                table: "JobApplication",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Interviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    interviewee = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SheduledBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interviews_CompanyUser_SheduledBy",
                        column: x => x.SheduledBy,
                        principalTable: "CompanyUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Interviews_JobApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "JobApplication",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Interviews_JobPost_JobId",
                        column: x => x.JobId,
                        principalTable: "JobPost",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Interviews_JobProviderCompany_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "JobProviderCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_JobSeeker_interviewee",
                        column: x => x.interviewee,
                        principalTable: "JobSeeker",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobPostQualifications",
                columns: table => new
                {
                    JobPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QualificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostQualifications", x => new { x.JobPostId, x.QualificationId });
                    table.ForeignKey(
                        name: "FK_JobPostQualifications_JobPost_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPostQualifications_Qualification_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPostSkills",
                columns: table => new
                {
                    JobPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostSkills", x => new { x.JobPostId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_JobPostSkills_JobPost_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPostSkills_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resume_JobSeekerProfileId",
                table: "Resume",
                column: "JobSeekerProfileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerImage_JobSeekerProfileId",
                table: "JobSeekerImage",
                column: "JobSeekerProfileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobApplication_Applicant",
                table: "JobApplication",
                column: "Applicant");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplication_ResumeId",
                table: "JobApplication",
                column: "Resume_id");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_ApplicationId",
                table: "Interviews",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_CompanyId",
                table: "Interviews",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_interviewee",
                table: "Interviews",
                column: "interviewee");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_JobId",
                table: "Interviews",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_SheduledBy",
                table: "Interviews",
                column: "SheduledBy");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostQualifications_QualificationId",
                table: "JobPostQualifications",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostSkills_SkillId",
                table: "JobPostSkills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplication_JobSeekerProfile_JobSeekerProfileId",
                table: "JobApplication",
                column: "JobSeekerProfileId",
                principalTable: "JobSeekerProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplication_JobSeeker_Applicant",
                table: "JobApplication",
                column: "Applicant",
                principalTable: "JobSeeker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplication_Resume_Resume_id",
                table: "JobApplication",
                column: "Resume_id",
                principalTable: "Resume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeeker_SystemUser_SystemUserId",
                table: "JobSeeker",
                column: "SystemUserId",
                principalTable: "SystemUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resume_JobSeekerProfile_JobSeekerProfileId",
                table: "Resume",
                column: "JobSeekerProfileId",
                principalTable: "JobSeekerProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplication_JobSeekerProfile_JobSeekerProfileId",
                table: "JobApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplication_JobSeeker_Applicant",
                table: "JobApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplication_Resume_Resume_id",
                table: "JobApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeeker_SystemUser_SystemUserId",
                table: "JobSeeker");

            migrationBuilder.DropForeignKey(
                name: "FK_Resume_JobSeekerProfile_JobSeekerProfileId",
                table: "Resume");

            migrationBuilder.DropTable(
                name: "Interviews");

            migrationBuilder.DropTable(
                name: "JobPostQualifications");

            migrationBuilder.DropTable(
                name: "JobPostSkills");

            migrationBuilder.DropIndex(
                name: "IX_Resume_JobSeekerProfileId",
                table: "Resume");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerImage_JobSeekerProfileId",
                table: "JobSeekerImage");

            migrationBuilder.DropIndex(
                name: "IX_JobApplication_Applicant",
                table: "JobApplication");

            migrationBuilder.DropIndex(
                name: "IX_JobApplication_ResumeId",
                table: "JobApplication");

            migrationBuilder.DropColumn(
                name: "Applicant",
                table: "JobApplication");

            migrationBuilder.DropColumn(
                name: "Resume_id",
                table: "JobApplication");

            migrationBuilder.RenameIndex(
                name: "IX_JobSeekerImage_JobSeekerProfileId1",
                table: "JobSeekerImage",
                newName: "IX_JobSeekerImage_JobSeekerProfileId");

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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Skill",
                type: "varchar(250)",
                unicode: false,
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldUnicode: false,
                oldMaxLength: 500);

            migrationBuilder.AddColumn<Guid>(
                name: "JobPostId",
                table: "Skill",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "SignUpRequest",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Qualification",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Qualification",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<Guid>(
                name: "JobSeekerImageId",
                table: "JobSeekerProfile",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobResponsibility",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(200)",
                oldFixedLength: true,
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "JobResponsibility",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(500)",
                oldFixedLength: true,
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "JobPost",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(100)",
                oldFixedLength: true,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "JobSummary",
                table: "JobPost",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Skill_JobPostId",
                table: "Skill",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfile_JobSeekerImageId",
                table: "JobSeekerProfile",
                column: "JobSeekerImageId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfile_ResumeId",
                table: "JobSeekerProfile",
                column: "ResumeId",
                unique: true,
                filter: "([ResumeId] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfile_ResumeId1",
                table: "JobSeekerProfile",
                column: "ResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplication_JobSeekerProfile_JobSeekerProfileId",
                table: "JobApplication",
                column: "JobSeekerProfileId",
                principalTable: "JobSeekerProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeeker_SystemUser_SystemUserId",
                table: "JobSeeker",
                column: "SystemUserId",
                principalTable: "SystemUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerProfile_JobSeekerImage_JobSeekerImageId",
                table: "JobSeekerProfile",
                column: "JobSeekerImageId",
                principalTable: "JobSeekerImage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerProfile_JobSeeker_JobSeekerId",
                table: "JobSeekerProfile",
                column: "JobSeekerId",
                principalTable: "JobSeeker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerProfile_Resume_ResumeId",
                table: "JobSeekerProfile",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_JobPost_JobPostId",
                table: "Skill",
                column: "JobPostId",
                principalTable: "JobPost",
                principalColumn: "Id");
        }
    }
}
