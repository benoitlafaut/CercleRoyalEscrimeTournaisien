﻿using CercleRoyalEscrimeTournaisien.ClassPublic;
using CercleRoyalEscrimeTournaisien.Models;
using System;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Threading.Tasks;
using WebApplication1.Models;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CercleRoyalEscrimeTournaisien
{
    [RoutePrefix("Epub")]
    public class EpubController : Controller
    {

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult Epub122024()
        {
            ModelEpub122024 modelEpub122024 = new ModelEpub122024();
            return View(Constantes.Epub122024, modelEpub122024);
        }

        [HttpPost]
        public ActionResult ChargerEpub(string currentRow, string fileNameBook)
        {
            string result;
            ModelEpub122024 modelEpub122024 = new ModelEpub122024() { };

            if (Request.Files.Count == 0)
            {
                if (Convert.ToInt32(currentRow) < 0)
                {
                    currentRow = "0";
                }

                result = GetValue<string>("rowsToRead");
                modelEpub122024.RowsToRead = (ChangeCharactesr(result).Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries)).ToList();
                modelEpub122024.CurrentStep = Convert.ToInt32(currentRow);
                modelEpub122024.FileNameBook = fileNameBook;

                UpdateInDBForNumberOfPage(fileNameBook, currentRow);
            }
            else
            {
                result = new StreamReader(Request.Files[0].InputStream).ReadToEnd();
                modelEpub122024.RowsToRead = (ChangeCharactesr(result).Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries)).ToList();
                modelEpub122024.CurrentStep = Convert.ToInt32(currentRow);
                System.Web.HttpContext.Current.Session.Add("rowsToRead", Serialize(result));

                ClassNumberOfPage classNumberOfPage = CheckInDBForNumberOfPage(Request.Files[0].FileName);
                if (classNumberOfPage.IsPresent)
                {
                    modelEpub122024.CurrentStep = classNumberOfPage.NumberOfPage;
                }

                modelEpub122024.FileNameBook = Request.Files[0].FileName;
            }

            return PartialView(PartialViewNames.Epub122024_Body, modelEpub122024);
        }

        private void UpdateInDBForNumberOfPage(string fileNameBook, string currentPage)
        {
            var path = Server.MapPath("/App_Data/francais.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            string mySelectQuery = "UPDATE TableListBooks SET Page = '" + currentPage + "' where NameOfBook = '" + fileNameBook + "'";
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);

            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);

            myCommand.Connection.Open();

            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            myCommand.Connection.Close();
        }

        private ClassNumberOfPage CheckInDBForNumberOfPage(string titreBook)
        {
            var path = Server.MapPath("/App_Data/francais.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            string mySelectQuery = " SELECT * FROM TableListBooks where NameOfBook = '" + titreBook + "'";

            OleDbConnection myConnection = new OleDbConnection(ConnectionString);

            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);

            myCommand.Connection.Open();

            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            if (myReader.HasRows)
            {
                string page = "0";
                while (myReader.Read())
                {
                    page = (string)myReader["Page"];
                }

                return new ClassNumberOfPage()
                {
                    IsPresent = true,
                    NumberOfPage = Convert.ToInt32(page)
                };

            }
            else
            {
                InsertInDBWithNumberOfPage(titreBook);
                return new ClassNumberOfPage()
                {
                    IsPresent = false
                };
            }
        }

        private void InsertInDBWithNumberOfPage(string titreBook)
        {
            var path = Server.MapPath("/App_Data/francais.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            string mySelectQuery = "INSERT INTO TableListBooks (NameOfBook, Page) Values ('" + titreBook + "', '0')";
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);

            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);

            myCommand.Connection.Open();

            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            myCommand.Connection.Close();
        }

        #region renderRazorView
        private T GetValue<T>(string key)
        {
            string value = (string)System.Web.HttpContext.Current.Session[key];

            if (value != null)
                return (T)Deserialize(value);
            else
                return default(T);
        }
        private static object Deserialize(string str)
        {
            byte[] bytes = Convert.FromBase64String(str);

            using (MemoryStream stream = new MemoryStream(bytes))
            {
                return new BinaryFormatter().Deserialize(stream);
            }
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
        private string RenderRazorViewToString(string viewName, object model)
        {
            return RenderRazorViewToString(viewName, model, string.Empty);
        }
        private string ChangeCharactesr(string result)
        {
            return result.Replace("&rsquo;", "'").Replace("&nbsp;", "").Replace("&mdash;", "").Replace("&ndash;", "");
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