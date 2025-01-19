using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Remi_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                };
            }
        }
        public Remi_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
        {
            TireurSelectionne = tireurSelectionne;
        }
        public List<RemarqueParDate> RemarquesParDateTireur
        {
            get
            {
                List<RemarqueParDate> remarquesParDateTireur = new List<RemarqueParDate>() { };
              
                return remarquesParDateTireur;
            }
        }
      
    }
}