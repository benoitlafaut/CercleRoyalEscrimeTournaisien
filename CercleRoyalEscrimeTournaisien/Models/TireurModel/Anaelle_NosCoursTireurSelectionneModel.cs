using System;
using System.Collections.Generic;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Anaelle_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
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
                      { "/Poules/Poule 2025-03-28 Sabre.pdf", "Poule 2025-03-28 Sabre"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Anaelle_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                Remarque="La machine commence à se mettre en place. au plus tu iras vite dans tes déplacements sans y penser, au plus tu gagneras.",
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                               Remarque="Tu attends souvent que l'autre fasse qqch. Non, agis ! fais qqch avant que l'autre ne le fasse. ",
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
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                    Remarque="Juste un point d'attention, tu n'es pas obligée d'avoir le bras allongé alors que tu es à 3 ou 4 mètres de ton adversaire, de un tu épuises ton bras, de deux cela ne sert à rien de l'avoir déjà allongé à ce moment là. Allonge-le dès que c'est nécessaire.",
                                    HasUrlVideo=false,
                                    UrlVideo = "",
                                    UrlYoutubeVideo = ""
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
                                   Remarque="Ne mets plus ta main non armée devant ton corps. si tu reçois un coup à ce moment-là, tu vas avoir mal. Tu es protégée. Si tu as des bleus, comme je l'ai dit à Apolline, tu peux mettre une sous-cuirasse en plus et vois si tu as moins mal. Ou essayer les protège-poitrines qu'on a à la salle, quitte à acheter quelques protège-poitrines pour enfants.",
                                    HasUrlVideo=false,
                                    Frequency = 7,
                                },
                                new RemarqueData()
                                {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                   Remarque="N'allonge pas ton bras dès la reprise de l'assaut tout de suite. tu te fatigues pour rien. Tu n'allonges ton bras armé que quand tu attaques.",
                                    HasUrlVideo=false,
                                    Frequency = 1,
                                },
                                new RemarqueData()
                                {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                   Remarque="Tu lèves encore ton pied arrière lors de la fente. quand tu fais une fente, laisse ton pied gauche par terre. au lieu de le lever. qu'il soit collé au sol. ",
                                    HasUrlVideo=false,
                                    Frequency = 4,
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
                                    Remarque="Sur la vidéo, on voit que tu es souvent trop près de Maé qui ne fait qu'une fente pour te toucher. Ne sois pas trop près d'elle. A la fin de la vidéo, on voit que tu commences à attaquer, à oser, à prendre l'initiative. c'est moi qui attaque c'est moi le chef  c'est moi qui dirige l'assaut. N'hésite pas à t'affirmer, à oser. tu es protégée de la tête aux pieds, tu peux y aller sans crainte. Au sabre comme au fleuret, celle qui attaque a un avantage sur l'autre. Vas y Anaëlle, montre à ton adversaire qui mène la danse!",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Anaelle.avi",
                                    UrlYoutubeVideo = "CD9H6M2O72o"
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
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                Remarque="Tu attaques c'est bien! continue d'attaquer. N'oublie pas d'allonger le bras avant de démarrer tes jambes. La touche que tu as reçue, c'est juste que tu as fléchi le bras lors de l'attaque. ne le fléchis pas.",
                                HasUrlVideo =true,
                                UrlVideo = "/Videos/12-10-2024_Anaelle.avi",
                                UrlYoutubeVideo = "tszdCVKPXwI"
                            },
                            
                        }
                    }

                });

                return remarquesParDateTireur;
            }
        }
      
    }
}