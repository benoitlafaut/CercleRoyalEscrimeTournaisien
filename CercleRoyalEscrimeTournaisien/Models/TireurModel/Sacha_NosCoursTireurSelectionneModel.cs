using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Sacha_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },
                    { "/Poules/Poule 2025-01-24 Epée.pdf", "Poule 2025-01-24 Epée"  },
                     { "/Poules/Poule 2025-03-28 Sabre.pdf", "Poule 2025-03-28 Sabre"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Sacha_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                    PointNégatif="Quand tu tires contre qqn de plus grand, ne charge pas comme un taureau. Il y a d'autres façons de parvenir à toucher qu'à foncer tête baissée. Plus en finesse. Au bras par exemple. en faisant des marchés fente.",
                                    HasUrlVideo=false,
                                    Frequency = 3,
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
                                    PointPositif="C'est un beau match. Tu prends des initiatives et tu attaques en choisissant une cible. Continue ainsi. Fais juste attention de ne pas sauter en l'air comme les kangourous au lieu de faire de beaux marchés ou marchés fente.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Sacha.avi",
                                    UrlYoutubeVideo = "KipxcKDd6Mg"
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
                                    PointNégatif="Quand tu tires à l'épée, les déplacements t'aident à porter la touche. c'est perfecto.. Par contre l'arme est toujours dirigée vers une surface valable. Ici elle est dirigée vers le sol.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/16-11-2024_Sacha.avi",
                                    UrlYoutubeVideo = "bW8bdYmp1PM"
                                }
                        }
                    }
                });

                return remarquesParDateTireur;
            }
        }
      
    }
}