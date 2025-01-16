using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            //ChanteurSelected = "2";
            //ChansonSelected = "1";
            RowsToRead = new List<string>() { };
            MomentsToRead = new List<string>() { };
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
                },
                new Artiste()
                {
                    Index = "2",
                    NomDeLArtiste = "Vincent Niclo",
                    ChansonsList = new List<ChansonData>()
                    {
                        new ChansonData()
                        {
                            Index = "0",
                        },
                        new ChansonData()
                        {
                            Index = "1",
                            Chanson = "Divino",
                            UrlChansonEmbed = "kDHEsbkIBnE"
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
        private void ChargerLyricsChanson()
        {
            List<RowsListenWithLRC> RowsListenWithLRC = new List<RowsListenWithLRC>() { };
            if (string.IsNullOrEmpty(ChansonSelected) || ChansonSelected == "0") 
            {
                RowsToRead = new List<string>() { };
                MomentsToRead = new List<string>() { };
                return; 
            }
            if (string.IsNullOrEmpty(ChanteurSelected) || ChanteurSelected == "0")
            {
                RowsToRead = new List<string>() { };
                MomentsToRead = new List<string>() { };
                return;
            }

            string FilePath = HttpContext.Current.Server.MapPath("/VideoLyrics/");
            FilePath += ArtistesList.FirstOrDefault(x => x.Index == ChanteurSelected).ChansonsList.FirstOrDefault(x => x.Index == ChansonSelected).Chanson + ".txt";

            List<string> rowsToRead  = File.ReadAllLines(FilePath, Encoding.Default).ToList();

            foreach (string row in rowsToRead)
            {
                string[] rowFormatted = row.Split(']');
                rowFormatted[0] = rowFormatted[0] + "]";
                RowsListenWithLRC.Add(new Models.RowsListenWithLRC()
                {
                    Moment = rowFormatted[0],
                    Row = rowFormatted[1]
                });
            }

            RowsToRead = RowsListenWithLRC.Select(x => x.Row).ToList();
            MomentsToRead = RowsListenWithLRC.Select(x => x.Moment.Replace("[", "").Replace("]", "")).ToList();
        }

        public List<string> RowsToRead { get; set; }
        public List<string> MomentsToRead { get; set; }

        public List<Artiste> ArtistesList { get; set; }
        public string ChanteurSelected { get; set; }
        
        private string ChansonSelectedField;
        public string ChansonSelected
        {
            get
            {
                return this.ChansonSelectedField;
            }
            set
            {
                this.ChansonSelectedField = value;
                ChargerLyricsChanson();
            }
        }
    }
    public class RowsListenWithLRC
    {
        public string Moment { get; set; }
        public string Row { get; set; }
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