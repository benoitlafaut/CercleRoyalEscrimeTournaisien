using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Eliot_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
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
       
        private Tireur _tireurSelectionne { get; set; }
        public Eliot_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
        {
            this._tireurSelectionne = tireurSelectionne;
        }
        public List<RemarqueParDate> RemarquesParDateTireur
        {
            get
            {
                List<RemarqueParDate> remarquesParDateTireur = new List<RemarqueParDate>() { };
                remarquesParDateTireur.AddRange(new List<RemarqueParDate>()
                {
                     new RemarqueParDate()
                                    {
                                        DateRemarque = new DateTime(2024, 12, 18),
                                        Arme = TypeArme.Epée,
                                        Tireur = new Tireur()
                                        {
                                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                                        },
                                        RemarquesData = new List<RemarqueData>()
                                                {
                                                 new RemarqueData()
                                                    {
                                                        PointNégatif="Ne pense pas toujours à essayer de taper sur le fer adverse mais plutôt à allonger ton bras et pointer ta lame et ton bras vers la cible que tu auras choisie.",
                                                        HasUrlVideo=false,
                                                        Frequency = 1,
                                                    },
                                                 new RemarqueData()
                                                    {
                                                        PointPositif="C'était un beau match face à Martin. Tu menais de 3 0. Et tu as laissé le temps défilé. chapeau !",
                                                        HasUrlVideo=false,
                                                        Frequency = 1,
                                                    },

                                                }
                                    }
                });
               

                return remarquesParDateTireur;
            }
        }
      
    }
}