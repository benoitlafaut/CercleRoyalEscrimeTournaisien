using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace CercleRoyalEscrimeTournaisien.Mappers
{
    [Serializable]
    public class BaseDeDonnéesMapper
    {     

        public List<TableListeTireursData> GetTableListeTireursData(HttpServerUtilityBase serverTmp, string période)
        {
            List<TableListeTireursData> tireursDataList = this.GetValueStartsWith<List<TableListeTireursData>>("ChargerTableListeTireursDataSession");
            if (tireursDataList != null)
            {
                return tireursDataList;
            }

            tireursDataList = new List<TableListeTireursData>() { };

            var path = serverTmp.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Mode=Read;Persist Security Info=True";

            string mySelectQuery = " SELECT * FROM TableListeTireursData where Periode = '" + période + "'";

            using (var conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(mySelectQuery, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tireursDataList.Add(new TableListeTireursData()
                            {
                                Periode = (string)reader["Periode"],
                                GuidTireur = (string)reader["GuidTireur"],
                                Prenom = (string)reader["Prenom"],
                                Nom = (string)reader["Nom"],
                                Birthdate = (string)reader["Birthdate"],
                                EmailPropre = reader["EmailPropre"] == DBNull.Value ? "" : (string)reader["EmailPropre"],
                                EmailPere = reader["EmailPere"] == DBNull.Value ? "" : (string)reader["EmailPere"],
                                EmailMere = reader["EmailMere"] == DBNull.Value ? "" : (string)reader["EmailMere"],
                                NomPere = reader["NomPere"] == DBNull.Value ? "" : (string)reader["NomPere"],
                                NomMere = reader["NomMere"] == DBNull.Value ? "" : (string)reader["NomMere"],
                                TelephonePropre = reader["TelephonePropre"] == DBNull.Value ? "" : (string)reader["TelephonePropre"],
                                TelephoneMere = reader["TelephoneMere"] == DBNull.Value ? "" : (string)reader["TelephoneMere"],
                                TelephonePere = reader["TelephonePere"] == DBNull.Value ? "" : (string)reader["TelephonePere"],
                                FicheSignaletiqueUrl = reader["FicheSignaletiqueUrl"] == DBNull.Value ? "" : (string)reader["FicheSignaletiqueUrl"],
                                PaiementsEffectues = reader["PaiementsEffectues"] == DBNull.Value ? "" : (string)reader["PaiementsEffectues"],
                                SeancesGratuites = reader["SeancesGratuites"] == DBNull.Value ? "" : (string)reader["SeancesGratuites"],
                                IsCotisationAnnuelle = (bool)reader["IsCotisationAnnuelle"],
                                IsCotisationCarte1 = (bool)reader["IsCotisationCarte1"],
                                IsCotisationCarte2 = (bool)reader["IsCotisationCarte2"],
                                IsCotisationCarte3 = (bool)reader["IsCotisationCarte3"],
                                IsCotisationCarte4 = (bool)reader["IsCotisationCarte4"],
                                IsCotisationCarte5 = (bool)reader["IsCotisationCarte5"],
                                IsCotisationCarte6 = (bool)reader["IsCotisationCarte6"],
                                IsChaussettesPayeesEnOrdre = (bool)reader["IsChaussettesPayeesEnOrdre"],
                                IsLocationMaterielEnOrdre = (bool)reader["IsLocationMaterielEnOrdre"],
                                IsFicheSignaletiqueEnOrdre = (bool)reader["IsFicheSignaletiqueEnOrdre"],
                                IsTeeShirtsPayeesEnOrdre = (bool)reader["IsTeeShirtsPayeesEnOrdre"],
                                IsMaterielLoue = (bool)reader["IsMaterielLoue"],    
                                IsCotisationEnOrdre = (bool)reader["IsCotisationEnOrdre"],
                            });
                        }
                    }
                }
            }

            string mySelectQuerySecond = " SELECT * FROM TableJourDesPoules";

            using (var conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(mySelectQuerySecond, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string guidTireur = (string)reader["GuidTireur"];
                            tireursDataList.FirstOrDefault(x => x.GuidTireur == guidTireur).DayMercredi = (string)reader["DayMercredi"];
                            tireursDataList.FirstOrDefault(x => x.GuidTireur == guidTireur).DayVendredi = (string)reader["DayVendredi"];
                            tireursDataList.FirstOrDefault(x => x.GuidTireur == guidTireur).DayDimanche = (string)reader["DayDimanche"];
                        }
                    }
                }
            }

            System.Web.HttpContext.Current.Session.Add("ChargerTableListeTireursDataSession", tireursDataList.OrderBy(t => t.Prenom).ToList());

            return tireursDataList.OrderBy(t => t.Prenom).ToList();
        }
        public List<TableDesLecons> GetTableDesLecons(HttpServerUtilityBase serverTmp, string période)
        {
            List<TableDesLecons> tableDesLeconsList = this.GetValueStartsWith<List<TableDesLecons>>("ChargerTableDesLecons");
            if (tableDesLeconsList != null)
            {
                return tableDesLeconsList;
            }

            tableDesLeconsList = new List<TableDesLecons>() { };

            var path = serverTmp.MapPath("/App_Data/Poules.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Mode=Read;Persist Security Info=True";

            string mySelectQuery = " SELECT * FROM TableDesLecons";

            using (var conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(mySelectQuery, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tableDesLeconsList.Add(new TableDesLecons()
                            {
                                GuidTireur = (string)reader["GuidTireur"],
                                NombreDeLeconsDejaRecues = (int)reader["NombreDeLeconsDejaRecues"],
                            });
                        }
                    }
                }
            }

            System.Web.HttpContext.Current.Session.Add("ChargerTableDesLecons", tableDesLeconsList);

            return tableDesLeconsList;
        }
        private T GetValueStartsWith<T>(string key)
        {
            var lastSessionKey = System.Web.HttpContext.Current.Session.Keys.Cast<string>()
                .LastOrDefault(x => x.StartsWith(key));

            if (string.IsNullOrEmpty(lastSessionKey))
                return default(T);

            return (T)Convert.ChangeType(HttpContext.Current.Session[lastSessionKey], typeof(T));
        }
    }
}