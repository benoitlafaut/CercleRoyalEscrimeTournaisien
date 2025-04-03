using System;
using System.Collections.Generic;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Mae_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },
                    { "/Poules/Poule 2025-01-24 Epée Grand.pdf", "Poule 2025-01-24 Epée"  },
                    { "/Poules/Poule 2025-03-14 Epée.pdf", "Poule 2025-03-14 Epée"  },
                    { "/Poules/Poule 2025-03-16 Epée.pdf", "Poule 2025-03-16 Epée"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Mae_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
        {
            this._tireurSelectionne = tireurSelectionne;
        }
        public List<RemarqueParDate> RemarquesParDateTireur
        {
            get
            {
                List<RemarqueParDate> remarquesParDateTireur = new List<RemarqueParDate>() { };
                remarquesParDateTireur.AddRange(
                new List<RemarqueParDate>()
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
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Quand tu mènes de plus d' une touche (4-2 par exemple), c'est à ton adversaire à attaquer. Toi tu dois juste tenir la distance et laisser défiler le temps.",
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
                                Remarque="Tu viens de commencer cette année-ci. il est normal que cà soit dur pour toi de gagner. mais tout travail ou évolution mérite d'être souligné. je vois du répondant, peut-etre un peu timide encore mais il faut oser. je vois une belle garde, une belle précision de la pointe. il faut croire en toi et ne pas douter de toi. je suis sûr que tu es capable de faire de belles touches à la manchette ou saignée. il faut y aller, mordre sur la chique et tenter des choses. c'est à la salle qu'on tente des choses. Continue et n'aie pas peur d'attaquer, ose !",
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                               Remarque="Parfois tu démarres trop tôt les jambes. le bras doit être allongé complètement avant de démarrer les jambes. si tu fais les deux en meme temps, tu risques d'être touchée à la saignée.",
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                               Remarque="Tu es souvent trop proche de ton adversaire, plus il est grand plus tu es éloignée de lui. ",
                            },
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                Remarque="Tu fais un retrait du bras trop vite quand tu n'es pas encore à bonne distance de lui. Laisse ton bras allonger jusqu'au moment où tu es bien loin de lui.",
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
                                   Remarque="Souvent trop proche, tu es touchée parce que c'est toi qui te rapproches trop de ton adversaire. ",
                                    HasUrlVideo=false,
                                    Frequency = 3,
                                },
                            new RemarqueData()
                                {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif ,
                                    Remarque="Petite astuce contre les tireurs ou tireuses qui fléchissent très vite leur bras après une attaque qui ne touche pas, c'est à ce moment-là que ton attaque peut commencer. D'abord le bras, puis les jambes.",
                                    HasUrlVideo=false,
                                    Frequency = 2,
                                },
                                new RemarqueData()
                                {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif ,
                                   Remarque="Si tu vois une ouverture, le bras trop rapproché ou le masque trop rapproché, n'hésite pas à attaquer sans te soucier de te faire toucher.",
                                    HasUrlVideo=false,
                                    Frequency = 2,
                                },
                                new RemarqueData()
                                {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                   Remarque="Au plus grand est ton adversaire, au plus grande est ta distance.",
                                    HasUrlVideo=false,
                                    Frequency = 2,
                                }
                            }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 10, 19),
                        Arme = TypeArme.Sabre,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                            {
                                new RemarqueData()
                                {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                    Remarque="Ce sont de belles touches que tu mets à Anaëlle sur cette vidéo. n'hésite pas à varier la cible que tu veux toucher : la tête par exemple. pas toujours la manchette même si cela paie. Si l'autre cible ne marche pas, reviens à la cible de départ. Ce qui marche bien aussi ce sont les marchés rompés que tu fais pour te rapprocher d'Anaëlle. Cela paie de casser la distance pour te rapprocher de ton adversaire et finir par une belle touche en fente.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Mae.avi",
                                    Frequency = 4,
                                    UrlYoutubeVideo = "kqCL3Nf7HJU"
                                }
                            }
                    },
                     new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024,10 ,12),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex ,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                Remarque="Je vois sur cette vidéo que ta pointe est trop haute par rapport à ton coude. A l'épée, le coude ainsi que la main et la pointe doivent être au même niveau par rapport au sol. Là tu relèves et la main et la pointe. tout est parallèle au sol à l'épée. Si ton adversaire essaie de te toucher à un certain endroit c'est qu'il voit une ouverture.",
                                HasUrlVideo =true,
                                UrlVideo = "/Videos/12-10-2024_Mae.avi",
                                UrlYoutubeVideo = "7vOCLA2Xxpc"
                            },
                        }
                    }

                });

                return remarquesParDateTireur;
            }
        }
      
    }
}