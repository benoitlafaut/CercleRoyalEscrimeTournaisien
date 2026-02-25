using System;

namespace CercleRoyalEscrimeTournaisien.Models
{
    public class MyRequestEliminationDirecteToSaveInPoule
    {
        public string DateDuJourWithoutDay { get; set; }
        public string PouleSelected { get; set; }
        public string Round { get; set; }
        public Guid Tireur1Guid { get; set; }
        public Guid Tireur2Guid { get; set; }
        public int InputScoreTireur1Guid { get; set; }
        public int InputScoreTireur2Guid { get; set; }
    }
}
