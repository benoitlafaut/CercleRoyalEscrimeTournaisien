using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;

namespace CercleRoyalEscrimeTournaisien.Models
{
    [Serializable]
    public class PoulesViewModel
    {
        public PoulesViewModel(HttpServerUtilityBase serverTmp)
        {
            this.ServerTmp = serverTmp;
            ChargerListeDesPoulesPotentielles();
            ChargerListeDesTireurs();
            ChargerPoulesDuJour();
            ChargerRésultatsDesPoulesDuJour();
            ChargerRésultatsDesElimintationsDirectesDuJour();
            ChargerDatesPourToutesLesPoules();
        }

        public HttpServerUtilityBase ServerTmp { get; set; }
        public List<ClassPoule> PoulesList { get; set; }
        public List<ClassScore> ScoresList { get; set; }
        public List<ClassScoreEliminationsDirectes> ScoresEliminitationsDirectesList { get; set; }        
        public List<ClassScoreEliminationsDirectes> GetOrdreDesMatchs(List<ClassScoreEliminationsDirectes> scores)
        {
            List<ClassScoreEliminationsDirectes> scoresResult = new List<ClassScoreEliminationsDirectes>() { };

            if (!scores.Any()) { return scores; }

            List<int> ordreDesMatchsList = GenerateFirstRound(scores.Count * 2);

            for (int i = 0; i < ordreDesMatchsList.Count; i += 2)
            {
                ClassScoreEliminationsDirectes score = scores.Where(x => x.IndexTireur1 == ordreDesMatchsList[i].ToString() || x.IndexTireur2 == ordreDesMatchsList[i].ToString()).First();
                scoresResult.Add(score);
            }

            return scoresResult;
        }
        private List<int> GenerateFirstRound(int fencers)
        {
            switch (fencers)
            {
                case 2:
                    return new List<int> { 1, 2 };
                case 4:
                    return new List<int> { 1, 4, 3, 2 };
                case 8:
                    return new List<int> { 1, 8, 5, 4, 3, 6, 7, 2 };
                case 16:
                    return new List<int> { 1, 16, 9, 8, 5, 12, 13, 4, 3, 14, 11, 6, 7, 10, 15, 2 };
                default:
                    return new List<int> { 1 };
            }
        }

        public List<ClassPoulesDuJour> PoulesDuJourList { get; set; }
        public List<ClassDatesPourToutesLesPoules> DatesPourToutesLesPoulesList { get; set; }
        public List<ClassTireur> TireursList { get; set; }
        public List<ClassTireur> TireursPourLaPouleSelectionneeList
        {
            get
            {
                if (string.IsNullOrEmpty(PouleSelected))
                {
                    return new List<ClassTireur>() { };
                }

                List<ClassPoulesDuJour> PoulesDuJourListTmp = PoulesDuJourList;

                List<ClassTireur> TireursPourLaPouleSelectionneeListTmp = TireursList.FindAll(t => t.PouleAttribuee == PouleSelected && t.JourDeLaPoule == Jour);
                foreach (ClassTireur tireur in TireursPourLaPouleSelectionneeListTmp)
                {
                    if (PoulesDuJourListTmp.Any(x=> x.Tireur == tireur.Tireur && x.Poule == PouleSelected))
                    {
                        tireur.IsSelected = true;
                    }
                }

                return TireursList.FindAll(t => t.PouleAttribuee == PouleSelected && t.JourDeLaPoule == Jour);
            } 
        }

        public List<ClassTireur> OthersTireursPourLaPouleSelectionneeList
        {
            get
            {
                List<ClassTireur> tireursList = new List<ClassTireur>() { };

                if (string.IsNullOrEmpty(PouleSelected))
                {
                    return tireursList;
                }

                var selection = TireursPourLaPouleSelectionneeList.GroupBy(x => x.Tireur).ToList();
                foreach (var tireur in TireursList)
                {
                    if (!selection.Any(f => tireur.Tireur.Contains(f.Key)))
                    {
                        tireursList.Add(tireur);
                    }
                }

                return tireursList.GroupBy(x => x.Tireur).Select(g => g.First()).ToList();
            }
        }
        public IDictionary<Guid, string> ListTireursToAddScore
        {
            get
            {
                if (string.IsNullOrEmpty(PouleSelected))
                {
                    return new Dictionary<Guid, string>() { };
                }

                return PoulesDuJourList.Where(x => x.Poule == PouleSelected).GroupBy(x => x.TireurGuid).ToDictionary(g => g.Key, g => g.First().Tireur);               
            }
        }
        public int ScoreTireur1 { get; set; }
        public int ScoreTireur2 { get; set; }
        public string Tireur1Selected { get; set; }
        public string Tireur2Selected { get; set; }

        public ClassEnumScreen.EnumScreen ScreenIndex { get; set; }
        public string PouleSelected { get; set; }

        public string GetScoreVictoireOuDéfaite(Guid tireur1, Guid tireur2)
        {
            ClassScore score;

            if (ScoresList.Any(x => x.Tireur1Guid == tireur1 && x.Tireur2Guid == tireur2))
            {
                score = ScoresList.First(x => x.Tireur1Guid == tireur1 && x.Tireur2Guid == tireur2);
                return score.VictoireOuDéfaiteDuTireur1 ? "V" : "D";
            }
            else if (ScoresList.Any(x => x.Tireur1Guid == tireur2 && x.Tireur2Guid == tireur1))
            {
                score = ScoresList.First(x => x.Tireur1Guid == tireur2 && x.Tireur2Guid == tireur1);
                return score.VictoireOuDéfaiteDuTireur2 ? "V" : "D";
            }
            else
            {
                return string.Empty;
            }    
        }
        public string GetScore(Guid tireur1, Guid tireur2)
        {
            ClassScore score;

            if (ScoresList.Any(x => x.Tireur1Guid == tireur1 && x.Tireur2Guid == tireur2))
            {
                score = ScoresList.First(x => x.Tireur1Guid == tireur1 && x.Tireur2Guid == tireur2);
                return score.ScoreDuTireur1.ToString();
            }
            else if (ScoresList.Any(x => x.Tireur1Guid == tireur2 && x.Tireur2Guid == tireur1))
            {
                score = ScoresList.First(x => x.Tireur1Guid == tireur2 && x.Tireur2Guid == tireur1);
                return score.ScoreDuTireur2.ToString();
            }
            else
            {
                return string.Empty;
            } 
        }
        public bool ExistEliminationsDirectes(string dateDuJourWithoutDay, string pouleSelected)
        {
            return ScoresEliminitationsDirectesList.Any(x=>x.DateDeLaPoule == dateDuJourWithoutDay && x.PouleSelected == pouleSelected);
        }
        public DateTime DateDAujourdhui 
        { 
            get
            {
                string isOtherDateThanDateDuJour = this.GetValueStartsWith<string>("IsOtherDateThanDateDuJour");
                string otherDate = this.GetValueStartsWith<string>("OtherDate");

                if (isOtherDateThanDateDuJour == "true" && !string.IsNullOrEmpty(otherDate))
                {
                    if (DateTime.TryParseExact(otherDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        return parsedDate;
                    }
                }

                return DateTime.Now.AddDays(-1);
            }
        }
        public bool IsDateDAujourdhuiEqualsDateNow
        {
            get
            {
                return true;
                return DateDAujourdhui.ToString("ddMMyyyy") == DateTime.Now.ToString("ddMMyyyy");
            }
        }
        public string RoundSelected { get; set; }
        public string Score { get; set; }
        public IDictionary<string, string> RoundsList
        {
            get
            {
                return ScoresEliminitationsDirectesList.Where(x => x.PouleSelected == PouleSelected).GroupBy(x => x.Round).ToDictionary(g => g.Key, g => g.Key);
            }
        }
        public List<string> GetListeDesMatchs(int nombreDeTireurs)
        {
            switch (nombreDeTireurs)
            {
                case 3:
                    return new List<string>() { "1-2", "1-3", "2-3" };
                case 4:
                    return new List<string>() { "1-4", "2-3", "1-3", "2-4", "3-4", "1-2" };
                case 5:
                    return new List<string>() { "1-5","2-4","3-5","1-4","2-3","4-5","1-3", "2-5", "3-4", "1-2" };
                case 6:
                    return new List<string>() { "1-6", "2-5", "3-4", "4-6", "3-5", "1-2", "2-4", "1-3", "5-6", "2-3", "1-4", "3-6", "1-5", "2-6", "4-5" };
                case 7:
                    return new List<string>() { "1-7","2-6",    "3-5",    "4-7",    "5-6",    "1-3",    "2-4",    "6-7",    "3-4",    "1-5",    "2-7",    "4-5",    "1-2",    "3-7",    "5-7",    "1-4",    "2-3",    "6-3",    "1-6",    "4-6",    "2-5" };
                case 8:
                    return new List<string>() { "1-8", "2-7", "3-6", "4-5",    "1-7", "2-6", "3-5", "4-8",    "1-6", "2-5", "3-4", "7-8",    "1-5", "2-4", "6-8", "3-7",   "1-4", "5-8", "2-3", "6-7",    "1-3", "4-6", "5-7", "2-8",    "1-2", "3-8", "4-7", "5-6" };
                case 9:
                    return new List<string>() { "2-9", "3-8", "4-7", "5-6",    "1-9", "2-7", "3-6", "4-5",    "1-8", "9-7", "2-5", "3-4",    "1-7", "8-6", "9-5", "2-3",    "1-6", "7-5", "8-4", "9-3",    "1-5", "6-4", "7-3", "8-2",    "1-4", "5-3", "6-2", "8-9",    "1-3", "4-2", "6-9", "7-8",    "1-2", "4-9", "5-8", "6-7"};
                default:
                    return new List<string>() { };
            }
        }
        public string DateDuJourWithDayLabel
        {
            get
            {
                DateTime dateNow = DateDAujourdhui;
                var culture = new CultureInfo("fr-FR");
                string dateFormatee = dateNow.ToString("dddd, dd MMMM yyyy", culture);
                return dateFormatee;
            }
        }
        public string DateDuJourWithoutDayLabel
        {
            get
            {
                DateTime dateNow = DateDAujourdhui;
                var culture = new CultureInfo("fr-FR");
                string dateFormatee = dateNow.ToString("dd/MM/yyyy", culture);
                return dateFormatee;
            }
        }
        public string Jour
        {
            get
            {
                DateTime dateNow = DateDAujourdhui;
                var culture = new CultureInfo("fr-FR");
                string dateFormatee = dateNow.ToString("dddd", culture);
                return char.ToUpper(dateFormatee[0]) + dateFormatee.Substring(1);
            }
        }
        public  string GetRoundSuivant(string roundSelected)
        {
            switch (roundSelected)
            {
                case "1/16":
                    return "1/8";
                case "1/8":
                    return "1/4";
                case "1/4":
                    return "1/2";
                case "1/2":
                    return "Finale";
                default:
                    return "";
            }
        }

        private void ChargerListeDesPoulesPotentielles()
        {
            PoulesList = new List<ClassPoule>() { };

            var path = ServerTmp.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";
            string mySelectQuery = " SELECT * FROM TableListeDesPoules";
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
            myCommand.Connection.Open();
            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            while (myReader.Read())
            {
                string poule = (string)myReader["Poule"];
                string descriptionDeLaPoule = (string)myReader["DescriptionDeLaPoule"];
                PoulesList.Add(new ClassPoule()
                {
                    Poule = poule,
                    DescriptionDeLaPoule = descriptionDeLaPoule
                });
            }

            myCommand.Connection.Close();
        }
        private void ChargerRésultatsDesPoulesDuJour()
        {
            ScoresList = new List<ClassScore>() { };

            var path = ServerTmp.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";
            string mySelectQuery = " SELECT * FROM TableRésultatsDesPoules where DateDeLaPoule = '" + DateDuJourWithoutDayLabel + "'";
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
            myCommand.Connection.Open();
            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            while (myReader.Read())
            {
                string poule = (string)myReader["Poule"];

                string guidStr1 = myReader["Tireur1Guid"].ToString().Trim();
                Guid tireur1Guid = Guid.Parse(guidStr1);

                string guidStr2 = myReader["Tireur2Guid"].ToString().Trim();
                Guid tireur2Guid = Guid.Parse(guidStr2);

                bool victoireOuDéfaiteDuTireur1 = (bool)myReader["VictoireOuDéfaiteDuTireur1"];
                bool victoireOuDéfaiteDuTireur2 = (bool)myReader["VictoireOuDéfaiteDuTireur2"];
                int scoreDuTireur1 = (int)myReader["ScoreDuTireur1"];
                int scoreDuTireur2 = (int)myReader["ScoreDuTireur2"];
                ScoresList.Add(new ClassScore()
                {
                    Poule = poule,
                    Tireur1Guid = tireur1Guid,
                    Tireur2Guid = tireur2Guid,
                    VictoireOuDéfaiteDuTireur1 = victoireOuDéfaiteDuTireur1,
                    VictoireOuDéfaiteDuTireur2 = victoireOuDéfaiteDuTireur2,
                    ScoreDuTireur1 = scoreDuTireur1,
                    ScoreDuTireur2 = scoreDuTireur2
                });
            }

            myCommand.Connection.Close();
        }
        private void ChargerRésultatsDesElimintationsDirectesDuJour()
        {
            ScoresEliminitationsDirectesList = new List<ClassScoreEliminationsDirectes>() { };

            var path = ServerTmp.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";
            string mySelectQuery = " SELECT * FROM TableRésultatsDesEliminationsDirectes where DateDeLaPoule = '" + DateDuJourWithoutDayLabel + "'";
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
            myCommand.Connection.Open();
            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            while (myReader.Read())
            {
                string poule = (string)myReader["Poule"];
                string dateDeLaPoule = (string)myReader["DateDeLaPoule"];
                string round = (string)myReader["Round"];
                string indexTireur1 = (string)myReader["IndexTireur1"];
                string indexTireur2 = (string)myReader["IndexTireur2"];
                string tireur1Name = (string)myReader["Tireur1Name"];
                string tireur2Name = (string)myReader["Tireur2Name"];

                string guidStr1 = myReader["Tireur1Guid"].ToString().Trim();
                Guid tireur1Guid = Guid.Parse(guidStr1);

                string guidStr2 = myReader["Tireur2Guid"].ToString().Trim();
                Guid tireur2Guid = Guid.Parse(guidStr2);

                bool victoireOuDéfaiteDuTireur1 = (bool)myReader["VictoireOuDéfaiteDuTireur1"];
                bool victoireOuDéfaiteDuTireur2 = (bool)myReader["VictoireOuDéfaiteDuTireur2"];

                bool scoreDejaIntroduit = (bool)myReader["ScoreDejaIntroduit"];

                int scoreDuTireur1 = (int)myReader["ScoreDuTireur1"];
                int scoreDuTireur2 = (int)myReader["ScoreDuTireur2"];
                ScoresEliminitationsDirectesList.Add(new ClassScoreEliminationsDirectes()
                {
                    DateDeLaPoule = dateDeLaPoule,
                    PouleSelected = poule,
                    Tireur1Guid = tireur1Guid,
                    Tireur2Guid = tireur2Guid,
                    VictoireOuDéfaiteDuTireur1 = victoireOuDéfaiteDuTireur1,
                    VictoireOuDéfaiteDuTireur2 = victoireOuDéfaiteDuTireur2,
                    ScoreDuTireur1 = scoreDuTireur1,
                    ScoreDuTireur2 = scoreDuTireur2,
                    Round = round,
                    IndexTireur1 = indexTireur1,
                    IndexTireur2 = indexTireur2,
                    Tireur1Name = tireur1Name,
                    Tireur2Name = tireur2Name,
                    ScoreDejaIntroduit = scoreDejaIntroduit
                });
            }


            myCommand.Connection.Close();
        }
        private void ChargerPoulesDuJour()
        {
            PoulesDuJourList = new List<ClassPoulesDuJour>() { };

            var path = ServerTmp.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";
            string mySelectQuery = " SELECT * FROM TableDesTireursPourUnePouleDuJour where DateDeLaPoule = '" + DateDuJourWithoutDayLabel + "'";
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
            myCommand.Connection.Open();
            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            while (myReader.Read())
            {
                Guid tireurGuid = (Guid)myReader["TireurGuid"];
                string poule = (string)myReader["Poule"];
                string tireur = (string)myReader["Tireur"];
                PoulesDuJourList.Add(new ClassPoulesDuJour()
                {
                    TireurGuid = tireurGuid,
                    Poule = poule,
                    Tireur = tireur
                });
            }

            myCommand.Connection.Close();
        }

        private void ChargerDatesPourToutesLesPoules()
        {
            DatesPourToutesLesPoulesList = new List<ClassDatesPourToutesLesPoules>() { };

            var path = ServerTmp.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";
            string mySelectQuery = " SELECT DateDeLaPoule FROM TableDesTireursPourUnePouleDuJour GROUP BY DateDeLaPoule";
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
            myCommand.Connection.Open();
            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            while (myReader.Read())
            {
                string dateDeLaPoule = (string)myReader["DateDeLaPoule"];

                DatesPourToutesLesPoulesList.Add(new ClassDatesPourToutesLesPoules()
                {
                    DateDeLaPoule = dateDeLaPoule,
                });
            }

            myCommand.Connection.Close();
        }
        private T GetValueStartsWith<T>(string key)
        {
            var lastSessionKey = System.Web.HttpContext.Current.Session.Keys.Cast<string>()
                .LastOrDefault(x => x.StartsWith(key));

            if (string.IsNullOrEmpty(lastSessionKey))
                return default(T);

            return (T)Convert.ChangeType(HttpContext.Current.Session[lastSessionKey], typeof(T));

            //return (T)Deserialize((string)System.Web.HttpContext.Current.Session[lastSessionKey]);
        }
        private static object Deserialize(string str)
        {
            byte[] bytes = Convert.FromBase64String(str);

            using (MemoryStream stream = new MemoryStream(bytes))
            {
                return new BinaryFormatter().Deserialize(stream);
            }
        }

        private void ChargerListeDesTireurs()
        {
            TireursList = new List<ClassTireur>() { };

            var path = ServerTmp.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";
            string mySelectQuery = " SELECT * FROM TableTireurs";
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
            myCommand.Connection.Open();
            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            while (myReader.Read())
            {
                string tireur = (string)myReader["Tireur"];
                string jourDeLaPoule = (string)myReader["JourDeLaPoule"];
                string pouleAttribuee = (string)myReader["PouleAttribuee"];
                TireursList.Add(new ClassTireur()
                {
                    Tireur = tireur,
                    JourDeLaPoule = jourDeLaPoule,
                    PouleAttribuee = pouleAttribuee
                });
            }

            myCommand.Connection.Close();
        }
    }

    #region All Class public
    public class ClassPoule
    {
        public string Poule { get; set; }
        public string DescriptionDeLaPoule { get; set; }
    }
    public class ClassTireur
    {
        public string Tireur { get; set; }
        public string JourDeLaPoule { get; set; }
        public string PouleAttribuee { get; set; }
        public bool IsSelected { get; set; }
    }
    public class ClassDatesPourToutesLesPoules
    {
        public string DateDeLaPoule { get; set; }
    }
    public class ClassPoulesDuJour
    {
        public Guid TireurGuid { get; set; }
        public string Poule { get; set; }
        public string Tireur { get; set; }
    }
    public class ClassScore
    {
        public Guid Tireur1Guid { get; set; }
        public Guid Tireur2Guid { get; set; }
        public string Poule { get; set; }
        public bool VictoireOuDéfaiteDuTireur1 { get; set; }
        public bool VictoireOuDéfaiteDuTireur2 { get; set; }
        public int ScoreDuTireur1 { get; set; }
        public int ScoreDuTireur2 { get; set; }
    }
    public class ClassScoreEliminationsDirectes
    {
        public string DateDeLaPoule { get; set; }
        public string PouleSelected { get; set; }
        public Guid Tireur1Guid { get; set; }
        public Guid Tireur2Guid { get; set; }
        public string Round { get; set; }
        public string IndexTireur1 { get; set; }
        public string IndexTireur2 { get; set; }
        public string Tireur1Name { get; set; }
        public string Tireur2Name { get; set; }
        public bool VictoireOuDéfaiteDuTireur1 { get; set; }
        public bool VictoireOuDéfaiteDuTireur2 { get; set; }
        public int ScoreDuTireur1 { get; set; }
        public int ScoreDuTireur2 { get; set; }
        public bool ScoreDejaIntroduit { get; set; }
    }
    public class ClassRound
    {
        public string DateDuJourWithoutDay { get; set; }
        public string PouleSelected { get; set; }
        public string Round { get; set; }
        public Guid Tireur1Guid { get; set; }
        public Guid Tireur2Guid { get; set; }
        public string Tireur1Name { get; set; }
        public string Tireur2Name { get; set; }
        public bool VictoireOuDéfaiteDuTireur1 { get; set; }
        public bool VictoireOuDéfaiteDuTireur2 { get; set; }
        public int ScoreDuTireur1 { get; set; }
        public int ScoreDuTireur2 { get; set; }
        public int IndexTireur1 { get; set; }
        public int IndexTireur2 { get; set; }
    }
    public class MatchFencer 
    { 
        public int Round { get; set; }
        public int Seed1 { get; set; } 
        public int Seed2 { get; set; }
    }

    #endregion
}