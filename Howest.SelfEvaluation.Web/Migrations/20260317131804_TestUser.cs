using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Howest.SelfEvaluation.Web.Migrations
{
    /// <inheritdoc />
    public partial class TestUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "Created", "Deleted", "Role", "Updated", "Username" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3402), null, "Student", null, "test@test.com" });

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000006"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000007"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000008"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000009"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee11"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee12"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee13"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee14"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee15"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee16"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee17"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee18"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee19"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee1e"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee21"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee22"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee23"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee24"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee25"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee26"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee27"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee28"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee2e"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa111"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa112"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa113"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa114"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa115"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa116"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa117"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa118"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa119"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa11a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa121"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa122"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa123"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa124"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa125"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa126"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa127"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa128"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa129"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa12a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa131"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa132"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa133"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa134"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa135"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa136"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa137"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa138"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa139"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa13a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa141"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa142"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa143"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa144"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa145"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa146"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa147"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa148"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa149"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa14a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa151"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa152"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa153"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa154"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa155"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa156"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa157"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa158"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa159"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa15a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa161"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa16a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a1"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a2"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a3"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a4"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a5"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a6"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a7"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a8"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a9"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1aa"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa29"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa31"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa32"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa33"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa34"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa35"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa36"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa37"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa38"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa39"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa3a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa41"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa42"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa43"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa44"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa45"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa46"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa47"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa48"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa49"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa4a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa51"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa52"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa53"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa54"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa55"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa56"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa57"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa58"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa59"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa5a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa61"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa62"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa63"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa64"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa65"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa66"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa67"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa68"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa69"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa6a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa71"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa72"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa73"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa74"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa75"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa76"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa77"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa78"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa79"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa7a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa81"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa82"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa83"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa84"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa85"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa86"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa87"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa88"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa89"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa8a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa91"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa92"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa93"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa94"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa95"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa96"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa97"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa98"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa99"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa9a"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(2198));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000006"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000007"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000008"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "CompetenceDomains",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000009"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee11"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee12"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee13"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee14"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee15"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee16"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee17"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee18"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee19"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee1e"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee21"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee22"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee23"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee24"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee25"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee26"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee27"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee28"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Competences",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee2e"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa111"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa112"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa113"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa114"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa115"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa116"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa117"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa118"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa119"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa11a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa121"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa122"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa123"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa124"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa125"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa126"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa127"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa128"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa129"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa12a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa131"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa132"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa133"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa134"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa135"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa136"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa137"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa138"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa139"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa13a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa141"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa142"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa143"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa144"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa145"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa146"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa147"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa148"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa149"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa14a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa151"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa152"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa153"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa154"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa155"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa156"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa157"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa158"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa159"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa15a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa161"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa16a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a1"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a2"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a3"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a4"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a5"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a6"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a7"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a8"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1a9"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa1aa"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa29"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa31"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa32"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa33"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa34"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa35"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa36"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa37"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa38"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa39"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa3a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa41"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa42"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa43"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa44"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa45"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa46"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa47"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa48"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa49"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa4a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa51"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa52"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa53"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa54"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa55"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa56"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa57"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa58"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa59"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa5a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa61"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa62"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa63"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa64"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa65"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa66"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa67"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa68"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa69"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa6a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa71"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa72"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa73"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa74"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa75"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa76"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa77"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa78"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa79"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa7a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa81"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa82"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa83"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa84"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa85"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa86"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa87"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa88"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa89"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa8a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa91"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa92"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa93"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa94"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa95"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa96"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa97"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa98"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa99"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Indicators",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa9a"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2026, 2, 11, 13, 21, 55, 776, DateTimeKind.Local).AddTicks(4125));
        }
    }
}
