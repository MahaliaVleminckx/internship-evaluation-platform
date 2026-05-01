using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Howest.SelfEvaluation.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEvaluationScoreWithTargetUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("71b243df-198c-4d9c-834a-db54efbe3730"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("a9f19e8a-31d6-46cd-8f92-68383da28da3"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("be0947f2-2c3a-41f9-bd7e-601d742f1502"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUsersId", "ModulesId" },
                keyValues: new object[] { new Guid("c37e6459-842a-41a8-8625-caecbe2f1df1"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("438e0c25-7da8-42a6-bfcc-89712bbdf109"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b49877b-991e-41a1-ab3b-627c1a04b292"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("71b243df-198c-4d9c-834a-db54efbe3730"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("a9f19e8a-31d6-46cd-8f92-68383da28da3"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("be0947f2-2c3a-41f9-bd7e-601d742f1502"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("c37e6459-842a-41a8-8625-caecbe2f1df1"));

            migrationBuilder.AddColumn<Guid>(
                name: "TargetUserId",
                table: "EvaluationScores",
                type: "uniqueidentifier",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TargetUserId",
                table: "EvaluationScores");

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AssignedMentorId", "Created", "Deleted", "Firstname", "Lastname", "Role", "Updated", "Username" },
                values: new object[,]
                {
                    { new Guid("438e0c25-7da8-42a6-bfcc-89712bbdf109"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5928), null, "Lyra", "Belrose", "Student", null, "lyra.belrose@test.com" },
                    { new Guid("71b243df-198c-4d9c-834a-db54efbe3730"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5923), null, "Seraphina", "Sterling", "Student", null, "seraphina.sterling@test.com" },
                    { new Guid("8b49877b-991e-41a1-ab3b-627c1a04b292"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5915), null, "Elara", "Vance", "Student", null, "elara.vance@test.com" },
                    { new Guid("a9f19e8a-31d6-46cd-8f92-68383da28da3"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5926), null, "Kaelen", "Voss", "Student", null, "kaelen.voss@test.com" },
                    { new Guid("be0947f2-2c3a-41f9-bd7e-601d742f1502"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5920), null, "Cassian", "Cole", "Student", null, "cassian.cole@test.com" },
                    { new Guid("c37e6459-842a-41a8-8625-caecbe2f1df1"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5901), null, "Julian", "Thorne", "Student", null, "julian.thorne@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000006"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000007"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000008"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000009"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee11"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee12"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee13"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee14"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee15"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee16"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee17"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee18"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee19"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee1e"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee21"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee22"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee23"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee24"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee25"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee26"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee27"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee28"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee2e"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa111"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa112"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa113"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa114"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa115"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa116"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa117"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa118"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa119"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa11a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa121"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa122"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa123"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa124"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa125"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa126"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa127"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa128"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa129"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa12a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa131"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa132"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa133"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa134"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa135"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa136"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa137"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa138"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa139"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa13a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa141"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa142"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa143"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa144"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa145"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa146"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa147"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa148"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa149"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa14a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa151"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa152"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa153"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa154"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa155"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa156"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa157"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa158"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa159"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa15a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa161"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa16a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a1"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a2"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a3"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a4"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a5"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a6"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a7"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a8"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a9"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1aa"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa29"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa31"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa32"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa33"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa34"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa35"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa36"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa37"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa38"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa39"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa3a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa41"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa42"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa43"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa44"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa45"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa46"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa47"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa48"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa49"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa4a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa51"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa52"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa53"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa54"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa55"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa56"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa57"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa58"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa59"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa5a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa61"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa62"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa63"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa64"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa65"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa66"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa67"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa68"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa69"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa6a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa71"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa72"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa73"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa74"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa75"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa76"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa77"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa78"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa79"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa7a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa81"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa82"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa83"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa84"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa85"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa86"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa87"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa88"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa89"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa8a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa91"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa92"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa93"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa94"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa95"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa96"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa97"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa98"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa99"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa9a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 6, 48, 8, 443, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.InsertData(
                table: "ApplicationUserModule",
                columns: new[] { "ApplicationUsersId", "ModulesId" },
                values: new object[,]
                {
                    { new Guid("71b243df-198c-4d9c-834a-db54efbe3730"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("a9f19e8a-31d6-46cd-8f92-68383da28da3"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("be0947f2-2c3a-41f9-bd7e-601d742f1502"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("c37e6459-842a-41a8-8625-caecbe2f1df1"), new Guid("00000000-0000-0000-0000-000000000003") }
                });
        }
    }
}
