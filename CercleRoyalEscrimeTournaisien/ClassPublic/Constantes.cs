using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

namespace CercleRoyalEscrimeTournaisien.ClassPublic
{
    public class Constantes
    {
        public const string CurrentPage = "CurrentPage";
        //public const string StartPage = "StartPage";
        public const string Video = "Video";
        public const string ShowMenuPrincipal = "ShowMenuPrincipal";
        public const string Accueil = "Accueil";
        public const string Agenda = "Agenda";
        public const string Catégories = "Catégories";
        public const string Albums = "Albums";
        public const string Historique = "Historique";
        public const string Activités = "Activités";
        public const string QuelquesSitesInteressants = "QuelquesSitesInteressants";
        public const string NosCours = "NosCours";
        public const string PagePersoManager = "PagePersoManager";
        public const string Epub_20221112 = "Epub_20221112";
        public const string ScreenPDFPage = "ScreenPDFPage";
        public const string Dico = "Dico";
        public const string ReadEpub20042023 = "ReadEpub20042023";
        public const string Mp3 = "Mp3";
        public const string Logon = "Logon";
        public const string Velo = "Velo";
        public const string Karaoke = "Karaoke";
        public const string LoggingUsers = "LoggingUsers";
        public const string ReadEpub28012024 = "ReadEpub28012024";
        public const string NosCoursTireurSelectionne = "NosCoursTireurSelectionne";
        public const string Epub122024 = "Epub122024";
        public const string Poules = "Poules";
        public static string Serialize(object o)
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
        public static object Deserialize(string str)
        {
            byte[] bytes = Convert.FromBase64String(str);

            using (MemoryStream stream = new MemoryStream(bytes))
            {
                return new BinaryFormatter().Deserialize(stream);
            }
        }
    }
}