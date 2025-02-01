using System;
using System.Collections.Generic;

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
                    { "/Poules/Poule 24-01-2025 Epée.pdf", "Poule 24-01-2025 Epée"  },
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
                                PointPositif="tu bouges bien !! N'hésite pas à muscler avec une bouteille d'eau ton bras armé. je vois souvent que tu es obligé de relever ta main parce que l'arme est lourde. protège toi avec la coquille et l'avant-bras derrière la coquille.",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Ne baisse pas trop vite les bras quand tu es touché. un match n'est jamais fini tant que l'arbitre n'a pas proclamé un vainqueur. Bats toi jusqu'au bout.",
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
                                    PointNégatif="Chez toi, pendant les vacances, tu peux faire des déplacements (pas longtemps genre 5 minutes par jour pas plus)  à ton aise marché rompé fente. Pour que tu n'y penses plus en assaut... En allongeant le bras et en utilisant ton poignet pour contourner la coquille tu vas plus te concentrer sur ton bras ton poignet que tes jambes.",
                                    HasUrlVideo=false,
                                    UrlVideo = "",
                                    UrlYoutubeVideo = ""
                                },
                                 new RemarqueData()
                                {
                                    PointNégatif="Juste un point d'attention, à l'échauffement tu es parfois dans la lune, ailleurs. Du coup, tu démarres une ou deux secondes après le top, deux secondes de trop...",
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