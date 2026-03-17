using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Howest.SelfEvaluation.Web.Migrations
{
    /// <inheritdoc />
    public partial class LinkUsersToModules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserModule_ApplicationUsers_ApplicationUsersId",
                table: "ApplicationUserModule");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserModule_Modules_ModulesId",
                table: "ApplicationUserModule");

            migrationBuilder.RenameColumn(
                name: "ModulesId",
                table: "ApplicationUserModule",
                newName: "ModuleId");

            migrationBuilder.RenameColumn(
                name: "ApplicationUsersId",
                table: "ApplicationUserModule",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserModule_ModulesId",
                table: "ApplicationUserModule",
                newName: "IX_ApplicationUserModule_ModuleId");

            migrationBuilder.InsertData(
                table: "ApplicationUserModule",
                columns: new[] { "ApplicationUserId", "ModuleId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000003") });

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

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserModule_ApplicationUsers_ApplicationUserId",
                table: "ApplicationUserModule",
                column: "ApplicationUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserModule_Modules_ModuleId",
                table: "ApplicationUserModule",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserModule_ApplicationUsers_ApplicationUserId",
                table: "ApplicationUserModule");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserModule_Modules_ModuleId",
                table: "ApplicationUserModule");

            migrationBuilder.DeleteData(
                table: "ApplicationUserModule",
                keyColumns: new[] { "ApplicationUserId", "ModuleId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "ApplicationUserModule",
                newName: "ModulesId");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "ApplicationUserModule",
                newName: "ApplicationUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserModule_ModuleId",
                table: "ApplicationUserModule",
                newName: "IX_ApplicationUserModule_ModulesId");

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2026, 3, 17, 14, 18, 4, 165, DateTimeKind.Local).AddTicks(3402));

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

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserModule_ApplicationUsers_ApplicationUsersId",
                table: "ApplicationUserModule",
                column: "ApplicationUsersId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserModule_Modules_ModulesId",
                table: "ApplicationUserModule",
                column: "ModulesId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
