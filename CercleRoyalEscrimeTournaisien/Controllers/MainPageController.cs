using CercleRoyalEscrimeTournaisien.ClassPublic;
using CercleRoyalEscrimeTournaisien.Models;
using System;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using WebApplication1.Models;
using System.Threading.Tasks;
using FluentValidation.Results;
using System.Web;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Runtime.Serialization.Formatters.Binary;
using static CercleRoyalEscrimeTournaisien.IndexTireurConstantes;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [RoutePrefix("MainPage")]
    public class MainPageController : Controller
    {

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        [Route("Video")]
        public ActionResult Video()
        {
            System.Web.HttpContext.Current.Session.Add(Constantes.CurrentPage, Constantes.Serialize(Constantes.Video));

            ModelMainPage mainPage = new ModelMainPage();
            mainPage.HasPubAlreadyShowed = Models.MainModel.HasPubAlreadyShowed;

            if (Models.MainModel.HasPubAlreadyShowed)
            {
                Models.MainModel.HasPubAlreadyShowed = false;
            }


            return View(mainPage);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        [Route("StartPageNew")]
        public ActionResult StartPageNew()
        {
            System.Web.HttpContext.Current.Session.Remove("tireurSelectionne");

            return View();
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        [Route("NosCoursParTireurLogin")]
        public ActionResult NosCoursParTireurLogin()
        {
            NosCoursParTireurLoginModel nosCoursParTireurLoginModel = new NosCoursParTireurLoginModel();
            return View(nosCoursParTireurLoginModel);
        }


        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        [Route("ChangeVideo")]
        public ActionResult ChangeVideo(ModelMainPage modelMainPage, int step)
        {
            modelMainPage.CurrentVideo += step;
            if (modelMainPage.CurrentVideo > 4) { modelMainPage.CurrentVideo = 0; }
            if (modelMainPage.CurrentVideo == -1) { modelMainPage.CurrentVideo = 4; }
            return Json(new { mainPage = RenderRazorViewToString(Constantes.Video, modelMainPage) }, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        [Route("ChangeArtiste")]
        public ActionResult ChangeArtiste(KaraokeViewModel karaokeViewModel)
        {
            karaokeViewModel.ChansonSelected = "0";
            return Json(new { karaokeViewModel = RenderRazorViewToString(Constantes.Karaoke, karaokeViewModel) }, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        [Route("ChangeChanson")]
        public ActionResult ChangeChanson(KaraokeViewModel karaokeViewModel)
        {
            return Json(new { karaokeViewModel = RenderRazorViewToString(Constantes.Karaoke, karaokeViewModel) }, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        [Route("ShowMenuPrincipal")]
        public ActionResult ShowMenuPrincipal()
        {
            return View(Constantes.ShowMenuPrincipal);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        [Route("Accueil")]
        public ActionResult Accueil()
        {
            return View(Constantes.Accueil);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        [Route("Agenda")]
        public ActionResult Agenda()
        {
            Agenda modelAgenda = new Agenda();
            return View(modelAgenda);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ChangeMoisMoins1(DateTime DateCurrent)
        {
            Agenda modelAgenda = new Agenda
            {
                DateCurrent = DateCurrent.AddMonths(-1)
            };
            return View(Constantes.Agenda, modelAgenda);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ChangeMoisPlus1(DateTime DateCurrent)
        {
            Agenda modelAgenda = new Agenda
            {
                DateCurrent = DateCurrent.AddMonths(1)
            };
            return View(Constantes.Agenda, modelAgenda);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Catégories()
        {
            Categories modelCategories = new Categories();
            return View(Constantes.Catégories, modelCategories);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Albums()
        {
            Albums modelAlbums = new Albums();
            return View(Constantes.Albums, modelAlbums);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ChangePhotos(string id)
        {
            Albums modelAlbums = new Albums
            {
                NumeroAlbumCurrent = Convert.ToInt32(id),
                NumeroPhotoOfAlbumCurrent = 1
            };
            return Json(new { modelAlbums = RenderRazorViewToString(Constantes.Albums, modelAlbums) }, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Historique()
        {
            return View(Constantes.Historique);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Activités()
        {
            Activites modelActivites = new Activites();
            return View(Constantes.Activités, modelActivites);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult QuelquesSitesInteressants()
        {
            QuelquesSites modelQuelquesSitesInteressants = new QuelquesSites();
            return View(Constantes.QuelquesSitesInteressants, modelQuelquesSitesInteressants);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult NosCours(int newSelectedIndexTheme = 0)
        {
            NosCours modelNosCours = new NosCours();

            if (newSelectedIndexTheme == -1) { newSelectedIndexTheme = (modelNosCours.AllTitresThemeDistinct.Count() - 1); }
            if (Convert.ToInt32(newSelectedIndexTheme) == modelNosCours.AllTitresThemeDistinct.Count()) { newSelectedIndexTheme = 0; }

            modelNosCours.NewSelectedIndexTheme = newSelectedIndexTheme;
            return View(Constantes.NosCours, modelNosCours);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult PagePersoManager()
        {
            return View(Constantes.PagePersoManager);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Epub_20221112()
        {
            ModelViewEpubFile modelViewEpubFile = new ModelViewEpubFile();
            return View(Constantes.Epub_20221112, modelViewEpubFile);
        }
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ScreenPDFPage()
        {
            ModelBDFile modelBDFile = new ModelBDFile();
            return View(Constantes.ScreenPDFPage, modelBDFile);
        }
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Dico()
        {
            ModelViewDico modelViewDico = new ModelViewDico();
            return View(Constantes.Dico, modelViewDico);
        }
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ReadEpub20042023()
        {
            ModelEpub20042023 modelEpub20042023 = new ModelEpub20042023();
            return View(Constantes.ReadEpub20042023, modelEpub20042023);
        }
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ReadEpub28012024()
        {
            ModelEpub20042023 modelEpub20042023 = new ModelEpub20042023();
            return View(Constantes.ReadEpub28012024, modelEpub20042023);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Mp3()
        {
            Mp3 mp3 = new Mp3();
            return View(Constantes.Mp3, mp3);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult NosCoursTireurSelectionne()
        {
            Tireur tireurSelectionne = this.GetValueStartsWith<Tireur>("tireurSelectionne");
            if (tireurSelectionne == null)
            {
                return RedirectToAction("NosCoursParTireurLogin", "MainPage");
            }

            NosCoursTireurSelectionneModel nosCoursTireurSelectionneModel = new NosCoursTireurSelectionneModel() 
            { 
                TireurSelectionne = tireurSelectionne
            };            
            
            return View(Constantes.NosCoursTireurSelectionne, nosCoursTireurSelectionneModel);
        }
        private static object Deserialize(string str)
        {
            byte[] bytes = Convert.FromBase64String(str);

            using (MemoryStream stream = new MemoryStream(bytes))
            {
                return new BinaryFormatter().Deserialize(stream);
            }
        }
        private T GetValueStartsWith<T>(string key)
        {
            var lastSessionKey = System.Web.HttpContext.Current.Session.Keys.Cast<string>()
                .LastOrDefault(x => x.StartsWith(key));

            if (string.IsNullOrEmpty(lastSessionKey))
                return default(T);

            return (T)Deserialize((string)System.Web.HttpContext.Current.Session[lastSessionKey]);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Velo()
        {
            Velo velo = new Velo();
            return View(Constantes.Velo, velo);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Karaoke()
        {
            KaraokeViewModel karaokeViewModel = new KaraokeViewModel ();
            return View(Constantes.Karaoke, karaokeViewModel);
        }

        [HttpPost]
        public JsonResult ChargerEpubNew20042023()
        {
            string result = new StreamReader(Request.Files[0].InputStream).ReadToEnd();

            ModelEpub20042023 modelEpub20042023 = new ModelEpub20042023()
            {
                RowsToRead = (ChangeCharactesr(result).Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries)).ToList(),
                TitreLivre = Request.Files[0].FileName
            };

            return Json(new { modelEpub20042023 = RenderRazorViewToString("ReadEpub20042023", modelEpub20042023) }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult NosCoursParTireurLoginButtonSuivant(TireurIndex userNameSelectionne, string passwordSelectionne)
        {
            NosCoursParTireurLoginModel nosCoursParTireurLoginModel = new NosCoursParTireurLoginModel() { };

            Tireur tireur = nosCoursParTireurLoginModel.Tireurs.FirstOrDefault(x => x.UserNameIndex == userNameSelectionne);

            bool isSuccessful = CheckGuid(tireur, passwordSelectionne);
# if DEBUG
            //isSuccessful = true;
#endif
            System.Web.HttpContext.Current.Session.Add("tireurSelectionne", Serialize(new Tireur()));
            if (isSuccessful)
            {
                System.Web.HttpContext.Current.Session.Add("tireurSelectionne", Serialize(tireur));
            }

            return Json(new { isSuccessful }, JsonRequestBehavior.AllowGet);
        }
        private static string Serialize(object o)
        {
            if (!o.GetType().IsSerializable)
            {
                return null;
            }

            using (MemoryStream stream = new MemoryStream())
            {
                new BinaryFormatter().Serialize(stream, o);
                return Convert.ToBase64String(stream.ToArray());
            }
        }

        private bool CheckGuid(Tireur tireur, string passwordSelectionne)
        {
            passwordSelectionne = passwordSelectionne.ToUpper();

            if (passwordSelectionne == GuidConstantes.GuidAllAuthorisation.ToString().ToUpper()) { return true; }

            switch (tireur.UserNameIndex)
            {
                case IndexTireurConstantes.TireurIndex.RémiSoyez:
                    return passwordSelectionne == GuidConstantes.GuidRémiSoyez.ToString();
                case IndexTireurConstantes.TireurIndex.ElodieMass:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidElodieMass.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.EvaDufrasne:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidEvaDufrasne.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.FélixTrannoy:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidFélixTrannoy.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.OscarDeblocq:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidOscarDeblocq.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.MaybelleCarlier:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidMaybelleCarlier.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.FabriceRazanajao:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidFabriceRazanajao.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.AbelMotte:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidAbelMotte.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.BaptisteMotte:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidBaptisteMotte.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.ArthurBarbery:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidArthurBarbery.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.LeanderCle:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidLeanderCle.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.ArthurCouturiaux:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidArthurCouturiaux.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.JordanMestdagh:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidJordanMestdagh.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.MartinSiu:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidMartinSiu.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.RaedwaldVercouter:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidRaedwaldVercouter.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.EloiBinois:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidEloiBinois.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.AuroreCarlier:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidAuroreCarlier.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.AnaelleIvanov:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidAnaelleIvanov.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.LiliMestdag:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidLiliMestdag.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.MathildeCarette:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidMathildeCarette.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.MaeVantroyen:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidMaeVantroyen.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.SachaLessart:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidSachaLessart.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.ApollineOdendhal:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidApollineOdendhal.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.AmadoSimon:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidAmadoSimon.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.LouisonBinois:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidLouisonBinois.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.HéloïsePras:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidHéloïsePras.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.RebeccaVandy:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidRebeccaVandy.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.EliotPunchoo:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidEliotPunchoo.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.NoelMarieDransart:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidNoelMarieDransart.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.NayaBeaucamp:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidNayaBeaucamp.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.BarnabéBeaucamp:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidBarnabéBeaucamp.ToString().ToUpper();
                case IndexTireurConstantes.TireurIndex.RomainBelbenoit:
                    return passwordSelectionne.ToUpper() == GuidConstantes.GuidRomainBelbenoit.ToString().ToUpper();
                default:
                    return false;
            }
        }

        [HttpPost]
        public JsonResult ChargerEpubNew28012024()
        {
            string result = new StreamReader(Request.Files[0].InputStream).ReadToEnd();

            ModelEpub20042023 modelEpub20042023 = new ModelEpub20042023()
            {
                RowsToRead = (ChangeCharactesr(result).Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries)).ToList(),
                TitreLivre = Request.Files[0].FileName
            };

            return Json(new { rowsToRead = modelEpub20042023.RowsToRead }, JsonRequestBehavior.AllowGet);
        }

        private string ChangeCharactesr(string result)
        {
            return result.Replace("&rsquo;", "'").Replace("&nbsp;", "").Replace("&mdash;", "").Replace("&ndash;", "");
        }

        [HttpGet]
        public JsonResult searchWorlds(string wordInputOne)
        {

            wordInputOne = wordInputOne.Split('(')[0].Trim();

            ModelViewDico modelViewDico = new ModelViewDico();

            if (wordInputOne.Length < 3)
            {
                return Json(new { modelViewDico = RenderRazorViewToString("Dico", modelViewDico) }, JsonRequestBehavior.AllowGet);
            }

            var path = Server.MapPath("/App_Data/francais.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            string mySelectQuery = " SELECT * FROM TTradFrancais where ftradFrancais like '%" + wordInputOne + "%'";

            OleDbConnection myConnection = new OleDbConnection(ConnectionString);

            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);

            myCommand.Connection.Open();

            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            while (myReader.Read())
            {
                modelViewDico.WordsOutputList.Add(new classWord()
                {
                    Definition = (string)myReader["ftradFrancais"],
                    Word = (string)myReader["fMotFrancais"]
                });
            }

            modelViewDico.WordInputOne = wordInputOne;

            return Json(new { wordsOutputList = modelViewDico.WordsOutputList, modelViewDico = RenderRazorViewToString("Dico", modelViewDico) }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAllUrls(ModelBDFile modelBDFile)
        {
            return Json(new { modelBDFile = RenderRazorViewToString("ScreenPDFPage", modelBDFile) }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult LoadBD(ModelBDFile modelBDFile)
        {



            string newUrl = "../../DossierExterieurAVS/BD2/" + modelBDFile.ListBD.Where(x => x.NomBD == modelBDFile.BookSelected).FirstOrDefault().BDPathWithoutPath;

            return Json(new { url = newUrl }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Logon()
        {
            ModelLogon modelLogon = new ModelLogon();

#if (DEBUG)
            modelLogon.UserName = "EscrimeTournai";
#endif
            return View(Constantes.Logon, modelLogon);
            //return Json(new { logon = RenderRazorViewToString("Logon", new ModelLogon()) }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public  ActionResult LogonControl(ModelLogon model, string returnUrl)
        {
            ModelLogonValidator modelLogonValidator = new ModelLogonValidator();
            ValidationResult validationResult = modelLogonValidator.Validate(model);

            if (validationResult.IsValid)
            {
                return View("AdministrationPage", new EscrimeursListe());
            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View("Logon", model);
            }

        }

        [HttpPost]
        public Task<ActionResult> TakeAccountTireursOK(string  isNotTakeAccountTireursOK)
        {
            EscrimeursListe escrimeursListe = new EscrimeursListe();
            escrimeursListe.IsNotTakeAccountTireursOK = isNotTakeAccountTireursOK == "true";
            return Task.FromResult<ActionResult>(View("AdministrationPage", escrimeursListe));
        }

        [HttpPost]
        public Task<ActionResult> ChangePeriode(string period)
        {
            EscrimeursListe escrimeursListe = new EscrimeursListe
            {
                Periode = period
            };
            escrimeursListe.ApplicPeriod();
            return Task.FromResult<ActionResult>(View("AdministrationPage", escrimeursListe));

        }

        [HttpGet]
        public ActionResult ChangeCurrentSon(string selectedLanguage, string SelectedNameDossier, string SelectedIndexDossier, string SelectedIndexFile)
        {
            string currentLanguageSelected = selectedLanguage + "/" + SelectedNameDossier + "/" + SelectedIndexDossier + "/" + SelectedIndexFile;
            var optForDigitalPopupCookie = new HttpCookie("currentLanguageSelected", currentLanguageSelected)
            {
                Secure = true,
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.Now.AddYears(1)
            };
            System.Web.HttpContext.Current.Response.Cookies.Add(optForDigitalPopupCookie);

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult DownloadExcel(string period)
        {
            EscrimeursListe escrimeursListe = new EscrimeursListe
            {
                Periode = period
            };

            var stream = new MemoryStream();            
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Rapport_" + DateTime.Now.ToString("ddMMyyyy"));

                workSheet.Cells[1, 1].Value = "Nom";
                workSheet.Cells[1, 2].Value = "Prénom";
                workSheet.Cells[1, 3].Value = "Date de naissance";
                workSheet.Cells[1, 4].Value = "Catégorie";
                workSheet.Cells[1, 5].Value = "Email 1";
                workSheet.Cells[1, 6].Value = "Email 2";
                workSheet.Cells[1, 7].Value = "Email 3";
                workSheet.Cells[1, 8].Value = "Téléphone 1";
                workSheet.Cells[1, 9].Value = "Téléphone 2";
                workSheet.Cells[1, 10].Value = "Téléphone 3";
                workSheet.Cells[1, 11].Value = "Licence en ordre";
                workSheet.Cells[1, 12].Value = "Fiche signalétique en ordre";
                workSheet.Cells[1, 13].Value = "Paiements effectués";
                workSheet.Cells[1, 14].Value = "Tout est ok";

                using (ExcelRange Rng = workSheet.Cells[1, 1, 1, 50])
                {
                    
                    Rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    Rng.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }

                int indexRow = 2;
                foreach (var tireur in escrimeursListe.Membres)
                {
                    workSheet.Cells[indexRow, 1].Value = tireur.Nom;
                    workSheet.Cells[indexRow, 2].Value = tireur.Prénom;

                    if (tireur.Signaletique != null)
                    {
                        workSheet.Cells[indexRow, 3].Value = tireur.Signaletique.DateDeNaissance.ToString("dd-MM-yyyy");
                        workSheet.Cells[indexRow, 4].Value = tireur.Signaletique.Categorie;
                        if (tireur.Signaletique.Email.Count > 0) { workSheet.Cells[indexRow, 5].Value = tireur.Signaletique.Email[0]; }
                        if (tireur.Signaletique.Email.Count > 1) { workSheet.Cells[indexRow, 6].Value = tireur.Signaletique.Email[1]; }
                        if (tireur.Signaletique.Email.Count > 2) { workSheet.Cells[indexRow, 7].Value = tireur.Signaletique.Email[2]; }
    
                        if (tireur.Signaletique.Telephone.Count > 0) { workSheet.Cells[indexRow, 8].Value = tireur.Signaletique.Telephone[0]; }
                        if (tireur.Signaletique.Telephone.Count > 1) { workSheet.Cells[indexRow, 9].Value = tireur.Signaletique.Telephone[1]; }
                        if (tireur.Signaletique.Telephone.Count > 2) { workSheet.Cells[indexRow, 10].Value = tireur.Signaletique.Telephone[2]; }

                        workSheet.Cells[indexRow, 11].Value = tireur.Paiement.IsLicenceEnOrdre ? "Y":"N" ;
                        workSheet.Cells[indexRow, 12].Value = tireur.Paiement.IsFicheSignaletiqueEnOrdre? "Y":"N";


                        foreach (string paiement in tireur.Paiement.PaiementsEffectues)
                        {
                            workSheet.Cells[indexRow, 13].Value += paiement + ' ';
                        }

                        workSheet.Cells[indexRow, 14].Value = tireur.Paiement?.IsCotisationEnOrdre == true && tireur.Paiement?.IsLicenceEnOrdre == true && tireur.Paiement?.IsFicheSignaletiqueEnOrdre == true && tireur.Paiement?.IsLocationMatérielEnOrdre == true ? "En ordre" : "";
                    }
                    indexRow++;
                }

                workSheet.Columns.AutoFit();

                package.Save();
            }
            stream.Position = 0;
            string excelName = $"Rapport_{DateTime.Now:ddMMyyyy}.xlsx";

            return File(stream, "application/octet-stream", excelName);
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

        [HttpPost]
        public async Task<ActionResult> AddNewsletterInDB(string newsletter)
        {
            var path = Server.MapPath("/App_Data/francais.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            string mySelectQuery = "INSERT INTO TableNewsletter (NewsletterEmail) Values ('" + newsletter + "')";
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);

            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);

            myCommand.Connection.Open();

            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            myCommand.Connection.Close();

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}