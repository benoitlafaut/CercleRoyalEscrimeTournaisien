using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json;

namespace CercleRoyalEscrimeTournaisien.Models
{
    public static class TypeUtilities
    {
        public static List<T> GetAllPublicConstantValues<T>(this Type type)
        {
            return type
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Where(fi => fi.IsLiteral && !fi.IsInitOnly && fi.FieldType == typeof(T))
                .Select(x => (T)x.GetRawConstantValue())
                .ToList();
        }
    }

    public class ListNomBD
    {
        public const string BuckDanny_1 = "Buck Danny 1";
        public const string BuckDanny_2 = "Buck Danny 2";        
        public const string RicHochet = "Ric Hochet";
        public const string Thorgal = "Thorgal";
        public const string Astérix = "Astérix";
        public const string YokoTsuno = "Yoko Tsuno";
        public const string XIII = "XIII";
        public const string BobetBobette1à160 = "Bob et Bobette 1 à 160";
        public const string BobetBobette161à260 = "Bob et Bobette 161 à 260";
        public const string BobetBobette261à350 = "Bob et Bobette 261 à 350";
        public const string BobetBobetteHS = "Bob et Bobette HS";
        public const string Timour = "Timour";
        public const string SandyetHoppy = "Sandy et Hoppy";
        public const string Bessy = "Bessy";
        public const string Durango = "Durango";
        public const string Soda = "Soda";
        public const string SCRAMEUSTACHE = "Le scrameustache";
        public const string MichelVaillantAncien = "Michel Vaillant Ancien";
    }
    public class ListUrlBD
    {
        public const string SCRAMEUSTACHE = "https://vk.com/topic-203785966_47447898";
        public const string BuckDanny_1 = "https://vk.com/topic-203785966_47459886";
        public const string BuckDanny_2 = "https://vk.com/topic-203785966_47459886?offset=20";       
        public const string RicHochet = "https://vk.com/topic-203785966_47446095";
        public const string Thorgal = "https://vk.com/topic-203785966_47425597";
        public const string Astérix = "https://vk.com/topic-203785966_47422638";
        public const string YokoTsuno = "https://vk.com/topic-203785966_47395686";
        public const string XIII = "https://vk.com/topic-203785966_47480662";
        public const string BobetBobette1à160 = "https://vk.com/topic-203785966_47460715";
        public const string BobetBobette161à260 = "https://vk.com/topic-203785966_47460715?offset=20";
        public const string BobetBobette261à350 = "https://vk.com/topic-203785966_47460715?offset=40";
        public const string BobetBobetteHS = "https://vk.com/topic-203785966_47460715?offset=60";
        public const string Timour = "https://vk.com/topic-203785966_48422440";
        public const string SandyetHoppy = "https://vk.com/topic-203785966_48214417";
        public const string Bessy = "https://vk.com/topic-203785966_47460606";
        public const string Durango = "https://vk.com/topic-203785966_47477415";
        public const string Soda = "https://vk.com/topic-203785966_47496102";
        public const string MichelVaillantAncien = "https://vk.com/topic-203785966_47420993";
    }
    public enum Language
    {
        Francais = 1,
        Espagnol = 2,
        Allemand = 3,
        Anglais = 4,
        Néerlandais = 5
    }
    [Serializable]
    public class ModelViewEpubFile
    {
        public bool Allemand { get; set; }
        public bool Francais { get; set; }
        public bool Neerlandais { get; set; }
        public bool Espagnol { get; set; }
        public bool Anglais { get; set; }
        public string NomBD { get; set; }
        public string BookSelected { get; set; }
        public List<ModelViewBook> NewBooksList { get; set; }


        public List<string> NewNomBDList
        {
            get
            {
                return typeof(ListNomBD).GetAllPublicConstantValues<string>();
            }
        }


        
        public List<ModelViewBook> NewBooksListSelect { get; set; }
        public ModelViewEpubFile()
        {
            ListThemes.Add("0", "");
            Francais = true;
            NewBooksListSelect = new List<ModelViewBook>() { };
        }


        public List<ModelViewBook> DecodedOutputMessage(string nomBD, string url)
        {
           


            //string fullUrl = url;
            //var response = CallUrl(fullUrl).Result;

            //HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();

            ////string url = "https://www.site.com";

            //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            //doc = web.Load(url);

            //var nodes = doc.DocumentNode.SelectSingleNode("//span[@ class='a-size-medium']");


            List<ModelViewBook> booksList = new List<ModelViewBook>() { };
            //string result = string.Empty;


            //WebClient wc = new WebClient();
            //wc.Proxy = WebProxy.GetDefaultProxy();
            //var page = wc.DownloadString(url);

            //HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
            //doc2.LoadHtml(page);
            //IEnumerable<HtmlNode> htmlNodeCollection3 = doc2.DocumentNode.DescendantNodesAndSelf();


            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            ////request.Credentials = CredentialCache.DefaultCredentials;
            //request.Proxy = WebProxy.GetDefaultProxy();
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Stream dataStream = response.GetResponseStream();
            ////StreamReader reader2 = new StreamReader(dataStream);


            /////////////////////////////////


            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(url);

            //// Add an Accept header for JSON format.
            //client.DefaultRequestHeaders.Accept.Add(
            //new MediaTypeWithQualityHeaderValue("application/json"));

            //// List data response.
            //HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            //if (response.IsSuccessStatusCode)
            //{
            //    // Parse the response body.
            //    var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
            //    foreach (var d in dataObjects)
            //    {
            //        Console.WriteLine("{0}", d.Name);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            //}

            ////////////////////////////////




            //
            // webBrowser1.DocumentText = page;

            //WebRequest wrGETURL;
            //wrGETURL = WebRequest.Create(url);
            //wrGETURL.Proxy = WebProxy.GetDefaultProxy();

            //using (var stream = wrGETURL.GetResponse().GetResponseStream())
            //using (var reader = new StreamReader(stream, Encoding.UTF8))
            //{
            //    result = reader.ReadToEnd();
            //}

            //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //doc.Load(new StringReader(result));

            //HtmlNodeCollection htmlNodeCollection2 = doc.DocumentNode.SelectNodes("//*[@class=\"mr_label medias_link\"]");

            //foreach (HtmlNode node in htmlNodeCollection2)
            //{
            //    booksList.Add(new ModelViewBook()
            //    {
            //        NomBD = nomBD,

            //        Title = ReplaceInnerText(node.InnerText),
            //        Url = "https://vk.com/" + node.Attributes["href"].Value
            //    });
            //}

            return booksList;
        }
        private static  Task<string> CallUrl(string fullUrl)
        {
            HttpClient client = new HttpClient();
            
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetStringAsync(fullUrl);
            return  response;
        }
        private string ReplaceInnerText(string text)
        {
            string newText = text;
            string[] aryText = newText.Split(new string[] { ".pdf" }, StringSplitOptions.None);

            return aryText[0]
                 .Replace("File ", "")
                 .Replace("&#233;", "é")
                 .Replace("&#232;", "è")
                 .Replace("&#224;", "à")
                 .Replace("&#768;", "")
                 .Replace("&#769;", "")
                 .Replace("&#244;", "ô")
                 .Replace("&#39;", "'");
        }
      
        public List<string> PhrasesFrancaises
        {

            get
            {
                if (CurrentLigne < 0)
                {
                    CurrentLigne = 0;
                }


                List<string> ListPhrasesFrancaises = new List<string>() { };
                if (RowsEpub is null) { return ListPhrasesFrancaises; }
                if (RowsEpub.Count == 0) { return ListPhrasesFrancaises; }

                for (int iloop = CurrentLigne; iloop < CurrentLigne + 15 && iloop < RowsEpub.Count; iloop++)
                {
                    ListPhrasesFrancaises.Add("FR: " + RowsEpub[iloop].Replace('—', ' ').Replace('«', ' ').Replace('»', ' '));
                }

                return ListPhrasesFrancaises;
            }
        }
        public List<string> PhrasesEspagnoles
        {
            get
            {
                List<string> ListPhrasesFrancaises = new List<string>() { };

                for (int iloop = 0; iloop < 15; iloop++)
                {
                    ListPhrasesFrancaises.Add("...");
                }

                return ListPhrasesFrancaises;
            }
        }
        public List<string> PhrasesAllemandes
        {
            get
            {
                List<string> ListPhrasesFrancaises = new List<string>() { };

                for (int iloop = 0; iloop < 15; iloop++)
                {
                    ListPhrasesFrancaises.Add("...");
                }

                return ListPhrasesFrancaises;
            }
        }
        public List<string> PhrasesAnglaises
        {
            get
            {
                List<string> ListPhrasesFrancaises = new List<string>() { };

                for (int iloop = 0; iloop < 15; iloop++)
                {
                    ListPhrasesFrancaises.Add("...");
                }

                return ListPhrasesFrancaises;
            }
        }
        public List<string> PhrasesNeerlandaises
        {
            get
            {
                List<string> ListPhrasesFrancaises = new List<string>() { };

                for (int iloop = 0; iloop < 15; iloop++)
                {
                    ListPhrasesFrancaises.Add("...");
                }

                return ListPhrasesFrancaises;
            }
        }

        public string ThemeSelected { get; set; }
        public string BouquinSelected { get; set; }

        public IDictionary<string, string> ListBouquins
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "","" },
                    { "1","le miroir d'ambre" }
                };
            }
        }

        public IDictionary<string, string> ListThemes
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "","" },
                    { "1","les chiffres" },
                    { "2","les pronoms" },
                    { "3","les couleurs" },
                    { "4","être à l'indicatif présent" },
                    { "5","avoir à l'indicatif présent" },
                    { "6","être à l'indicatif imparfait" },
                    { "7","avoir à l'indicatif imparfait" },
                    { "8","pouvoir à l'indicatif présent" },
                    { "9","aimer" },
                    { "10","vouloir à l'indicatif présent" },
                     { "11","devoir à l'indicatif présent" },
                };
            }
        }

        public void ClearRowsEpub ()
        {
            rowsEpub = null;
        }
        private List<string> rowsEpub;
        public List<string> RowsEpub
        {
            get
            {
                if (rowsEpub == null)
                {
                    if (GetValue<string[]>("rowsToRead") == null)
                    {
                        return new List<string>();
                    }
                    rowsEpub =  GetValue<string[]>("rowsToRead").ToList();
                }

                return rowsEpub;
            }
        }

      
        private T GetValue<T>(string key)
        {
            string value = (string)HttpContext.Current.Session[key];

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
        public int CurrentLigne { get; set; }
        public Language CurrentLanguage { get; set; }
        public int CurrentSentenceToListen { get; set; }
    }
}