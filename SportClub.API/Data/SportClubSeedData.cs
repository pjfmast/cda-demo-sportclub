using SportClub.API.Entities;
using SportClub.API.Extensions;

namespace SportClub.API.Data
{

    public static class SportClubSeedData
    {
        // warning: The static field variable initializers of a class declaration correspond to a sequence of assignments that are executed in the textual order in which they appear in the class declaration. 

        private static DateTime today = DateTime.Now;

        #region individual locations
        private static int locationId = 1;

        private static Location bressSportcentrum = new Location()
        {
            Id = locationId++,
            Name = "BRESS Sportcentrum",
            Address = "Nieuwe Inslag 99",
            Capacity = 150,
            IsOutside = false
        };
        
        private static Location apenkooiGym = new Location()
        {
            Id = locationId++,
            Name = "ApenkooiGym",
            Address = "Brouwmeesterstraat 10 Breda",
            Capacity = 25,
            IsOutside = false
        };

        private static Location wilderen = new Location()
        {
            Id = locationId++,
            Name = "Wilderen 2 Breda",
            Address = "Wilderen 2, 4817 VG Breda",
            Capacity = 20,
            IsOutside = true
        };

        private static Location boulderhalBruut = new Location()
        {
            Id = locationId++,
            Name = "Boulderhal Bruut",
            Address = "Spinveld 66 A1 Breda",
            Capacity = 60,
            IsOutside = false
        };

        private static Location dansStudio1 = new Location()
        {
            Id = locationId++,
            Name = "BRESS Sportcentrum, Dance Studio 1",
            Address = "Nieuwe Inslag 99, 4817 GN Breda",
            Capacity = 30,
            IsOutside = true
        };

        private static Location dansStudio2 = new Location()
        {
            Id = locationId++,
            Name = "BRESS Sportcentrum, Dance Studio 2",
            Address = "Nieuwe Inslag 99, 4817 GN Breda",
            Capacity = 20,
            IsOutside = true
        };

        private static Location fitnessRoom = new Location()
        {
            Id = locationId++,
            Name = "BRESS Sportcentrum, Fitness",
            Address = "Nieuwe Inslag 99, 4817 GN Breda",
            Capacity = 25,
            IsOutside = false
        };

        private static Location belcrumhuis = new Location()
        {
            Id = locationId++,
            Name = "Belcrumhuis",
            Address = "Pastoor Pottersplein 12, 4815 BC Breda",
            Capacity = 25,
            IsOutside = true
        };

        private static Location tennisTVBN = new Location()
        {
            Id = locationId++,
            Name = "TVBN Tennisvereniging Breda Noord",
            Address = "Terheijdenseweg 508 Breda",
            Capacity = 16,
            IsOutside = true
        };

        private static Location paaldansStudio = new Location()
        {
            Id = locationId++,
            Name = "Atletiekvereniging SPRINT",
            Address = "Dr. Schaepmanlaan 4 Breda",
            Capacity = 16,
            IsOutside = false
        };

        private static Location teteringseDijk = new Location()
        {
            Id = locationId++,
            Name = "Ortega Diving",
            Address = "Teteringsedijk 145, 4817 MD Breda",
            Capacity = 12,
            IsOutside = false
        };


        #endregion
        public static readonly List<Location> Locations 
            = new List<Location>() {bressSportcentrum, apenkooiGym, boulderhalBruut, wilderen, dansStudio1, dansStudio2, belcrumhuis, fitnessRoom, tennisTVBN, paaldansStudio, teteringseDijk };



        #region individual workouts
        private static int workOutId = 1;
        private static Workout acroYoga = new Workout()
        {
            Id = workOutId++,
            Title = "Acro Yoga",
            Description = "Combineer yoga, Thaise massage en acrobatiek met elkaar en je hebt AcroYoga.",
            Category = "groepsles",
            Image = "https://bress.nl/wp-content/uploads/2022/05/couple-in-park-practising-pair-acro-yoga-2022-02-02-05-06-46-utc-scaled-e1653915380837-1024x407.jpg",
            Duration = 90
        };


        private static Workout aerialSilk = new Workout()
        {
            Id = workOutId++,
            Title = "Aerial Silk",
            Description = "Aerial Silk is een unieke sport die zijn oorsprong kent in het circus. Tijdens het beoefenen van deze sport train je heel je lichaam en ontwikkel je evenwicht, kracht en flexibiliteit. Daarnaast krijg je echt een kick als je in de doeken hangt.",
            Category = "groepsles",
            Image = "https://bress.nl/wp-content/uploads/2022/05/adult-woman-practices-anti-gravity-yoga-position-i-2022-02-02-03-49-35-utc-1024x683.jpg",
            Duration = 90
        };
        
        private static Workout atletiek = new Workout()
        {
            Id = workOutId++,
            Title = "Atletiek",
            Description = "Atletiek is samen met de zwemsport de oudste sport ter wereld en wordt ook wel ‘de moeder der sporten’ genoemd omdat het de menselijke basisbewegingen (lopen, springen en werpen) omvat. Bij atletiek moeten sporters (de atleten) op individueel of in groepen (estafette) presteren en kan zowel op de weg als op de atletiekbaan worden beoefend.",
            Category = "buiten sporten",
            Image = "https://bress.nl/wp-content/uploads/2022/05/Schermafbeelding-2022-05-30-om-14.36.33-1024x329.png",
            Duration = 75,
        };

        private static Workout badminton = new Workout()
        {
            Id = workOutId++,
            Title = "Badminton",
            Description = "Badminton is een Olympische sport die wordt gespeeld met een racket en een shuttle. De shuttle wordt over een net heen en weer geslagen met de rackets. Afhankelijk van met hoeveel personen je op de baan staat speel je een enkelspel of een dubbelspel. Bij een enkelspel speel je één tegen één en bij een dubbelspel twee tegen twee.",
            Category = "binnen sporten",
            Image = "https://bress.nl/wp-content/uploads/2022/03/277168663_7600580646633713_135095285667829979_n-1024x545.jpeg",
            Duration = 60,
        };


        private static Workout basketbal = new Workout()
        {
            Id = workOutId++,
            Title = "Basketbal",
            Description = "Basketbal is een van oorsprong Amerikaanse balsport waarbij je een bal moet veroveren en deze door de ring (de basket) van de tegenpartij moet gooien. Natuurlijk moet je proberen te voorkomen dat de tegenstander hetzelfde bij jou doet.\r\n\r\nTijdens de training op donderdagavond ligt de focus echt op het verbeteren van je balvaardigheid, techniek, regelkennis en tactiek en tijdens de training op de dinsdagavond worden er vriendschappelijke wedstrijden gespeeld (de teams worden ter plaatse gevormd).\r\n\r\nJe kunt het gehele jaar door bij beide trainingsmomenten aansluiten en je hoeft geen basketbal ervaring te hebben.",
            Category = "binnen sporten",
            Image = "https://bress.nl/wp-content/uploads/2022/05/DSC_8600-1024x684.jpg",
            Duration = 90,
        };

        private static Workout bbbAttack = new Workout()
        {
            Id = workOutId++,
            Title = "BBB-attack",
            Description = "Tijdens de BBB-attack staat het trainen van jouw buik, benen en billen centraal. Door oefeningen uit te voeren die zich focussen op deze 3 gebieden komen deze binnen no-time weer in shape!",
            Category = "binnen sporten",
            Image = "https://bress.nl/wp-content/uploads/2022/05/man-doing-sit-ups-2021-08-26-15-34-39-utc-scaled-e1653393049902-1024x538.jpg",
            Duration = 45,
        };

        private static Workout beachTennis = new Workout()
        {
            Id = workOutId++,
            Title = "Beachtennis",
            Description = "Wie kent het spelletje met de 2 rackets en het kleine plastic balletje voor op het strand of op de camping niet? Inmiddels is dit spelletje geëvolueerd in een echte sport, genaamd beachtennis. Beachtennis is een snelgroeiende beachsport die zijn oorsprong vindt in Amerika en Brazilië. Het grote verschil met reguliere tennis is dat er bij beachtennis geen ingewikkelde lijnen zijn; met de buitenlijnen en een net ben je al klaar!",
            Category = "buiten sporten",
            Image = "https://bress.nl/wp-content/uploads/2022/05/beach-tennis-player-at-the-net-2021-08-29-19-24-52-utc-1024x683.jpg",
            Duration = 120,
            Price = 12M,
        };

        private static Workout beachVolleybal = new Workout()
        {
            Id = workOutId++,
            Title = "Beachvolleybal",
            Description = "Beachvolleybal wordt gespeeld in zand en in tegenstelling tot normaal volleybal bestaat een team (officieel) maar uit 2 spelers. Twee andere grote verschillen zijn dat de spelers geen vaste posities in het veld hebben en dat de bal zwaarder en zachter is.",
            Category = "buiten sporten",
            Image = "https://bress.nl/wp-content/uploads/2022/05/a-beach-volleyball-net-on-the-beach-with-a-clear-a-2022-02-03-11-46-59-utc-1024x696.jpg",
            Duration = 90,
            Price = 10M,
        };

        private static Workout bodyAndMind = new Workout()
        {
            Id = workOutId++,
            Title = "Body and mind",
            Description = "Ben jij wel toe aan wat ontspanning maar wil je tegelijkertijd wel je lichaam trainen? Volg dan de Body & Mind les van Robert. Tijdens deze les leer je gecontroleerd te ademhalen en verbeter je je flexibiliteit en statische kracht. Dankzij de meditatie oefeningen verbeter je ook nog eens je concentratie. Alle oefeningen worden uitgevoerd met rustgevende muziek op de achtergrond maar vergis je niet; dit is absoluut geen suffe les!",
            Category = "binnen sporten",
            Image = "https://bress.nl/wp-content/uploads/2022/05/girl-in-black-sport-clothes-have-planking-exercise-2021-08-30-00-36-32-utc-1024x683.jpg",
            Duration = 50,
        };

        private static Workout bodyshape = new Workout()
        {
            Id = workOutId++,
            Title = "Bodyshape",
            Description = "Bodyshape is al jaren één van de populairste groepslessen van BRESS. Deze les start met pittige aerobics oefeningen gevolgd door een blok spierversterkende oefeningen. De ideale combinatie!\r\n\r\nDe aerobics oefeningen worden uitgevoerd op uptempo Dance muziek. Tijdens de spierversterkende oefeningen worden vooral de grote spiergroepen aangepakt waardoor de vetverbranding optimaal wordt. Onder andere oefeningen als lunges, squats, crunches, planken, leg lifts, hip thrusts en push-ups komen aan bod.",
            Category = "binnen sporten",
            Image = "https://bress.nl/wp-content/uploads/2022/05/Schermafbeelding-2022-05-23-om-16.59.44-1024x326.png",
            Duration = 60,
        };

        private static Workout boogschieten = new Workout()
        {
            Id = workOutId++,
            Title = "Boogschieten",
            Description = "Boogschieten is een sport waarbij pijlen worden weggeschoten naar een doel met behulp van een boog. Hoewel vroeger de pijl en boog werd gebruikt als jacht- en oorlogswapen, is boogschieten tegenwoordig vooral een concentratiesport. Bij iedere te schieten pijl moet je het maximale halen uit je concentratie, schiethouding, ademhaling en techniek.",
            Category = "binnen sporten",
            Image = "https://bress.nl/wp-content/uploads/2022/05/powerful-female-archer-aiming-with-bow-and-arrow-2021-11-02-17-54-36-utc-1024x576.jpg",
            Duration = 60,
            Price = 50M
        };


        private static Workout bootcamp = new Workout()
        {
            Id = workOutId++,
            Title = "Bootcamp",
            Description = "Bootcamp is groepstraining die conditie- en krachtoefeningen combineert en buiten plaatsvindt. Tijdens veel oefeningen wordt er gebruik gemaakt van eigen lichaamsgewicht en obstakels die in de omgeving aanwezig zijn, denk bijvoorbeeld aan bankjes, stoepranden en hekken. Sommige oefeningen doe je in tweetallen of in kleine groepjes, zodat je elkaar kunt gebruiken om bepaalde oefeningen uit te voeren en elkaar aan te moedigen. Samen bereik je meer!",
            Category = "conditie en kracht",
            Image = "https://bress.nl/wp-content/uploads/2022/05/Schermafbeelding-2022-05-23-om-16.47.36-1024x959.png",
            Duration = 75,
            Price = 2.5M,
        };

        private static Workout bootcampObstacleTraining = new Workout()
        {
            Id = workOutId++,
            Title = "Bootcamp & Obstacle Training",
            Description = "Sta jij ingeschreven voor een obstacle event en wil je hiervoor trainen? Of houd je gewoon van buiten sporten en vind je het tof om bootcamp te combineren met het klimmen over obstakels? Wat het ook is; de bootcamp & obstacle training heeft het allemaal! Deze training is een unieke combinatie van intensieve motivatie, stimulans en gezelligheid in groepsverband, dit alles in de buitenlucht. Tijdens een training ga je hardlopen en o.a. krachtoefeningen, circuit- en TRX-trainingen doen, gevolgd door één (of meerdere) rondje(s) over de obstacle baan.",
            Category = "conditie en kracht",
            Image = "https://bress.nl/wp-content/uploads/2022/05/fit-people-performing-crunches-exercise-2021-08-28-17-57-48-utc-scaled-e1653317042267-1024x540.jpg",
            Duration = 75,
            Price = 2.5M,
        };

        private static Workout boulderen = new Workout()
        {
            Id = workOutId++,
            Title = "Boulderen",
            Description = "Boulderen is een spectaculaire vorm van klimmen en komt voort uit het beklimmen van rotsblokken. Anders dan bij klimmen heb je bij boulderen geen touw en klimgordels nodig. Dikke valmatten onder de routes zorgen voor veiligheid. De klimwanden in de boulderhal hebben een maximale hoogte van 4,5 meter en variëren van voorover neigend tot en met fors achterover hellend. Het is een sport voor vrijwel iedereen en kan zowel individueel als in groepsverband beoefend worden. Door de mix van de verschillende wanden en boulders kunnen zowel beginnende klimmers als gevorderden naast en met elkaar boulderen.",
            Category = "conditie en kracht",
            Image = "https://bress.nl/wp-content/uploads/2022/03/bouldering-2021-08-28-18-47-52-utc-scaled-e1650881591375-1024x530.jpg",
            Duration = 120,
            Price = 6.5M
        };

        private static Workout boxFit = new Workout()
        {
            Id = workOutId++,
            Title = "BoxFit",
            Description = "Tijdens de high intensity training BoxFit krijg je te maken met een combinatie van bokstechnieken en oefeningen met eigen lichaamsgewicht, waarbij fun en samenwerking centraal staat.",
            Category = "kracht",
            Image = "https://bress.nl/wp-content/uploads/2022/03/Schermafbeelding-2022-03-30-om-17.27.25-1022x1024.png",
            Duration = 60
        };

        private static Workout gymmen = new Workout()
        {
            Id = workOutId++,
            Title = "Gymmen",
            Description = "Bij onze gymlessen maak je na een lange werkdag je hoofd weer even helemaal leeg. De nostalgie slaat zó hard in dat de smaak van Wicky spontaan weer te proeven is! Elke les bestaat uit een warming-up, een hoofdspel en een eindspel. De opgeleide meesters en juffen van ApenkooiGym doen er alles aan om jou zo hard mogelijk door de zaal te laten gieren. De ene keer is dat met Apenkooien, de andere keer met bestaande of zelfbedachte spellen als James Bond, het Grote Waterspektakel, Super Mario Kart of één van de vele varianten op trefbal. Al deze spellen zijn (her)uitgevonden voor volwassenen. Nooit kinderachtig, altijd met kinderlijk plezier. Door het trainen van je lachspieren heb je bijna niet in de gaten dat je met een aardige work-out bezig bent.",
            Category = "conditie en kracht",
            Image = "https://bress.nl/wp-content/uploads/2022/03/Schermafbeelding-2022-03-30-om-14.52.29-1024x854.png",
            Duration = 75,
            Price = 2.5M,
        };

        private static Workout spinning = new Workout()
        {
            Id = workOutId++,
            Title = "Spinning",
            Description = "Spinning is een high intensity groepsles waarbij je op een leuke manier je conditie in hoog tempo verbetert. Je doet dit op een vaststaande fiets, met extra weerstand. Hoeveel weerstand? Dit bepaal je helemaal zelf! Hierdoor is deze les geschikt voor iedereen. De instructeur geeft instructies terwijl de muziek het tempo ondersteunt.",
            Category = "cardio",
            Image = "https://bress.nl/wp-content/uploads/2022/03/Schermafbeelding-2022-03-30-om-14.40.03-1024x939.png",
            Duration = 60
        };


        private static Workout fitness = new Workout()
        {
            Id = workOutId++,
            Title = "Fitness",
            Description = "Onze fitness beschikt over de up-to-date cardio- en krachtapparatuur van Matrix Fitness en daarnaast ook over een free weight area waar je alle ruimte hebt om (grond)oefeningen te doen of te trainen met dumbbells, barbells en andere materialen.",
            Category = "kracht",
            Image = "https://bress.nl/wp-content/uploads/2022/03/interior-of-fitness-hall-with-fitness-bicycles-2021-08-28-00-35-59-utc-1024x683.jpg",
            Duration = 90
        };

        private static Workout tennis = new Workout()
        {
            Id = workOutId++,
            Title = "Tennis",
            Description = "Tennis is een balsport voor twee spelers (enkelspel) of paren (dubbelspel). De tennisbal moet met een racket over een net op de speelhelft van de tegenspeler(s) geslagen worden. Het doel is om het de tegenspelers(s) onmogelijk te maken de bal terug te slaan.",
            Category = "balsport",
            Image = "https://bress.nl/wp-content/uploads/2022/03/tennis-racket-and-tennis-net-on-tennis-court-2021-09-03-12-45-52-utc-1024x683.jpg",
            Duration = 90
        };


        private static Workout duiken = new Workout()
        {
            Id = workOutId++,
            Title = "Duiken",
            Description = "Duiken is één van de snelst groeiende avontuurlijke sporten ter wereld en dat is niet zonder reden. Het ontspannen gevoel en het gevoel van gewichtloosheid (een gevoel dat verder alleen astronauten kunnen meemaken) maakt duiken tot een unieke sport. Duiken doe je altijd met minimaal 2 personen waardoor het ook nog eens een sociale sport is. Wist je trouwens dat het aardoppervlakte\r\nuit 70% water bestaat en dat er onder water meer verschillende soorten planten en dieren leven dan erboven? Er valt dus nog genoeg te ontdekken in de onderwaterwereld!",
            Category = "groepsles",
            Image = "https://bress.nl/wp-content/uploads/2022/05/Schermafbeelding-2022-05-18-om-11.08.38-1024x327.png",
            Duration = 90
        };

        private static Workout zouk = new Workout()
        {
            Id = workOutId++,
            Title = "Zouk",
            Description = "Zouk betekent ‘feest’ in het Frans Creools en is een muziekgenre uit de Franse Antillen. De dans Zouk is net zo vrolijk als de muziek en kwam op in de jaren 60 op de Caraïbische eilanden. Ook in Brazilië is Zouk populair geworden, maar dan onder de naam Kizomba. De dans biedt veel ruimte voor variatie en creativiteit en door het toom-chic-chic (slow-quick-quick) tempo is deze heel elegant. De mannen leiden en bepalen de volgorde van de figuren. De vrouwen maken bewegingen met hun hoofd waardoor hun haar in de lucht zwiert.",
            Category = "dans",
            Image = "https://bress.nl/wp-content/uploads/2022/05/young-couple-dancing-latin-dance-bachata-merengue-2022-01-11-06-15-58-utc-scaled-e1652359701676-1024x546.jpg",
            Duration = 90,
            Price = 55M
        };

        private static Workout zwemmen = new Workout()
        {
            Id = workOutId++,
            Title = "Zwemmen",
            Description = "Zwemmen is supergezond! Je verbrandt er razendsnel calorieën mee en het verbetert je conditie. Het fijne aan zwemmen is dat je je spieren en gewrichten gebruikt op een niet-belastende manier, hierdoor blijven deze soepeler.\r\nWanneer je een echte waterrat bent dan heb je geluk; Breda telt maar liefst 3 Optisport zwembaden waar je als BRESS-lid baantjes kunt trekken of recreatief kunt zwemmen.",
            Category = "atletiek",
            Image = "https://bress.nl/wp-content/uploads/2022/03/male-swimmer-swimming-laps-in-a-pool-2021-08-26-19-58-29-utc-scaled-e1648646593733-1024x388.jpg",
            Duration = 90,
            Price = 35M
        };

        public static readonly List<Workout> Workouts 
            = new List<Workout>() {acroYoga, aerialSilk, atletiek, badminton, basketbal, bbbAttack, beachTennis, beachVolleybal, bodyAndMind, bodyshape, boogschieten, bootcamp, bootcampObstacleTraining, boulderen, boxFit, duiken, fitness, gymmen, spinning, tennis, zouk, zwemmen};

        #endregion

        #region all lessons (with startime and location)
        private static int lessonId = 1;

        public static readonly List<Lesson> Lessons 
            = new List<Lesson>()
        {
            new Lesson() {Id = lessonId++, WorkOutId = bootcamp.Id, Instructor = "Marcel", LocationId = wilderen.Id, StartDateTime = today.NextDayAt(DayOfWeek.Tuesday, 19, 30)},
            new Lesson() {Id = lessonId++, WorkOutId = boxFit.Id, Instructor = "Coen", LocationId = dansStudio1.Id, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 18, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = gymmen.Id, Instructor = "Freek", LocationId = apenkooiGym.Id, StartDateTime = today.AtTime(18, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = spinning.Id, Instructor = "Miriam", LocationId = dansStudio2.Id, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 20, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = acroYoga.Id, Instructor = "Marcel", LocationId = belcrumhuis.Id, StartDateTime = today.NextDayAt(DayOfWeek.Saturday, 10, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = aerialSilk.Id, Instructor = "Laura", LocationId = paaldansStudio.Id, StartDateTime = today.NextDayAt(DayOfWeek.Friday, 19, 30)},
            new Lesson() {Id = lessonId++, WorkOutId = fitness.Id, Instructor = "Emilio", LocationId = fitnessRoom.Id, StartDateTime = today.NextDayAt(DayOfWeek.Sunday, 11, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = tennis.Id, Instructor = "Judith", LocationId = tennisTVBN.Id, StartDateTime = today.AtTime(16, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = aerialSilk.Id, Instructor = "Eva", LocationId = paaldansStudio.Id, StartDateTime = today.AtTime(19, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = duiken.Id, Instructor = "Suzanne", LocationId = teteringseDijk.Id, StartDateTime = today.AtTime(20, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = badminton.Id, Instructor = "zelf trainen", LocationId = bressSportcentrum.Id, StartDateTime = today.AtTime(17, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = bodyAndMind.Id, Instructor = "Robert", LocationId = dansStudio1.Id, StartDateTime = today.AtTime(19, 30)},

            new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Monday ,17, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Tuesday ,17, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Wednesday ,14, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Thursday, 14, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Friday, 14, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Saturday, 10, 0)},
            new Lesson() {Id = lessonId++, WorkOutId = boulderen.Id, Instructor = "", LocationId = boulderhalBruut.Id, StartDateTime = today.NextDayAt(DayOfWeek.Sunday, 10, 0)},
        };

        #endregion

    }
}
