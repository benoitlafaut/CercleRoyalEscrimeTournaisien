using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
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
        }

        public HttpServerUtilityBase ServerTmp { get; set; }
        public List<ClassPoule> PoulesList { get; set; }
        public List<ClassScore> ScoresList { get; set; }
        public List<ClassScoreEliminationsDirectes> ScoresEliminitationsDirectesList { get; set; }        
        public List<ClassPoulesDuJour> PoulesDuJourList { get; set; }
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
                return DateTime.Now.AddDays(0);
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
                default:
                    return new List<string>() { };
            }
        }
        public string DateDuJour
        {
            get
            {
                DateTime dateNow = DateDAujourdhui;
                var culture = new CultureInfo("fr-FR");
                string dateFormatee = dateNow.ToString("dddd, dd MMMM yyyy", culture);
                return dateFormatee;
            }
        }
        public string DateDuJourWithoutDay
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
            string mySelectQuery = " SELECT * FROM TableRésultatsDesPoules where DateDeLaPoule = '" + DateDuJourWithoutDay + "'";
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
            string mySelectQuery = " SELECT * FROM TableRésultatsDesEliminationsDirectes where DateDeLaPoule = '" + DateDuJourWithoutDay + "'";
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
            string mySelectQuery = " SELECT * FROM TableDesTireursPourUnePouleDuJour where DateDeLaPoule = '" + DateDuJourWithoutDay + "'";
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
}