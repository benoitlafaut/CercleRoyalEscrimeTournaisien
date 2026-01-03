using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Web.Mvc;
using CercleRoyalEscrimeTournaisien.Models;
using System.Collections.Generic;
using System.Linq;

namespace CercleRoyalEscrimeTournaisien
{
    [RoutePrefix("Dico")]
    public class DicoController : Controller
    {
        [HttpGet]
        public JsonResult SearchMots(string textInput)
        {
            List<classWord> wordsOutputList = new List<classWord>() { };

            var path = Server.MapPath("/App_Data/francais.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";

            string mySelectQuery = "SELECT * FROM TTradFrancais WHERE 1=1";
            foreach (char c in textInput)
            { 
                mySelectQuery += $" AND fMotFrancais LIKE '%{c}%'";
            }


            OleDbConnection myConnection = new OleDbConnection(ConnectionString);

            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);

            myCommand.Connection.Open();

            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            while (myReader.Read())
            {
                wordsOutputList.Add(new classWord()
                {
                    Definition = (string)myReader["ftradFrancais"],
                    Word = (string)myReader["fMotFrancais"],
                    WordLength = ((string)myReader["fMotFrancais"]).Length
                });
            }

            wordsOutputList = wordsOutputList.OrderBy(x => x.WordLength).ToList();

            return Json(new { wordsOutputList }, JsonRequestBehavior.AllowGet);
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