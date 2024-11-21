using System;
using System.Collections.Generic;

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
        public string PointPositif { get; set; }
        public string PointNégatif { get; set; }
        public string UrlYoutubeVideo { get; set; }
        public int Frequency { get; set; }
        public bool HasUrlVideo { get; set; }
        public string UrlVideo { get; set; }
    }
}