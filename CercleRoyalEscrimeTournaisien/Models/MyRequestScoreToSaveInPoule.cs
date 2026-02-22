using System;

namespace CercleRoyalEscrimeTournaisien.Models
{
    public class MyRequestScoreToSaveInPoule
    {
        public Guid Tireur1Guid { get; set; }
        public Guid Tireur2Guid { get; set; }
        public int ScoreTireur1 { get; set; }
        public int ScoreTireur2 { get; set; }
        public int Vainqueur { get; set; }
        public string PouleSelected { get; set; }
    }
}
