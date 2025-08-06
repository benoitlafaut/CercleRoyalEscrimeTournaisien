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
                string link = @"<a target='_blank' href=/FileToUpload/AGENDA_SAISON_2025_2026.doc>ici</a>";
                string texte;

                texte = "L'escrime est un sport de combat. 3 armes sont utilisées : le fleuret, l'épée et le sabre. Ces 3 armes sont mixtes; individuelle ou par équipes.";
                texte += @"<br />" + "Les cours au <b><span style='color: cornflowerblue'>fleuret</span></b> sont en bleu, à <b><span style='color: red'>l'épée</span></b> en rouge et au <b><span style='color: forestgreen'>sabre</span></b> en vert. Les séances parents sont en <b><span style='color: #ED7D31'>orange</span></b>.";
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
            list.Add(new DateTime(2025, 10, 15));
            list.Add(new DateTime(2025, 10, 17));
            list.Add(new DateTime(2025, 10, 19));
            list.Add(new DateTime(2025, 11, 5));
            list.Add(new DateTime(2025, 11, 7));
            list.Add(new DateTime(2025, 11, 9));
            list.Add(new DateTime(2026, 1, 7));
            list.Add(new DateTime(2026, 1, 9));
            list.Add(new DateTime(2026, 1, 11));
            list.Add(new DateTime(2026, 1, 14));
            list.Add(new DateTime(2026, 1, 16));
            list.Add(new DateTime(2026, 3, 18));
            list.Add(new DateTime(2026, 3, 20));
            list.Add(new DateTime(2026, 3, 22));
            list.Add(new DateTime(2026, 3, 25));
            list.Add(new DateTime(2026, 3, 27));
            list.Add(new DateTime(2026, 3, 29));
            list.Add(new DateTime(2026, 5, 27));
            list.Add(new DateTime(2026, 5, 29));
            list.Add(new DateTime(2026, 5, 31));
            list.Add(new DateTime(2026, 6, 3));
            list.Add(new DateTime(2026, 6, 5));
            list.Add(new DateTime(2026, 6, 7));         
            return list;
        }

        private List<DateTime> GetAllHolidays()
        {
            List<DateTime> list = new List<DateTime>() { };
            list.Add(new DateTime(2025, 9, 27));
            list.Add(new DateTime(2025, 10, 20));
            list.Add(new DateTime(2025, 10, 21));
            list.Add(new DateTime(2025, 10, 22));
            list.Add(new DateTime(2025, 10, 23));
            list.Add(new DateTime(2025, 10, 24));
            list.Add(new DateTime(2025, 10, 25));
            list.Add(new DateTime(2025, 10, 26));
            list.Add(new DateTime(2025, 10, 27));
            list.Add(new DateTime(2025, 10, 28));
            list.Add(new DateTime(2025, 10, 29));
            list.Add(new DateTime(2025, 10, 30));
            list.Add(new DateTime(2025, 10, 31));
            list.Add(new DateTime(2025, 11, 1));
            list.Add(new DateTime(2025, 11, 2));
            list.Add(new DateTime(2025, 11, 11));
            list.Add(new DateTime(2025, 12, 22));
            list.Add(new DateTime(2025, 12, 23));
            list.Add(new DateTime(2025, 12, 24));
            list.Add(new DateTime(2025, 12, 25));
            list.Add(new DateTime(2025, 12, 26));
            list.Add(new DateTime(2025, 12, 27));
            list.Add(new DateTime(2025, 12, 28));
            list.Add(new DateTime(2025, 12, 29));
            list.Add(new DateTime(2025, 12, 30));
            list.Add(new DateTime(2025, 12, 31));
            list.Add(new DateTime(2026, 1, 1));
            list.Add(new DateTime(2026, 1, 2));
            list.Add(new DateTime(2026, 1, 3));
            list.Add(new DateTime(2026, 1, 4));
            list.Add(new DateTime(2026, 2, 16));
            list.Add(new DateTime(2026, 2, 17));
            list.Add(new DateTime(2026, 2, 18));
            list.Add(new DateTime(2026, 2, 19));
            list.Add(new DateTime(2026, 2, 20));
            list.Add(new DateTime(2026, 2, 21));
            list.Add(new DateTime(2026, 2, 22));
            list.Add(new DateTime(2026, 2, 23));
            list.Add(new DateTime(2026, 2, 24));
            list.Add(new DateTime(2026, 2, 25));
            list.Add(new DateTime(2026, 2, 26));
            list.Add(new DateTime(2026, 2, 27));
            list.Add(new DateTime(2026, 2, 28));
            list.Add(new DateTime(2026, 3, 1));
            list.Add(new DateTime(2026, 4, 6));
            list.Add(new DateTime(2026, 4, 27));
            list.Add(new DateTime(2026, 4, 28));
            list.Add(new DateTime(2026, 4, 29));
            list.Add(new DateTime(2026, 4, 30));
            list.Add(new DateTime(2026, 5, 1));
            list.Add(new DateTime(2026, 5, 2));
            list.Add(new DateTime(2026, 5, 3));
            list.Add(new DateTime(2026, 5, 4));
            list.Add(new DateTime(2026, 5, 5));
            list.Add(new DateTime(2026, 5, 6));
            list.Add(new DateTime(2026, 5, 7));
            list.Add(new DateTime(2026, 5, 8));
            list.Add(new DateTime(2026, 5, 9));
            list.Add(new DateTime(2026, 5, 10));
            list.Add(new DateTime(2026, 5, 14));
            list.Add(new DateTime(2026, 5, 25));
           
            return list;
        }

        private List<DateTime> GetAllSeancesForFleuret()
        {
            List<DateTime> list = new List<DateTime>() { };
            list.Add(new DateTime(2025, 9, 17));
            list.Add(new DateTime(2025, 9, 19));
            list.Add(new DateTime(2025, 9, 21));
            list.Add(new DateTime(2025, 9, 24));
            list.Add(new DateTime(2025, 9, 26));
            list.Add(new DateTime(2025, 9, 28));
            list.Add(new DateTime(2025, 11, 26));
            list.Add(new DateTime(2025, 11, 28));
            list.Add(new DateTime(2025, 11, 30));
            list.Add(new DateTime(2025, 12, 3));
            list.Add(new DateTime(2025, 12, 5));
            list.Add(new DateTime(2025, 12, 7));
            list.Add(new DateTime(2026, 2, 4));
            list.Add(new DateTime(2026, 2, 6));
            list.Add(new DateTime(2026, 2, 8));
            list.Add(new DateTime(2026, 2, 11));
            list.Add(new DateTime(2026, 2, 13));
            list.Add(new DateTime(2026, 4, 15));
            list.Add(new DateTime(2026, 4, 17));
            list.Add(new DateTime(2026, 4, 22));
            list.Add(new DateTime(2026, 4, 24));
            list.Add(new DateTime(2026, 4, 26));
           

            return list;
        }

        private List<DateTime> GetAllSeancesForEpee()
        {
            List<DateTime> list = new List<DateTime>() { };
            list.Add(new DateTime(2025, 9, 3));
            list.Add(new DateTime(2025, 9, 5));
            list.Add(new DateTime(2025, 9, 7));
            list.Add(new DateTime(2025, 9, 10));
            list.Add(new DateTime(2025, 9, 12));
            list.Add(new DateTime(2025, 9, 14));
            list.Add(new DateTime(2025, 10, 1));
            list.Add(new DateTime(2025, 10, 3));
            list.Add(new DateTime(2025, 10, 5));
            list.Add(new DateTime(2025, 10, 8));
            list.Add(new DateTime(2025, 10, 10));
            list.Add(new DateTime(2025, 11, 12));
            list.Add(new DateTime(2025, 11, 14));
            list.Add(new DateTime(2025, 11, 16));
            list.Add(new DateTime(2025, 11, 19));
            list.Add(new DateTime(2025, 11, 21));
            list.Add(new DateTime(2025, 12, 10));
            list.Add(new DateTime(2025, 12, 12));
            list.Add(new DateTime(2025, 12, 14));
            list.Add(new DateTime(2025, 12, 17));
            list.Add(new DateTime(2025, 12, 19));
            list.Add(new DateTime(2026, 1, 21));
            list.Add(new DateTime(2026, 1, 23));
            list.Add(new DateTime(2026, 1, 25));
            list.Add(new DateTime(2026, 1, 28));
            list.Add(new DateTime(2026, 1, 30));
            list.Add(new DateTime(2026, 2, 1));
            list.Add(new DateTime(2026, 3, 4));
            list.Add(new DateTime(2026, 3, 6));
            list.Add(new DateTime(2026, 3, 8));
            list.Add(new DateTime(2026, 3, 11));
            list.Add(new DateTime(2026, 3, 13));
            list.Add(new DateTime(2026, 4, 1));
            list.Add(new DateTime(2026, 4, 3));
            list.Add(new DateTime(2026, 4, 5));
            list.Add(new DateTime(2026, 4, 8));
            list.Add(new DateTime(2026, 4, 10));
            list.Add(new DateTime(2026, 4, 12));
            list.Add(new DateTime(2026, 5, 13));
            list.Add(new DateTime(2026, 5, 15));
            list.Add(new DateTime(2026, 5, 17));
            list.Add(new DateTime(2026, 5, 20));
            list.Add(new DateTime(2026, 5, 22));
            list.Add(new DateTime(2026, 6, 10));
            list.Add(new DateTime(2026, 6, 12));

           

            return list;
        }
        private List<DateTime> GetAllSeancesForParents()
        {
            List<DateTime> list = new List<DateTime>() { };
            list.Add(new DateTime(2025, 10, 12));
            list.Add(new DateTime(2025, 11, 23));
            list.Add(new DateTime(2025, 12, 21));
            list.Add(new DateTime(2026, 1, 18));
            list.Add(new DateTime(2026, 2, 15));
            list.Add(new DateTime(2026, 3, 15));
            list.Add(new DateTime(2026, 4, 19));
            list.Add(new DateTime(2026, 5, 24));
            list.Add(new DateTime(2026, 6, 14));

            return list;
        }
        private List<DateTime> GetAllSalleDéjàPrise()
        {
            List<DateTime> list = new List<DateTime>() { };
            

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
