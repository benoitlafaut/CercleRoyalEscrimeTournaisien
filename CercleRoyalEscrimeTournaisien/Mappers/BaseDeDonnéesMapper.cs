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
            string mySelectQuery = " SELECT * FROM TableListeTireursData where Période = '" + période + "'";

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
                                Période = (string)reader["Période"],
                                GuidTireur = (string)reader["GuidTireur"],
                                Prénom = (string)reader["Prénom"],
                                Nom = (string)reader["Nom"],
                                Birthdate = (string)reader["Birthdate"]
                            });
                        }
                    }
                }
            }

            System.Web.HttpContext.Current.Session.Add("ChargerTableListeTireursDataSession", tireursDataList);

            return tireursDataList;
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