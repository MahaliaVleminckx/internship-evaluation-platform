using Howest.SelfEvaluation.Core.Entities;
using Howest.SelfEvaluation.Core.Enums;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;

namespace Howest.SelfEvaluation.Web.Data
{
	public class DataSeeder
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			#region Modules

            Guid moduleId = Guid.Parse("00000000-0000-0000-0000-000000000003");

			var modules = new List<Module>
			{
				new Module { Id = moduleId, Created = DateTime.Now, Name = "Stage",
					Description = "Zelfevaluaties stageperiode."}
			};

			#endregion

			#region Evaluations

			Guid evaluationIdMid = Guid.Parse("00000000-0000-0000-0000-000000000004");
			Guid evaluationIdEnd = Guid.Parse("00000000-0000-0000-0000-000000000005");

			var evaluations = new List<Evaluation>
			{
				new Evaluation {
					Id = evaluationIdMid,
					Title = "Tussentijdse Evaluatie",
					Created = DateTime.Now,
					StartDate = new DateTime(2025, 03, 16),
					EndDate =  new DateTime(2025, 03, 30),
					IsPublished = true,
					ModuleId = moduleId,
					Description = "Bij de tussentijdse zelfvaluatie voorzien we vragen om halverwege jouw stageperiode het verloop af te toesten. Zie die als een uitnodiging om deze ervaring kritisch te analyseren en evalueren."
				},
				new Evaluation {
					Id = evaluationIdEnd,
					Title = "Eindevaluatie",
					Created = DateTime.Now,
					StartDate = new DateTime(2025, 05, 18),
					EndDate =  new DateTime(2025, 06, 1),
					IsPublished = true,
					ModuleId = moduleId,
					Description = "Bij de eindevaluatie komen er vragen naar voren over het verloop van jouw stage aan het eind van de stageperiode."
				}
			};
            #endregion

            #region Domains

            Guid domainOne = Guid.Parse("00000000-0000-0000-0000-000000000006");
			Guid domainTwo = Guid.Parse("00000000-0000-0000-0000-000000000007");
			Guid domainThree = Guid.Parse("00000000-0000-0000-0000-000000000008");
			Guid domainFour = Guid.Parse("00000000-0000-0000-0000-000000000009");

			Guid domainOneEnd = Guid.Parse("00000000-0000-0000-0000-100000000006");
			Guid domainTwoEnd = Guid.Parse("00000000-0000-0000-0000-100000000007");
			Guid domainThreeEnd = Guid.Parse("00000000-0000-0000-0000-100000000008");
			Guid domainFourEnd = Guid.Parse("00000000-0000-0000-0000-100000000009");

			var domains = new List<CompetenceDomain>
			{
				//Midterm Evaluation Domains
				new CompetenceDomain
				{
					Id = domainOne,
					Created = DateTime.Now,
					Name = "Domein 1: (Leerlijn) Algemene Houding",
					EvaluationId = evaluationIdMid
				},
				new CompetenceDomain
				{
					Id = domainTwo,
					Created = DateTime.Now,
					Name = "Domein 2: (Leerlijn) Professioneel Handelen",
					EvaluationId = evaluationIdMid
				},
				new CompetenceDomain
				{
					Id = domainThree,
					Created = DateTime.Now,
					Name = "Domein 3: (Leerlijn) Gedrag Onderzoeken",
					EvaluationId = evaluationIdMid
				},
				new CompetenceDomain
				{
					Id = domainFour,
					Created = DateTime.Now,
					Name = "Domein 4: (Leerlijn) Gedrag Beïnvloeden",
					EvaluationId = evaluationIdMid
				},

				//End Evaluation Domains
				new CompetenceDomain
				{
					Id = domainOneEnd,
					Created = DateTime.Now,
					Name = "Domein 1: (Leerlijn) Algemene Houding",
					EvaluationId = evaluationIdEnd
				},
				new CompetenceDomain
				{
					Id = domainTwoEnd,
					Created = DateTime.Now,
					Name = "Domein 2: (Leerlijn) Professioneel Handelen",
					EvaluationId = evaluationIdEnd
				},
				new CompetenceDomain
				{
					Id = domainThreeEnd,
					Created = DateTime.Now,
					Name = "Domein 3: (Leerlijn) Gedrag Onderzoeken",
					EvaluationId = evaluationIdEnd
				},
				new CompetenceDomain
				{
					Id = domainFourEnd,
					Created = DateTime.Now,
					Name = "Domein 4: (Leerlijn) Gedrag Beïnvloeden",
					EvaluationId = evaluationIdEnd
				}
			};

			#endregion

			#region Competences

			Guid compOne = Guid.Parse("00000000-0000-0000-0000-000000000010");
			Guid compTwo = Guid.Parse("00000000-0000-0000-0000-000000000011");
			Guid compThree = Guid.Parse("00000000-0000-0000-0000-000000000012");
			Guid compFour = Guid.Parse("00000000-0000-0000-0000-000000000013");
			Guid compFive = Guid.Parse("00000000-0000-0000-0000-000000000014");
			Guid compSix = Guid.Parse("00000000-0000-0000-0000-000000000015");
			Guid compSeven = Guid.Parse("00000000-0000-0000-0000-000000000016");
			Guid compEight = Guid.Parse("00000000-0000-0000-0000-000000000017");
			Guid compTen = Guid.Parse("00000000-0000-0000-0000-000000000018");
			Guid compEleven = Guid.Parse("00000000-0000-0000-0000-000000000019");
			Guid compTwelve = Guid.Parse("00000000-0000-0000-0000-000000000020");
			Guid compThirteen = Guid.Parse("00000000-0000-0000-0000-000000000021");
			Guid compFourteen = Guid.Parse("00000000-0000-0000-0000-000000000022");
			Guid compFifteen = Guid.Parse("00000000-0000-0000-0000-000000000023");
			Guid compSixteen = Guid.Parse("00000000-0000-0000-0000-000000000024");
			Guid compSeventeen = Guid.Parse("00000000-0000-0000-0000-000000000025");
			Guid compEighteen = Guid.Parse("00000000-0000-0000-0000-000000000026");
			Guid compNineteen = Guid.Parse("00000000-0000-0000-0000-000000000027");
			Guid compTwenty = Guid.Parse("00000000-0000-0000-0000-000000000028");

			Guid compOneEnd = Guid.Parse(compOne.ToString().Replace("0", "e"));
			Guid compTwoEnd = Guid.Parse(compTwo.ToString().Replace("0", "e"));
			Guid compThreeEnd = Guid.Parse(compThree.ToString().Replace("0", "e"));
			Guid compFourEnd = Guid.Parse(compFour.ToString().Replace("0", "e"));
			Guid compFiveEnd = Guid.Parse(compFive.ToString().Replace("0", "e"));
			Guid compSixEnd = Guid.Parse(compSix.ToString().Replace("0", "e"));
			Guid compSevenEnd = Guid.Parse(compSeven.ToString().Replace("0", "e"));
			Guid compEightEnd = Guid.Parse(compEight.ToString().Replace("0", "e"));
			Guid compTenEnd = Guid.Parse(compTen.ToString().Replace("0", "e"));
			Guid compElevenEnd = Guid.Parse(compEleven.ToString().Replace("0", "e"));
			Guid compTwelveEnd = Guid.Parse(compTwelve.ToString().Replace("0", "e"));
			Guid compThirteenEnd = Guid.Parse(compThirteen.ToString().Replace("0", "e"));
			Guid compFourteenEnd = Guid.Parse(compFourteen.ToString().Replace("0", "e"));
			Guid compFifteenEnd = Guid.Parse(compFifteen.ToString().Replace("0", "e"));
			Guid compSixteenEnd = Guid.Parse(compSixteen.ToString().Replace("0", "e"));
			Guid compSeventeenEnd = Guid.Parse(compSeventeen.ToString().Replace("0", "e"));
			Guid compEighteenEnd = Guid.Parse(compEighteen.ToString().Replace("0", "e"));
			Guid compNineteenEnd = Guid.Parse(compNineteen.ToString().Replace("0", "e"));
			Guid compTwentyEnd = Guid.Parse(compTwenty.ToString().Replace("0", "e"));

			var competences = new List<Competence>
			{
				//Midterm Evaluation Domains
				//Domain 1
				new Competence
				{
					Id = compOne,
					Created = DateTime.Now,
					CompetenceDomainId = domainOne,
					Name = "Betrouwbaarheid",
					Description = "De student houdt zich aan voorschriften, regels en procedures. Bijvoorbeeld: aanwezigheid, afspraken nakomen, stiptheid,..."
				},
				new Competence
				{
					Id = compTwo,
					Created = DateTime.Now,
					CompetenceDomainId = domainOne,
					Name = "Actieve medewerking",
					Description = "De student toont inzet en engagement"
				},
				new Competence
				{
					Id = compThree,
					Created = DateTime.Now,
					CompetenceDomainId = domainOne,
					Name = "Efficiëntie",
					Description = "De student kan stageopdrachten plannen en organiseren, is nauwkeurig, bewaakt de tijd en heeft een goed werkritme"
				},
				new Competence
				{
					Id = compFour,
					Created = DateTime.Now,
					CompetenceDomainId = domainOne,
					Name = "Flexibiliteit",
					Description = "De student kan omgaan met onverwachte zaken, kan inspringen waar nodig en indien nodig, kan snel schakelen tussen taken"
				},
				new Competence
				{
					Id = compFive,
					Created = DateTime.Now,
					CompetenceDomainId = domainOne,
					Name = "Emotionele coping",
					Description = "De student kan omgaan met werkgerelateerde stressoren (werkdruk, complexe situaties, kan werk en privé voldoende scheiden,…)"
				},
				new Competence
				{
					Id = compSix,
					Created = DateTime.Now,
					CompetenceDomainId = domainOne,
					Name = "Zelfvertrouwen",
					Description = "Groeiende zelfzekerheid en zelfvertrouwen bij uitoefenen van stageactiviteiten: student durft buiten de comfortzone stappen, durft groeien, pakt leerproces in handen"
				},
				new Competence
				{
					Id = compSeven,
					Created = DateTime.Now,
					CompetenceDomainId = domainOne,
					Name = "Autonomie",
					Description = "De student kan zelfstandig taken uitvoeren, stuurt zichzelf aan, is zelfredzaam"
				},
				new Competence
				{
					Id = compEight,
					Created = DateTime.Now,
					CompetenceDomainId = domainOne,
					Name = "Initiatief nemen",
					Description = "De student levert constructieve bijdragen (aan de organisatie), komt spontaan met nieuwe ideeën"
				},

				//Domain 2
				new Competence
				{
					Id = compTen,
					Created = DateTime.Now,
					CompetenceDomainId = domainTwo,
					Name = "Grondhouding",
					Description = "De student handelt vanuit een laagdrempelige, respectvolle, empathische, divers-sensitieve, ethische en deontologische grondhouding"
				},
				new Competence
				{
					Id = compEleven,
					Created = DateTime.Now,
					CompetenceDomainId = domainTwo,
					Name = "Functioneren",
					Description = "De student functioneert opbouwend en initiatiefnemend in en met een multidisciplinair team en zorgnetwerk"
				},
				new Competence
				{
					Id = compTwelve,
					Created = DateTime.Now,
					CompetenceDomainId = domainTwo,
					Name = "Reflecteren",
					Description = "De student reflecteert kritisch en innovatiegericht op het eigen professioneel handelen en op de eigen persoonlijke ontwikkeling"
				},

				//Domain 3
				new Competence
				{
					Id = compThirteen,
					Created = DateTime.Now,
					CompetenceDomainId = domainThree,
					Name = "Diagnostisch vermogen",
					Description = "De psychologisch consulent voert (alle) fasen van het psychodiagnostisch proces uit: observatie en/of (screenings-, intake)gesprekken, afnemen en scoren van psychodiagnostische testen, interpreteren van psychodiagnostische resultaten, rapporteren van psychodiagnostische gegevens (mondeling en/of schriftelijk)"
				},
				new Competence
				{
					Id = compFourteen,
					Created = DateTime.Now,
					CompetenceDomainId = domainThree,
					Name = "Onderzoekend vermogen",
					Description = "De psychologisch consulent voert (alle) fasen van de onderzoekscyclus uit (onderzoeksvraag formuleren -informatie verzamelen – onderzoeksmethode bepalen – analyse van de resultaten – terugkoppelen naar onderzoeksvraag): bijvoorbeeld kleinschalig praktijkonderzoek uitvoeren op de werkvloer"
				},
				new Competence
				{
					Id = compFifteen,
					Created = DateTime.Now,
					CompetenceDomainId = domainThree,
					Name = "Ontwikkelen handelingsplan",
					Description = "De student ontwikkelt een handelings-/ preventieplan"
				},

				//Domain 4
				new Competence
				{
					Id = compSixteen,
					Created = DateTime.Now,
					CompetenceDomainId = domainFour,
					Name = "Voorlichten",
					Description = "In het kader van de implementatie van het handelings/preventieplan geeft de psychologisch consulent cliënt/klantgerichte informatie en/of advies"
				},
				new Competence
				{
					Id = compSeventeen,
					Created = DateTime.Now,
					CompetenceDomainId = domainFour,
					Name = "Ondersteunen",
					Description = "In het kader van de implementatie van het handelings/preventieplan biedt de psychologisch consulent steun aan individuen en groepen"
				},
				new Competence
				{
					Id = compEighteen,
					Created = DateTime.Now,
					CompetenceDomainId = domainFour,
					Name = "Counselen",
					Description = "In het kader van de implementatie van het handelings/preventieplan faciliteert de psychologisch consulent het verwerven van inzicht/inzichtsverandering"
				},
				new Competence
				{
					Id = compNineteen,
					Created = DateTime.Now,
					CompetenceDomainId = domainFour,
					Name = "Trainen",
					Description = "In het kader van de implementatie van het handelings/preventieplan leert de psychologisch consulent individuen en groepen vaardigheden aan"
				},
				new Competence
				{
					Id = compTwenty,
					Created = DateTime.Now,
					CompetenceDomainId = domainFour,
					Name = "Coachen",
					Description = "In het kader van de implementatie van het handelings/preventieplan coacht en motiveert de psychologisch consulent de cliënt om gestelde doelen te bereiken"
				},

				//End Evaluation Domains
				//Domain 1
				new Competence
				{
					Id = compOneEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainOneEnd,
					Name = "Betrouwbaarheid",
					Description = "De student houdt zich aan voorschriften, regels en procedures. Bijvoorbeeld: aanwezigheid, afspraken nakomen, stiptheid,..."
				},
				new Competence
				{
					Id = compTwoEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainOneEnd,
					Name = "Actieve medewerking",
					Description = "De student toont inzet en engagement"
				},
				new Competence
				{
					Id = compThreeEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainOneEnd,
					Name = "Efficiëntie",
					Description = "De student kan stageopdrachten plannen en organiseren, is nauwkeurig, bewaakt de tijd en heeft een goed werkritme"
				},
				new Competence
				{
					Id = compFourEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainOneEnd,
					Name = "Flexibiliteit",
					Description = "De student kan omgaan met onverwachte zaken, kan inspringen waar nodig en indien nodig, kan snel schakelen tussen taken"
				},
				new Competence
				{
					Id = compFiveEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainOneEnd,
					Name = "Emotionele coping",
					Description = "De student kan omgaan met werkgerelateerde stressoren (werkdruk, complexe situaties, kan werk en privé voldoende scheiden,…)"
				},
				new Competence
				{
					Id = compSixEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainOneEnd,
					Name = "Zelfvertrouwen",
					Description = "Groeiende zelfzekerheid en zelfvertrouwen bij uitoefenen van stageactiviteiten: student durft buiten de comfortzone stappen, durft groeien, pakt leerproces in handen"
				},
				new Competence
				{
					Id = compSevenEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainOneEnd,
					Name = "Autonomie",
					Description = "De student kan zelfstandig taken uitvoeren, stuurt zichzelf aan, is zelfredzaam"
				},
				new Competence
				{
					Id = compEightEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainOneEnd,
					Name = "Initiatief nemen",
					Description = "De student levert constructieve bijdragen (aan de organisatie), komt spontaan met nieuwe ideeën"
				},

				//Domain 2
				new Competence
				{
					Id = compTenEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainTwoEnd,
					Name = "Grondhouding",
					Description = "De student handelt vanuit een laagdrempelige, respectvolle, empathische, divers-sensitieve, ethische en deontologische grondhouding"
				},
				new Competence
				{
					Id = compElevenEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainTwoEnd,
					Name = "Functioneren",
					Description = "De student functioneert opbouwend en initiatiefnemend in en met een multidisciplinair team en zorgnetwerk"
				},
				new Competence
				{
					Id = compTwelveEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainTwoEnd,
					Name = "Reflecteren",
					Description = "De student reflecteert kritisch en innovatiegericht op het eigen professioneel handelen en op de eigen persoonlijke ontwikkeling"
				},

				//Domain 3
				new Competence
				{
					Id = compThirteenEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainThreeEnd,
					Name = "Diagnostisch vermogen",
					Description = "De psychologisch consulent voert (alle) fasen van het psychodiagnostisch proces uit: observatie en/of (screenings-, intake)gesprekken, afnemen en scoren van psychodiagnostische testen, interpreteren van psychodiagnostische resultaten, rapporteren van psychodiagnostische gegevens (mondeling en/of schriftelijk)"
				},
				new Competence
				{
					Id = compFourteenEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainThreeEnd,
					Name = "Onderzoekend vermogen",
					Description = "De psychologisch consulent voert (alle) fasen van de onderzoekscyclus uit (onderzoeksvraag formuleren -informatie verzamelen – onderzoeksmethode bepalen – analyse van de resultaten – terugkoppelen naar onderzoeksvraag): bijvoorbeeld kleinschalig praktijkonderzoek uitvoeren op de werkvloer"
				},
				new Competence
				{
					Id = compFifteenEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainThreeEnd,
					Name = "Ontwikkelen handelingsplan",
					Description = "De student ontwikkelt een handelings-/ preventieplan"
				},

				//Domain 4
				new Competence
				{
					Id = compSixteenEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainFourEnd,
					Name = "Voorlichten",
					Description = "In het kader van de implementatie van het handelings/preventieplan geeft de psychologisch consulent cliënt/klantgerichte informatie en/of advies"
				},
				new Competence
				{
					Id = compSeventeenEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainFourEnd,
					Name = "Ondersteunen",
					Description = "In het kader van de implementatie van het handelings/preventieplan biedt de psychologisch consulent steun aan individuen en groepen"
				},
				new Competence
				{
					Id = compEighteenEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainFourEnd,
					Name = "Counselen",
					Description = "In het kader van de implementatie van het handelings/preventieplan faciliteert de psychologisch consulent het verwerven van inzicht/inzichtsverandering"
				},
				new Competence
				{
					Id = compNineteenEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainFourEnd,
					Name = "Trainen",
					Description = "In het kader van de implementatie van het handelings/preventieplan leert de psychologisch consulent individuen en groepen vaardigheden aan"
				},
				new Competence
				{
					Id = compTwentyEnd,
					Created = DateTime.Now,
					CompetenceDomainId = domainFourEnd,
					Name = "Coachen",
					Description = "In het kader van de implementatie van het handelings/preventieplan coacht en motiveert de psychologisch consulent de cliënt om gestelde doelen te bereiken"
				},

			};
			#endregion

			#region Indicators

			string realBad = "Zwaar onvoldoende";
			string bad = "Onvoldoende";
			string prettyBad = "Licht onvoldoende";
			string alright = "Voldoende";
			string good = "Goed";
			string veryGood = "Zeer goed";
			string great = "Uitstekend";

			var indicators = new List<Indicator>
			{
				//First competence (Start Domain 1)
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000029"),
					CompetenceId = compOne,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Onwettig afwezig, komt systematisch te laat",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000030"),
					CompetenceId = compOne,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student durft soms eens te laat komen, vergeet bepaalde afspraken, blijft tegen dezelfde voorschriften/afspraken fouten maken",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000031"),
					CompetenceId = compOne,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student durft soms eens te laat komen, vergeet bepaalde afspraken, blijft tegen dezelfde voorschriften/afspraken fouten maken",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000032"),
					CompetenceId = compOne,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student komt op tijd, meldt afwezigheid correct, houdt zich aan voorschriften/afspraken",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000033"),
					CompetenceId = compOne,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student komt op tijd, meldt afwezigheid correct, houdt zich aan voorschriften/afspraken",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000034"),
					CompetenceId = compOne,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student is altijd stipt, toont een feilloze houding in het nakomen van afspraken",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000035"),
					CompetenceId = compOne,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student is altijd stipt, toont een feilloze houding in het nakomen van afspraken",
					ScaleValueScore = 7
				},
				//Second competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000036"),
					CompetenceId = compTwo,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student is snel tevreden over zichzelf, brengt weinig in, werkt enkel mee op nadrukkelijke vraag. Student bereidt zich systematisch onvoldoende voor. Afwezige houding",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000037"),
					CompetenceId = compTwo,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student is niet altijd goed voorbereid. Neemt vaak een passieve en afwachtende houding aan",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000038"),
					CompetenceId = compTwo,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student is niet altijd goed voorbereid. Neemt vaak een passieve en afwachtende houding aan",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000039"),
					CompetenceId = compTwo,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student is voorbereid en zet zich in om taken tot een goed einde te brengen, is bereid een extra inspanning te leveren indien gevraagd",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000040"),
					CompetenceId = compTwo,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student is voorbereid en zet zich in om taken tot een goed einde te brengen, is bereid een extra inspanning te leveren indien gevraagd",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000041"),
					CompetenceId = compTwo,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student ziet werk, neemt spontaan taken op, toont verantwoordelijkheid en ownership, levert spontaan een gepaste extra inspanning",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000042"),
					CompetenceId = compTwo,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student ziet werk, neemt spontaan taken op, toont verantwoordelijkheid en ownership, levert spontaan een gepaste extra inspanning",
					ScaleValueScore = 7
				},

				//Third competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000043"),
					CompetenceId = compThree,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student werkt chaotisch, haalt deadlines niet. Werkt systematisch slordig en te traag",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000044"),
					CompetenceId = compThree,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student heeft het moeilijk met plannen en organiseren. Heeft regelmatig bijsturing en hulp nodig bij planning en organisatie",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000045"),
					CompetenceId = compThree,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student heeft het moeilijk met plannen en organiseren. Heeft regelmatig bijsturing en hulp nodig bij planning en organisatie",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000046"),
					CompetenceId = compThree,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student kan het werk plannen en organiseren, heeft een goed werkritme",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000047"),
					CompetenceId = compThree,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student kan het werk plannen en organiseren, heeft een goed werkritme",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000048"),
					CompetenceId = compThree,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student is proactief in het plannen en organiseren van het werk, werkt heel nauwkeurig en efficiënt",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000049"),
					CompetenceId = compThree,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student is proactief in het plannen en organiseren van het werk, werkt heel nauwkeurig en efficiënt",
					ScaleValueScore = 7
				},

				//Fourth competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000050"),
					CompetenceId = compFour,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student heeft een rigide houding, kan zich niet aanpassen aan onverwachte wijzigingen, kan niet schakelen tussen taken",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000051"),
					CompetenceId = compFour,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student heeft het moeilijk met onverwachte wijzigingen, heeft tijd nodig, kan moeilijk schakelen tussen taken",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000052"),
					CompetenceId = compFour,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student heeft het moeilijk met onverwachte wijzigingen, heeft tijd nodig, kan moeilijk schakelen tussen taken",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000053"),
					CompetenceId = compFour,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student kan omgaan met onverwachte wijzigingen, is flexibel, kan schakelen indien nodig",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000054"),
					CompetenceId = compFour,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student kan omgaan met onverwachte wijzigingen, is flexibel, kan schakelen indien nodig",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000055"),
					CompetenceId = compFour,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student is zeer flexibel, schakelt spontaan en is vooruitziend",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000056"),
					CompetenceId = compFour,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student is zeer flexibel, schakelt spontaan en is vooruitziend",
					ScaleValueScore = 7
				},

				//Fifth competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000057"),
					CompetenceId = compFive,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student wordt emotioneel overspoeld, blokkeert, bevriest, loopt weg van moeilijkheden, reageert ongepast",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000058"),
					CompetenceId = compFive,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student reageert vaak onaangepast (ontwijken, rationaliseren, minimaliseren, negeren)",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000059"),
					CompetenceId = compFive,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student reageert vaak onaangepast (ontwijken, rationaliseren, minimaliseren, negeren)",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000060"),
					CompetenceId = compFive,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student herkent stressoren en zoekt naar een gepaste manier om hier mee om te gaan",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000061"),
					CompetenceId = compFive,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student herkent stressoren en zoekt naar een gepaste manier om hier mee om te gaan",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000062"),
					CompetenceId = compFive,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student is weerbaar en veerkrachtig",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000063"),
					CompetenceId = compFive,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student is weerbaar en veerkrachtig",
					ScaleValueScore = 7
				},

				//Sixth competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000064"),
					CompetenceId = compSix,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student is angstig, gaat leermogelijkheden hierdoor uit de weg, durft comfortzone niet verlaten, toont vermijdingsgedrag. Student is ongepast zelfzeker, voelt de rol als stagiair(e) niet aan. Geen communicatie over groeiproces",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000065"),
					CompetenceId = compSix,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student heeft voortdurend aanmoediging en bevestiging nodig om comfortzone te verlaten. Student moet gewezen worden op een gepaste houding als stagiair(e). Weinig communicatie over groeiproces",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000066"),
					CompetenceId = compSix,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student heeft voortdurend aanmoediging en bevestiging nodig om comfortzone te verlaten. Student moet gewezen worden op een gepaste houding als stagiair(e). Weinig communicatie over groeiproces",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000067"),
					CompetenceId = compSix,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student kan met voldoende zelfvertrouwen taken uitvoeren, heeft soms een aanmoediging of zetje nodig. Student communiceert over eigen groeiproces",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000068"),
					CompetenceId = compSix,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student kan met voldoende zelfvertrouwen taken uitvoeren, heeft soms een aanmoediging of zetje nodig. Student communiceert over eigen groeiproces",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000069"),
					CompetenceId = compSix,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student functioneert met zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan. Communiceert spontaan over groeiproces",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000070"),
					CompetenceId = compSix,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student functioneert met zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan. Communiceert spontaan over groeiproces",
					ScaleValueScore = 7
				},

				//Seventh competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000071"),
					CompetenceId = compSeven,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student heeft voortdurend aansturing nodig",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000072"),
					CompetenceId = compSeven,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student kan taken nog onvoldoende zelfstandig uitvoeren, vraagt nog begeleiding",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000073"),
					CompetenceId = compSeven,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student kan taken nog onvoldoende zelfstandig uitvoeren, vraagt nog begeleiding",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000074"),
					CompetenceId = compSeven,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student kan met zelfvertrouwen en zelfzekerheid taken uitvoeren",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000075"),
					CompetenceId = compSeven,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student kan met zelfvertrouwen en zelfzekerheid taken uitvoeren",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000076"),
					CompetenceId = compSeven,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student functioneert met grote zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan, functioneert als beginnend beroepsbeoefenaar",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000077"),
					CompetenceId = compSeven,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student functioneert met grote zelfzekerheid en zelfvertrouwen en stuurt het eigen leerproces spontaan aan, functioneert als beginnend beroepsbeoefenaar",
					ScaleValueScore = 7
				},

				//Eighth competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000078"),
					CompetenceId = compEight,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student is passief en afwachtend",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000079"),
					CompetenceId = compEight,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student heeft vaak nog aansporing nodig om bijdragen te leveren. Student blijft eerder terughoudend",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000080"),
					CompetenceId = compEight,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student heeft vaak nog aansporing nodig om bijdragen te leveren. Student blijft eerder terughoudend",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000081"),
					CompetenceId = compEight,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student kan meedenken, is kritisch en verwoordt spontaan eigen ideeën, durft suggesties te geven. Kan ideeën en voorstellen uitwerken",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000082"),
					CompetenceId = compEight,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student kan meedenken, is kritisch en verwoordt spontaan eigen ideeën, durft suggesties te geven. Kan ideeën en voorstellen uitwerken",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000083"),
					CompetenceId = compEight,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student is in staat om ideeën voor te stellen en uit te voeren, gaat hierbij kritisch te werk en koppelt terug",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000084"),
					CompetenceId = compEight,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student is in staat om ideeën voor te stellen en uit te voeren, gaat hierbij kritisch te werk en koppelt terug",
					ScaleValueScore = 7
				},

				//Tenth competence (Start Domain 2)
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000085"),
					CompetenceId = compTen,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student is meermaals onrespectvol tegenover gevoelens en opvattingen van de cliënt/klant. Toont weinig empathie. Is brutaal in zijn handelen. Heeft weinig oog voor maatschappelijke diversiteit. Maakt meermaals deontologische fouten",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000086"),
					CompetenceId = compTen,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student is soms onrespectvol, tegenover gevoelens en opvattingen van de cliënt/klant, maar kan zichzelf corrigeren op vraag van de mentor",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000087"),
					CompetenceId = compTen,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student is soms onrespectvol, tegenover gevoelens en opvattingen van de cliënt/klant, maar kan zichzelf corrigeren op vraag van de mentor",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000088"),
					CompetenceId = compTen,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student handelt respectvol en zorgzaam tegenover gevoelens en opvattingen van de cliënt/klant. Kan zich inleven in de situatie van de cliënt/klant en toont dit in zijn handelen. Heeft een respectvolle houding tegenover maatschappelijke diversiteit. Handelt naar de deontologische code",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000089"),
					CompetenceId = compTen,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student handelt respectvol en zorgzaam tegenover gevoelens en opvattingen van de cliënt/klant. Kan zich inleven in de situatie van de cliënt/klant en toont dit in zijn handelen. Heeft een respectvolle houding tegenover maatschappelijke diversiteit. Handelt naar de deontologische code",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000090"),
					CompetenceId = compTen,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student toont voorbeeldgedrag op vlak van respect, empathie en divers-sensitief handelen. Is pro-actief in het benaderen van een moeilijke cliënt/klant",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000091"),
					CompetenceId = compTen,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student toont voorbeeldgedrag op vlak van respect, empathie en divers-sensitief handelen. Is pro-actief in het benaderen van een moeilijke cliënt/klant",
					ScaleValueScore = 7
				},

				//Eleventh competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000092"),
					CompetenceId = compEleven,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student isoleert zich en deelt onvoldoende informatie met collega’s of relevante anderen. Neemt een eerder gesloten houding aan in het team",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000093"),
					CompetenceId = compEleven,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student participeert vooral op vraag van de andere(n). Neemt een houding aan die communicatie en samenwerking bemoeilijkt",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000094"),
					CompetenceId = compEleven,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student participeert vooral op vraag van de andere(n). Neemt een houding aan die communicatie en samenwerking bemoeilijkt",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000095"),
					CompetenceId = compEleven,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student deelt informatie met collega’s en derden volgens de op de werkvloer geldende protocollen en afspraken. Ageert vanuit een open, respectvolle en constructieve houding. Spreekt relevante disciplines binnen de organisatie aan",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000096"),
					CompetenceId = compEleven,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student deelt informatie met collega’s en derden volgens de op de werkvloer geldende protocollen en afspraken. Ageert vanuit een open, respectvolle en constructieve houding. Spreekt relevante disciplines binnen de organisatie aan",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000097"),
					CompetenceId = compEleven,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student deelt spontaan informatie en onderhoudt spontaan goede contacten. Zet bruikbare ondersteunende samenwerkingsverbanden en/of netwerken op. Is een volwaardig teamlid in de organisatie",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000098"),
					CompetenceId = compEleven,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student deelt spontaan informatie en onderhoudt spontaan goede contacten. Zet bruikbare ondersteunende samenwerkingsverbanden en/of netwerken op. Is een volwaardig teamlid in de organisatie",
					ScaleValueScore = 7
				},

				//Twelfth competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000099"),
					CompetenceId = compTwelve,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student is niet in staat op zijn professioneel handelen te reflecteren. Reageert veelal defensief bij het ontvangen van feedback. Stuurt gedrag onvoldoende bij",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000100"),
					CompetenceId = compTwelve,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student heeft weinig inzicht in zijn professioneel handelen. Student reageert vaak defensief. Student is wisselend in het bijsturen van gedrag",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000101"),
					CompetenceId = compTwelve,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student heeft weinig inzicht in zijn professioneel handelen. Student reageert vaak defensief. Student is wisselend in het bijsturen van gedrag",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000102"),
					CompetenceId = compTwelve,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student reflecteert op zijn professioneel handelen. Gaat constructief om met ontvangen feedback. Geeft het eigen handelen vorm en stuurt zijn gedrag bij vanuit een kritische en reflectieve houding",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000103"),
					CompetenceId = compTwelve,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student reflecteert op zijn professioneel handelen. Gaat constructief om met ontvangen feedback. Geeft het eigen handelen vorm en stuurt zijn gedrag bij vanuit een kritische en reflectieve houding",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000104"),
					CompetenceId = compTwelve,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Integreert spontaan een reflectieve houding in het professioneel handelen. Benut momenten van overleg om op gepaste wijze feedback te ontvangen en te geven aan anderen",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000105"),
					CompetenceId = compTwelve,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Integreert spontaan een reflectieve houding in het professioneel handelen. Benut momenten van overleg om op gepaste wijze feedback te ontvangen en te geven aan anderen",
					ScaleValueScore = 7
				},

				//Thirteenth competence (start Domain 3)
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000106"),
					CompetenceId = compThirteen,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student slaagt er niet in (fasen van) het psychodiagnostisch proces correct uit te voeren. Mist systematisch nauwkeurigheid en kritische zin. Taalgebruik is onvoldoende correct en professioneel",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000107"),
					CompetenceId = compThirteen,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student is wisselend in het uitvoeren van (fasen van) het psychodiagnostisch proces. Is af en toe onnauwkeurig. Heeft bijsturing nodig",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000108"),
					CompetenceId = compThirteen,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student is wisselend in het uitvoeren van (fasen van) het psychodiagnostisch proces. Is af en toe onnauwkeurig. Heeft bijsturing nodig",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000109"),
					CompetenceId = compThirteen,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student kan elke relevante fase van het psychodiagnostisch proces op een voldoende wijze uitvoeren. Kan nog groeien in het uitvoeren van bepaalde fasen. Kan nog groeien in gebruik van correcte en professionele taal",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000110"),
					CompetenceId = compThirteen,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student kan elke relevante fase van het psychodiagnostisch proces op een voldoende wijze uitvoeren. Kan nog groeien in het uitvoeren van bepaalde fasen. Kan nog groeien in gebruik van correcte en professionele taal",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000111"),
					CompetenceId = compThirteen,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "e student kan elke relevante fase van het psychodiagnostisch proces met kritische zin en nauwkeurigheid uitvoeren. Hanteert correcte en professionele taal",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000112"),
					CompetenceId = compThirteen,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "e student kan elke relevante fase van het psychodiagnostisch proces met kritische zin en nauwkeurigheid uitvoeren. Hanteert correcte en professionele taal",
					ScaleValueScore = 7
				},

				//Fourteenth competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000113"),
					CompetenceId = compFourteen,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student slaagt er niet in het onderzoeksproces correct uit te voeren. Mist systematisch nauwkeurigheid en kritische zin. Taalgebruik is onvoldoende correct en professioneel",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000114"),
					CompetenceId = compFourteen,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student is wisselend in het uitvoeren van het onderzoeksproces. Is af en toe onnauwkeurig. Heeft bijsturing nodig",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000115"),
					CompetenceId = compFourteen,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student is wisselend in het uitvoeren van het onderzoeksproces. Is af en toe onnauwkeurig. Heeft bijsturing nodig",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000116"),
					CompetenceId = compFourteen,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student kan het onderzoeksproces op een voldoende wijze uitvoeren. Kan nog groeien in het gebruik van correcte en professionele taal",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000117"),
					CompetenceId = compFourteen,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student kan het onderzoeksproces op een voldoende wijze uitvoeren. Kan nog groeien in het gebruik van correcte en professionele taal",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000118"),
					CompetenceId = compFourteen,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "De student kan elke fase van het onderzoeksproces met kritische zin en nauwkeurigheid uitvoeren",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000119"),
					CompetenceId = compFourteen,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "De student kan elke fase van het onderzoeksproces met kritische zin en nauwkeurigheid uitvoeren",
					ScaleValueScore = 7
				},

				//Fifteenth competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000120"),
					CompetenceId = compFifteen,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "De student slaagt er niet in om op basis van een psychodiagnostisch of onderzoeksproces een relevante bijdrage te leveren bij het ontwikkelen van een handelings-/preventieplan",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000121"),
					CompetenceId = compFifteen,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "De student heeft veel ondersteuning nodig om op basis van een psychodiagnostisch of onderzoeksproces een relevante bijdrage te kunnen leveren bij het ontwikkelen van een handelings-/preventieplan",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000122"),
					CompetenceId = compFifteen,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "De student heeft veel ondersteuning nodig om op basis van een psychodiagnostisch of onderzoeksproces een relevante bijdrage te kunnen leveren bij het ontwikkelen van een handelings-/preventieplan",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000123"),
					CompetenceId = compFifteen,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "De student kan op basis van een psychodiagnostisch of onderzoeksproces een bijdrage leveren bij het ontwikkelen van een goed handelings-/preventieplan",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000124"),
					CompetenceId = compFifteen,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "De student kan op basis van een psychodiagnostisch of onderzoeksproces een bijdrage leveren bij het ontwikkelen van een goed handelings-/preventieplan",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000125"),
					CompetenceId = compFifteen,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "De student kan op basis van een psychodiagnostisch of onderzoeksproces zelfstandig een goed handelings-/preventieplan ontwikkelen",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000126"),
					CompetenceId = compFifteen,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "De student kan op basis van een psychodiagnostisch of onderzoeksproces zelfstandig een goed handelings-/preventieplan ontwikkelen",
					ScaleValueScore = 7
				},

				//Sixteenth competence (start Domain 4)
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000127"),
					CompetenceId = compSixteen,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student slaagt er niet in om op een heldere en gestructureerde manier informatie over te brengen en/of te presenteren",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000128"),
					CompetenceId = compSixteen,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student heeft veel ondersteuning nodig om op een heldere en gestructureerde manier informatie over te brengen en/of te presenteren",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000129"),
					CompetenceId = compSixteen,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student heeft veel ondersteuning nodig om op een heldere en gestructureerde manier informatie over te brengen en/of te presenteren",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000130"),
					CompetenceId = compSixteen,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student kan informatie op een didactisch verantwoorde wijze geven en/of presenteren: dit is rekening houdend met doelgroep, valkuilen van het instrument dat ze gebruiken, etc. Kan nog groeien in zelfvertrouwen en overtuigingskracht",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000131"),
					CompetenceId = compSixteen,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student kan informatie op een didactisch verantwoorde wijze geven en/of presenteren: dit is rekening houdend met doelgroep, valkuilen van het instrument dat ze gebruiken, etc. Kan nog groeien in zelfvertrouwen en overtuigingskracht",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000132"),
					CompetenceId = compSixteen,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student kan informatie op een heldere en toegankelijke manier geven en/of presenteren. Kan met veel zelfvertrouwen en overtuigingskracht informatie geven en/of presenteren",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000133"),
					CompetenceId = compSixteen,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student kan informatie op een heldere en toegankelijke manier geven en/of presenteren. Kan met veel zelfvertrouwen en overtuigingskracht informatie geven en/of presenteren",
					ScaleValueScore = 7
				},

				//Seventeenth competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000134"),
					CompetenceId = compSeventeen,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Student slaagt er niet in een begeleidingsrelatie met individuen en groepen op te bouwen. Ondersteunende gespreksvaardigheden (parafraseren, empathisch gissen, etc) worden onvoldoende benut",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000135"),
					CompetenceId = compSeventeen,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Student is wisselend in het opbouwen van een begeleidingsrelatie met individuen en groepen. Student is wisselend in het benutten van ondersteunende gespreksvaardigheden",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000136"),
					CompetenceId = compSeventeen,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Student is wisselend in het opbouwen van een begeleidingsrelatie met individuen en groepen. Student is wisselend in het benutten van ondersteunende gespreksvaardigheden",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000137"),
					CompetenceId = compSeventeen,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Student past ondersteunende gespreksvaardigheden toe bij individuen en groepen (parafraseren, empathisch gissen, etc). Bouwt een begeleidingsrelatie op met individuen en groepen waarin 'warm aanwezig zijn' centraal staat",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000138"),
					CompetenceId = compSeventeen,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Student past ondersteunende gespreksvaardigheden toe bij individuen en groepen (parafraseren, empathisch gissen, etc). Bouwt een begeleidingsrelatie op met individuen en groepen waarin 'warm aanwezig zijn' centraal staat",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000139"),
					CompetenceId = compSeventeen,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Student past ondersteunende gespreksvaardigheden toe op een vlotte en natuurlijke wijze. Heeft vanuit zichzelf een warm aanwezige en authentieke houding",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000140"),
					CompetenceId = compSeventeen,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Student past ondersteunende gespreksvaardigheden toe op een vlotte en natuurlijke wijze. Heeft vanuit zichzelf een warm aanwezige en authentieke houding",
					ScaleValueScore = 7
				},

				//Eighteenth competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000141"),
					CompetenceId = compEighteen,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Past counselingstechnieken niet of systematisch foutief toe",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000142"),
					CompetenceId = compEighteen,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Past counselingtechnieken wel toe, maar kwaliteit van uitvoering is wisselend",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000143"),
					CompetenceId = compEighteen,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Past counselingtechnieken wel toe, maar kwaliteit van uitvoering is wisselend",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000144"),
					CompetenceId = compEighteen,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Helpt de cliënt inzicht te verwerven in zichzelf en zijn situatie. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Kan counselingtechnieken toepassen",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000145"),
					CompetenceId = compEighteen,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Helpt de cliënt inzicht te verwerven in zichzelf en zijn situatie. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Kan counselingtechnieken toepassen",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000146"),
					CompetenceId = compEighteen,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Past op effectieve wijze counselingtechnieken toe in gesprekken. Zet aan tot inzichtsverandering. Zet in op empowerment. Zet in op zelfredzaamheid",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000147"),
					CompetenceId = compEighteen,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Past op effectieve wijze counselingtechnieken toe in gesprekken. Zet aan tot inzichtsverandering. Zet in op empowerment. Zet in op zelfredzaamheid",
					ScaleValueScore = 7
				},

				//Nineteenth competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000148"),
					CompetenceId = compNineteen,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Slaagt er niet in een bestaande training uit te voeren. Zowel inhoudelijk als groepsdynamisch is de training ontoereikend uitgevoerd",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000149"),
					CompetenceId = compNineteen,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Slaagt erin een bestaande training uit te voeren, maar heeft weinig oog voor groepsdynamische processen en/of is weinig flexibel in uitvoering",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000150"),
					CompetenceId = compNineteen,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Slaagt erin een bestaande training uit te voeren, maar heeft weinig oog voor groepsdynamische processen en/of is weinig flexibel in uitvoering",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000151"),
					CompetenceId = compNineteen,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Traint personen op een resultaatsgerichte en persoonlijke wijze om vaardigheden aan te leren. Draagt op een didactisch verantwoorde wijze kennis en inzichten over in een veilige en vertrouwde context, al dan niet samen met een collega of supervisor",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000152"),
					CompetenceId = compNineteen,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Traint personen op een resultaatsgerichte en persoonlijke wijze om vaardigheden aan te leren. Draagt op een didactisch verantwoorde wijze kennis en inzichten over in een veilige en vertrouwde context, al dan niet samen met een collega of supervisor",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000153"),
					CompetenceId = compNineteen,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Kiest een geschikte training, past die aan of stelt die samen in functie van de vraag, op basis van duidelijke kwaliteitscriteria. Toont flexibiliteit in uitvoering, hanteert groepsdynamische processen en enthousiasmeert. Toetst actief af wat het effect is van de training op de deelnemers",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000154"),
					CompetenceId = compNineteen,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Kiest een geschikte training, past die aan of stelt die samen in functie van de vraag, op basis van duidelijke kwaliteitscriteria. Toont flexibiliteit in uitvoering, hanteert groepsdynamische processen en enthousiasmeert. Toetst actief af wat het effect is van de training op de deelnemers",
					ScaleValueScore = 7
				},

				//Twentieth competence
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000155"),
					CompetenceId = compTwenty,
					Created = DateTime.Now,
					ScaleValue = realBad,
					Description = "Past coachingstechnieken niet of systematisch foutief toe",
					ScaleValueScore = 1
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000156"),
					CompetenceId = compTwenty,
					Created = DateTime.Now,
					ScaleValue = bad,
					Description = "Past coachingstechnieken toe, maar kwaliteit van uitvoering is wisselend en/of deze bereiken onvoldoende hun doel",
					ScaleValueScore = 2
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000157"),
					CompetenceId = compTwenty,
					Created = DateTime.Now,
					ScaleValue = prettyBad,
					Description = "Past coachingstechnieken toe, maar kwaliteit van uitvoering is wisselend en/of deze bereiken onvoldoende hun doel",
					ScaleValueScore = 3
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000158"),
					CompetenceId = compTwenty,
					Created = DateTime.Now,
					ScaleValue = alright,
					Description = "Helpt de cliënt inzicht te verwerven in zichzelf, gewenste doelen en mogelijke stappen om deze te realiseren. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Maakt gebruik van coachingstechnieken waar nodig",
					ScaleValueScore = 4
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000159"),
					CompetenceId = compTwenty,
					Created = DateTime.Now,
					ScaleValue = good,
					Description = "Helpt de cliënt inzicht te verwerven in zichzelf, gewenste doelen en mogelijke stappen om deze te realiseren. Kan een stabiele en constructieve werkrelatie opbouwen met cliënt/klant. Maakt gebruik van coachingstechnieken waar nodig",
					ScaleValueScore = 5
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000160"),
					CompetenceId = compTwenty,
					Created = DateTime.Now,
					ScaleValue = veryGood,
					Description = "Past op effectieve en doelmatige wijze coachingstechnieken toe en slaagt erin cliënt tot verandering te brengen",
					ScaleValueScore = 6
				},
				new Indicator
				{
					Id = Guid.Parse("00000000-0000-0000-0000-000000000161"),
					CompetenceId = compTwenty,
					Created = DateTime.Now,
					ScaleValue = great,
					Description = "Past op effectieve en doelmatige wijze coachingstechnieken toe en slaagt erin cliënt tot verandering te brengen",
					ScaleValueScore = 7
				}

			};

			List<Indicator> endEvaluationIndicators = indicators.Select(i => new Indicator
			{
				Id = Guid.Parse(i.Id.ToString().Replace("0", "a")),
				CompetenceId = Guid.Parse(i.CompetenceId.ToString().Replace("0", "e")),
				Created = DateTime.Now,
				ScaleValue = i.ScaleValue,
				Description = i.Description,
				ScaleValueScore = i.ScaleValueScore
			}).ToList();
			#endregion

			//hardcoded user for dev testing purposes, to be deleted once register implemented
			Guid testUserId = Guid.Parse("00000000-0000-0000-0000-000000000001");

            var users = new List<ApplicationUser>
			{
				new ApplicationUser
				{
					Id = testUserId,
					Role = RoleTypes.Student.ToString(),
					Username="test@test.com",
					Created = DateTime.Now
				}
			};

			var ApplicationUserModule = new List<ApplicationUserModule>
			{
				new ApplicationUserModule
				{
					ApplicationUserId = testUserId,
					ModuleId = moduleId
                }
			};



            modelBuilder.Entity<ApplicationUser>().HasData(users);
            modelBuilder.Entity<Module>().HasData(modules);
			modelBuilder.Entity<Evaluation>().HasData(evaluations);
			modelBuilder.Entity<CompetenceDomain>().HasData(domains);
			modelBuilder.Entity<Competence>().HasData(competences);
			modelBuilder.Entity<Indicator>().HasData(indicators);
			modelBuilder.Entity<Indicator>().HasData(endEvaluationIndicators);
        }
	}
}