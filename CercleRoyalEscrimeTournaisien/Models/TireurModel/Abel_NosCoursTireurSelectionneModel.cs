using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Abel_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },
                    { "/Poules/Poule 19-01-2025 Sabre.pdf", "Poule 19-01-2025 Sabre"  },
                };

            }
        }
        public Abel_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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