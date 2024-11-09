using System;
using System.Collections.Generic;
using System.Linq;

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
                            Chanson = " Le chant est libre",
                            UrlChanson = "https://www.youtube.com/embed/rLfdENU19NY?list=RDEMgJD0UhYfVc2UlvaclqohxQ&enablejsapi=1",
                            UrlChansonEmbed = "rLfdENU19NY",
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
                if (string.IsNullOrEmpty(ChanteurSelected)) { return new Dictionary<string, string>();  }
                return ArtistesList.FirstOrDefault(x=>x.Index == ChanteurSelected).ChansonsList.ToDictionary(x => x.Index, x => x.Chanson);
            }
        }
        public string ChansonSelectedUrl
        {
            get
            {
                if (string.IsNullOrEmpty(ChanteurSelected) || string.IsNullOrEmpty(ChansonSelected)) { return string.Empty; }
                return ArtistesList.FirstOrDefault(x => x.Index == ChanteurSelected).ChansonsList.FirstOrDefault(x => x.Index == ChansonSelected).UrlChanson;
            }
        }
        public string UrlChansonEmbed
        {
            get
            {
                if (string.IsNullOrEmpty(ChanteurSelected) || string.IsNullOrEmpty(ChansonSelected)) { return string.Empty; }
                return ArtistesList.FirstOrDefault(x => x.Index == ChanteurSelected).ChansonsList.FirstOrDefault(x => x.Index == ChansonSelected).UrlChansonEmbed;
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
        public string UrlChanson { get; set; }
        public string UrlChansonEmbed { get; set; }
    }
}