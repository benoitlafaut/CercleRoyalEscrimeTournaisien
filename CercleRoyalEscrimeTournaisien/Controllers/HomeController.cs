using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System;
using VersOne.Epub;
using HtmlAgilityPack;
using System.IO;
using CercleRoyalEscrimeTournaisien.Models;
using System.Web.Script.Serialization;
using System.Data.OleDb;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Text;
//using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WebApplication1.Models;
using FluentValidation.Results;
using System.Diagnostics;

namespace CercleRoyalEscrimeTournaisien
{
    public class HomeController : Controller
    {
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Accueil()
        {
            Accueil accueil = new Accueil();
            return View(accueil);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Banniere()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenBannier;
            return View(PartialViewNames.Banniere);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Redirect()
        {
            return RedirectToAction("StartPageNew", "mainPage");
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult MainPage()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenBannier;
            return View(PartialViewNames.MainPage);
        }

       

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Agenda()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenAgenda;
            return View(PartialViewNames.MainPage);
        }



        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ChangeMoisMoins1()
        {
            CercleRoyalEscrimeTournaisien.Models.MainModel.DateCurrent = CercleRoyalEscrimeTournaisien.Models.MainModel.DateCurrent.AddMonths(-1);
            return RedirectToAction("Agenda", "Home");
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ChangeMoisPlus1()
        {
            MainModel.DateCurrent = MainModel.DateCurrent.AddMonths(1);
            return RedirectToAction("Agenda", "Home");
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Categories()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenCategories;
            return View(PartialViewNames.MainPage);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Historique()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenHistorique;
            return View(PartialViewNames.MainPage);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Albums()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenAlbums;
            return View(PartialViewNames.MainPage);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult ChangePhotos(string id)
        {
            MainModel.NumeroAlbumCurrent = Convert.ToInt32(id);
            MainModel.NumeroPhotoOfAlbumCurrent = 1;
            return RedirectToAction("Albums", "Home");
        }



        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Activites()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenActivites;
            return View(PartialViewNames.MainPage);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult QuelquesSitesInteressants()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenQuelquesSitesInteressants;
            return View(PartialViewNames.MainPage);
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult NosCours(string newSelectedIndexTheme)
        {
            NosCours nosCours = new NosCours();

            if (newSelectedIndexTheme == null) { newSelectedIndexTheme = "0"; }
            if (newSelectedIndexTheme == "-1") { newSelectedIndexTheme = (nosCours.AllTitresThemeDistinct.Count() - 1).ToString(); }
            if (Convert.ToInt32(newSelectedIndexTheme) == nosCours.AllTitresThemeDistinct.Count()) { newSelectedIndexTheme = "0"; }

            MainModel.NewSelectedIndexTheme = newSelectedIndexTheme;

            MainModel.ScreenToShow = TypeScreenToShow.ScreenNosCours;
            return View(PartialViewNames.MainPage);
        }

        public ActionResult Epub()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenEpub;
            return View(PartialViewNames.MainPage);
        }
        public ActionResult Epub_20221112()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenEpub_20221112;
            return View(PartialViewNames.MainPage);
        }

        public ActionResult ReadEpub20042023()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ReadEpub20042023;
            return View(PartialViewNames.MainPage);
        }

        public ActionResult PagePersoManager()
        {
            MainModel.ScreenToShow = TypeScreenToShow.PagePersoManager;
            return View(PartialViewNames.MainPage);
        }

        public ActionResult ScreenPDFPage()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenPDFPage;
            return View(PartialViewNames.MainPage);
        }

        public ActionResult Dico()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenDico;
            return View(PartialViewNames.MainPage);
        }
        public ActionResult ReturnEscrime()
        {
            MainModel.ScreenToShow = TypeScreenToShow.ScreenBannier;
            return View(PartialViewNames.MainPage);
        }


        [HttpPost]
        public ActionResult Transform()
        {
            try
            {
                string RowsToCreate = string.Empty;
                if (Request.Files.Count > 0)
                {
                    var _file = Request.Files[0];

                    EpubBook book = EpubReader.ReadBook(_file.InputStream);
                    foreach (EpubTextContentFile textContentFile in book.ReadingOrder)
                    {
                        PrintTextContentFile(textContentFile, ref RowsToCreate);
                    }

                    List<string> aryRowsToCreate = RowsToCreate.Split('.').ToList();

                    var serializer = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue, RecursionLimit = 900 };

                    return new ContentResult()
                    {
                        Content = serializer.Serialize(string.Join("||", aryRowsToCreate)),
                        ContentType = "application/json"
                    };
                }

                return Json(new { success = false, responseText = "no file founded" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public JsonResult searchWorlds(string wordInputOne, string wordInputTwo)
        {
            ModelViewDico modelViewDico = new ModelViewDico();

            if (wordInputOne.Length < 3)
            {
                return Json(new { modelViewDico = RenderRazorViewToString("Dico", modelViewDico) }, JsonRequestBehavior.AllowGet);
            }

            var path = Server.MapPath("/App_Data/francais.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            string mySelectQuery = " SELECT * FROM TTradFrancais where ftradFrancais like '%" + wordInputOne + "%'";

            if (!string.IsNullOrEmpty(wordInputTwo))
            {
                mySelectQuery += "and ftradFrancais like '%" + wordInputTwo + "%'";
            }

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
            modelViewDico.WordInputTwo = wordInputTwo;

            return Json(new { modelViewDico = RenderRazorViewToString("Dico", modelViewDico) }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ChargerEpub(ModelViewEpubFile modelViewEpubFile, string IsToListenNew, int addLines)
        {
            if (modelViewEpubFile.RowsEpub.Count == 0 && Request.Files.Count > 0)
            {
                System.Web.HttpContext.Current.Session.Clear();

                string result = new StreamReader(Request.Files[0].InputStream).ReadToEnd();
                string[] rowsToRead = result.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                System.Web.HttpContext.Current.Session.Add("rowsToRead", Serialize(rowsToRead));

                modelViewEpubFile.CurrentLigne = 0;
                modelViewEpubFile.CurrentLanguage = Language.Francais;
                modelViewEpubFile.CurrentSentenceToListen = -1;
            }

            return Json(new { modelViewEpubFile = RenderRazorViewToString("PartRead_New_112022DIV", modelViewEpubFile) }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ChargerEpubNew20042023()
        {
            string result = new StreamReader(Request.Files[0].InputStream).ReadToEnd();

            ModelEpub20042023 modelEpub20042023 = new ModelEpub20042023()
            {
                RowsToRead = (result.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries)).ToList()
            };            
            
            return Json(new { modelEpub20042023 = RenderRazorViewToString("ReadEpub20042023", modelEpub20042023) }, JsonRequestBehavior.AllowGet);
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
        private static object Deserialize(string str)
        {
            byte[] bytes = Convert.FromBase64String(str);

            using (MemoryStream stream = new MemoryStream(bytes))
            {
                return new BinaryFormatter().Deserialize(stream);
            }
        }
        public T GetValueStartsWith<T>(string key)
        {
            var lastSessionKey = System.Web.HttpContext.Current.Session.Keys.Cast<string>()
                .LastOrDefault(x => x.StartsWith(key));

            if (string.IsNullOrEmpty(lastSessionKey))
                return default(T);

            return (T)Deserialize((string)System.Web.HttpContext.Current.Session[lastSessionKey]);
        }

        [HttpPost]
        public JsonResult ChargerEpubChoisi(int bouquinSelected)
        {
            string[] rowsToRead = null;

            ModelViewEpubFile modelViewEpubFile = new ModelViewEpubFile() { };

            String FilePath = Server.MapPath("/Epub/Bouquins/");
            switch (bouquinSelected)
            {
                case 1:
                    rowsToRead = System.IO.File.ReadAllLines(FilePath + "le miroir d ambre.epublaf");
                    break;
            }

            System.Web.HttpContext.Current.Session.Add("rowsToRead", Serialize(rowsToRead));

            modelViewEpubFile.CurrentLigne = 0;
            modelViewEpubFile.CurrentLanguage = Language.Francais;
            modelViewEpubFile.CurrentSentenceToListen = -1;

            return Json(new { modelViewEpubFile = RenderRazorViewToString("PartRead_New_112022DIV", modelViewEpubFile) }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult ChargerListeThemes(string ThemeSelected, ModelViewEpubFile modelViewEpubFile)
        {
            List<string> rowsToRead_Theme_1 = new List<string>()
            {
                "un", "deux", "trois", "quatre", "cinq", "six", "sept","huit","neuf","dix","onze","douze", "treize", "quartorze", "quinze", "seize", "dix-sept","dix-huit", "dix-neuf", "vingt","trente", "quarante", "cinquante", "soixante", "septante", "quatre-vingt", "nonante", "cent", "mille", "un million"
            };
            List<string> rowsToRead_Theme_2 = new List<string>()
            {
                "je", "tu", "il", "elle", "nous", "vous", "ils", "elles", "eux"
            };
            List<string> rowsToRead_Theme_3 = new List<string>()
            {
                "bleu", "rouge", "vert","jaune", "brun", "roux", "noir", "blanc"
            };
            List<string> rowsToRead_Theme_4 = new List<string>()
            {
                 "je suis", "tu es", "il est", "nous sommes", "vous êtes", "ils sont"
            };
            List<string> rowsToRead_Theme_5 = new List<string>()
            {
                "j'ai", "tu as", "il a", "nous avons", "vous avez", "ils ont"
            };
            List<string> rowsToRead_Theme_6 = new List<string>()
            {
                 "être", "j'étais", "tu étais", "il était", "nous étions", "vous êtiez", "ils étaient"
            };
            List<string> rowsToRead_Theme_7 = new List<string>()
            {
                "avoir", "j'avais", "tu avais", "il avait", "nous avions", "vous aviez", "ils avaient"
            };
            List<string> rowsToRead_Theme_8 = new List<string>()
            {
                 "pouvoir", "je peux", "tu peux", "il peut", "nous pouvons", "vous pouvez", "ils peuvent"
            };
            List<string> rowsToRead_Theme_9 = new List<string>()
            {
                 "j'aime les frites", "j'aime les carottes", "j'aime la bière", "j'aime mon père et ma mère", "je n'aime pas les chicons", "je n'aime ni les serpents ni les crocodiles", "j'aime jouer de la guitare",
            };
            List<string> rowsToRead_Theme_10 = new List<string>()
            {
                 "vouloir", "je veux", "tu veux", "il veut", "nous voulons", "vous voulez", "ils veulent"
            };
            List<string> rowsToRead_Theme_11 = new List<string>()
            {
                 "devoir", "je dois", "tu dois", "il doit", "nous devons", "vous devez", "ils doivent"
            };

            IDictionary<List<string>, string> ListThemes = new Dictionary<List<string>, string>()
            {
                { rowsToRead_Theme_1, "1" },
                { rowsToRead_Theme_2, "2" },
                { rowsToRead_Theme_3, "3" },
                { rowsToRead_Theme_4, "4" },
                { rowsToRead_Theme_5, "5" },
                { rowsToRead_Theme_6, "6" },
                { rowsToRead_Theme_7, "7" },
                { rowsToRead_Theme_8, "8" } ,
                { rowsToRead_Theme_9, "9" },
                { rowsToRead_Theme_10, "10" },
                 { rowsToRead_Theme_11, "11" }
            };
            modelViewEpubFile.CurrentLigne = 0;
            modelViewEpubFile.ClearRowsEpub();
            string[] rowsToRead = ListThemes.FirstOrDefault(x => x.Value == ThemeSelected).Key.ToArray();

            System.Web.HttpContext.Current.Session.Add("rowsToRead", Serialize(rowsToRead));

            return Json(new { modelViewEpubFile = RenderRazorViewToString("PartRead_New_112022DIV", modelViewEpubFile) }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ChangeEpub_New_112022(ModelViewEpubFile modelViewEpubFile, bool isNext, bool isPrevious, int numeroPage)
        {
            if (modelViewEpubFile.RowsEpub == null)
            {
                return Json(new { modelViewEpubFile = RenderRazorViewToString("PartRead_New_112022DIV", modelViewEpubFile) }, JsonRequestBehavior.AllowGet);
            }

            if (isNext) { modelViewEpubFile.CurrentLigne += 15; }
            if (isPrevious) { modelViewEpubFile.CurrentLigne -= 15; }
            if (modelViewEpubFile.CurrentLigne >= modelViewEpubFile.RowsEpub.Count)
            {
                modelViewEpubFile.CurrentLigne -= 15;
            }

            if (numeroPage != -1) { modelViewEpubFile.CurrentLigne = numeroPage; }

            return Json(new { modelViewEpubFile = RenderRazorViewToString("PartRead_New_112022DIV", modelViewEpubFile) }, JsonRequestBehavior.AllowGet);
        }


        #region methods private
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
        private void PrintTextContentFile(EpubTextContentFile textContentFile, ref string RowsToCreate)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(textContentFile.Content);

            foreach (HtmlNode node in htmlDocument.DocumentNode.SelectNodes("//text()"))
            {
                string textFormatted = (GetText(node.InnerText)).Replace("«", "").Replace("&amp;", " et ").Replace("»", "").Replace("&#160;", " ").Replace("&nbsp;", " ").Replace("—", "");
                
                if (textFormatted != string.Empty)
                {
                   

                    if (!textFormatted.EndsWith(".")) { textFormatted += "."; }
                    RowsToCreate += " " + textFormatted;
                }
            }
        }
        private static string GetText(string innerText)
        {
            string output = innerText;
            if (output.IndexOf("<?xml ") != -1 || output.IndexOf("@page") != -1)
            {
                output = string.Empty;
            }
            output = output.Replace("\n", " ").Replace("&lt;", "").Replace("&gt;", "");

            output = output.Trim();
            return output;
        }
        #endregion

        [HttpGet]
        public JsonResult GetAllUrls(ModelViewEpubFile modelViewEpubFile, string NomBDSelected)
        {
            modelViewEpubFile.NomBD = NomBDSelected;

            var searchResponse = this.GetValueStartsWith<List<ModelViewBook>>("NewBooksListSelect_" + NomBDSelected);
            if (searchResponse == null)
            {
                FieldInfo[] fieldInfos = typeof(ListNomBD).GetFields();

                FieldInfo essai = fieldInfos.Where(x => x.GetRawConstantValue().ToString() == NomBDSelected).FirstOrDefault();

                string urlBD = typeof(ListUrlBD).GetFields().Where(x => x.Name == essai.Name).FirstOrDefault().GetRawConstantValue().ToString();

                modelViewEpubFile.NewBooksListSelect = new List<ModelViewBook>() { };
                modelViewEpubFile.NewBooksListSelect.AddRange(modelViewEpubFile.DecodedOutputMessage(NomBDSelected, urlBD));

                System.Web.HttpContext.Current.Session.Add("NewBooksListSelect_" + NomBDSelected, Serialize(modelViewEpubFile.NewBooksListSelect));
            }
            else
            {
                modelViewEpubFile.NewBooksListSelect = new List<ModelViewBook>() { };
                modelViewEpubFile.NewBooksListSelect.AddRange(searchResponse);
            }

           

            return Json(new { modelViewEpubFile = RenderRazorViewToString("ScreenPDFPage", modelViewEpubFile) }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetUrlForBD(string NomBDSelected, int BookIndexSelected)
        {
            BookIndexSelected -=1 ;

            ModelViewEpubFile modelViewEpubFile = new ModelViewEpubFile
            {
                NomBD = NomBDSelected
            };
            List<ModelViewBook> searchResponse = this.GetValueStartsWith<List<ModelViewBook>>("NewBooksListSelect_" + NomBDSelected);
            modelViewEpubFile.NewBooksListSelect.AddRange(searchResponse);
            string urlBD = searchResponse[Convert.ToInt32(BookIndexSelected)].Url;

            modelViewEpubFile.BookSelected= urlBD;

            string result = string.Empty;
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(urlBD);
            wrGETURL.Proxy = WebProxy.GetDefaultProxy();

            using (var stream = wrGETURL.GetResponse().GetResponseStream())
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(new StringReader(result));

            string[] separatingStrings = { "docUrl", "docBuyLink" };
            string[] words = result.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            string[] words2 = words[1].Split(Convert.ToChar(34));
            var urlNew = words2[2].Replace("\\", "").Replace(":\"", "");


            return Json(new { urlNew, modelViewEpubFile = RenderRazorViewToString("ScreenPDFPage", modelViewEpubFile) }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LogOnAsync(ModelLogon model, string returnUrl)
        {
            ModelLogonValidator modelLogonValidator = new ModelLogonValidator();
            ValidationResult validationResult = modelLogonValidator.Validate(model);

            if (validationResult.IsValid)
            {
                return View("LogonSuccess", new EscrimeursListe());
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

      
    }
}

