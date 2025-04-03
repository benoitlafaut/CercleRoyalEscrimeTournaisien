using System;
using System.Collections.Generic;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

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
                    { "/Poules/Poule 2025-01-19 Sabre.pdf", "Poule 2025-01-19 Sabre"  },
                    { "/Poules/Poule 2025-01-24 Epée Grand.pdf", "Poule 2025-01-24 Epée"  },
                    { "/Poules/Poule 2025-02-02 Epée.pdf", "Poule 2025-02-02 Epée"  },
                    { "/Poules/Poule 2025-03-14 Epée.pdf", "Poule 2025-03-14 Epée"  },
                    { "/Poules/Poule 2025-03-16 Epée.pdf", "Poule 2025-03-16 Epée"  },
                     { "/Poules/Poule 2025-03-12 Epée.pdf", "Poule 2025-03-12 Epée"  },
                       { "/Poules/Constatations 2025-03-28 Elodie.pdf", "Constatations 2025-03-28 Elodie"  },
                        { "/Poules/Poule 2025-03-28 Sabre.pdf", "Poule 2025-03-28 Sabre"  },
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
                        DateRemarque = new DateTime(2025, 4, 3),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque="Quand tu mènes de plus d' une touche (4-2 par exemple), c'est à ton adversaire à attaquer. Toi tu dois juste tenir la distance et laisser défiler le temps.",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },

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
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                               Remarque="Tu as commencé début de saison et tu mets déjà de belles touches. avec de la maîtrise du bras qui va vers la cible sans de détour et une bonne précision de pointe qui s'acquière avec le temps, tu gagneras en point et tu gagneras en match. tu as la volonté de gagner. c'est dur je le sais, je suis passé par là mais avec du travail tu y arriveras. ",
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
                                   PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                                     Remarque="Ne pense pas toujours à essayer de taper sur le fer adverse mais plutôt à allonger ton bras et pointer ta lame et ton bras vers la cible que tu auras choisie.",
                                                        HasUrlVideo=false,
                                                        Frequency = 1,
                                                    },
                                                 new RemarqueData()
                                                    {
                                   PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                                     Remarque="C'était un beau match face à Martin. Tu menais de 3 0. Et tu as laissé le temps défilé. chapeau !",
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