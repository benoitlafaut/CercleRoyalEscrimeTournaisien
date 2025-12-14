using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Web;

namespace CercleRoyalEscrimeTournaisien.Models
{
    [Serializable]
    public class LoggingUsersViewModel
    {
        public LoggingUsersViewModel(HttpServerUtilityBase serverTmp) 
        {
            this.ServerTmp = serverTmp;
            ChargerUsersConnectés();
        }

        public HttpServerUtilityBase ServerTmp { get; set; }
        public List<ClassTireurLoggé> TireursLoggés { get; set; }


        private void ChargerUsersConnectés()
        {
            TireursLoggés = new List<ClassTireurLoggé>() { };

            var path = ServerTmp.MapPath("/App_Data/tireursLog.accdb");
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=True";
            string mySelectQuery = " SELECT * FROM TableTireursLogin";
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
            myCommand.Connection.Open();
            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);   

            while (myReader.Read())
            {
                string tireurLoggé = (string)myReader["TireurLoggé"];
                string dateLog = (string)myReader["DateLog"];
                TireursLoggés.Add(new ClassTireurLoggé()
                {
                    DateLog = dateLog,
                    TireurLoggé = tireurLoggé
                });
            }
        }
    }

    public class ClassTireurLoggé
    {
        public string TireurLoggé { get; set; }
        public string DateLog { get; set; }
    }
}