using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Howest.SelfEvaluation.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddMentorTestUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "Created", "Deleted", "Role", "Updated", "Username" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5782), null, "Mentor", null, "mentor@mentor.com" });

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000006"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000007"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000008"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000009"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee11"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee12"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee13"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee14"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee15"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee16"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee17"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee18"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee19"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee1e"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee21"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee22"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee23"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee24"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee25"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee26"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee27"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee28"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee2e"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa111"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa112"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa113"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa114"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa115"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa116"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa117"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa118"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa119"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa11a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa121"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa122"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa123"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa124"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa125"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa126"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa127"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa128"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa129"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa12a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa131"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa132"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa133"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa134"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa135"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa136"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa137"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa138"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa139"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa13a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa141"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa142"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa143"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa144"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa145"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa146"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa147"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa148"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa149"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa14a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa151"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa152"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa153"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa154"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa155"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa156"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa157"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa158"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa159"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa15a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa161"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa16a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a1"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a2"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a3"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a4"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a5"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a6"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a7"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a8"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a9"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1aa"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa29"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa31"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa32"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa33"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa34"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa35"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa36"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa37"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa38"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa39"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa3a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa41"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa42"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa43"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa44"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa45"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa46"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa47"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa48"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa49"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa4a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa51"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa52"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa53"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa54"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa55"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa56"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa57"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa58"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa59"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa5a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa61"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa62"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa63"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa64"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa65"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa66"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa67"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa68"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa69"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa6a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa71"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa72"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa73"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa74"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa75"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa76"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa77"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa78"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa79"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa7a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa81"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa82"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa83"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa84"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa85"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa86"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa87"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa88"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa89"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa8a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa91"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa92"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa93"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa94"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa95"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa96"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa97"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa98"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa99"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa9a"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2026, 5, 1, 3, 11, 11, 385, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.InsertData(
                table: "ApplicationUserModule",
                columns: new[] { "ApplicationUserId", "ModuleId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUserId", "ModuleId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000006"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000007"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000008"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000009"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee11"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee12"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee13"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee14"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee15"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee16"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee17"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee18"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee19"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee1e"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee21"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee22"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee23"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee24"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee25"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee26"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee27"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee28"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee2e"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa111"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa112"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa113"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa114"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa115"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa116"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa117"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa118"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa119"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa11a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa121"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa122"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa123"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa124"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa125"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa126"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa127"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa128"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa129"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa12a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa131"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa132"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa133"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa134"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa135"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa136"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa137"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa138"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa139"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa13a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa141"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa142"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa143"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa144"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa145"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa146"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa147"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa148"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa149"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa14a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa151"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa152"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa153"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa154"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa155"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa156"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa157"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa158"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa159"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa15a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa161"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa16a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a1"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a2"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a3"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a4"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a5"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a6"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a7"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a8"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a9"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1aa"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa29"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa31"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa32"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa33"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa34"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa35"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa36"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa37"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa38"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa39"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa3a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa41"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa42"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa43"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa44"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa45"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa46"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa47"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa48"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa49"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa4a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa51"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa52"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa53"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa54"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa55"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa56"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa57"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa58"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa59"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa5a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa61"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa62"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa63"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa64"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa65"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa66"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa67"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa68"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa69"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa6a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa71"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa72"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa73"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa74"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa75"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa76"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa77"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa78"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa79"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa7a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa81"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa82"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa83"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa84"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa85"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa86"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa87"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa88"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa89"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa8a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa91"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa92"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa93"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa94"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa95"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa96"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa97"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa98"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa99"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa9a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 15, 35, 51, 230, DateTimeKind.Local).AddTicks(3754));
        }
    }
}
