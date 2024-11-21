using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using System.Text;

namespace CercleRoyalEscrimeTournaisien.Models
{
    [Serializable]
    public class KaraokeViewModel
    {
        public KaraokeViewModel() 
        {
            ChargerArtistes();
        }

        private void ChargerArtistes()
        {
            ArtistesList = new List<Artiste>()
            {
                new Artiste()
                {
                    Index = "0",
                    NomDeLArtiste = "",
                },
                new Artiste()
                {
                    Index = "1",
                    NomDeLArtiste = "Patrick Fiori",
                    ChansonsList = new List<ChansonData>()
                    {
                        new ChansonData()
                        {
                            Index = "0",
                        },
                        new ChansonData()
                        {
                            Index = "1",
                            Chanson = "Le chant est libre",
                            UrlChansonEmbed = "rLfdENU19NY"
                        }
                    }
                }
            };
        }
        public IDictionary<string, string> ListeDesChanteurs
        {
            get
            {
                return ArtistesList.ToDictionary(x => x.Index, x => x.NomDeLArtiste);
            }
        }
        public IDictionary<string, string> ListeDesChansons
        {
            get
            {
                if (ChanteurSelected == "0") { return new Dictionary<string, string>(); }
                if (string.IsNullOrEmpty(ChanteurSelected)) { return new Dictionary<string, string>();  }
                return ArtistesList.FirstOrDefault(x=>x.Index == ChanteurSelected).ChansonsList.ToDictionary(x => x.Index, x => x.Chanson);
            }
        }        
        public string UrlChansonEmbed
        {
            get
            {
                if (ChanteurSelected == "0") { return string.Empty; }
                if (string.IsNullOrEmpty(ChanteurSelected) || string.IsNullOrEmpty(ChansonSelected)) { return string.Empty; }
                return ArtistesList.FirstOrDefault(x => x.Index == ChanteurSelected).ChansonsList.FirstOrDefault(x => x.Index == ChansonSelected).UrlChansonEmbed;
            }
        }
        public List<string> LyricsChanson
        {
            get
            {
                if (string.IsNullOrEmpty(UrlChansonEmbed)) { return new List<string>(); }

                string FilePath = HttpContext.Current.Server.MapPath("/VideoLyrics/");
                FilePath += ArtistesList.FirstOrDefault(x => x.Index == ChanteurSelected).ChansonsList.FirstOrDefault(x => x.Index == ChansonSelected).Chanson + ".txt";
                return File.ReadAllLines(FilePath, Encoding.Default).ToList();
            }
        }
        public List<Artiste> ArtistesList { get; set; }
        public string ChanteurSelected { get; set; }
        public string ChansonSelected { get; set; }
    }

    public class Artiste
    {
        public string Index { get; set; }
        public string NomDeLArtiste { get; set; }
        public List<ChansonData> ChansonsList  { get; set; }
    }

    public class ChansonData
    {
        public string Index { get; set; }
        public string Chanson { get; set; }
        public string UrlChansonEmbed { get; set; }
    }
}