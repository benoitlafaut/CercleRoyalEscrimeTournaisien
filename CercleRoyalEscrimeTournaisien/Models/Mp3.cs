using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace CercleRoyalEscrimeTournaisien.Models
{
    [Serializable]
    public class Mp3
    {
        public enum NameDossier
        {
            Debutant,
            Vocabulaire,
            Perfectionnement,
        }
        public enum LanguageMP3
        {
            Francais = 1,
            Espagnol = 2,
            Allemand = 3,
            Anglais = 4,
            Néerlandais = 5
        }
       
        public Mp3()
        {
            SelectedLanguage = LanguageMP3.Anglais;

            List<SelectListItem> listItem = new List<SelectListItem>();
            for (int iloop = 1; iloop <= 7; iloop++)
            {
                var newItem = new SelectListItem { Text = iloop.ToString(), Value = iloop.ToString() };
                listItem.Add(newItem);
            }

            IndexDossierList = listItem.Select(C => new SelectListItem
            {
                Value = C.Value,
                Text = C.Text

            });

            listItem = new List<SelectListItem>();
            for (int iloop = 1; iloop <= 15; iloop++)
            {
                var newItem = new SelectListItem { Text = iloop.ToString(), Value = iloop.ToString() };
                listItem.Add(newItem);
            }
            IndexFileList = listItem.Select(C => new SelectListItem
            {
                Value = C.Value,
                Text = C.Text

            });
            SelectedFile = string.Empty;

            


            var currentLanguageSelected = HttpContext.Current.Request.Cookies["currentLanguageSelected"];
            if (currentLanguageSelected != null) 
            { 
                string[] currentLanguage = currentLanguageSelected.Value.Split('/');
                SelectedLanguage = (LanguageMP3)Enum.Parse(typeof(LanguageMP3), currentLanguage[0]);
                SelectedNameDossier = (NameDossier)Enum.Parse(typeof(NameDossier), currentLanguage[1]);
                SelectedIndexDossier = currentLanguage[2];
                SelectedIndexFile = currentLanguage[3];

                SelectedFile = "../DossierExterieurAVS/mp3/" + SelectedLanguage + "/" + SelectedNameDossier + "/" + SelectedIndexDossier + "/" + SelectedIndexFile + ".mp3";

            }

        }
        public IEnumerable<SelectListItem> IndexDossierList { get; set; }
        public IEnumerable<SelectListItem> IndexFileList { get; set; }
        public LanguageMP3 SelectedLanguage { get; set; }
        public NameDossier SelectedNameDossier { get; set; }
        public string SelectedIndexDossier { get; set; }
        public string SelectedIndexFile { get; set; }
        public string SelectedFile { get; set; }
        public IndexMp3 Allemand { get; set; }
        public IndexMp3 Espagnol { get; set; }
        public IndexMp3 Anglais { get; set; }    
    }

    [Serializable]
    public class IndexMp3
    {       
        public string NomDossier { get; set; }
        public int NumeroDossier { get; set; }
        public int NumeroFichier { get; set; }
    }   
}