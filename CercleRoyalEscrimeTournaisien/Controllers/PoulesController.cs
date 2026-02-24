using CercleRoyalEscrimeTournaisien.ClassPublic;
using CercleRoyalEscrimeTournaisien.Models;
using DocumentFormat.OpenXml.Office.Word;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
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
        public ActionResult AjouterDesScores()
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);
            poulesViewModel.ScreenIndex = ClassEnumScreen.EnumScreen.AjouterScoreAUnePoule;

            return View(Constantes.Poules, poulesViewModel);
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
                if (!ExistsRecord(poulesViewModel.DateDuJourWithoutDay, pouleSelected, tireur))
                {
                    string mySelectQuery = "INSERT INTO TableDesTireursPourUnePouleDuJour (DateDeLaPoule, Poule, Tireur) Values ('" + poulesViewModel.DateDuJourWithoutDay + "','" + pouleSelected + "','" + tireur + "')";

                    OleDbConnection myConnection = new OleDbConnection(ConnectionString);
                    OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
                    myCommand.Connection.Open();
                    OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    myCommand.Connection.Close();
                }                  
            }

            return Json(new { redirectUrl = Url.Action("AfficherLesPoules", "Poules") });

            // return RedirectToAction("AfficherLesPoules", "Poules");
        }

        [HttpPost]
        public ActionResult AddScoreToTireursSelected(MyRequestScoreToSaveInPoule myRequestScoreToSaveInPoule)
        {
            PoulesViewModel poulesViewModel = new PoulesViewModel(Server);

            var path = Server.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            string mySelectQueryDelete1 = @" DELETE FROM TableRésultats WHERE RTRIM(Tireur1Guid) = @t1 AND RTRIM(Tireur2Guid) = @t2 AND Poule = @poule";

            OleDbConnection myConnection = new OleDbConnection(ConnectionString);
            OleDbCommand myCommandDelete1 = new OleDbCommand(mySelectQueryDelete1, myConnection);

            myCommandDelete1.Parameters.AddWithValue("@t1", myRequestScoreToSaveInPoule.Tireur1Guid.ToString().TrimEnd());
            myCommandDelete1.Parameters.AddWithValue("@t2", myRequestScoreToSaveInPoule.Tireur2Guid.ToString().TrimEnd());
            myCommandDelete1.Parameters.AddWithValue("@poule", myRequestScoreToSaveInPoule.PouleSelected);

            myCommandDelete1.Connection.Open();
            int rowsDelete1 = myCommandDelete1.ExecuteNonQuery();
            if (rowsDelete1 != 0)
            {
                myCommandDelete1.ExecuteReader(CommandBehavior.CloseConnection);
            }
            myCommandDelete1.Connection.Close();

            string mySelectQueryDelete2 = @" DELETE FROM TableRésultats WHERE RTRIM(Tireur2Guid) = @t1 AND RTRIM(Tireur1Guid) = @t2 AND Poule = @poule";
            
            OleDbCommand myCommandDelete2 = new OleDbCommand(mySelectQueryDelete2, myConnection);

            myCommandDelete2.Parameters.AddWithValue("@t1", myRequestScoreToSaveInPoule.Tireur1Guid.ToString().TrimEnd());
            myCommandDelete2.Parameters.AddWithValue("@t2", myRequestScoreToSaveInPoule.Tireur2Guid.ToString().TrimEnd());
            myCommandDelete2.Parameters.AddWithValue("@poule", myRequestScoreToSaveInPoule.PouleSelected);

            myCommandDelete2.Connection.Open();
            int rowsDelete2 = myCommandDelete2.ExecuteNonQuery();
            if (rowsDelete2 != 0)
            {
                myCommandDelete2.ExecuteReader(CommandBehavior.CloseConnection);
            }

            myCommandDelete2.Connection.Close();


            string mySelectQuery2 = "INSERT INTO TableRésultats (Poule, Tireur1Guid,Tireur2Guid,DateDeLaPoule ,VictoireOuDéfaiteDuTireur1,VictoireOuDéfaiteDuTireur2,ScoreDuTireur1,ScoreDuTireur2) " +
                "Values ('" + myRequestScoreToSaveInPoule.PouleSelected + "','"
                + myRequestScoreToSaveInPoule.Tireur1Guid.ToString().TrimEnd() + "','" 
                + myRequestScoreToSaveInPoule.Tireur2Guid.ToString().TrimEnd() + "','" 
                + poulesViewModel.DateDuJourWithoutDay + "','"
                + (myRequestScoreToSaveInPoule.Vainqueur == 1  ? "1" : "0") + "','" 
                + (myRequestScoreToSaveInPoule.Vainqueur == 2  ? "1" : "0") + "','"
                + myRequestScoreToSaveInPoule.ScoreTireur1 + "','"
                + myRequestScoreToSaveInPoule.ScoreTireur2 + "')";

            
            OleDbCommand myCommand2 = new OleDbCommand(mySelectQuery2, myConnection);
            myCommand2.Connection.Open();
            OleDbDataReader myReader2 = myCommand2.ExecuteReader(CommandBehavior.CloseConnection);
            myCommand2.Connection.Close();


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

            int nombreRoundMax = CalculerRoundMax(myRequestResultatsPoule.ClassResultatsList.Count);
            int nombreDePlaces = CalculerNombreDePlaces(myRequestResultatsPoule.ClassResultatsList.Count);
            int nombreDeMatchs = nombreDePlaces / 2;
            List<ClassRound> roundsList = new List<ClassRound>() { };

            for (int loop = 1; loop <= nombreDeMatchs; loop++)
            {
                int indexAdversaire = nombreDePlaces + 1 - loop;

                roundsList.Add(new ClassRound()
                {
                    Tireur1Guid = classResultatsList[loop - 1].TireurGuid,
                    Tireur2Guid = indexAdversaire <= classResultatsList.Count ? classResultatsList[indexAdversaire - 1].TireurGuid : new Guid(),
                    DateDuJour = poulesViewModel.DateDuJourWithoutDay,
                    Poule = pouleSelected,
                    Round = "1/" + nombreRoundMax.ToString(),
                    IndexTireur1 = loop,
                    IndexTireur2 = indexAdversaire
                });
            }

            return null; 
        }
        private int CalculerNombreDePlaces(int nbTireurs) 
        { 
            int roundMax = (int)Math.Ceiling(Math.Log(nbTireurs, 2)); return (int)Math.Pow(2, roundMax); 
        }
        private int CalculerRoundMax(int nbTireurs)
        { 
            return (int)Math.Ceiling(Math.Log(nbTireurs, 2)); 
        }
        private bool ExistsRecord(string dateDuJourWithoutDay, string pouleSelected, string tireur)
        {
            var path = Server.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";
            string mySelectQuery = "SELECT * FROM TableDesTireursPourUnePouleDuJour WHERE DateDeLaPoule='" + dateDuJourWithoutDay + "' AND Poule='" + pouleSelected + "' AND Tireur='" + tireur + "'";
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
            myCommand.Connection.Open();
            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            bool existsRecord = false;
            while (myReader.Read())
            {
                existsRecord = true;
                break;
            }
            myCommand.Connection.Close();
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