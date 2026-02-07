using System;
using System.Collections.Generic;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class RemarqueParDate
    {
        public RemarqueParDate()
        {
            RemarquesData = new List<RemarqueData>() { };
        }
        public DateTime DateRemarque { get; set; }
        public bool IsShowPartialView { get; set; }
        public bool IsSwitchToShowDossierPhotos { get; set; }
        public Guid SwitchToDossierPhotosGuid { get; set; }
        public string PartialViewToShow { get; set; }
        public string Titre { get; set; }
        public TypeArme Arme { get; set; }
        public Tireur Tireur { get; set; }
        public List<RemarqueData> RemarquesData { get; set; }
    }

    [Serializable]
    public class RemarqueData
    {
        public RemarqueData()
        {
            Frequency = 1;
        }
        public PointPositifNégatifObservation PointPositifNégatifObservation { get; set;}
        public string Remarque { get; set; }
        public string UrlYoutubeVideo { get; set; }
        public int Frequency { get; set; }
        public bool HasUrlVideo { get; set; }
        public string UrlVideo { get; set; }
    }
}