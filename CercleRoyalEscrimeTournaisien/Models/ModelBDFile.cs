using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CercleRoyalEscrimeTournaisien.Models
{
    [Serializable]
    public class ModelBDFile
    {
        public ModelBDFile()
        {
            ListBD = new List<BDData>() { };

            string url = "/DossierExterieurAVS/BD2/";

            IEnumerable<string> allFiles = Directory.EnumerateFiles(System.Web.HttpContext.Current.Server.MapPath(url));

            Dossier = System.Web.HttpContext.Current.Server.MapPath(url);

            ListBD.Add(new BDData()
            {
                BDPath = "",
                Collection = "",
                NomBD = "",
                TomeNumber = ""
            });

            foreach (string file in allFiles)
            {
                string[] fileData = file.Split('_');

                ListBD.Add(new BDData()
                {
                    BDPath = file,
                    BDPathWithoutPath = file.Replace(Dossier, ""),
                    Collection = fileData[0].Replace(Dossier, ""),
                    NomBD = fileData[2],
                    TomeNumber = fileData[1]
                });
            }
        }
        public string Dossier { get; set; }
        public List<BDData> ListBD { get; set; }
        public List<string> ListCollection
        {
            get
            {
                return ListBD.DistinctBy(x => x.Collection).Select(x => x.Collection).ToList();
            }
        }

        public List<string> ListBDParCollection
        {
            get
            {
                if (string.IsNullOrEmpty(NomDeLaCollectionSelected)) { return new List<string>() { }; }
                return ListBD.Where(x => x.Collection == NomDeLaCollectionSelected || x.Collection == "").Select(x => x.NomBD).ToList();
            }
        }

        public string NomDeLaCollectionSelected { get; set; }
        public string BookSelected { get; set; }
    }

    [Serializable]
    public class BDData
    {
        public BDData()
        {
            BDPath = string.Empty;
            NomBD = string.Empty;
            Collection = string.Empty;
            TomeNumber = string.Empty;
            BDPathWithoutPath = string.Empty;
        }

        public string BDPath { get; set; }
        public string BDPathWithoutPath { get; set; }
        public string Collection { get; set; }
        public string NomBD { get; set; }
        public string TomeNumber { get; set; }
    }
}