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
                    { "/Poules/Poule 24-01-2025 Epée Grand.pdf", "Poule 24-01-2025 Epée"  },
                    { "/Poules/Poule 02-02-2025 Epée.pdf", "Poule 02-02-2025 Epée"  },
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
                        DateRemarque = new DateTime(2025, 1, 24),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositif="Tu as commencé début de saison et tu mets déjà de belles touches. avec de la maîtrise du bras qui va vers la cible sans de détour et une bonne précision de pointe qui s'acquière avec le temps, tu gagneras en point et tu gagneras en match. tu as la volonté de gagner. c'est dur je le sais, je suis passé par là mais avec du travail tu y arriveras. ",
                            },
                        }
                    },
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