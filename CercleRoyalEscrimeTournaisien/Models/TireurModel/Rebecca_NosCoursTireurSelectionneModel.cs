using System;
using System.Collections.Generic;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Rebecca_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public Rebecca_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
        {
            this._tireurSelectionne = tireurSelectionne;
        }
        public IDictionary<string, string> GetPoules
        {
            get
                {
                return new Dictionary<string, string>()
                {
                     { "", ""  },
                    { "/Poules/Poule 2025-01-19 Sabre.pdf", "Poule 2025-01-19 Sabre"  },
                    { "/Poules/Poule 2025-02-02 Epée.pdf", "Poule 2025-02-02 Epée"  },
                    { "/Poules/Constatations 2025-03-28 Elodie.pdf", "Constatations 2025-03-28 Elodie"  },
                };

            }
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
                               Remarque="Dans les assauts que je vois, il y a du progrès par rapport au début de saison. Tu n'osais pas attaquer tu étais statique; Ici tu commences à bouger à venir chercher des touches. N'hésite pas à essayer d'attaquer avant l'autre. Prends des initiatives avant que l'autre ne fasse quelque chose. C'est en essayant des choses qu'on peut basculer un match.",
                            }                           
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 11, 16),
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
                                Remarque="Quand tu attaques, laisse ton bras allongé et ce sont les jambes qui amènent à la touche. Tu ne fléchis le bras que si tu es à bonne distance de ton adversaire. Si tu allonges le bras en même temps que tu marches, ton adversaire fixe sa pointe sur ta saignée et c'est toi qui lui apporte la touche.",
                                HasUrlVideo=false,
                                UrlVideo = "",
                                UrlYoutubeVideo = "",
                                Frequency = 5
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 9, 22),
                        Arme = TypeArme.Fleuret,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                                {
                                    new RemarqueData()
                                    {
                                       // HasPointPositif=false,
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                       Remarque="Au fleuret, quand tu fais un batté, tu accentues ta priorité. Du coup, après un batté, n'hésite pas à aller jusqu'à la touche sans qu'il y ait parade de la part de ton adversaire. ",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/22-09-2024_Rebecca_1.avi",
                                        UrlYoutubeVideo = "_aIIVF5N_B8"
                                    },
                                    new RemarqueData()
                                    {
                                       // HasPointPositif=false,
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                       Remarque="Quand tu fais une parade, en défense, tu as le droit de faire une riposte. La parade te donne la priorité sur l'attaque.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/22-09-2024_Rebecca_2.avi",
                                        UrlYoutubeVideo = "nn3dSGHhs4M",
                                        Frequency =4
                                    },


                                }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 10, 20),
                        Arme = TypeArme.Sabre,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                                {
                                    new RemarqueData()
                                    {
                                      //  HasPointPositif=false,
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                       Remarque="Je remarque que Maybelle t'a touchée 3 fois au même endroit. Tu n'es pas bien en garde. Quand qqn te touche au même endroit plusieurs fois, c'est qu'il y a un problème de ton côté. ici ta main armée est trop haute par rapport à ton coude. et tu mets ton arme quasi au milieu de ton corps alors qu'elle doit protéger la partie droite de ton corps. c'est pour cà que Maybelle touche systématiquement à la manchette. ah oui j'oubliais de le dire.. la passe avant est interdite au sabre. je l'ai vue deux fois non sanctionnée par l'arbitre.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/20-10-2024_Rebecca.avi",
                                        UrlYoutubeVideo = "yPHCUZDO19o"
                                    },
                                    new RemarqueData()
                                    {
                                    //    HasPointPositif=false,
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                       Remarque="Une simple fente ne devrait pas te toucher. si elle te touche, c'est que tu es trop près de ton adversaire.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/20-10-2024_Rebecca_2.avi",
                                        UrlYoutubeVideo = "TtS7nSSNqbk"
                                    },
                                     new RemarqueData()
                                    {
                                    //    HasPointPositif=false,
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                       Remarque="Ayant peur de recevoir un coup, tu mets ta main armée près de ta surface valable. Non seulement c'est sanctionnable si tu caches une surface valable mais tu pourrais avoir mal en recevant un coup. Tu le fais qqs fois ici.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/20-10-2024_Rebecca_3.avi",
                                        UrlYoutubeVideo = "-10mWOkRSaU",
                                        Frequency = 3
                                    },
                                }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 11, 10),
                        Arme = TypeArme.Sabre,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                                {
                                    new RemarqueData()
                                    {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                        Remarque="Quand tu te fends, laisse ton pied arrière au sol. Si tu es trop loin de ton adversaire, utilise le marché fente en agrandissant ton marché si besoin.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/10-11-2024 Rebecca.avi",
                                        UrlYoutubeVideo = "zwx_HJjrmL4"
                                    },
                                     new RemarqueData()
                                    {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                        Remarque="Quand tu subis une attaque, ne va pas avec ton fer vers l'arme adversaire. tu restes dans la position adéquate sans allonger le bras. c'est seulement après qu'il ait touché ta lame que tu peux faire la riposte.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/10-11-2024 Rebecca-2.avi",
                                        UrlYoutubeVideo = "zI1OOx0AZz0"
                                    }
                                }
                    }
                });
                return remarquesParDateTireur;
            }
        }
      
    }
}