using System;
using System.Collections.Generic;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Baptiste_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },
                    { "/Poules/Poule 2025-03-16 Epée.pdf", "Poule 2025-03-16 Epée"  },
                     { "/Poules/poule 2025-03-28 Sabre Seniors.pdf", "poule 2025-03-28 Sabre Seniors"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Baptiste_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif ,
                               Remarque="Lorsque tu attaques, laisse ta main armée à hauteur de l'épaule. La coquille protégera ton avant-bras.",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 1, 17),
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
                             Remarque="Au sabre, lors de l'attaque, le bras reste allongé jusqu'à la touche. Et le bras est dirigé vers la cible voulue.",
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
                                    Remarque="Quand tu as le bras allongé ou quand tu l'allonges, ne tourne pas ton pouce qui doit être à 11h tout le temps mais surtout utilise ton poignet pour longer la pointe tout autour de la coquille et ne te sers pas de tout ton avant-bras. Au plus petit c'est, au mieux c'est quand tu dégages.",
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                    HasUrlVideo=false,
                                    UrlVideo = "",
                                    Frequency = 5,
                                    UrlYoutubeVideo = ""
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
                                    Remarque="Belle parade de quarte avec riposte. n'hésite pas à réduire les mouvements. tu vas rechercher un peu trop loin l'arme de Valentin. Mais la riposte touche donc gooood",
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                   HasUrlVideo=true,
                                    UrlVideo = "/Videos/20-10-2024_Baptiste.avi",
                                    Frequency = 4,
                                    UrlYoutubeVideo = "774-zK6hayc"
                                },
                                
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
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                Remarque="Quel vent tu as fait à Lili. Je confirme donc qu'à la fin de l'assaut non seulement on salue son adversaire mais on lui serre la main. Les bonnes pratiques doivent revenir suite au covid...",
                                HasUrlVideo=true,
                                UrlVideo = "/Videos/19-10-2024_Baptiste.avi",
                                UrlYoutubeVideo = "M3VeV8fgarg"
                            }
                        }
                    }
                });

                return remarquesParDateTireur;
            }
        }
      
    }
}