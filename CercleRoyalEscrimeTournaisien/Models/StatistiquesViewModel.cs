using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace CercleRoyalEscrimeTournaisien.Models
{
    [Serializable]
    public class StatistiquesViewModel
    {
        public List<ClassStatistiques> StatistiquesList { get; set; }
        public string TireurSelected { get; set; }
        public string AdversaireSelected { get; set; }
        public HttpServerUtilityBase ServerTmp { get; set; }
        public StatistiquesViewModel(HttpServerUtilityBase serverTmp)
        {
            this.ServerTmp = serverTmp;
            ChargerStatistiques();
        }


        public IDictionary<string, string> ListTireursToShowAndChoose
        {
            get
            {
                Dictionary<string, string> listTireursToShowAndChoose = new Dictionary<string, string>() { };

                foreach (var tireur in StatistiquesList)
                {
                    if (!listTireursToShowAndChoose.ContainsKey(tireur.Tireur1Name))
                    {
                        listTireursToShowAndChoose.Add(tireur.Tireur1Name, tireur.Tireur1Name);
                    }

                    if (!listTireursToShowAndChoose.ContainsKey(tireur.Tireur2Name))
                    {
                        listTireursToShowAndChoose.Add(tireur.Tireur2Name, tireur.Tireur2Name);
                    }
                }

                return listTireursToShowAndChoose.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            }
        }

        public List<ClassStatistiques> ListeDesMatchs
        {
            get
            {
                List<ClassStatistiques> listeDesMatchs = new List<ClassStatistiques>() { };

                if (AdversaireSelected == "All tireurs")
                {
                    listeDesMatchs = StatistiquesList.Where(x => x.Tireur1Name == TireurSelected || x.Tireur2Name == TireurSelected).ToList();
                }
                else
                {
                    listeDesMatchs = StatistiquesList.Where(x => x.Tireur1Name == TireurSelected && x.Tireur2Name == AdversaireSelected
                                                         || x.Tireur2Name == TireurSelected && x.Tireur1Name == AdversaireSelected).ToList();
                }

                return listeDesMatchs;
            }
        }
        public IDictionary<string, string> ListTireursToShowAndChooseForAdversaires
        {
            get
            {
                Dictionary<string, string> listTireursToShowAndChooseForAdversairesBegin = new Dictionary<string, string>
                {
                    { "", "" },
                    { "All tireurs", "All tireurs" }
                };

                Dictionary<string, string> listTireursToShowAndChooseForAdversaires = new Dictionary<string, string> {};

                foreach (var tireur in StatistiquesList)
                {
                    if (!listTireursToShowAndChooseForAdversaires.ContainsKey(tireur.Tireur1Name))
                    {
                        listTireursToShowAndChooseForAdversaires.Add(tireur.Tireur1Name, tireur.Tireur1Name);
                    }

                    if (!listTireursToShowAndChooseForAdversaires.ContainsKey(tireur.Tireur2Name))
                    {
                        listTireursToShowAndChooseForAdversaires.Add(tireur.Tireur2Name, tireur.Tireur2Name);
                    }
                }

                listTireursToShowAndChooseForAdversaires = listTireursToShowAndChooseForAdversaires.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                Dictionary<string,string> list = new Dictionary<string, string>() { };

                foreach (var tireur in listTireursToShowAndChooseForAdversairesBegin)
                {
                    list.Add(tireur.Key, tireur.Value);
                }

                foreach (var tireur in listTireursToShowAndChooseForAdversaires)
                {
                    list.Add(tireur.Key, tireur.Value);
                }

                return list;
            }
        }

        #region All Class public
        public class ClassStatistiques
        {
            public Guid Tireur1Guid { get; set; }
            public Guid Tireur2Guid { get; set; }
            public string Tireur1Name { get; set; }
            public string Tireur2Name { get; set; }
            public string Poule { get; set; }
            public bool VictoireOuDéfaiteDuTireur1 { get; set; }
            public bool VictoireOuDéfaiteDuTireur2 { get; set; }
            public int ScoreDuTireur1 { get; set; }
            public int ScoreDuTireur2 { get; set; }
            public string DateDeLaPoule { get; set; }
            public string Arme { get; set; }
        }
        #endregion

        #region All methods private
        private void ChargerStatistiques()
        {
            List<ClassStatistiques> chargerListeDesStatistiquesSession = this.GetValueStartsWith<List<ClassStatistiques>>("ChargerListeDesStatistiques");
            if (chargerListeDesStatistiquesSession != null)
            {
                StatistiquesList = chargerListeDesStatistiquesSession;
            }
            else
            {
                StatistiquesList = new List<ClassStatistiques>() { };

                var path = ServerTmp.MapPath("/App_Data/Poules.accdb");
                string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Mode=Read;Persist Security Info=True";
                string mySelectQuery = " SELECT * FROM TableRésultatsDesPoules ";

                using (var conn = new OleDbConnection(ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new OleDbCommand(mySelectQuery, conn))
                    {
                        using (var myReader = cmd.ExecuteReader())
                        {
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
                                string dateDeLaPoule = myReader["DateDeLaPoule"].ToString().Trim();
                                
                                StatistiquesList.Add(new ClassStatistiques()
                                {
                                    Poule = poule,
                                    Tireur1Guid = tireur1Guid,
                                    Tireur2Guid = tireur2Guid,
                                    VictoireOuDéfaiteDuTireur1 = victoireOuDéfaiteDuTireur1,
                                    VictoireOuDéfaiteDuTireur2 = victoireOuDéfaiteDuTireur2,
                                    ScoreDuTireur1 = scoreDuTireur1,
                                    ScoreDuTireur2 = scoreDuTireur2,
                                    DateDeLaPoule = dateDeLaPoule
                                });
                            }
                        }
                    }
                }

                List<ClassPoulesDuJour> allPoules = new List<ClassPoulesDuJour>() { };

                string mySelectQueryBis = " SELECT * FROM TableDesTireursPourUnePouleDuJour ";

                using (var conn = new OleDbConnection(ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new OleDbCommand(mySelectQueryBis, conn))
                    {
                        using (var myReader = cmd.ExecuteReader())
                        {
                            while (myReader.Read())
                            {
                                Guid tireurGuid = (Guid)myReader["TireurGuid"];
                                string poule = (string)myReader["Poule"];
                                string tireur = (string)myReader["Tireur"];
                                allPoules.Add(new ClassPoulesDuJour()
                                {
                                    TireurGuid = tireurGuid,
                                    Poule = poule,
                                    Tireur = tireur
                                });
                            }
                        }
                    }
                }

                var armesParDate = new Dictionary<string, string>();

                string sql = "SELECT DateDeLaPoule, Arme FROM TableDateAvecArmePratiquee";

                using (var conn = new OleDbConnection(ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new OleDbCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string date = reader.GetString(reader.GetOrdinal("DateDeLaPoule"));
                            string arme = reader.GetString(reader.GetOrdinal("Arme"));

                            armesParDate[date] = arme;
                        }
                    }
                }

                foreach (var tireur in StatistiquesList)
                {
                    if (allPoules.Any(x => x.TireurGuid == tireur.Tireur1Guid))
                    {
                        tireur.Tireur1Name = allPoules.FirstOrDefault(x => x.TireurGuid == tireur.Tireur1Guid).Tireur;
                    }

                    if (allPoules.Any(x => x.TireurGuid == tireur.Tireur2Guid))
                    {
                        tireur.Tireur2Name = allPoules.FirstOrDefault(x => x.TireurGuid == tireur.Tireur2Guid).Tireur;
                    }

                    if (allPoules.Any(x => x.TireurGuid == tireur.Tireur1Guid))
                    {
                        tireur.Tireur1Name = allPoules.FirstOrDefault(x => x.TireurGuid == tireur.Tireur1Guid).Tireur;
                    }

                    if (allPoules.Any(x => x.TireurGuid == tireur.Tireur2Guid))
                    {
                        tireur.Tireur2Name = allPoules.FirstOrDefault(x => x.TireurGuid == tireur.Tireur2Guid).Tireur;
                    }

                    if (armesParDate.TryGetValue(tireur.DateDeLaPoule, out string arme))
                    {
                        tireur.Arme = arme;
                    }
                }

                System.Web.HttpContext.Current.Session.Add("ChargerListeDesStatistiques", StatistiquesList);
            }
        }
        private T GetValueStartsWith<T>(string key)
        {
            var lastSessionKey = System.Web.HttpContext.Current.Session.Keys.Cast<string>()
                .LastOrDefault(x => x.StartsWith(key));

            if (string.IsNullOrEmpty(lastSessionKey))
                return default(T);

            return (T)Convert.ChangeType(HttpContext.Current.Session[lastSessionKey], typeof(T));
        }
        #endregion
    }
}