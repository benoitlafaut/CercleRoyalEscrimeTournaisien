using System;

namespace CercleRoyalEscrimeTournaisien.Models
{
    public enum TypeScreenToShow
    {
        ScreenBannier = 1,
        ScreenEpub = 2,
        ScreenAgenda = 3,
        ScreenCategories = 4,
        ScreenAlbums = 5,
        ScreenHistorique = 6,
        ScreenActivites = 7,
        ScreenQuelquesSitesInteressants = 8,
        ScreenNosCours = 9,
        ScreenDico = 10,
        ScreenEpub_20221112=11,
        ScreenPDFPage = 12,
        PagePersoManager=13,
        ReadEpub20042023=14,
        ReadEpub28012024 = 15
    }
    public static class MainModel
    {
        public static TypeScreenToShow ScreenToShow { get; set; }
        public static DateTime DateCurrent { get; set; }
        public static int NumeroAlbumCurrent { get; set; }
        public static int NumeroPhotoOfAlbumCurrent { get; set; }
        public static string NewSelectedIndexTheme { get; set; }
        public static bool HasPubAlreadyShowed { get; set; }
    }
}