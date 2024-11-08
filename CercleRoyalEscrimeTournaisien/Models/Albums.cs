using System.Collections.Generic;
using System.Linq;

namespace CercleRoyalEscrimeTournaisien
{
    public class Albums
    {
        public Albums()
        {
            NumeroAlbumCurrent = 12;
            NumeroPhotoOfAlbumCurrent = 1;  
        }
        public int NumeroAlbumCurrent { get; set; }
        public int NumeroPhotoOfAlbumCurrent { get; set; }
        public int NombreMaxPhotosOfAlbumCurrent
        {
            get
            {
                return GetMaxPhotosOfAlbumCurrent();
            }
        }
        public string TitreDiapo
        {
            get
            {
                return ListeDesAlbums.First(x => x.Key == NumeroAlbumCurrent.ToString()).Value;
            }
        }
     

        public IDictionary<string, string> ListeDesAlbums
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "12","Rencontre Maubeuge-Charleroi-Tournai 2019" },
                    { "11","Carnaval 2019" },
                    { "10","Fin de saison à Saint André" },
                    { "9","Un petit hockey à Don Bosco" },
                    { "8","Carnaval 2018" },
                    { "7","Gembloux février 2018" },
                    { "6","La saint-Nicolas 2017" },
                    { "5","Compétition à Lessines le 21/10/2017" },
                    { "4","Les petits et les grands en fin de saison 2017" },
                    { "3","Diverses photos 2017" },
                    { "2","A l'entraînement (juin 2017)" },
                    { "1","Challenge Charles Debeur" },
                };
            }
        }

       // public string NomAlbumSelected { get; set; }


        public int GetMaxPhotosOfAlbumCurrent()
        {
            switch (NumeroAlbumCurrent)
            {
                case 1:
                    return 8;
                case 2:
                    return 12;
                case 3:
                    return 58;
                case 4:
                    return 173;
                case 5:
                    return 46;
                case 6:
                    return 58;
                case 7:
                    return 5;
                case 8:
                    return 48;
                case 9:
                    return 9;
                case 10:
                    return 72;
                case 11:
                    return 58;
                case 12:
                    return 26;
            }

            return 0;
        }
    }
    public class Album
    {
        public string NomAlbum { get; set; }
        public int NumeroAlbum { get; set; }
    }
}
