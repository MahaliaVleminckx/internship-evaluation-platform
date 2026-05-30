using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Howest.SelfEvaluation.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    { new Guid("00000000-0000-0000-0000-000000000001"), null, new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4858), null, "TestFirstname", "TestLastName", "Student", null, "test@test.com" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4864), null, "TestMentorFirstname", "TestMentorLastname", "Mentor", null, "mentor@mentor.com" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), null, new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4866), null, "TestMentorTwoFirstname", "TestMentorTwoLastname", "Mentor", null, "mentor2@mentor.com" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), null, new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4928), null, "TestTeacherFirstname", "TestTeacherLastname", "Teacher", null, "teacher@teacher.com" },
                    { new Guid("1ff2f023-637a-43e4-84cd-a1837e976ab1"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(5052), null, "Seraphina", "Sterling", "Student", null, "seraphina.sterling@test.com" },
                    { new Guid("3a229a21-36ba-4edd-97a7-39eb121b1481"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(5056), null, "Kaelen", "Voss", "Student", null, "kaelen.voss@test.com" },
                    { new Guid("51b3159a-a64a-4a0b-8e58-a652bd5e54b2"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(5037), null, "Julian", "Thorne", "Student", null, "julian.thorne@test.com" },
                    { new Guid("791cdc0f-ee2f-4da7-8201-39aeaac5cfdd"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(5060), null, "Lyra", "Belrose", "Student", null, "lyra.belrose@test.com" },
                    { new Guid("97eb2fec-a94d-4986-95be-0c1c25e362ab"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(5045), null, "Elara", "Vance", "Student", null, "elara.vance@test.com" },
                    { new Guid("f5cdf9d2-3e04-4ff0-9747-97c835108861"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(5048), null, "Cassian", "Cole", "Student", null, "cassian.cole@test.com" }
                });

            migrationBuilder.InsertData(
                table: "CompetenceDomains",
                columns: new[] { "Id", "Created", "Deleted", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3255), null, "Domein 1: (Leerlijn) Algemene Houding", null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3263), null, "Domein 2: (Leerlijn) Professioneel Handelen", null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3265), null, "Domein 3: (Leerlijn) Gedrag Onderzoeken", null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3267), null, "Domein 4: (Leerlijn) Gedrag Beïnvloeden", null }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Created", "Deleted", "Description", "Name", "OwnerId", "Updated" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3139), null, "Zelfevaluaties stageperiode.", "Stage", null, null });

            migrationBuilder.InsertData(
                table: "ApplicationUserModule",
                columns: new[] { "ApplicationUsersId", "ModulesId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("1ff2f023-637a-43e4-84cd-a1837e976ab1"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("97eb2fec-a94d-4986-95be-0c1c25e362ab"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("f5cdf9d2-3e04-4ff0-9747-97c835108861"), new Guid("00000000-0000-0000-0000-000000000003") }
                });

            migrationBuilder.InsertData(
                table: "Competences",
                columns: new[] { "Id", "CompetenceDomainId", "Created", "Deleted", "Description", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3293), null, "De student houdt zich aan voorschriften, regels en procedures. Bijvoorbeeld: aanwezigheid, afspraken nakomen, stiptheid,...", "Betrouwbaarheid", null },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3300), null, "De student toont inzet en engagement", "Actieve medewerking", null },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3302), null, "De student kan stageopdrachten plannen en organiseren, is nauwkeurig, bewaakt de tijd en heeft een goed werkritme", "Efficiëntie", null },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3305), null, "De student kan omgaan met onverwachte zaken, kan inspringen waar nodig en indien nodig, kan snel schakelen tussen taken", "Flexibiliteit", null },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3372), null, "De student kan omgaan met werkgerelateerde stressoren (werkdruk, complexe situaties, kan werk en privé voldoende scheiden,…)", "Emotionele coping", null },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3376), null, "Groeiende zelfzekerheid en zelfvertrouwen bij uitoefenen van stageactiviteiten: student durft buiten de comfortzone stappen, durft groeien, pakt leerproces in handen", "Zelfvertrouwen", null },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3379), null, "De student kan zelfstandig taken uitvoeren, stuurt zichzelf aan, is zelfredzaam", "Autonomie", null },
                    { new Guid("00000000-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3381), null, "De student levert constructieve bijdragen (aan de organisatie), komt spontaan met nieuwe ideeën", "Initiatief nemen", null },
                    { new Guid("00000000-0000-0000-0000-000000000018"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3383), null, "De student handelt vanuit een laagdrempelige, respectvolle, empathische, divers-sensitieve, ethische en deontologische grondhouding", "Grondhouding", null },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3386), null, "De student functioneert opbouwend en initiatiefnemend in en met een multidisciplinair team en zorgnetwerk", "Functioneren", null },
                    { new Guid("00000000-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3389), null, "De student reflecteert kritisch en innovatiegericht op het eigen professioneel handelen en op de eigen persoonlijke ontwikkeling", "Reflecteren", null },
                    { new Guid("00000000-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3391), null, "De psychologisch consulent voert (alle) fasen van het psychodiagnostisch proces uit: observatie en/of (screenings-, intake)gesprekken, afnemen en scoren van psychodiagnostische testen, interpreteren van psychodiagnostische resultaten, rapporteren van psychodiagnostische gegevens (mondeling en/of schriftelijk)", "Diagnostisch vermogen", null },
                    { new Guid("00000000-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3393), null, "De psychologisch consulent voert (alle) fasen van de onderzoekscyclus uit (onderzoeksvraag formuleren -informatie verzamelen – onderzoeksmethode bepalen – analyse van de resultaten – terugkoppelen naar onderzoeksvraag): bijvoorbeeld kleinschalig praktijkonderzoek uitvoeren op de werkvloer", "Onderzoekend vermogen", null },
                    { new Guid("00000000-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3396), null, "De student ontwikkelt een handelings-/ preventieplan", "Ontwikkelen handelingsplan", null },
                    { new Guid("00000000-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3398), null, "In het kader van de implementatie van het handelings/preventieplan geeft de psychologisch consulent cliënt/klantgerichte informatie en/of advies", "Voorlichten", null },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3400), null, "In het kader van de implementatie van het handelings/preventieplan biedt de psychologisch consulent steun aan individuen en groepen", "Ondersteunen", null },
                    { new Guid("00000000-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3403), null, "In het kader van de implementatie van het handelings/preventieplan faciliteert de psychologisch consulent het verwerven van inzicht/inzichtsverandering", "Counselen", null },
                    { new Guid("00000000-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3406), null, "In het kader van de implementatie van het handelings/preventieplan leert de psychologisch consulent individuen en groepen vaardigheden aan", "Trainen", null },
                    { new Guid("00000000-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3408), null, "In het kader van de implementatie van het handelings/preventieplan coacht en motiveert de psychologisch consulent de cliënt om gestelde doelen te bereiken", "Coachen", null }
                });

            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "Id", "Created", "Deleted", "Description", "EndDate", "IsPublished", "ModuleId", "StartDate", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3227), null, "Bij de tussentijdse zelfvaluatie voorzien we vragen om halverwege jouw stageperiode het verloop af te toesten. Zie die als een uitnodiging om deze ervaring kritisch te analyseren en evalueren.", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tussentijdse Evaluatie", null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(3245), null, "Bij de eindevaluatie komen er vragen naar voren over het verloop van jouw stage aan het eind van de stageperiode.", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eindevaluatie", null }
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
                    { new Guid("00000000-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4300), null, "Onwettig afwezig, komt systematisch te laat", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4310), null, "Student durft soms eens te laat komen, vergeet bepaalde afspraken, blijft tegen dezelfde voorschriften/afspraken fouten maken", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4316), null, "Student durft soms eens te laat komen, vergeet bepaalde afspraken, blijft tegen dezelfde voorschriften/afspraken fouten maken", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4319), null, "Student komt op tijd, meldt afwezigheid correct, houdt zich aan voorschriften/afspraken", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4322), null, "Student komt op tijd, meldt afwezigheid correct, houdt zich aan voorschriften/afspraken", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4325), null, "Student is altijd stipt, toont een feilloze houding in het nakomen van afspraken", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4328), null, "Student is altijd stipt, toont een feilloze houding in het nakomen van afspraken", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4331), null, "Student is snel tevreden over zichzelf, brengt weinig in, werkt enkel mee op nadrukkelijke vraag. Student bereidt zich systematisch onvoldoende voor. Afwezige houding", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4333), null, "Student is niet altijd goed voorbereid. Neemt vaak een passieve en afwachtende houding aan", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4338), null, "Student is niet altijd goed voorbereid. Neemt vaak een passieve en afwachtende houding aan", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000039"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4341), null, "Student is voorbereid en zet zich in om taken tot een goed einde te brengen, is bereid een extra inspanning te leveren indien gevraagd", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4344), null, "Student is voorbereid en zet zich in om taken tot een goed einde te brengen, is bereid een extra inspanning te leveren indien gevraagd", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000041"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4347), null, "Student ziet werk, neemt spontaan taken op, toont verantwoordelijkheid en ownership, levert spontaan een gepaste extra inspanning", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000042"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4350), null, "Student ziet werk, neemt spontaan taken op, toont verantwoordelijkheid en ownership, levert spontaan een gepaste extra inspanning", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000043"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4352), null, "Student werkt chaotisch, haalt deadlines niet. Werkt systematisch slordig en te traag", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000044"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4355), null, "Student heeft het moeilijk met plannen en organiseren. Heeft regelmatig bijsturing en hulp nodig bij planning en organisatie", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4358), null, "Student heeft het moeilijk met plannen en organiseren. Heeft regelmatig bijsturing en hulp nodig bij planning en organisatie", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4361), null, "Student kan het werk plannen en organiseren, heeft een goed werkritme", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000047"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4364), null, "Student kan het werk plannen en organiseren, heeft een goed werkritme", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4366), null, "Student is proactief in het plannen en organiseren van het werk, werkt heel nauwkeurig en efficiënt", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4369), null, "Student is proactief in het plannen en organiseren van het werk, werkt heel nauwkeurig en efficiënt", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4372), null, "Student heeft een rigide houding, kan zich niet aanpassen aan onverwachte wijzigingen, kan niet schakelen tussen taken", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000051"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4374), null, "Student heeft het moeilijk met onverwachte wijzigingen, heeft tijd nodig, kan moeilijk schakelen tussen taken", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000052"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4377), null, "Student heeft het moeilijk met onverwachte wijzigingen, heeft tijd nodig, kan moeilijk schakelen tussen taken", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000053"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4380), null, "Student kan omgaan met onverwachte wijzigingen, is flexibel, kan schakelen indien nodig", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000054"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4382), null, "Student kan omgaan met onverwachte wijzigingen, is flexibel, kan schakelen indien nodig", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000055"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4385), null, "Student is zeer flexibel, schakelt spontaan en is vooruitziend", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000056"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4388), null, "Student is zeer flexibel, schakelt spontaan en is vooruitziend", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000057"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4390), null, "Student wordt emotioneel overspoeld, blokkeert, bevriest, loopt weg van moeilijkheden, reageert ongepast", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000058"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4393), null, "Student reageert vaak onaangepast (ontwijken, rationaliseren, minimaliseren, negeren)", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000059"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4396), null, "Student reageert vaak onaangepast (ontwijken, rationaliseren, minimaliseren, negeren)", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000060"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4399), null, "Student herkent stressoren en zoekt naar een gepaste manier om hier mee om te gaan", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000061"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4401), null, "Student herkent stressoren en zoekt naar een gepaste manier om hier mee om te gaan", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4405), null, "Student is weerbaar en veerkrachtig", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4408), null, "Student is weerbaar en veerkrachtig", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4410), null, "Student is angstig, gaat leermogelijkheden hierdoor uit de weg, durft comfortzone niet verlaten, toont vermijdingsgedrag. Student is ongepast zelfzeker, voelt de rol als stagiair(e) niet aan. Geen communicatie over groeiproces", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4446), null, "Student heeft voortdurend aanmoediging en bevestiging nodig om comfortzone te verlaten. Student moet gewezen worden op een gepaste houding als stagiair(e). Weinig communicatie over groeiproces", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4450), null, "Student heeft voortdurend aanmoediging en bevestiging nodig om comfortzone te verlaten. Student moet gewezen worden op een gepaste houding als stagiair(e). Weinig communicatie over groeiproces", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4452), null, "Student kan met voldoende zelfvertrouwen taken uitvoeren, heeft soms een aanmoediging of zetje nodig. Student communiceert over eigen groeiproces", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4455), null, "Student kan met voldoende zelfvertrouwen taken uitvoeren, heeft soms een aanmoediging of zetje nodig. Student communiceert over eigen groeiproces", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4458), null, "Student functioneert met zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan. Communiceert spontaan over groeiproces", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4461), null, "Student functioneert met zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan. Communiceert spontaan over groeiproces", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4464), null, "Student heeft voortdurend aansturing nodig", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4466), null, "Student kan taken nog onvoldoende zelfstandig uitvoeren, vraagt nog begeleiding", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4469), null, "Student kan taken nog onvoldoende zelfstandig uitvoeren, vraagt nog begeleiding", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000074"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4472), null, "Student kan met zelfvertrouwen en zelfzekerheid taken uitvoeren", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000075"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4475), null, "Student kan met zelfvertrouwen en zelfzekerheid taken uitvoeren", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000076"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4477), null, "Student functioneert met grote zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan, functioneert als beginnend beroepsbeoefenaar", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000077"), new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4480), null, "Student functioneert met grote zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan, functioneert als beginnend beroepsbeoefenaar", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000078"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4482), null, "Student is passief en afwachtend", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000079"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4485), null, "Student heeft vaak nog aansporing nodig om bijdragen te leveren. Student blijft eerder terughoudend", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4488), null, "Student heeft vaak nog aansporing nodig om bijdragen te leveren. Student blijft eerder terughoudend", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000081"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4490), null, "Student kan meedenken, is kritisch en verwoordt spontaan eigen ideeën, durft suggesties te geven. Kan ideeën en voorstellen uitwerken", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000082"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4493), null, "Student kan meedenken, is kritisch en verwoordt spontaan eigen ideeën, durft suggesties te geven. Kan ideeën en voorstellen uitwerken", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000083"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4496), null, "Student is in staat om ideeën voor te stellen en uit te voeren, gaat hierbij kritisch te werk en koppelt terug", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000084"), new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4498), null, "Student is in staat om ideeën voor te stellen en uit te voeren, gaat hierbij kritisch te werk en koppelt terug", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000085"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4501), null, "Student is meermaals onrespectvol tegenover gevoelens en opvattingen van de cliënt/klant. Toont weinig empathie. Is brutaal in zijn handelen. Heeft weinig oog voor maatschappelijke diversiteit. Maakt meermaals deontologische fouten", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000086"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4504), null, "Student is soms onrespectvol, tegenover gevoelens en opvattingen van de cliënt/klant, maar kan zichzelf corrigeren op vraag van de mentor", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4506), null, "Student is soms onrespectvol, tegenover gevoelens en opvattingen van de cliënt/klant, maar kan zichzelf corrigeren op vraag van de mentor", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000088"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4509), null, "Student handelt respectvol en zorgzaam tegenover gevoelens en opvattingen van de cliënt/klant. Kan zich inleven in de situatie van de cliënt/klant en toont dit in zijn handelen. Heeft een respectvolle houding tegenover maatschappelijke diversiteit. Handelt naar de deontologische code", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000089"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4514), null, "Student handelt respectvol en zorgzaam tegenover gevoelens en opvattingen van de cliënt/klant. Kan zich inleven in de situatie van de cliënt/klant en toont dit in zijn handelen. Heeft een respectvolle houding tegenover maatschappelijke diversiteit. Handelt naar de deontologische code", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4518), null, "Student toont voorbeeldgedrag op vlak van respect, empathie en divers-sensitief handelen. Is pro-actief in het benaderen van een moeilijke cliënt/klant", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4522), null, "Student toont voorbeeldgedrag op vlak van respect, empathie en divers-sensitief handelen. Is pro-actief in het benaderen van een moeilijke cliënt/klant", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4525), null, "Student isoleert zich en deelt onvoldoende informatie met collega’s of relevante anderen. Neemt een eerder gesloten houding aan in het team", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4529), null, "Student participeert vooral op vraag van de andere(n). Neemt een houding aan die communicatie en samenwerking bemoeilijkt", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4533), null, "Student participeert vooral op vraag van de andere(n). Neemt een houding aan die communicatie en samenwerking bemoeilijkt", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4536), null, "Student deelt informatie met collega’s en derden volgens de op de werkvloer geldende protocollen en afspraken. Ageert vanuit een open, respectvolle en constructieve houding. Spreekt relevante disciplines binnen de organisatie aan", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4538), null, "Student deelt informatie met collega’s en derden volgens de op de werkvloer geldende protocollen en afspraken. Ageert vanuit een open, respectvolle en constructieve houding. Spreekt relevante disciplines binnen de organisatie aan", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4541), null, "Student deelt spontaan informatie en onderhoudt spontaan goede contacten. Zet bruikbare ondersteunende samenwerkingsverbanden en/of netwerken op. Is een volwaardig teamlid in de organisatie", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4544), null, "Student deelt spontaan informatie en onderhoudt spontaan goede contacten. Zet bruikbare ondersteunende samenwerkingsverbanden en/of netwerken op. Is een volwaardig teamlid in de organisatie", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4546), null, "Student is niet in staat op zijn professioneel handelen te reflecteren. Reageert veelal defensief bij het ontvangen van feedback. Stuurt gedrag onvoldoende bij", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000100"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4549), null, "Student heeft weinig inzicht in zijn professioneel handelen. Student reageert vaak defensief. Student is wisselend in het bijsturen van gedrag", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000101"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4552), null, "Student heeft weinig inzicht in zijn professioneel handelen. Student reageert vaak defensief. Student is wisselend in het bijsturen van gedrag", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000102"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4554), null, "Student reflecteert op zijn professioneel handelen. Gaat constructief om met ontvangen feedback. Geeft het eigen handelen vorm en stuurt zijn gedrag bij vanuit een kritische en reflectieve houding", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000103"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4558), null, "Student reflecteert op zijn professioneel handelen. Gaat constructief om met ontvangen feedback. Geeft het eigen handelen vorm en stuurt zijn gedrag bij vanuit een kritische en reflectieve houding", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000104"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4562), null, "Integreert spontaan een reflectieve houding in het professioneel handelen. Benut momenten van overleg om op gepaste wijze feedback te ontvangen en te geven aan anderen", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000105"), new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4566), null, "Integreert spontaan een reflectieve houding in het professioneel handelen. Benut momenten van overleg om op gepaste wijze feedback te ontvangen en te geven aan anderen", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4568), null, "Student slaagt er niet in (fasen van) het psychodiagnostisch proces correct uit te voeren. Mist systematisch nauwkeurigheid en kritische zin. Taalgebruik is onvoldoende correct en professioneel", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000107"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4572), null, "Student is wisselend in het uitvoeren van (fasen van) het psychodiagnostisch proces. Is af en toe onnauwkeurig. Heeft bijsturing nodig", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000108"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4575), null, "Student is wisselend in het uitvoeren van (fasen van) het psychodiagnostisch proces. Is af en toe onnauwkeurig. Heeft bijsturing nodig", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4578), null, "Student kan elke relevante fase van het psychodiagnostisch proces op een voldoende wijze uitvoeren. Kan nog groeien in het uitvoeren van bepaalde fasen. Kan nog groeien in gebruik van correcte en professionele taal", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000110"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4580), null, "Student kan elke relevante fase van het psychodiagnostisch proces op een voldoende wijze uitvoeren. Kan nog groeien in het uitvoeren van bepaalde fasen. Kan nog groeien in gebruik van correcte en professionele taal", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000111"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4583), null, "e student kan elke relevante fase van het psychodiagnostisch proces met kritische zin en nauwkeurigheid uitvoeren. Hanteert correcte en professionele taal", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000112"), new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4586), null, "e student kan elke relevante fase van het psychodiagnostisch proces met kritische zin en nauwkeurigheid uitvoeren. Hanteert correcte en professionele taal", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000113"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4588), null, "Student slaagt er niet in het onderzoeksproces correct uit te voeren. Mist systematisch nauwkeurigheid en kritische zin. Taalgebruik is onvoldoende correct en professioneel", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000114"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4591), null, "Student is wisselend in het uitvoeren van het onderzoeksproces. Is af en toe onnauwkeurig. Heeft bijsturing nodig", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000115"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4594), null, "Student is wisselend in het uitvoeren van het onderzoeksproces. Is af en toe onnauwkeurig. Heeft bijsturing nodig", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000116"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4596), null, "Student kan het onderzoeksproces op een voldoende wijze uitvoeren. Kan nog groeien in het gebruik van correcte en professionele taal", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000117"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4599), null, "Student kan het onderzoeksproces op een voldoende wijze uitvoeren. Kan nog groeien in het gebruik van correcte en professionele taal", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000118"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4683), null, "De student kan elke fase van het onderzoeksproces met kritische zin en nauwkeurigheid uitvoeren", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000119"), new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4686), null, "De student kan elke fase van het onderzoeksproces met kritische zin en nauwkeurigheid uitvoeren", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000120"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4689), null, "De student slaagt er niet in om op basis van een psychodiagnostisch of onderzoeksproces een relevante bijdrage te leveren bij het ontwikkelen van een handelings-/preventieplan", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000121"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4694), null, "De student heeft veel ondersteuning nodig om op basis van een psychodiagnostisch of onderzoeksproces een relevante bijdrage te kunnen leveren bij het ontwikkelen van een handelings-/preventieplan", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000122"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4697), null, "De student heeft veel ondersteuning nodig om op basis van een psychodiagnostisch of onderzoeksproces een relevante bijdrage te kunnen leveren bij het ontwikkelen van een handelings-/preventieplan", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000123"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4701), null, "De student kan op basis van een psychodiagnostisch of onderzoeksproces een bijdrage leveren bij het ontwikkelen van een goed handelings-/preventieplan", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000124"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4705), null, "De student kan op basis van een psychodiagnostisch of onderzoeksproces een bijdrage leveren bij het ontwikkelen van een goed handelings-/preventieplan", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000125"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4707), null, "De student kan op basis van een psychodiagnostisch of onderzoeksproces zelfstandig een goed handelings-/preventieplan ontwikkelen", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000126"), new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4711), null, "De student kan op basis van een psychodiagnostisch of onderzoeksproces zelfstandig een goed handelings-/preventieplan ontwikkelen", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000127"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4715), null, "Student slaagt er niet in om op een heldere en gestructureerde manier informatie over te brengen en/of te presenteren", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000128"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4718), null, "Student heeft veel ondersteuning nodig om op een heldere en gestructureerde manier informatie over te brengen en/of te presenteren", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000129"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4725), null, "Student heeft veel ondersteuning nodig om op een heldere en gestructureerde manier informatie over te brengen en/of te presenteren", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000130"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4728), null, "Student kan informatie op een didactisch verantwoorde wijze geven en/of presenteren: dit is rekening houdend met doelgroep, valkuilen van het instrument dat ze gebruiken, etc. Kan nog groeien in zelfvertrouwen en overtuigingskracht", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000131"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4732), null, "Student kan informatie op een didactisch verantwoorde wijze geven en/of presenteren: dit is rekening houdend met doelgroep, valkuilen van het instrument dat ze gebruiken, etc. Kan nog groeien in zelfvertrouwen en overtuigingskracht", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000132"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4734), null, "Student kan informatie op een heldere en toegankelijke manier geven en/of presenteren. Kan met veel zelfvertrouwen en overtuigingskracht informatie geven en/of presenteren", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000133"), new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4738), null, "Student kan informatie op een heldere en toegankelijke manier geven en/of presenteren. Kan met veel zelfvertrouwen en overtuigingskracht informatie geven en/of presenteren", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000134"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4741), null, "Student slaagt er niet in een begeleidingsrelatie met individuen en groepen op te bouwen. Ondersteunende gespreksvaardigheden (parafraseren, empathisch gissen, etc) worden onvoldoende benut", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000135"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4744), null, "Student is wisselend in het opbouwen van een begeleidingsrelatie met individuen en groepen. Student is wisselend in het benutten van ondersteunende gespreksvaardigheden", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000136"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4748), null, "Student is wisselend in het opbouwen van een begeleidingsrelatie met individuen en groepen. Student is wisselend in het benutten van ondersteunende gespreksvaardigheden", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000137"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4751), null, "Student past ondersteunende gespreksvaardigheden toe bij individuen en groepen (parafraseren, empathisch gissen, etc). Bouwt een begeleidingsrelatie op met individuen en groepen waarin 'warm aanwezig zijn' centraal staat", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000138"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4754), null, "Student past ondersteunende gespreksvaardigheden toe bij individuen en groepen (parafraseren, empathisch gissen, etc). Bouwt een begeleidingsrelatie op met individuen en groepen waarin 'warm aanwezig zijn' centraal staat", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000139"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4757), null, "Student past ondersteunende gespreksvaardigheden toe op een vlotte en natuurlijke wijze. Heeft vanuit zichzelf een warm aanwezige en authentieke houding", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000140"), new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4760), null, "Student past ondersteunende gespreksvaardigheden toe op een vlotte en natuurlijke wijze. Heeft vanuit zichzelf een warm aanwezige en authentieke houding", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000141"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4762), null, "Past counselingstechnieken niet of systematisch foutief toe", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000142"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4765), null, "Past counselingtechnieken wel toe, maar kwaliteit van uitvoering is wisselend", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000143"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4768), null, "Past counselingtechnieken wel toe, maar kwaliteit van uitvoering is wisselend", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000144"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4770), null, "Helpt de cliënt inzicht te verwerven in zichzelf en zijn situatie. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Kan counselingtechnieken toepassen", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000145"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4774), null, "Helpt de cliënt inzicht te verwerven in zichzelf en zijn situatie. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Kan counselingtechnieken toepassen", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000146"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4777), null, "Past op effectieve wijze counselingtechnieken toe in gesprekken. Zet aan tot inzichtsverandering. Zet in op empowerment. Zet in op zelfredzaamheid", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4781), null, "Past op effectieve wijze counselingtechnieken toe in gesprekken. Zet aan tot inzichtsverandering. Zet in op empowerment. Zet in op zelfredzaamheid", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000148"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4783), null, "Slaagt er niet in een bestaande training uit te voeren. Zowel inhoudelijk als groepsdynamisch is de training ontoereikend uitgevoerd", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000149"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4786), null, "Slaagt erin een bestaande training uit te voeren, maar heeft weinig oog voor groepsdynamische processen en/of is weinig flexibel in uitvoering", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4790), null, "Slaagt erin een bestaande training uit te voeren, maar heeft weinig oog voor groepsdynamische processen en/of is weinig flexibel in uitvoering", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000151"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4792), null, "Traint personen op een resultaatsgerichte en persoonlijke wijze om vaardigheden aan te leren. Draagt op een didactisch verantwoorde wijze kennis en inzichten over in een veilige en vertrouwde context, al dan niet samen met een collega of supervisor", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000152"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4795), null, "Traint personen op een resultaatsgerichte en persoonlijke wijze om vaardigheden aan te leren. Draagt op een didactisch verantwoorde wijze kennis en inzichten over in een veilige en vertrouwde context, al dan niet samen met een collega of supervisor", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000153"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4798), null, "Kiest een geschikte training, past die aan of stelt die samen in functie van de vraag, op basis van duidelijke kwaliteitscriteria. Toont flexibiliteit in uitvoering, hanteert groepsdynamische processen en enthousiasmeert. Toetst actief af wat het effect is van de training op de deelnemers", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000154"), new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4801), null, "Kiest een geschikte training, past die aan of stelt die samen in functie van de vraag, op basis van duidelijke kwaliteitscriteria. Toont flexibiliteit in uitvoering, hanteert groepsdynamische processen en enthousiasmeert. Toetst actief af wat het effect is van de training op de deelnemers", "Uitstekend", 7, null },
                    { new Guid("00000000-0000-0000-0000-000000000155"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4805), null, "Past coachingstechnieken niet of systematisch foutief toe", "Zwaar onvoldoende", 1, null },
                    { new Guid("00000000-0000-0000-0000-000000000156"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4809), null, "Past coachingstechnieken toe, maar kwaliteit van uitvoering is wisselend en/of deze bereiken onvoldoende hun doel", "Onvoldoende", 2, null },
                    { new Guid("00000000-0000-0000-0000-000000000157"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4813), null, "Past coachingstechnieken toe, maar kwaliteit van uitvoering is wisselend en/of deze bereiken onvoldoende hun doel", "Licht onvoldoende", 3, null },
                    { new Guid("00000000-0000-0000-0000-000000000158"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4817), null, "Helpt de cliënt inzicht te verwerven in zichzelf, gewenste doelen en mogelijke stappen om deze te realiseren. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Maakt gebruik van coachingstechnieken waar nodig", "Voldoende", 4, null },
                    { new Guid("00000000-0000-0000-0000-000000000159"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4822), null, "Helpt de cliënt inzicht te verwerven in zichzelf, gewenste doelen en mogelijke stappen om deze te realiseren. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Maakt gebruik van coachingstechnieken waar nodig", "Goed", 5, null },
                    { new Guid("00000000-0000-0000-0000-000000000160"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4826), null, "Past op effectieve en doelmatige wijze coachingstechnieken toe en slaagt erin cliënt tot verandering te brengen", "Zeer goed", 6, null },
                    { new Guid("00000000-0000-0000-0000-000000000161"), new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 5, 27, 17, 0, 31, 593, DateTimeKind.Local).AddTicks(4832), null, "Past op effectieve en doelmatige wijze coachingstechnieken toe en slaagt erin cliënt tot verandering te brengen", "Uitstekend", 7, null }
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
