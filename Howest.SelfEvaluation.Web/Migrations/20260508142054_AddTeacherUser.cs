using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Howest.SelfEvaluation.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddTeacherUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("45ca2157-3005-4472-9402-c7f3c66f8d10"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("82c92cc2-3ed1-4872-8155-39fdc8da4c90"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("df9f3750-0087-45b4-abcd-af83dadbee0d"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("f3b02013-43e6-4966-a661-233b75593184"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("01d85b9d-9931-40ab-b109-6ae889fd1ef3"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("08b81529-9318-4234-b163-2d60feaa3f99"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("45ca2157-3005-4472-9402-c7f3c66f8d10"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("82c92cc2-3ed1-4872-8155-39fdc8da4c90"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("df9f3750-0087-45b4-abcd-af83dadbee0d"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3b02013-43e6-4966-a661-233b75593184"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AssignedMentorId", "Created", "Deleted", "Firstname", "Lastname", "Role", "Updated", "Username" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000004"), null, new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(277), null, "TestTeacherFirstname", "TestTeacherLastname", "Teacher", null, "teacher@teacher.com" },
                    { new Guid("607fc771-dd27-4df8-8bde-c092bf4a07b2"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(340), null, "Seraphina", "Sterling", "Student", null, "seraphina.sterling@test.com" },
                    { new Guid("667bcbcd-3d77-4929-aba3-b984e49c2e68"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(314), null, "Julian", "Thorne", "Student", null, "julian.thorne@test.com" },
                    { new Guid("b7b82198-e824-4e7a-a020-d66c0a292b85"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(348), null, "Lyra", "Belrose", "Student", null, "lyra.belrose@test.com" },
                    { new Guid("c1745a9b-8451-422d-b291-b2fc82968786"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(344), null, "Kaelen", "Voss", "Student", null, "kaelen.voss@test.com" },
                    { new Guid("cb26949e-7c29-44f3-8d5e-0dec0ab54f51"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(332), null, "Elara", "Vance", "Student", null, "elara.vance@test.com" },
                    { new Guid("f26f0a5d-66d6-4628-bc94-263c52ed38e2"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(336), null, "Cassian", "Cole", "Student", null, "cassian.cole@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000006"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000007"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000008"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000009"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee11"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee12"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee13"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee14"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee15"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee16"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee17"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee18"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee19"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee1e"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee21"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee22"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee23"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee24"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee25"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee26"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee27"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee28"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee2e"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa111"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa112"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa113"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa114"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa115"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa116"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa117"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa118"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa119"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa11a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa121"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa122"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa123"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa124"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa125"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa126"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa127"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa128"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa129"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa12a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa131"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa132"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa133"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa134"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa135"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa136"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa137"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa138"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa139"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa13a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa141"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa142"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa143"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa144"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa145"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa146"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa147"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa148"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa149"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa14a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa151"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa152"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa153"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa154"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa155"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa156"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa157"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa158"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa159"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa15a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa161"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa16a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 916, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a1"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a2"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a3"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a4"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a5"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a6"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a7"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a8"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a9"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1aa"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa29"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa31"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa32"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa33"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa34"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa35"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa36"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa37"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa38"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa39"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa3a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa41"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa42"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa43"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa44"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa45"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa46"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa47"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa48"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa49"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa4a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa51"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa52"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa53"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa54"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa55"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa56"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa57"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa58"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa59"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa5a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa61"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa62"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa63"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa64"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa65"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa66"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa67"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa68"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa69"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa6a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa71"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa72"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa73"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa74"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa75"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa76"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa77"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa78"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa79"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa7a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa81"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa82"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa83"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa84"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa85"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa86"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa87"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa88"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa89"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa8a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa91"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa92"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa93"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa94"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa95"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa96"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa97"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa98"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa99"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa9a"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2026, 5, 8, 16, 20, 52, 915, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.InsertData(
                table: "ApplicationUserModule",
                columns: new[] { "ApplicationUsersId", "ModulesId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("607fc771-dd27-4df8-8bde-c092bf4a07b2"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("cb26949e-7c29-44f3-8d5e-0dec0ab54f51"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("f26f0a5d-66d6-4628-bc94-263c52ed38e2"), new Guid("00000000-0000-0000-0000-000000000003") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("607fc771-dd27-4df8-8bde-c092bf4a07b2"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("cb26949e-7c29-44f3-8d5e-0dec0ab54f51"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("f26f0a5d-66d6-4628-bc94-263c52ed38e2"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("667bcbcd-3d77-4929-aba3-b984e49c2e68"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7b82198-e824-4e7a-a020-d66c0a292b85"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("c1745a9b-8451-422d-b291-b2fc82968786"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("607fc771-dd27-4df8-8bde-c092bf4a07b2"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb26949e-7c29-44f3-8d5e-0dec0ab54f51"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("f26f0a5d-66d6-4628-bc94-263c52ed38e2"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AssignedMentorId", "Created", "Deleted", "Firstname", "Lastname", "Role", "Updated", "Username" },
                values: new object[,]
                {
                    { new Guid("01d85b9d-9931-40ab-b109-6ae889fd1ef3"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1640), null, "Lyra", "Belrose", "Student", null, "lyra.belrose@test.com" },
                    { new Guid("08b81529-9318-4234-b163-2d60feaa3f99"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1626), null, "Elara", "Vance", "Student", null, "elara.vance@test.com" },
                    { new Guid("45ca2157-3005-4472-9402-c7f3c66f8d10"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1637), null, "Kaelen", "Voss", "Student", null, "kaelen.voss@test.com" },
                    { new Guid("82c92cc2-3ed1-4872-8155-39fdc8da4c90"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1634), null, "Seraphina", "Sterling", "Student", null, "seraphina.sterling@test.com" },
                    { new Guid("df9f3750-0087-45b4-abcd-af83dadbee0d"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1621), null, "Julian", "Thorne", "Student", null, "julian.thorne@test.com" },
                    { new Guid("f3b02013-43e6-4966-a661-233b75593184"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1631), null, "Cassian", "Cole", "Student", null, "cassian.cole@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000006"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000007"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000008"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000009"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee11"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee12"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee13"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee14"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee15"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee16"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee17"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee18"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee19"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee1e"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee21"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee22"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee23"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee24"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee25"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee26"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee27"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee28"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee2e"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa111"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa112"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa113"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa114"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa115"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa116"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa117"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa118"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa119"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa11a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa121"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa122"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa123"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa124"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa125"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa126"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa127"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa128"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa129"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa12a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa131"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa132"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa133"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa134"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa135"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa136"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa137"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa138"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa139"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa13a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa141"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa142"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa143"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa144"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa145"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa146"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa147"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa148"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa149"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa14a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa151"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa152"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa153"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa154"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa155"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa156"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa157"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa158"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa159"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa15a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa161"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa16a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a1"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a2"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a3"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a4"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a5"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a6"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a7"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a8"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a9"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1aa"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa29"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa31"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa32"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa33"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa34"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa35"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa36"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa37"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa38"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa39"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa3a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa41"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa42"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa43"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa44"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa45"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa46"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa47"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa48"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa49"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa4a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa51"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa52"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa53"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa54"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa55"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa56"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa57"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa58"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa59"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa5a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa61"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa62"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa63"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa64"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa65"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa66"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa67"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa68"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa69"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa6a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa71"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa72"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa73"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa74"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa75"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa76"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa77"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa78"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa79"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa7a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa81"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa82"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa83"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa84"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa85"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa86"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa87"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa88"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa89"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa8a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa91"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa92"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa93"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa94"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa95"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa96"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa97"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa98"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa99"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa9a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 923, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 23, 26, 24, 922, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.InsertData(
                table: "ApplicationUserModule",
                columns: new[] { "ApplicationUsersId", "ModulesId" },
                values: new object[,]
                {
                    { new Guid("45ca2157-3005-4472-9402-c7f3c66f8d10"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("82c92cc2-3ed1-4872-8155-39fdc8da4c90"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("df9f3750-0087-45b4-abcd-af83dadbee0d"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("f3b02013-43e6-4966-a661-233b75593184"), new Guid("00000000-0000-0000-0000-000000000003") }
                });
        }
    }
}
