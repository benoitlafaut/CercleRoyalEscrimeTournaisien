using System;
using System.Collections.Generic;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Amado_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },
                    { "/Poules/Poule 2025-01-24 Epée.pdf", "Poule 2025-01-24 Epée"  },
                    { "/Poules/Poule 2025-03-14 Epée.pdf", "Poule 2025-03-14 Epée"  },
                     { "/Poules/Poule 2025-03-12 Epée.pdf", "Poule 2025-03-12 Epée"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Amado_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                           PointPositifNégatifObservation = PointPositifNégatifObservation.Observation
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
                                Remarque="tu bouges bien !! N'hésite pas à muscler avec une bouteille d'eau ton bras armé. je vois souvent que tu es obligé de relever ta main parce que l'arme est lourde. protège toi avec la coquille et l'avant-bras derrière la coquille.",
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Positif
                           },
                            new RemarqueData()
                            {
                                Remarque="Ne baisse pas trop vite les bras quand tu es touché. un match n'est jamais fini tant que l'arbitre n'a pas proclamé un vainqueur. Bats toi jusqu'au bout.",
                                  PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif
                          },
                        }
                    },
                     new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 12, 20),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                            {
                                new RemarqueData()
                                {
                                    Remarque="Chez toi, pendant les vacances, tu peux faire des déplacements (pas longtemps genre 5 minutes par jour pas plus)  à ton aise marché rompé fente. Pour que tu n'y penses plus en assaut... En allongeant le bras et en utilisant ton poignet pour contourner la coquille tu vas plus te concentrer sur ton bras ton poignet que tes jambes.",
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                   HasUrlVideo=false,
                                    UrlVideo = "",
                                    UrlYoutubeVideo = ""
                                },
                                 new RemarqueData()
                                {
                                    Remarque="Juste un point d'attention, à l'échauffement tu es parfois dans la lune, ailleurs. Du coup, tu démarres une ou deux secondes après le top, deux secondes de trop...",
                                   PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                 HasUrlVideo=false,
                                    UrlVideo = "",
                                    UrlYoutubeVideo = ""
                                },
                            }
                    },
                    

                });
                return remarquesParDateTireur;
            }
        }
      
    }
}