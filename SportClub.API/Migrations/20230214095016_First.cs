using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportClub.API.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkOutId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    IsOutside = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workouts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Capacity", "IsOutside", "Name" },
                values: new object[,]
                {
                    { 1, "Brouwmeesterstraat 10 Breda", 25, false, "ApenkooiGym" },
                    { 2, "Wilderen 2, 4817 VG Breda", 20, true, "Wilderen 2 Breda" },
                    { 3, "Spinveld 66 A1 Breda", 60, false, "Boulderhal Bruut" },
                    { 4, "Nieuwe Inslag 99, 4817 GN Breda", 30, true, "BRESS Sportcentrum, Dance Studio 1" },
                    { 5, "Nieuwe Inslag 99, 4817 GN Breda", 20, true, "BRESS Sportcentrum, Dance Studio 2" },
                    { 6, "Nieuwe Inslag 99, 4817 GN Breda", 25, false, "BRESS Sportcentrum, Fitness" },
                    { 7, "Pastoor Pottersplein 12, 4815 BC Breda", 25, true, "Belcrumhuis" },
                    { 8, "Terheijdenseweg 508 Breda", 16, true, "TVBN Tennisvereniging Breda Noord" },
                    { 9, "Dr. Schaepmanlaan 4 Breda", 16, false, "Atletiekvereniging SPRINT" },
                    { 10, "Teteringsedijk 145, 4817 MD Breda", 12, false, "Ortega Diving" }
                });

            migrationBuilder.InsertData(
                table: "lessons",
                columns: new[] { "Id", "Instructor", "LocationId", "StartDateTime", "WorkOutId" },
                values: new object[,]
                {
                    { 1, "Marcel", 2, new DateTime(2023, 2, 14, 19, 30, 0, 0, DateTimeKind.Local), 1 },
                    { 2, "Coen", 4, new DateTime(2023, 2, 20, 18, 0, 0, 0, DateTimeKind.Local), 2 },
                    { 3, "Freek", 1, new DateTime(2023, 2, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "Miriam", 5, new DateTime(2023, 2, 20, 20, 0, 0, 0, DateTimeKind.Local), 5 },
                    { 5, "Marcel", 7, new DateTime(2023, 2, 18, 10, 0, 0, 0, DateTimeKind.Local), 6 },
                    { 6, "Laura", 9, new DateTime(2023, 2, 17, 19, 30, 0, 0, DateTimeKind.Local), 9 },
                    { 7, "Emilio", 6, new DateTime(2023, 2, 19, 11, 0, 0, 0, DateTimeKind.Local), 7 },
                    { 8, "Judith", 8, new DateTime(2023, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 9, "Eva", 9, new DateTime(2023, 2, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 10, "Suzanne", 10, new DateTime(2023, 2, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 11, "", 3, new DateTime(2023, 2, 20, 17, 0, 0, 0, DateTimeKind.Local), 4 },
                    { 12, "", 3, new DateTime(2023, 2, 14, 17, 0, 0, 0, DateTimeKind.Local), 4 },
                    { 13, "", 3, new DateTime(2023, 2, 15, 14, 0, 0, 0, DateTimeKind.Local), 4 },
                    { 14, "", 3, new DateTime(2023, 2, 16, 14, 0, 0, 0, DateTimeKind.Local), 4 },
                    { 15, "", 3, new DateTime(2023, 2, 17, 14, 0, 0, 0, DateTimeKind.Local), 4 },
                    { 16, "", 3, new DateTime(2023, 2, 18, 10, 0, 0, 0, DateTimeKind.Local), 4 },
                    { 17, "", 3, new DateTime(2023, 2, 19, 10, 0, 0, 0, DateTimeKind.Local), 4 }
                });

            migrationBuilder.InsertData(
                table: "workouts",
                columns: new[] { "Id", "Category", "Description", "Duration", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "conditie en kracht", "Bootcamp is groepstraining die conditie- en krachtoefeningen combineert en buiten plaatsvindt. Tijdens veel oefeningen wordt er gebruik gemaakt van eigen lichaamsgewicht en obstakels die in de omgeving aanwezig zijn, denk bijvoorbeeld aan bankjes, stoepranden en hekken. Sommige oefeningen doe je in tweetallen of in kleine groepjes, zodat je elkaar kunt gebruiken om bepaalde oefeningen uit te voeren en elkaar aan te moedigen. Samen bereik je meer!", 75, "https://bress.nl/wp-content/uploads/2022/05/Schermafbeelding-2022-05-23-om-16.47.36-1024x959.png", 2.5m, "Bootcamp" },
                    { 2, "kracht", "Tijdens de high intensity training BoxFit krijg je te maken met een combinatie van bokstechnieken en oefeningen met eigen lichaamsgewicht, waarbij fun en samenwerking centraal staat.", 60, "https://bress.nl/wp-content/uploads/2022/03/Schermafbeelding-2022-03-30-om-17.27.25-1022x1024.png", null, "BoxFit" },
                    { 3, "conditie en kracht", "Bij onze gymlessen maak je na een lange werkdag je hoofd weer even helemaal leeg. De nostalgie slaat zó hard in dat de smaak van Wicky spontaan weer te proeven is! Elke les bestaat uit een warming-up, een hoofdspel en een eindspel. De opgeleide meesters en juffen van ApenkooiGym doen er alles aan om jou zo hard mogelijk door de zaal te laten gieren. De ene keer is dat met Apenkooien, de andere keer met bestaande of zelfbedachte spellen als James Bond, het Grote Waterspektakel, Super Mario Kart of één van de vele varianten op trefbal. Al deze spellen zijn (her)uitgevonden voor volwassenen. Nooit kinderachtig, altijd met kinderlijk plezier. Door het trainen van je lachspieren heb je bijna niet in de gaten dat je met een aardige work-out bezig bent.", 75, "https://bress.nl/wp-content/uploads/2022/03/Schermafbeelding-2022-03-30-om-14.52.29-1024x854.png", 2.5m, "Gymmen" },
                    { 4, "conditie en kracht", "Boulderen is een spectaculaire vorm van klimmen en komt voort uit het beklimmen van rotsblokken. Anders dan bij klimmen heb je bij boulderen geen touw en klimgordels nodig. Dikke valmatten onder de routes zorgen voor veiligheid. De klimwanden in de boulderhal hebben een maximale hoogte van 4,5 meter en variëren van voorover neigend tot en met fors achterover hellend. Het is een sport voor vrijwel iedereen en kan zowel individueel als in groepsverband beoefend worden. Door de mix van de verschillende wanden en boulders kunnen zowel beginnende klimmers als gevorderden naast en met elkaar boulderen.", 120, "https://bress.nl/wp-content/uploads/2022/03/bouldering-2021-08-28-18-47-52-utc-scaled-e1650881591375-1024x530.jpg", 6.5m, "Boulderen" },
                    { 5, "cardio", "Spinning is een high intensity groepsles waarbij je op een leuke manier je conditie in hoog tempo verbetert. Je doet dit op een vaststaande fiets, met extra weerstand. Hoeveel weerstand? Dit bepaal je helemaal zelf! Hierdoor is deze les geschikt voor iedereen. De instructeur geeft instructies terwijl de muziek het tempo ondersteunt.", 60, "https://bress.nl/wp-content/uploads/2022/03/Schermafbeelding-2022-03-30-om-14.40.03-1024x939.png", null, "Spinning" },
                    { 7, "kracht", "Onze fitness beschikt over de up-to-date cardio- en krachtapparatuur van Matrix Fitness en daarnaast ook over een free weight area waar je alle ruimte hebt om (grond)oefeningen te doen of te trainen met dumbbells, barbells en andere materialen.", 90, "https://bress.nl/wp-content/uploads/2022/03/interior-of-fitness-hall-with-fitness-bicycles-2021-08-28-00-35-59-utc-1024x683.jpg", null, "Fitness" },
                    { 8, "balsport", "Tennis is een balsport voor twee spelers (enkelspel) of paren (dubbelspel). De tennisbal moet met een racket over een net op de speelhelft van de tegenspeler(s) geslagen worden. Het doel is om het de tegenspelers(s) onmogelijk te maken de bal terug te slaan.", 90, "https://bress.nl/wp-content/uploads/2022/03/tennis-racket-and-tennis-net-on-tennis-court-2021-09-03-12-45-52-utc-1024x683.jpg", null, "Tennis" },
                    { 9, "groepsles", "Aerial Silk is een unieke sport die zijn oorsprong kent in het circus. Tijdens het beoefenen van deze sport train je heel je lichaam en ontwikkel je evenwicht, kracht en flexibiliteit. Daarnaast krijg je echt een kick als je in de doeken hangt.", 90, "https://bress.nl/wp-content/uploads/2022/05/adult-woman-practices-anti-gravity-yoga-position-i-2022-02-02-03-49-35-utc-1024x683.jpg", null, "Aerial Silk" },
                    { 10, "groepsles", "Duiken is één van de snelst groeiende avontuurlijke sporten ter wereld en dat is niet zonder reden. Het ontspannen gevoel en het gevoel van gewichtloosheid (een gevoel dat verder alleen astronauten kunnen meemaken) maakt duiken tot een unieke sport. Duiken doe je altijd met minimaal 2 personen waardoor het ook nog eens een sociale sport is. Wist je trouwens dat het aardoppervlakte\r\nuit 70% water bestaat en dat er onder water meer verschillende soorten planten en dieren leven dan erboven? Er valt dus nog genoeg te ontdekken in de onderwaterwereld!", 90, "https://bress.nl/wp-content/uploads/2022/05/Schermafbeelding-2022-05-18-om-11.08.38-1024x327.png", null, "Duiken" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lessons");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "workouts");
        }
    }
}
