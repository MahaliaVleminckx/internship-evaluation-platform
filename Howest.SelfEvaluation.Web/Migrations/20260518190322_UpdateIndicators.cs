using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Howest.SelfEvaluation.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIndicators : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedMentorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetenceDomains",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetenceDomains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modules_ApplicationUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Competences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompetenceDomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competences_CompetenceDomains_CompetenceDomainId",
                        column: x => x.CompetenceDomainId,
                        principalTable: "CompetenceDomains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserModule",
                columns: table => new
                {
                    ApplicationUsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModulesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserModule", x => new { x.ApplicationUsersId, x.ModulesId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserModule_ApplicationUsers_ApplicationUsersId",
                        column: x => x.ApplicationUsersId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserModule_Modules_ModulesId",
                        column: x => x.ModulesId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluations_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Indicators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompetenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScaleValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScaleValueScore = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Indicators_Competences_CompetenceId",
                        column: x => x.CompetenceId,
                        principalTable: "Competences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompetenceDomainEvaluation",
                columns: table => new
                {
                    CompetenceDomainsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EvaluationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetenceDomainEvaluation", x => new { x.CompetenceDomainsId, x.EvaluationsId });
                    table.ForeignKey(
                        name: "FK_CompetenceDomainEvaluation_CompetenceDomains_CompetenceDomainsId",
                        column: x => x.CompetenceDomainsId,
                        principalTable: "CompetenceDomains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetenceDomainEvaluation_Evaluations_EvaluationsId",
                        column: x => x.EvaluationsId,
                        principalTable: "Evaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationScores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EvaluationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompetenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NotApplicable = table.Column<bool>(type: "bit", nullable: false),
                    ExtraInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IndicatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationScores_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EvaluationScores_Competences_CompetenceId",
                        column: x => x.CompetenceId,
                        principalTable: "Competences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EvaluationScores_Evaluations_EvaluationId",
                        column: x => x.EvaluationId,
                        principalTable: "Evaluations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EvaluationScores_Indicators_IndicatorId",
                        column: x => x.IndicatorId,
                        principalTable: "Indicators",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AssignedMentorId", "Created", "Deleted", "Firstname", "Lastname", "Role", "Updated", "Username" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), null, new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5868), null, "TestFirstname", "TestLastName", "Student", null, "test@test.com" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5873), null, "TestMentorFirstname", "TestMentorLastname", "Mentor", null, "mentor@mentor.com" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), null, new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5876), null, "TestMentorTwoFirstname", "TestMentorTwoLastname", "Mentor", null, "mentor2@mentor.com" },
                    { new Guid("2eaccb80-4cc5-4ace-bd1b-3596ae1d0203"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5919), null, "Seraphina", "Sterling", "Student", null, "seraphina.sterling@test.com" },
                    { new Guid("a2428cb1-9b52-411f-afda-c1c1a45d0c3d"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5922), null, "Kaelen", "Voss", "Student", null, "kaelen.voss@test.com" },
                    { new Guid("a68a9318-8f72-4cb0-9eab-25eb4e23ac5d"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5916), null, "Cassian", "Cole", "Student", null, "cassian.cole@test.com" },
                    { new Guid("cb0234e7-c459-4aa1-8945-57bed1d70a95"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5898), null, "Julian", "Thorne", "Student", null, "julian.thorne@test.com" },
                    { new Guid("cfd0b2ad-9c2e-4d8e-bb3b-01486c5749b1"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5912), null, "Elara", "Vance", "Student", null, "elara.vance@test.com" },
                    { new Guid("f58c5c40-03a4-475a-9a96-775d31778a28"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5925), null, "Lyra", "Belrose", "Student", null, "lyra.belrose@test.com" }
                });

            migrationBuilder.InsertData(
                table: "CompetenceDomains",
                columns: new[] { "Id", "Created", "Deleted", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4876), null, "Domein 1: (Leerlijn) Algemene Houding", null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4880), null, "Domein 2: (Leerlijn) Professioneel Handelen", null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4881), null, "Domein 3: (Leerlijn) Gedrag Onderzoeken", null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4883), null, "Domein 4: (Leerlijn) Gedrag Beïnvloeden", null }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Created", "Deleted", "Description", "Name", "OwnerId", "Updated" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4787), null, "Zelfevaluaties stageperiode.", "Stage", null, null });

            migrationBuilder.InsertData(
                table: "ApplicationUserModule",
                columns: new[] { "ApplicationUsersId", "ModulesId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("2eaccb80-4cc5-4ace-bd1b-3596ae1d0203"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("a2428cb1-9b52-411f-afda-c1c1a45d0c3d"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("a68a9318-8f72-4cb0-9eab-25eb4e23ac5d"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("cb0234e7-c459-4aa1-8945-57bed1d70a95"), new Guid("00000000-0000-0000-0000-000000000003") }
                });

            migrationBuilder.InsertData(
                table: "Competences",
                columns: new[] { "Id", "CompetenceDomainId", "Created", "Deleted", "Description", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4896), null, "De student houdt zich aan voorschriften, regels en procedures. Bijvoorbeeld: aanwezigheid, afspraken nakomen, stiptheid,...", "Betrouwbaarheid", null },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4903), null, "De student toont inzet en engagement", "Actieve medewerking", null },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4905), null, "De student kan stageopdrachten plannen en organiseren, is nauwkeurig, bewaakt de tijd en heeft een goed werkritme", "Efficiëntie", null },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4907), null, "De student kan omgaan met onverwachte zaken, kan inspringen waar nodig en indien nodig, kan snel schakelen tussen taken", "Flexibiliteit", null },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4908), null, "De student kan omgaan met werkgerelateerde stressoren (werkdruk, complexe situaties, kan werk en privé voldoende scheiden,…)", "Emotionele coping", null },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4912), null, "Groeiende zelfzekerheid en zelfvertrouwen bij uitoefenen van stageactiviteiten: student durft buiten de comfortzone stappen, durft groeien, pakt leerproces in handen", "Zelfvertrouwen", null },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4914), null, "De student kan zelfstandig taken uitvoeren, stuurt zichzelf aan, is zelfredzaam", "Autonomie", null },
                    { new Guid("00000000-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4915), null, "De student levert constructieve bijdragen (aan de organisatie), komt spontaan met nieuwe ideeën", "Initiatief nemen", null },
                    { new Guid("00000000-0000-0000-0000-000000000018"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4917), null, "De student handelt vanuit een laagdrempelige, respectvolle, empathische, divers-sensitieve, ethische en deontologische grondhouding", "Grondhouding", null },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4920), null, "De student functioneert opbouwend en initiatiefnemend in en met een multidisciplinair team en zorgnetwerk", "Functioneren", null },
                    { new Guid("00000000-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4922), null, "De student reflecteert kritisch en innovatiegericht op het eigen professioneel handelen en op de eigen persoonlijke ontwikkeling", "Reflecteren", null },
                    { new Guid("00000000-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4924), null, "De psychologisch consulent voert (alle) fasen van het psychodiagnostisch proces uit: observatie en/of (screenings-, intake)gesprekken, afnemen en scoren van psychodiagnostische testen, interpreteren van psychodiagnostische resultaten, rapporteren van psychodiagnostische gegevens (mondeling en/of schriftelijk)", "Diagnostisch vermogen", null },
                    { new Guid("00000000-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4925), null, "De psychologisch consulent voert (alle) fasen van de onderzoekscyclus uit (onderzoeksvraag formuleren -informatie verzamelen – onderzoeksmethode bepalen – analyse van de resultaten – terugkoppelen naar onderzoeksvraag): bijvoorbeeld kleinschalig praktijkonderzoek uitvoeren op de werkvloer", "Onderzoekend vermogen", null },
                    { new Guid("00000000-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4927), null, "De student ontwikkelt een handelings-/ preventieplan", "Ontwikkelen handelingsplan", null },
                    { new Guid("00000000-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4929), null, "In het kader van de implementatie van het handelings/preventieplan geeft de psychologisch consulent cliënt/klantgerichte informatie en/of advies", "Voorlichten", null },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4931), null, "In het kader van de implementatie van het handelings/preventieplan biedt de psychologisch consulent steun aan individuen en groepen", "Ondersteunen", null },
                    { new Guid("00000000-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4933), null, "In het kader van de implementatie van het handelings/preventieplan faciliteert de psychologisch consulent het verwerven van inzicht/inzichtsverandering", "Counselen", null },
                    { new Guid("00000000-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4935), null, "In het kader van de implementatie van het handelings/preventieplan leert de psychologisch consulent individuen en groepen vaardigheden aan", "Trainen", null },
                    { new Guid("00000000-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4937), null, "In het kader van de implementatie van het handelings/preventieplan coacht en motiveert de psychologisch consulent de cliënt om gestelde doelen te bereiken", "Coachen", null }
                });

            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "Id", "Created", "Deleted", "Description", "EndDate", "IsPublished", "ModuleId", "StartDate", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4853), null, "Bij de tussentijdse zelfvaluatie voorzien we vragen om halverwege jouw stageperiode het verloop af te toesten. Zie die als een uitnodiging om deze ervaring kritisch te analyseren en evalueren.", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tussentijdse Evaluatie", null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(4866), null, "Bij de eindevaluatie komen er vragen naar voren over het verloop van jouw stage aan het eind van de stageperiode.", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eindevaluatie", null }
                });

            migrationBuilder.InsertData(
                table: "CompetenceDomainEvaluation",
                columns: new[] { "CompetenceDomainsId", "EvaluationsId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000005") }
                });

            migrationBuilder.InsertData(
                table: "Indicators",
                columns: new[] { "Id", "CompetenceId", "Created", "Deleted", "Description", "ScaleValue", "ScaleValueScore", "Updated" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5423), null, "Onwettig afwezig, komt systematisch te laat", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5433), null, "Student durft soms eens te laat komen, vergeet bepaalde afspraken, blijft tegen dezelfde voorschriften/afspraken fouten maken", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5436), null, "Student durft soms eens te laat komen, vergeet bepaalde afspraken, blijft tegen dezelfde voorschriften/afspraken fouten maken", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5439), null, "Student komt op tijd, meldt afwezigheid correct, houdt zich aan voorschriften/afspraken", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5441), null, "Student komt op tijd, meldt afwezigheid correct, houdt zich aan voorschriften/afspraken", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5444), null, "Student is altijd stipt, toont een feilloze houding in het nakomen van afspraken", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5447), null, "Student is altijd stipt, toont een feilloze houding in het nakomen van afspraken", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5449), null, "Student is snel tevreden over zichzelf, brengt weinig in, werkt enkel mee op nadrukkelijke vraag. Student bereidt zich systematisch onvoldoende voor. Afwezige houding", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5451), null, "Student is niet altijd goed voorbereid. Neemt vaak een passieve en afwachtende houding aan", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5454), null, "Student is niet altijd goed voorbereid. Neemt vaak een passieve en afwachtende houding aan", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000039"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5457), null, "Student is voorbereid en zet zich in om taken tot een goed einde te brengen, is bereid een extra inspanning te leveren indien gevraagd", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5459), null, "Student is voorbereid en zet zich in om taken tot een goed einde te brengen, is bereid een extra inspanning te leveren indien gevraagd", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000041"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5461), null, "Student ziet werk, neemt spontaan taken op, toont verantwoordelijkheid en ownership, levert spontaan een gepaste extra inspanning", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000042"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5464), null, "Student ziet werk, neemt spontaan taken op, toont verantwoordelijkheid en ownership, levert spontaan een gepaste extra inspanning", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000043"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5466), null, "Student werkt chaotisch, haalt deadlines niet. Werkt systematisch slordig en te traag", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000044"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5468), null, "Student heeft het moeilijk met plannen en organiseren. Heeft regelmatig bijsturing en hulp nodig bij planning en organisatie", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5471), null, "Student heeft het moeilijk met plannen en organiseren. Heeft regelmatig bijsturing en hulp nodig bij planning en organisatie", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5474), null, "Student kan het werk plannen en organiseren, heeft een goed werkritme", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000047"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5476), null, "Student kan het werk plannen en organiseren, heeft een goed werkritme", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5478), null, "Student is proactief in het plannen en organiseren van het werk, werkt heel nauwkeurig en efficiënt", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5481), null, "Student is proactief in het plannen en organiseren van het werk, werkt heel nauwkeurig en efficiënt", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5483), null, "Student heeft een rigide houding, kan zich niet aanpassen aan onverwachte wijzigingen, kan niet schakelen tussen taken", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000051"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5485), null, "Student heeft het moeilijk met onverwachte wijzigingen, heeft tijd nodig, kan moeilijk schakelen tussen taken", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000052"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5488), null, "Student heeft het moeilijk met onverwachte wijzigingen, heeft tijd nodig, kan moeilijk schakelen tussen taken", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000053"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5490), null, "Student kan omgaan met onverwachte wijzigingen, is flexibel, kan schakelen indien nodig", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000054"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5522), null, "Student kan omgaan met onverwachte wijzigingen, is flexibel, kan schakelen indien nodig", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000055"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5526), null, "Student is zeer flexibel, schakelt spontaan en is vooruitziend", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000056"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5528), null, "Student is zeer flexibel, schakelt spontaan en is vooruitziend", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000057"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5530), null, "Student wordt emotioneel overspoeld, blokkeert, bevriest, loopt weg van moeilijkheden, reageert ongepast", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000058"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5533), null, "Student reageert vaak onaangepast (ontwijken, rationaliseren, minimaliseren, negeren)", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000059"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5535), null, "Student reageert vaak onaangepast (ontwijken, rationaliseren, minimaliseren, negeren)", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000060"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5538), null, "Student herkent stressoren en zoekt naar een gepaste manier om hier mee om te gaan", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000061"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5540), null, "Student herkent stressoren en zoekt naar een gepaste manier om hier mee om te gaan", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5543), null, "Student is weerbaar en veerkrachtig", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5546), null, "Student is weerbaar en veerkrachtig", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5548), null, "Student is angstig, gaat leermogelijkheden hierdoor uit de weg, durft comfortzone niet verlaten, toont vermijdingsgedrag. Student is ongepast zelfzeker, voelt de rol als stagiair(e) niet aan. Geen communicatie over groeiproces", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5550), null, "Student heeft voortdurend aanmoediging en bevestiging nodig om comfortzone te verlaten. Student moet gewezen worden op een gepaste houding als stagiair(e). Weinig communicatie over groeiproces", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5554), null, "Student heeft voortdurend aanmoediging en bevestiging nodig om comfortzone te verlaten. Student moet gewezen worden op een gepaste houding als stagiair(e). Weinig communicatie over groeiproces", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5556), null, "Student kan met voldoende zelfvertrouwen taken uitvoeren, heeft soms een aanmoediging of zetje nodig. Student communiceert over eigen groeiproces", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5559), null, "Student kan met voldoende zelfvertrouwen taken uitvoeren, heeft soms een aanmoediging of zetje nodig. Student communiceert over eigen groeiproces", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5561), null, "Student functioneert met zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan. Communiceert spontaan over groeiproces", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5563), null, "Student functioneert met zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan. Communiceert spontaan over groeiproces", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5566), null, "Student heeft voortdurend aansturing nodig", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5568), null, "Student kan taken nog onvoldoende zelfstandig uitvoeren, vraagt nog begeleiding", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5570), null, "Student kan taken nog onvoldoende zelfstandig uitvoeren, vraagt nog begeleiding", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000074"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5573), null, "Student kan met zelfvertrouwen en zelfzekerheid taken uitvoeren", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000075"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5575), null, "Student kan met zelfvertrouwen en zelfzekerheid taken uitvoeren", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000076"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5577), null, "Student functioneert met grote zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan, functioneert als beginnend beroepsbeoefenaar", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000077"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5580), null, "Student functioneert met grote zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan, functioneert als beginnend beroepsbeoefenaar", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000078"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5582), null, "Student is passief en afwachtend", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000079"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5584), null, "Student heeft vaak nog aansporing nodig om bijdragen te leveren. Student blijft eerder terughoudend", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5587), null, "Student heeft vaak nog aansporing nodig om bijdragen te leveren. Student blijft eerder terughoudend", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000081"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5589), null, "Student kan meedenken, is kritisch en verwoordt spontaan eigen ideeën, durft suggesties te geven. Kan ideeën en voorstellen uitwerken", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000082"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5591), null, "Student kan meedenken, is kritisch en verwoordt spontaan eigen ideeën, durft suggesties te geven. Kan ideeën en voorstellen uitwerken", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000083"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5594), null, "Student is in staat om ideeën voor te stellen en uit te voeren, gaat hierbij kritisch te werk en koppelt terug", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000084"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5596), null, "Student is in staat om ideeën voor te stellen en uit te voeren, gaat hierbij kritisch te werk en koppelt terug", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000085"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5598), null, "Student is meermaals onrespectvol tegenover gevoelens en opvattingen van de cliënt/klant. Toont weinig empathie. Is brutaal in zijn handelen. Heeft weinig oog voor maatschappelijke diversiteit. Maakt meermaals deontologische fouten", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000086"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5601), null, "Student is soms onrespectvol, tegenover gevoelens en opvattingen van de cliënt/klant, maar kan zichzelf corrigeren op vraag van de mentor", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5603), null, "Student is soms onrespectvol, tegenover gevoelens en opvattingen van de cliënt/klant, maar kan zichzelf corrigeren op vraag van de mentor", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000088"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5605), null, "Student handelt respectvol en zorgzaam tegenover gevoelens en opvattingen van de cliënt/klant. Kan zich inleven in de situatie van de cliënt/klant en toont dit in zijn handelen. Heeft een respectvolle houding tegenover maatschappelijke diversiteit. Handelt naar de deontologische code", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000089"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5608), null, "Student handelt respectvol en zorgzaam tegenover gevoelens en opvattingen van de cliënt/klant. Kan zich inleven in de situatie van de cliënt/klant en toont dit in zijn handelen. Heeft een respectvolle houding tegenover maatschappelijke diversiteit. Handelt naar de deontologische code", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5610), null, "Student toont voorbeeldgedrag op vlak van respect, empathie en divers-sensitief handelen. Is pro-actief in het benaderen van een moeilijke cliënt/klant", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5612), null, "Student toont voorbeeldgedrag op vlak van respect, empathie en divers-sensitief handelen. Is pro-actief in het benaderen van een moeilijke cliënt/klant", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5615), null, "Student isoleert zich en deelt onvoldoende informatie met collega’s of relevante anderen. Neemt een eerder gesloten houding aan in het team", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5618), null, "Student participeert vooral op vraag van de andere(n). Neemt een houding aan die communicatie en samenwerking bemoeilijkt", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5622), null, "Student participeert vooral op vraag van de andere(n). Neemt een houding aan die communicatie en samenwerking bemoeilijkt", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5624), null, "Student deelt informatie met collega’s en derden volgens de op de werkvloer geldende protocollen en afspraken. Ageert vanuit een open, respectvolle en constructieve houding. Spreekt relevante disciplines binnen de organisatie aan", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5628), null, "Student deelt informatie met collega’s en derden volgens de op de werkvloer geldende protocollen en afspraken. Ageert vanuit een open, respectvolle en constructieve houding. Spreekt relevante disciplines binnen de organisatie aan", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5630), null, "Student deelt spontaan informatie en onderhoudt spontaan goede contacten. Zet bruikbare ondersteunende samenwerkingsverbanden en/of netwerken op. Is een volwaardig teamlid in de organisatie", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5633), null, "Student deelt spontaan informatie en onderhoudt spontaan goede contacten. Zet bruikbare ondersteunende samenwerkingsverbanden en/of netwerken op. Is een volwaardig teamlid in de organisatie", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5635), null, "Student is niet in staat op zijn professioneel handelen te reflecteren. Reageert veelal defensief bij het ontvangen van feedback. Stuurt gedrag onvoldoende bij", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000100"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5637), null, "Student heeft weinig inzicht in zijn professioneel handelen. Student reageert vaak defensief. Student is wisselend in het bijsturen van gedrag", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000101"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5640), null, "Student heeft weinig inzicht in zijn professioneel handelen. Student reageert vaak defensief. Student is wisselend in het bijsturen van gedrag", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000102"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5642), null, "Student reflecteert op zijn professioneel handelen. Gaat constructief om met ontvangen feedback. Geeft het eigen handelen vorm en stuurt zijn gedrag bij vanuit een kritische en reflectieve houding", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000103"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5644), null, "Student reflecteert op zijn professioneel handelen. Gaat constructief om met ontvangen feedback. Geeft het eigen handelen vorm en stuurt zijn gedrag bij vanuit een kritische en reflectieve houding", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000104"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5647), null, "Integreert spontaan een reflectieve houding in het professioneel handelen. Benut momenten van overleg om op gepaste wijze feedback te ontvangen en te geven aan anderen", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000105"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5649), null, "Integreert spontaan een reflectieve houding in het professioneel handelen. Benut momenten van overleg om op gepaste wijze feedback te ontvangen en te geven aan anderen", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5651), null, "Student slaagt er niet in (fasen van) het psychodiagnostisch proces correct uit te voeren. Mist systematisch nauwkeurigheid en kritische zin. Taalgebruik is onvoldoende correct en professioneel", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000107"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5654), null, "Student is wisselend in het uitvoeren van (fasen van) het psychodiagnostisch proces. Is af en toe onnauwkeurig. Heeft bijsturing nodig", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000108"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5656), null, "Student is wisselend in het uitvoeren van (fasen van) het psychodiagnostisch proces. Is af en toe onnauwkeurig. Heeft bijsturing nodig", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5707), null, "Student kan elke relevante fase van het psychodiagnostisch proces op een voldoende wijze uitvoeren. Kan nog groeien in het uitvoeren van bepaalde fasen. Kan nog groeien in gebruik van correcte en professionele taal", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000110"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5710), null, "Student kan elke relevante fase van het psychodiagnostisch proces op een voldoende wijze uitvoeren. Kan nog groeien in het uitvoeren van bepaalde fasen. Kan nog groeien in gebruik van correcte en professionele taal", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000111"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5712), null, "e student kan elke relevante fase van het psychodiagnostisch proces met kritische zin en nauwkeurigheid uitvoeren. Hanteert correcte en professionele taal", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000112"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5715), null, "e student kan elke relevante fase van het psychodiagnostisch proces met kritische zin en nauwkeurigheid uitvoeren. Hanteert correcte en professionele taal", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000113"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5717), null, "Student slaagt er niet in het onderzoeksproces correct uit te voeren. Mist systematisch nauwkeurigheid en kritische zin. Taalgebruik is onvoldoende correct en professioneel", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000114"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5719), null, "Student is wisselend in het uitvoeren van het onderzoeksproces. Is af en toe onnauwkeurig. Heeft bijsturing nodig", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000115"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5722), null, "Student is wisselend in het uitvoeren van het onderzoeksproces. Is af en toe onnauwkeurig. Heeft bijsturing nodig", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000116"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5724), null, "Student kan het onderzoeksproces op een voldoende wijze uitvoeren. Kan nog groeien in het gebruik van correcte en professionele taal", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000117"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5726), null, "Student kan het onderzoeksproces op een voldoende wijze uitvoeren. Kan nog groeien in het gebruik van correcte en professionele taal", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000118"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5729), null, "De student kan elke fase van het onderzoeksproces met kritische zin en nauwkeurigheid uitvoeren", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000119"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5731), null, "De student kan elke fase van het onderzoeksproces met kritische zin en nauwkeurigheid uitvoeren", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000120"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5733), null, "De student slaagt er niet in om op basis van een psychodiagnostisch of onderzoeksproces een relevante bijdrage te leveren bij het ontwikkelen van een handelings-/preventieplan", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000121"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5736), null, "De student heeft veel ondersteuning nodig om op basis van een psychodiagnostisch of onderzoeksproces een relevante bijdrage te kunnen leveren bij het ontwikkelen van een handelings-/preventieplan", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000122"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5738), null, "De student heeft veel ondersteuning nodig om op basis van een psychodiagnostisch of onderzoeksproces een relevante bijdrage te kunnen leveren bij het ontwikkelen van een handelings-/preventieplan", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000123"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5740), null, "De student kan op basis van een psychodiagnostisch of onderzoeksproces een bijdrage leveren bij het ontwikkelen van een goed handelings-/preventieplan", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000124"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5743), null, "De student kan op basis van een psychodiagnostisch of onderzoeksproces een bijdrage leveren bij het ontwikkelen van een goed handelings-/preventieplan", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000125"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5745), null, "De student kan op basis van een psychodiagnostisch of onderzoeksproces zelfstandig een goed handelings-/preventieplan ontwikkelen", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000126"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5747), null, "De student kan op basis van een psychodiagnostisch of onderzoeksproces zelfstandig een goed handelings-/preventieplan ontwikkelen", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000127"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5750), null, "Student slaagt er niet in om op een heldere en gestructureerde manier informatie over te brengen en/of te presenteren", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000128"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5752), null, "Student heeft veel ondersteuning nodig om op een heldere en gestructureerde manier informatie over te brengen en/of te presenteren", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000129"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5754), null, "Student heeft veel ondersteuning nodig om op een heldere en gestructureerde manier informatie over te brengen en/of te presenteren", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000130"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5757), null, "Student kan informatie op een didactisch verantwoorde wijze geven en/of presenteren: dit is rekening houdend met doelgroep, valkuilen van het instrument dat ze gebruiken, etc. Kan nog groeien in zelfvertrouwen en overtuigingskracht", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000131"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5759), null, "Student kan informatie op een didactisch verantwoorde wijze geven en/of presenteren: dit is rekening houdend met doelgroep, valkuilen van het instrument dat ze gebruiken, etc. Kan nog groeien in zelfvertrouwen en overtuigingskracht", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000132"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5761), null, "Student kan informatie op een heldere en toegankelijke manier geven en/of presenteren. Kan met veel zelfvertrouwen en overtuigingskracht informatie geven en/of presenteren", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000133"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5764), null, "Student kan informatie op een heldere en toegankelijke manier geven en/of presenteren. Kan met veel zelfvertrouwen en overtuigingskracht informatie geven en/of presenteren", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000134"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5766), null, "Student slaagt er niet in een begeleidingsrelatie met individuen en groepen op te bouwen. Ondersteunende gespreksvaardigheden (parafraseren, empathisch gissen, etc) worden onvoldoende benut", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000135"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5768), null, "Student is wisselend in het opbouwen van een begeleidingsrelatie met individuen en groepen. Student is wisselend in het benutten van ondersteunende gespreksvaardigheden", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000136"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5774), null, "Student is wisselend in het opbouwen van een begeleidingsrelatie met individuen en groepen. Student is wisselend in het benutten van ondersteunende gespreksvaardigheden", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000137"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5776), null, "Student past ondersteunende gespreksvaardigheden toe bij individuen en groepen (parafraseren, empathisch gissen, etc). Bouwt een begeleidingsrelatie op met individuen en groepen waarin 'warm aanwezig zijn' centraal staat", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000138"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5779), null, "Student past ondersteunende gespreksvaardigheden toe bij individuen en groepen (parafraseren, empathisch gissen, etc). Bouwt een begeleidingsrelatie op met individuen en groepen waarin 'warm aanwezig zijn' centraal staat", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000139"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5781), null, "Student past ondersteunende gespreksvaardigheden toe op een vlotte en natuurlijke wijze. Heeft vanuit zichzelf een warm aanwezige en authentieke houding", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000140"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5783), null, "Student past ondersteunende gespreksvaardigheden toe op een vlotte en natuurlijke wijze. Heeft vanuit zichzelf een warm aanwezige en authentieke houding", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000141"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5786), null, "Past counselingstechnieken niet of systematisch foutief toe", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000142"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5788), null, "Past counselingtechnieken wel toe, maar kwaliteit van uitvoering is wisselend", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000143"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5790), null, "Past counselingtechnieken wel toe, maar kwaliteit van uitvoering is wisselend", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000144"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5793), null, "Helpt de cliënt inzicht te verwerven in zichzelf en zijn situatie. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Kan counselingtechnieken toepassen", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000145"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5795), null, "Helpt de cliënt inzicht te verwerven in zichzelf en zijn situatie. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Kan counselingtechnieken toepassen", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000146"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5797), null, "Past op effectieve wijze counselingtechnieken toe in gesprekken. Zet aan tot inzichtsverandering. Zet in op empowerment. Zet in op zelfredzaamheid", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5800), null, "Past op effectieve wijze counselingtechnieken toe in gesprekken. Zet aan tot inzichtsverandering. Zet in op empowerment. Zet in op zelfredzaamheid", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000148"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5802), null, "Slaagt er niet in een bestaande training uit te voeren. Zowel inhoudelijk als groepsdynamisch is de training ontoereikend uitgevoerd", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000149"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5804), null, "Slaagt erin een bestaande training uit te voeren, maar heeft weinig oog voor groepsdynamische processen en/of is weinig flexibel in uitvoering", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5807), null, "Slaagt erin een bestaande training uit te voeren, maar heeft weinig oog voor groepsdynamische processen en/of is weinig flexibel in uitvoering", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000151"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5809), null, "Traint personen op een resultaatsgerichte en persoonlijke wijze om vaardigheden aan te leren. Draagt op een didactisch verantwoorde wijze kennis en inzichten over in een veilige en vertrouwde context, al dan niet samen met een collega of supervisor", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000152"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5811), null, "Traint personen op een resultaatsgerichte en persoonlijke wijze om vaardigheden aan te leren. Draagt op een didactisch verantwoorde wijze kennis en inzichten over in een veilige en vertrouwde context, al dan niet samen met een collega of supervisor", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000153"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5814), null, "Kiest een geschikte training, past die aan of stelt die samen in functie van de vraag, op basis van duidelijke kwaliteitscriteria. Toont flexibiliteit in uitvoering, hanteert groepsdynamische processen en enthousiasmeert. Toetst actief af wat het effect is van de training op de deelnemers", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000154"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5816), null, "Kiest een geschikte training, past die aan of stelt die samen in functie van de vraag, op basis van duidelijke kwaliteitscriteria. Toont flexibiliteit in uitvoering, hanteert groepsdynamische processen en enthousiasmeert. Toetst actief af wat het effect is van de training op de deelnemers", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000155"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5819), null, "Past coachingstechnieken niet of systematisch foutief toe", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000156"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5821), null, "Past coachingstechnieken toe, maar kwaliteit van uitvoering is wisselend en/of deze bereiken onvoldoende hun doel", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000157"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5823), null, "Past coachingstechnieken toe, maar kwaliteit van uitvoering is wisselend en/of deze bereiken onvoldoende hun doel", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000158"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5827), null, "Helpt de cliënt inzicht te verwerven in zichzelf, gewenste doelen en mogelijke stappen om deze te realiseren. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Maakt gebruik van coachingstechnieken waar nodig", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000159"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5829), null, "Helpt de cliënt inzicht te verwerven in zichzelf, gewenste doelen en mogelijke stappen om deze te realiseren. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Maakt gebruik van coachingstechnieken waar nodig", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000160"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5850), null, "Past op effectieve en doelmatige wijze coachingstechnieken toe en slaagt erin cliënt tot verandering te brengen", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000161"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 18, 21, 3, 21, 802, DateTimeKind.Local).AddTicks(5852), null, "Past op effectieve en doelmatige wijze coachingstechnieken toe en slaagt erin cliënt tot verandering te brengen", "Uitstekend", 7, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserModule_ModulesId",
                table: "ApplicationUserModule",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetenceDomainEvaluation_EvaluationsId",
                table: "CompetenceDomainEvaluation",
                column: "EvaluationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Competences_CompetenceDomainId",
                table: "Competences",
                column: "CompetenceDomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_ModuleId",
                table: "Evaluations",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationScores_CompetenceId",
                table: "EvaluationScores",
                column: "CompetenceId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationScores_EvaluationId",
                table: "EvaluationScores",
                column: "EvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationScores_IndicatorId",
                table: "EvaluationScores",
                column: "IndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationScores_UserId",
                table: "EvaluationScores",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Indicators_CompetenceId",
                table: "Indicators",
                column: "CompetenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_OwnerId",
                table: "Modules",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserModule");

            migrationBuilder.DropTable(
                name: "CompetenceDomainEvaluation");

            migrationBuilder.DropTable(
                name: "EvaluationScores");

            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "Indicators");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Competences");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "CompetenceDomains");
        }
    }
}
