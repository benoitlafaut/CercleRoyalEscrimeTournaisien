using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CercleRoyalEscrimeTournaisien
{
    public class Agenda
    {
        public Agenda()
        {
            DateCurrent = DateTime.Now;
        }

        public DateTime DateCurrent{ get; set; }
        public  string TexteEnDessousDuCalendar
        {
            get
            {
                string link = @"<a target='_blank' href=/FileToUpload/AGENDA_SAISON_2026_2027.docx>ici</a>";
                string texte;

                texte = "L'escrime est un sport de combat. 3 armes sont utilisées : le fleuret, l'épée et le sabre. Ces 3 armes sont mixtes; individuelle ou par équipes.";
                texte += @"<br />" + "Les cours au <b><span style='color: cornflowerblue'>fleuret</span></b> sont en bleu, à <b><span style='color: red'>l'épée</span></b> en rouge et au <b><span style='color: forestgreen'>sabre</span></b> en vert. Les séances parents sont en <b><span style='color: #ED7D31'>orange</span></b>. Les jours qui sont en <b><span style='color: magenta'>magenta</span></b> sont les jours où nous n'avons pas la salle..";
                texte += @"<br />" + "Vous trouverez " + link + " le calendrier téléchargeable sous format word.";

                return texte;
            }
        }

        public  string GetNomOfMois(int mois)
        {
            switch (mois)
            {
                case 1:
                    return "Janvier";
                case 2:
                    return "Février";
                case 3:
                    return "Mars";
                case 4:
                    return "Avril";
                case 5:
                    return "Mai";
                case 6:
                    return "Juin";
                case 7:
                    return "Juillet";
                case 8:
                    return "Août";
                case 9:
                    return "Septembre";
                case 10:
                    return "Octobre";
                case 11:
                    return "Novembre";
                case 12:
                    return "Décembre";
            }

            return string.Empty;
        }
    


   
        DateArmes JourNull = new DateArmes()
        {
            ArmeManieeOfDay = TypeArme.None,
            DateOfDay = DateTime.MinValue,
            JourneeOfTheDay = DayOfWeek.Monday,
            NummerOfDay = string.Empty,
            ISDateOfDay = false,
            ClassOfCell = string.Empty
        };

        public List<DateArmes> GetAllDaysOfTheCurrentDate()
        {
            List<DateArmes> list = new List<DateArmes>();

            DateTime DateDepart = DateCurrent;

            DateTime startDate = new DateTime(DateDepart.Year, DateDepart.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            List<DateTime> calculatedDates = GetAllDatesBetween(startDate, endDate);

            List<DateTime> AllSeancesFleuret = GetAllSeancesForFleuret();
            List<DateTime> AllSeancesEpée = GetAllSeancesForEpee();
            List<DateTime> AllSeancesSabre = GetAllSeancesForSabre();
            List<DateTime> AllSeancesHolidays = GetAllHolidays();
            List<DateTime> AllSeancesSalleDéjàPrise = GetAllSalleDéjàPrise();
            List<DateTime> AllSeancesParents = GetAllSeancesForParents();

            foreach (DateTime date in calculatedDates)
            {
                DateArmes dateArmes = new DateArmes();
                dateArmes.DateOfDay = date;
                dateArmes.NummerOfDay = date.Day.ToString();
                dateArmes.JourneeOfTheDay = date.DayOfWeek;
                dateArmes.ArmeManieeOfDay = TypeArme.None;
                dateArmes.ISDateOfDay = date.ToString("dd/M/yyyy", CultureInfo.InvariantCulture) == DateTime.Now.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);

                if (AllSeancesFleuret.Contains(date))
                {
                    dateArmes.ArmeManieeOfDay = TypeArme.Fleuret;
                    dateArmes.ClassOfCell = "CelluleCouleurFleuret";
                }

                if (AllSeancesEpée.Contains(date))
                {
                    dateArmes.ArmeManieeOfDay = TypeArme.Epée;
                    dateArmes.ClassOfCell = "CelluleCouleurEpee";
                }

                if (AllSeancesParents.Contains(date))
                {
                    dateArmes.ClassOfCell = "CelluleCouleurParents";
                }

                if (AllSeancesSabre.Contains(date))
                {
                    dateArmes.ArmeManieeOfDay = TypeArme.Sabre;
                    dateArmes.ClassOfCell = "CelluleCouleurSabre";
                }

                if (AllSeancesHolidays.Contains(date))
                {
                    dateArmes.ClassOfCell = "CelluleCouleurHolidays";
                }

                if (AllSeancesSalleDéjàPrise.Contains(date))
                {
                    dateArmes.ClassOfCell = "CelluleCouleurSalleDéjàPrise";
                }

                if (dateArmes.ISDateOfDay)
                {
                    dateArmes.ClassOfCell += " CelluleAujourdhui";
                }

                list.Add(dateArmes);
            }



            return list;
        }

        public List<LaSemaine> AllDatePerWeek(List<DateArmes> getAllDays)
        {
            List<LaSemaine> allDatePerWeek = new List<LaSemaine>
            {
                new LaSemaine()
                {
                    PremierJour = new DateArmes() { NummerOfDay = "Lundi" },
                    SecondJour = new DateArmes() { NummerOfDay = "Mardi" },
                    TroisièmeJour = new DateArmes() { NummerOfDay = "Mercredi" },
                    QuatrièmeJour = new DateArmes() { NummerOfDay = "Jeudi" },
                    CinquièmeJour = new DateArmes() { NummerOfDay = "Vendredi" },
                    SixièmeJour = new DateArmes() { NummerOfDay = "Samedi" },
                    SeptièmeJour = new DateArmes() { NummerOfDay = "Dimanche" }
                }
            };

            for (int i = 1; i <= getAllDays.Count - 1; i++)
            {
                int j = i;

                while (j != i + 6 && getAllDays[j].JourneeOfTheDay != DayOfWeek.Sunday && j < getAllDays.Count - 1)
                {
                    j++;

                };

                List<DateArmes> getPartOfAllDays = getAllDays.Skip(i).Take(j - i + 1).ToList();


                LaSemaine laSemaine = new LaSemaine();
                laSemaine.PremierJour = getPartOfAllDays.FirstOrDefault(x => x.JourneeOfTheDay == System.DayOfWeek.Monday);
                laSemaine.SecondJour = getPartOfAllDays.FirstOrDefault(x => x.JourneeOfTheDay == System.DayOfWeek.Tuesday);
                laSemaine.TroisièmeJour = getPartOfAllDays.FirstOrDefault(x => x.JourneeOfTheDay == System.DayOfWeek.Wednesday);
                laSemaine.QuatrièmeJour = getPartOfAllDays.FirstOrDefault(x => x.JourneeOfTheDay == System.DayOfWeek.Thursday);
                laSemaine.CinquièmeJour = getPartOfAllDays.FirstOrDefault(x => x.JourneeOfTheDay == System.DayOfWeek.Friday);
                laSemaine.SixièmeJour = getPartOfAllDays.FirstOrDefault(x => x.JourneeOfTheDay == System.DayOfWeek.Saturday);
                laSemaine.SeptièmeJour = getPartOfAllDays.FirstOrDefault(x => x.JourneeOfTheDay == System.DayOfWeek.Sunday);

                if (laSemaine.PremierJour == null) { laSemaine.PremierJour = JourNull; }
                if (laSemaine.SecondJour == null) { laSemaine.SecondJour = JourNull; }
                if (laSemaine.TroisièmeJour == null) { laSemaine.TroisièmeJour = JourNull; }
                if (laSemaine.QuatrièmeJour == null) { laSemaine.QuatrièmeJour = JourNull; }
                if (laSemaine.CinquièmeJour == null) { laSemaine.CinquièmeJour = JourNull; }
                if (laSemaine.SixièmeJour == null) { laSemaine.SixièmeJour = JourNull; }
                if (laSemaine.SeptièmeJour == null) { laSemaine.SeptièmeJour = JourNull; }

                allDatePerWeek.Add(laSemaine);

                i = i + (j - i);
            }

            return allDatePerWeek;
        }

        private List<DateTime> GetAllDatesBetween(DateTime start, DateTime end)
        {
            List<DateTime> list = new List<DateTime>() { };
            list.Add(DateTime.MinValue);

            for (DateTime day = start.Date; day <= end; day = day.AddDays(1))
            {
                list.Add(day);
            }
            return list;
        }

        private List<DateTime> GetAllSeancesForSabre ()
        {
            List<DateTime> list = new List<DateTime>() { };
            list.Add(new DateTime(2026, 10, 14));
            list.Add(new DateTime(2026, 10, 16));
            list.Add(new DateTime(2026, 10, 18));
            list.Add(new DateTime(2026, 11, 4));
            list.Add(new DateTime(2026, 11, 6));
            list.Add(new DateTime(2026, 11, 8));
            list.Add(new DateTime(2027, 1, 6));
            list.Add(new DateTime(2027, 1, 8));
            list.Add(new DateTime(2027, 1, 10));
            list.Add(new DateTime(2027, 1, 13));
            list.Add(new DateTime(2027, 1, 15));
            list.Add(new DateTime(2027, 1, 17));
            list.Add(new DateTime(2027, 3, 17));
            list.Add(new DateTime(2027, 3, 19));
            list.Add(new DateTime(2027, 3, 21));
            list.Add(new DateTime(2027, 3, 24));
            list.Add(new DateTime(2027, 3, 26));
       
            list.Add(new DateTime(2027, 5, 26));
            list.Add(new DateTime(2027, 5, 28));
            list.Add(new DateTime(2027, 5, 30));
            list.Add(new DateTime(2027, 6, 2));
            list.Add(new DateTime(2027, 6, 4));
            list.Add(new DateTime(2027, 6, 6));


            return list;
        }

        private List<DateTime> GetAllHolidays()
        {
            List<DateTime> list = new List<DateTime>() { };
            list.Add(new DateTime(2026, 9, 27));
            list.Add(new DateTime(2026, 10, 19));
            list.Add(new DateTime(2026, 10, 20));
            list.Add(new DateTime(2026, 10, 21));
            list.Add(new DateTime(2026, 10, 22));
            list.Add(new DateTime(2026, 10, 23));
            list.Add(new DateTime(2026, 10, 24));
            list.Add(new DateTime(2026, 10, 25));
            list.Add(new DateTime(2026, 10, 26));
            list.Add(new DateTime(2026, 10, 27));
            list.Add(new DateTime(2026, 10, 28));
            list.Add(new DateTime(2026, 10, 29));
            list.Add(new DateTime(2026, 10, 30));
            list.Add(new DateTime(2026, 10, 31));
            list.Add(new DateTime(2026, 11, 1));
            list.Add(new DateTime(2026, 11, 2));
            list.Add(new DateTime(2026, 11, 11));
            list.Add(new DateTime(2026, 12, 21));
            list.Add(new DateTime(2026, 12, 22));
            list.Add(new DateTime(2026, 12, 23));
            list.Add(new DateTime(2026, 12, 24));
            list.Add(new DateTime(2026, 12, 25));
            list.Add(new DateTime(2026, 12, 26));
            list.Add(new DateTime(2026, 12, 27));
            list.Add(new DateTime(2026, 12, 28));
            list.Add(new DateTime(2026, 12, 29));
            list.Add(new DateTime(2026, 12, 30));
            list.Add(new DateTime(2026, 12, 31));
            list.Add(new DateTime(2027, 1, 1));
            list.Add(new DateTime(2027, 1, 2));
            list.Add(new DateTime(2027, 1, 3));
            list.Add(new DateTime(2027, 2, 9));
            list.Add(new DateTime(2027, 2, 22));
            list.Add(new DateTime(2027, 2, 23));
            list.Add(new DateTime(2027, 2, 24));
            list.Add(new DateTime(2027, 2, 25));
            list.Add(new DateTime(2027, 2, 26));
            list.Add(new DateTime(2027, 2, 27));
            list.Add(new DateTime(2027, 2, 28));
            list.Add(new DateTime(2027, 3, 1));
            list.Add(new DateTime(2027, 3, 2));
            list.Add(new DateTime(2027, 3, 3));
            list.Add(new DateTime(2027, 3, 4));
            list.Add(new DateTime(2027, 3, 5));
            list.Add(new DateTime(2027, 3, 6));
            list.Add(new DateTime(2027, 3, 7));
            list.Add(new DateTime(2027, 3, 29));
            list.Add(new DateTime(2027, 4, 26));
            list.Add(new DateTime(2027, 4, 27));
            list.Add(new DateTime(2027, 4, 28));
            list.Add(new DateTime(2027, 4, 29));
            list.Add(new DateTime(2027, 4, 30));
            list.Add(new DateTime(2027, 5, 1));
            list.Add(new DateTime(2027, 5, 2));
            list.Add(new DateTime(2027, 5, 3));
            list.Add(new DateTime(2027, 5, 4));
            list.Add(new DateTime(2027, 5, 5));
            list.Add(new DateTime(2027, 5, 6));
            list.Add(new DateTime(2027, 5, 7));
            list.Add(new DateTime(2027, 5, 8));
            list.Add(new DateTime(2027, 5, 9));
            list.Add(new DateTime(2027, 5, 17));

            return list;
        }

        private List<DateTime> GetAllSeancesForFleuret()
        {
            List<DateTime> list = new List<DateTime>() { };
            list.Add(new DateTime(2026, 9, 16));
            list.Add(new DateTime(2026, 9, 18));
            list.Add(new DateTime(2026, 9, 20));
            list.Add(new DateTime(2026, 9, 23));
            list.Add(new DateTime(2026, 9, 25));
            list.Add(new DateTime(2026, 11, 25));
            list.Add(new DateTime(2026, 11, 27));
            list.Add(new DateTime(2026, 11, 29));
            list.Add(new DateTime(2026, 12, 2));
            list.Add(new DateTime(2026, 12, 4));
            list.Add(new DateTime(2026, 12, 6));
            list.Add(new DateTime(2027, 2, 3));
            list.Add(new DateTime(2027, 2, 5));
            list.Add(new DateTime(2027, 2, 7));
            list.Add(new DateTime(2027, 2, 10));
            list.Add(new DateTime(2027, 2, 12));
            list.Add(new DateTime(2027, 2, 14));
            list.Add(new DateTime(2027, 4, 14));
            list.Add(new DateTime(2027, 4, 16));
            list.Add(new DateTime(2027, 4, 18));
            list.Add(new DateTime(2027, 4, 21));
            list.Add(new DateTime(2027, 4, 23));
            list.Add(new DateTime(2027, 4, 25));

            return list;
        }

        private List<DateTime> GetAllSeancesForEpee()
        {
            List<DateTime> list = new List<DateTime>() { };
            list.Add(new DateTime(2026, 9, 2));
            list.Add(new DateTime(2026, 9, 4));
            list.Add(new DateTime(2026, 9, 6));
            list.Add(new DateTime(2026, 9, 9));
            list.Add(new DateTime(2026, 9, 11));
            list.Add(new DateTime(2026, 9, 13));
            list.Add(new DateTime(2026, 9, 30));
            list.Add(new DateTime(2026, 10, 2));
            list.Add(new DateTime(2026, 10, 4));
            list.Add(new DateTime(2026, 10, 7));
            list.Add(new DateTime(2026, 10, 11));
            list.Add(new DateTime(2026, 11, 13));
            list.Add(new DateTime(2026, 11, 15));
            list.Add(new DateTime(2026, 11, 18));
            list.Add(new DateTime(2026, 11, 20));
            list.Add(new DateTime(2026, 11, 22));
            list.Add(new DateTime(2026, 12, 9));
            list.Add(new DateTime(2026, 12, 13));
            list.Add(new DateTime(2026, 12, 16));
            list.Add(new DateTime(2026, 12, 18));
            list.Add(new DateTime(2026, 12, 20));
            list.Add(new DateTime(2027, 1, 20));
            list.Add(new DateTime(2027, 1, 22));
            list.Add(new DateTime(2027, 1, 24));
            list.Add(new DateTime(2027, 1, 27));
            list.Add(new DateTime(2027, 1, 29));
            list.Add(new DateTime(2027, 1, 31));
            list.Add(new DateTime(2027, 2, 17));
            list.Add(new DateTime(2027, 2, 19));
            list.Add(new DateTime(2027, 2, 21));
            list.Add(new DateTime(2027, 3, 10));
            list.Add(new DateTime(2027, 3, 12));
            list.Add(new DateTime(2027, 3, 14));
            list.Add(new DateTime(2027, 3, 31));
            list.Add(new DateTime(2027, 4, 2));
            list.Add(new DateTime(2027, 4, 4));
            list.Add(new DateTime(2027, 4, 7));
            list.Add(new DateTime(2027, 4, 9));
            list.Add(new DateTime(2027, 4, 11));
            list.Add(new DateTime(2027, 5, 12));
            list.Add(new DateTime(2027, 5, 14));
            list.Add(new DateTime(2027, 5, 16));
            list.Add(new DateTime(2027, 5, 19));
            list.Add(new DateTime(2027, 5, 21));
            list.Add(new DateTime(2027, 5, 23));
            list.Add(new DateTime(2027, 6, 9));
            list.Add(new DateTime(2027, 6, 11));
            list.Add(new DateTime(2027, 6, 13));
            list.Add(new DateTime(2027, 6, 16));
            list.Add(new DateTime(2027, 6, 18));
            list.Add(new DateTime(2027, 6, 20));

            return list;
        }
        private List<DateTime> GetAllSeancesForParents()
        {
            List<DateTime> list = new List<DateTime>() { };
            list.Add(new DateTime(2026, 10, 11));
            list.Add(new DateTime(2026, 12, 20));
            list.Add(new DateTime(2027, 2, 7));
            list.Add(new DateTime(2027, 3, 28));
            list.Add(new DateTime(2027, 5, 14));
            list.Add(new DateTime(2027, 6, 18));


            return list;
        }
        private List<DateTime> GetAllSalleDéjàPrise()
        {
            List<DateTime> list = new List<DateTime>() { };
            list.Add(new DateTime(2026, 10, 9));
            list.Add(new DateTime(2026, 12, 11));
            list.Add(new DateTime(2027, 6, 9));
            list.Add(new DateTime(2027, 6, 11));
            list.Add(new DateTime(2027, 6, 13));
            list.Add(new DateTime(2026, 12, 13));
            return list;
        }
    }

    public class DateArmes
    {
        public DateTime DateOfDay { get; set; }
        public string NummerOfDay { get; set; }
        public TypeArme ArmeManieeOfDay { get; set; }
        public DayOfWeek JourneeOfTheDay { get; set; }
        public bool ISDateOfDay { get; set; }
        public string ClassOfCell { get; set; }
    }
    public class LaSemaine
    {
        public DateArmes PremierJour { get; set; }
        public DateArmes SecondJour { get; set; }
        public DateArmes TroisièmeJour { get; set; }
        public DateArmes QuatrièmeJour { get; set; }
        public DateArmes CinquièmeJour { get; set; }
        public DateArmes SixièmeJour { get; set; }
        public DateArmes SeptièmeJour { get; set; }
    }

    public enum TypeArme
    {
        None = 0, Fleuret = 1, Epée = 2, Sabre = 3
    }
}
