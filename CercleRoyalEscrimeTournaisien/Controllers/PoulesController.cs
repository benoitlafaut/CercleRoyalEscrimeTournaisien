using CercleRoyalEscrimeTournaisien.ClassPublic;
using CercleRoyalEscrimeTournaisien.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;

namespace CercleRoyalEscrimeTournaisien
{
    [RoutePrefix("Poules")]
    public class PoulesController : Controller
    {

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Poules()
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.MenuPrincipal;
            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult AjouterTireurAUnePoule()
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.AddTireurs;

            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult AfficherLesPoules()
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.AfficherLesPoules;

            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult AfficherLesEliminationsDirectes()
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.AfficherLesEliminationsDirectes;

            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ChangePoule(string pouleSelected)
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.AddTireurs;
            poulesViewModel.PouleSelected = pouleSelected;

            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ChangePoulePourAjouterScore(string pouleSelected)
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.AjouterScoreAUnePoule;
            poulesViewModel.PouleSelected = pouleSelected;

            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ShowDirectlyScore(string pouleSelected, string tireur1Guid, string tireur2Guid)
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.AjouterScoreAUnePoule;
            poulesViewModel.PouleSelected = pouleSelected;
            poulesViewModel.Tireur1Selected = tireur1Guid;
            poulesViewModel.Tireur2Selected = tireur2Guid;

            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ChangePoulePourShowEliminationsDirectes(string pouleSelected)
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.AfficherLesEliminationsDirectes;
            poulesViewModel.PouleSelected = pouleSelected;

            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ChangeRoundPourShowEliminationsDirectes(string roundSelected, string pouleSelected)
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.AfficherLesEliminationsDirectes;
            poulesViewModel.PouleSelected = pouleSelected;
            poulesViewModel.RoundSelected = roundSelected;

            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult CalculerLeRoundSuivant(string roundSelected, string pouleSelected, string dateDuJourWithoutDay)
        {
            string roundSuivant = GetRoundSuivant(roundSelected);

            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            List<ClassScoreEliminationsDirectes> scores = poulesViewModel.GetOrdreDesMatchs(poulesViewModel.ScoresEliminitationsDirectesList.Where(x => x.PouleSelected == pouleSelected && x.Round == roundSelected).ToList());

            int nombreDePlaces = CalculerNombreDePlaces(scores.Count);
            int nombreDeMatchs = nombreDePlaces / 2;

            List<ClassScoreEliminationsDirectes> newScores = new List<ClassScoreEliminationsDirectes>() { };

            for (int i = 0; i < scores.Count; i += 2)
            {
                newScores.Add(new ClassScoreEliminationsDirectes()
                {
                    Round = roundSuivant,
                    PouleSelected = pouleSelected,
                    DateDeLaPoule = dateDuJourWithoutDay,
                    Tireur1Guid = scores[i].ScoreDuTireur1 > scores[i].ScoreDuTireur2 ? scores[i].Tireur1Guid : scores[i].Tireur2Guid,
                    Tireur1Name = scores[i].ScoreDuTireur1 > scores[i].ScoreDuTireur2 ? scores[i].Tireur1Name : scores[i].Tireur2Name,
                    IndexTireur1 = scores[i].ScoreDuTireur1 > scores[i].ScoreDuTireur2 ? scores[i].IndexTireur1 : scores[i].IndexTireur2,
                    Tireur2Guid = scores[i+1].ScoreDuTireur1 > scores[i+1].ScoreDuTireur2 ? scores[i+1].Tireur1Guid : scores[i + 1].Tireur2Guid,
                    Tireur2Name = scores[i + 1].ScoreDuTireur1 > scores[i + 1].ScoreDuTireur2 ? scores[i+1].Tireur1Name : scores[i + 1].Tireur2Name,
                    IndexTireur2 = scores[i + 1].ScoreDuTireur1 > scores[i + 1].ScoreDuTireur2 ? scores[i+1].IndexTireur1 : scores[i + 1].IndexTireur2,
                });
            }                          
            

            var path = Server.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";
            
            foreach (var score in newScores)
            {

                using (var conn = new OleDbConnection(ConnectionString))
                {
                    conn.Open();

                    string mySelectQuery2 = "INSERT INTO TableRésultatsDesEliminationsDirectes " +
                       "(Poule, Tireur1Guid,Tireur2Guid,DateDeLaPoule," +
                       "ScoreDuTireur1,ScoreDuTireur2, Round, IndexTireur1, IndexTireur2, tireur1Name,tireur2Name,ScoreDejaIntroduit) " +
                       "Values (@param1, @param2,@param3,@param4,@param7,@param8,@param9,@param10,@param11,@param12,@param13,@param14)";


                    using (var cmd = new OleDbCommand(mySelectQuery2, conn))
                    {
                        cmd.Parameters.AddWithValue("@param1", pouleSelected);
                        cmd.Parameters.AddWithValue("@param2", score.Tireur1Guid.ToString().TrimEnd());
                        cmd.Parameters.AddWithValue("@param3", score.Tireur2Guid.ToString().TrimEnd());
                        cmd.Parameters.AddWithValue("@param4", dateDuJourWithoutDay);
                        cmd.Parameters.AddWithValue("@param7", 0);
                        cmd.Parameters.AddWithValue("@param8", 0);
                        cmd.Parameters.AddWithValue("@param9", score.Round);
                        cmd.Parameters.AddWithValue("@param10", score.IndexTireur1);
                        cmd.Parameters.AddWithValue("@param11", score.IndexTireur2);
                        cmd.Parameters.AddWithValue("@param12", score.Tireur1Name);
                        cmd.Parameters.AddWithValue("@param13", score.Tireur2Name);
                        cmd.Parameters.AddWithValue("@param14", "0");

                        using (var reader = cmd.ExecuteReader())
                        {                           
                        }
                    }
                }
            }

            return Json(new { redirectUrl = Url.Action("Poules", "Poules") });
        }

        private string GetRoundSuivant(string roundSelected)
        {
            switch(roundSelected)
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

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult AjouterDesScores()
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.AjouterScoreAUnePoule;

            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult AfficherLesDatesPrecedentes()
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.AfficherLesDatesPrecedentes;

            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ResetDates()
        {
            System.Web.HttpContext.Current.Session.Remove("IsOtherDateThanDateDuJour");
            System.Web.HttpContext.Current.Session.Remove("OtherDate");

            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.MenuPrincipal;

            return View(Constantes.Poules, poulesViewModel);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ChangeDateDeLaPoule(string dateDeLaPouleSelected)
        {
            System.Web.HttpContext.Current.Session.Add("IsOtherDateThanDateDuJour", "true");
            System.Web.HttpContext.Current.Session.Add("OtherDate", dateDeLaPouleSelected);
            return RedirectToAction("Poules", "poules");          
        }

        [HttpPost]
        public ActionResult AddTireursSelectedToPoule(MyRequestToSaveInPoule myRequestToSaveInPoule)
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);

            var path = Server.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            string pouleSelected = myRequestToSaveInPoule.PouleSelected;
            List<string> tireursSelected = myRequestToSaveInPoule.TireursSelected;

            foreach(string tireur in tireursSelected)
            {
                if (!ExistsRecord(poulesViewModel.DateDuJourWithoutDayLabel, pouleSelected, tireur))
                {
                    using (var conn = new OleDbConnection(ConnectionString))
                    {
                        conn.Open();       
                        
                        string mySelectQuery = "INSERT INTO TableDesTireursPourUnePouleDuJour (DateDeLaPoule, Poule, Tireur) Values ('" + poulesViewModel.DateDuJourWithoutDayLabel + "','" + pouleSelected + "','" + tireur + "')";

                        using (var cmd = new OleDbCommand(mySelectQuery, conn))
                        {
                            using (var reader = cmd.ExecuteReader())
                            {
                               
                            }
                        }
                    }
                }                  
            }

            return Json(new { redirectUrl = Url.Action("AfficherLesPoules", "Poules") });
        }
        [HttpPost]
        public ActionResult AddScoreEliminationDirecte(MyRequestEliminationDirecteToSaveInPoule myRequestEliminationDirecteToSaveInPoule)
        {
            var path = Server.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            string mySelectQuery = "UPDATE TableRésultatsDesEliminationsDirectes SET VictoireOuDéfaiteDuTireur1 = ?,VictoireOuDéfaiteDuTireur2 = ?, ScoreDuTireur1 = ?, ScoreDuTireur2 = ?, ScoreDejaIntroduit = ? "
                + " where DateDeLaPoule = ? and Poule = ? and Tireur1Guid = ? and Tireur2Guid = ?";


            using (var conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(mySelectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", myRequestEliminationDirecteToSaveInPoule.InputScoreTireur1Guid > myRequestEliminationDirecteToSaveInPoule.InputScoreTireur2Guid ? "1" : "0");
                    cmd.Parameters.AddWithValue("?", myRequestEliminationDirecteToSaveInPoule.InputScoreTireur2Guid > myRequestEliminationDirecteToSaveInPoule.InputScoreTireur1Guid ? "1" : "0");
                    cmd.Parameters.AddWithValue("?", myRequestEliminationDirecteToSaveInPoule.InputScoreTireur1Guid);
                    cmd.Parameters.AddWithValue("?", myRequestEliminationDirecteToSaveInPoule.InputScoreTireur2Guid);
                    cmd.Parameters.AddWithValue("?", "1");
                    cmd.Parameters.AddWithValue("?", myRequestEliminationDirecteToSaveInPoule.DateDuJourWithoutDay);
                    cmd.Parameters.AddWithValue("?", myRequestEliminationDirecteToSaveInPoule.PouleSelected);
                    cmd.Parameters.AddWithValue("?", myRequestEliminationDirecteToSaveInPoule.Tireur1Guid.ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("?", myRequestEliminationDirecteToSaveInPoule.Tireur2Guid.ToString().TrimEnd());

                    using (var reader = cmd.ExecuteReader())
                    {
                        
                    }
                }
            }

            return Json(new { redirectUrl = Url.Action("ChangeRoundPourShowEliminationsDirectes", "Poules", new { roundSelected = myRequestEliminationDirecteToSaveInPoule.Round, PouleSelected = myRequestEliminationDirecteToSaveInPoule.PouleSelected }) });
        }
        [HttpPost]
        public ActionResult AddScoreToTireursSelected(MyRequestScoreToSaveInPoule myRequestScoreToSaveInPoule)
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);

            var path = Server.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            string mySelectQueryDelete1 = @" DELETE FROM TableRésultatsDesPoules WHERE RTRIM(Tireur1Guid) = @t1 AND RTRIM(Tireur2Guid) = @t2 AND Poule = @poule";

            using (var conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(mySelectQueryDelete1, conn))
                {
                    cmd.Parameters.AddWithValue("@t1", myRequestScoreToSaveInPoule.Tireur1Guid.ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@t2", myRequestScoreToSaveInPoule.Tireur2Guid.ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@poule", myRequestScoreToSaveInPoule.PouleSelected);

                    using (var reader = cmd.ExecuteReader())
                    {
                       
                    }
                }
            }

            string mySelectQueryDelete2 = @" DELETE FROM TableRésultatsDesPoules WHERE RTRIM(Tireur2Guid) = @t1 AND RTRIM(Tireur1Guid) = @t2 AND Poule = @poule";

            using (var conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(mySelectQueryDelete2, conn))
                {
                    cmd.Parameters.AddWithValue("@t1", myRequestScoreToSaveInPoule.Tireur1Guid.ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@t2", myRequestScoreToSaveInPoule.Tireur2Guid.ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@poule", myRequestScoreToSaveInPoule.PouleSelected);

                    using (var reader = cmd.ExecuteReader())
                    {

                    }
                }
            }


            string mySelectQuery2 = "INSERT INTO TableRésultatsDesPoules (Poule, Tireur1Guid,Tireur2Guid,DateDeLaPoule ,VictoireOuDéfaiteDuTireur1,VictoireOuDéfaiteDuTireur2,ScoreDuTireur1,ScoreDuTireur2, QuestionMeneOuNon) " +
                "Values ('" + myRequestScoreToSaveInPoule.PouleSelected + "','"
                + myRequestScoreToSaveInPoule.Tireur1Guid.ToString().TrimEnd() + "','" 
                + myRequestScoreToSaveInPoule.Tireur2Guid.ToString().TrimEnd() + "','" 
                + poulesViewModel.DateDuJourWithoutDayLabel + "','"
                + (myRequestScoreToSaveInPoule.Vainqueur == 1  ? "1" : "0") + "','" 
                + (myRequestScoreToSaveInPoule.Vainqueur == 2  ? "1" : "0") + "','"
                + myRequestScoreToSaveInPoule.ScoreTireur1 + "','"
                + myRequestScoreToSaveInPoule.ScoreTireur2 + "','"
                + myRequestScoreToSaveInPoule.QuestionMeneOuNon + "')";

            using (var conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(mySelectQuery2, conn))
                {                   
                    using (var reader = cmd.ExecuteReader())
                    {

                    }
                }
            }




            return Json(new { redirectUrl = Url.Action("AfficherLesPoules", "Poules") });            
        }

        [HttpPost]
        public ActionResult TraiterTableau(MyRequestResultatsPoule myRequestResultatsPoule, string pouleSelected)
        {
            myRequestResultatsPoule.ClassResultatsList.RemoveAll(x => x.NombreDeVictoiresParMatchs == null);

            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            List<ClassPoulesDuJour> poules = poulesViewModel.PoulesDuJourList.Where(x => x.Poule == pouleSelected).ToList();

            int index = 0;

            foreach (ClassResultats classResultats in myRequestResultatsPoule.ClassResultatsList)
            {
                classResultats.TireurGuid = poules[index].TireurGuid;
                classResultats.Tireur = poules[index].Tireur;
                index++;
            }

            List<ClassResultats> classResultatsList = myRequestResultatsPoule.ClassResultatsList.OrderByDescending(x => x.NombreDeVictoiresParMatchs).ThenByDescending(x => int.Parse(x.TDMoinsTR)).ThenByDescending(x => int.Parse(x.TD)).ThenBy(x => x.Tireur).ToList();

            int nombreRoundMax = GetTableau(index);
            int nombreDePlaces = CalculerNombreDePlaces(myRequestResultatsPoule.ClassResultatsList.Count);
            int nombreDeMatchs = nombreDePlaces / 2;
            List<ClassRound> roundsList = new List<ClassRound>() { };

            for (int loop = 1; loop <= nombreDeMatchs; loop++)
            {
                int indexAdversaire = nombreDePlaces + 1 - loop;

                roundsList.Add(new ClassRound()
                {
                    Tireur1Guid = classResultatsList[loop - 1].TireurGuid,
                    Tireur1Name = classResultatsList[loop - 1].Tireur,
                    Tireur2Guid = indexAdversaire <= classResultatsList.Count ? classResultatsList[indexAdversaire - 1].TireurGuid : new Guid(),
                    Tireur2Name = indexAdversaire <= classResultatsList.Count ? classResultatsList[indexAdversaire - 1].Tireur : "",
                    DateDuJourWithoutDay = poulesViewModel.DateDuJourWithoutDayLabel,
                    PouleSelected = pouleSelected,
                    Round = nombreRoundMax == 2 ? "Finale" : "1/" + (nombreRoundMax / 2).ToString(),
                    IndexTireur1 = loop,
                    IndexTireur2 = indexAdversaire
                });
            }

            var path = Server.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            OleDbConnection myConnection = new OleDbConnection(ConnectionString);

            foreach (var round in roundsList)
            {
                var victoireOuDéfaiteDuTireur1 = (round.Tireur2Guid.ToString().TrimEnd() == Guid.Empty.ToString()) ? "1" : null;
                var victoireOuDéfaiteDuTireur2 = (round.Tireur2Guid.ToString().TrimEnd() == Guid.Empty.ToString()) ? "0" : null;

                var scoreDejaIntroduit = (round.Tireur2Guid.ToString().TrimEnd() == Guid.Empty.ToString()) ? "1" : "0";

                var scoreDuTireur1 = (round.Tireur2Guid.ToString().TrimEnd() == Guid.Empty.ToString()) ? "15" : "0";
                var scoreDuTireur2 = (round.Tireur2Guid.ToString().TrimEnd() == Guid.Empty.ToString()) ? "0" : "0";

                if (victoireOuDéfaiteDuTireur1 == null)
                {
                    string mySelectQuery2 = "INSERT INTO TableRésultatsDesEliminationsDirectes " +
                        "(Poule, Tireur1Guid,Tireur2Guid,DateDeLaPoule," +
                        "ScoreDuTireur1,ScoreDuTireur2, Round, IndexTireur1, IndexTireur2, tireur1Name,tireur2Name,ScoreDejaIntroduit) " +
                        "Values (@param1, @param2,@param3,@param4,@param7,@param8,@param9,@param10,@param11,@param12,@param13,@param14)";


                    using (var conn = new OleDbConnection(ConnectionString))
                    {
                        conn.Open();
                        using (var cmd = new OleDbCommand(mySelectQuery2, conn))
                        {
                            cmd.Parameters.AddWithValue("@param1", round.PouleSelected);
                            cmd.Parameters.AddWithValue("@param2", round.Tireur1Guid.ToString().TrimEnd());
                            cmd.Parameters.AddWithValue("@param3", round.Tireur2Guid.ToString().TrimEnd());
                            cmd.Parameters.AddWithValue("@param4", round.DateDuJourWithoutDay);
                            cmd.Parameters.AddWithValue("@param7", scoreDuTireur1);
                            cmd.Parameters.AddWithValue("@param8", scoreDuTireur2);
                            cmd.Parameters.AddWithValue("@param9", round.Round);
                            cmd.Parameters.AddWithValue("@param10", round.IndexTireur1);
                            cmd.Parameters.AddWithValue("@param11", round.IndexTireur2);
                            cmd.Parameters.AddWithValue("@param12", round.Tireur1Name);
                            cmd.Parameters.AddWithValue("@param13", round.Tireur2Name);
                            cmd.Parameters.AddWithValue("@param14", scoreDejaIntroduit);

                            using (var reader = cmd.ExecuteReader())
                            {
                               
                            }
                        }
                    }
                }
                else
                {
                    string mySelectQuery2 = "INSERT INTO TableRésultatsDesEliminationsDirectes " +
                        "(Poule, Tireur1Guid,Tireur2Guid,DateDeLaPoule ,VictoireOuDéfaiteDuTireur1,VictoireOuDéfaiteDuTireur2," +
                        "ScoreDuTireur1,ScoreDuTireur2, Round, IndexTireur1, IndexTireur2, Tireur1Name,Tireur2Name,ScoreDejaIntroduit) " +
                        "Values (@param1, @param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10,@param11 ,@param12 ,@param13,@param14 ) ";
                   
                    using (var conn = new OleDbConnection(ConnectionString))
                    {
                        conn.Open();
                        using (var cmd = new OleDbCommand(mySelectQuery2, conn))
                        {
                            cmd.Parameters.AddWithValue("@param1", round.PouleSelected);
                            cmd.Parameters.AddWithValue("@param2", round.Tireur1Guid.ToString().TrimEnd());
                            cmd.Parameters.AddWithValue("@param3", round.Tireur2Guid.ToString().TrimEnd());
                            cmd.Parameters.AddWithValue("@param4", round.DateDuJourWithoutDay);
                            cmd.Parameters.AddWithValue("@param5", victoireOuDéfaiteDuTireur1);
                            cmd.Parameters.AddWithValue("@param6", victoireOuDéfaiteDuTireur2);
                            cmd.Parameters.AddWithValue("@param7", scoreDuTireur1);
                            cmd.Parameters.AddWithValue("@param8", scoreDuTireur2);
                            cmd.Parameters.AddWithValue("@param9", round.Round);
                            cmd.Parameters.AddWithValue("@param10", round.IndexTireur1);
                            cmd.Parameters.AddWithValue("@param11", round.IndexTireur2);
                            cmd.Parameters.AddWithValue("@param12", round.Tireur1Name);
                            cmd.Parameters.AddWithValue("@param13", round.Tireur2Name);
                            cmd.Parameters.AddWithValue("@param14", scoreDejaIntroduit);

                            using (var reader = cmd.ExecuteReader())
                            {
                                
                            }
                        }
                    }
                }
            }

            return Json(new { redirectUrl = Url.Action("Poules", "Poules") });
        }
        private int GetTableau(int nbTireurs)
        {
            if (nbTireurs < 2)
                return 0;

            // Trouver la plus petite puissance de 2 >= nbTireurs
            int tableau = 1;
            while (tableau < nbTireurs)
                tableau *= 2;

            return tableau;
        }
        private int CalculerNombreDePlaces(int nbTireurs) 
        { 
            int roundMax = (int)Math.Ceiling(Math.Log(nbTireurs, 2)); return (int)Math.Pow(2, roundMax); 
        }
       
        private bool ExistsRecord(string dateDuJourWithoutDay, string pouleSelected, string tireur)
        {
            bool existsRecord = false;
            var path = Server.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Mode=Read;Persist Security Info=True";
            string mySelectQuery = "SELECT * FROM TableDesTireursPourUnePouleDuJour WHERE DateDeLaPoule = '" + dateDuJourWithoutDay + "' AND Poule = '" + pouleSelected + "' AND Tireur = '" + tireur + "'";

            using (var conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(mySelectQuery, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            existsRecord = true;
                            break;
                        }
                    }
                }
            }

            return existsRecord;
        }

        #region renderRazorView
        private string RenderRazorViewToString(string viewName, object model)
        {
            return RenderRazorViewToString(viewName, model, string.Empty);
        }
        private string RenderRazorViewToString(string viewName, object model, string Prefix)
        {
            var viewDataForPrefix = new ViewDataDictionary
            {
                TemplateInfo = new TemplateInfo { HtmlFieldPrefix = Prefix }
            };
            return RenderRazorViewToString(viewName, model, viewDataForPrefix);
        }
        private string RenderRazorViewToString(string viewName, object model, ViewDataDictionary ViewdataDictionary)
        {
            ViewData = ViewdataDictionary;
            ViewData.Model = model;

            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }

       
        #endregion
    }    
}