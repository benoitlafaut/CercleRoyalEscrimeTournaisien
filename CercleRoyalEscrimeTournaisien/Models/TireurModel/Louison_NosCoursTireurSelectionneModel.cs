using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Louison_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },
                     { "/Poules/Poule 2025-01-19 Sabre.pdf", "Poule 2025-01-19 Sabre"  },
                     { "/Poules/Poule 2025-01-24 Epée.pdf", "Poule 2025-01-24 Epée"  },
                     { "/Poules/Poule 2025-02-02 Epée.pdf", "Poule 2025-02-02 Epée"  },
                     { "/Poules/Poule 2025-03-16 Epée.pdf", "Poule 2025-03-16 Epée"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Louison_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                        DateRemarque = new DateTime(2024,9 ,29),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                //HasPointPositif=false,
                                PointNégatif="Laisse tes deux pieds au sol. A la fin de cette vidéo, on voit que tu lèves la jambe arrière.",
                                Frequency = 2,
                                HasUrlVideo=true,
                                UrlVideo = "/Videos/29-09-2024_ Louison_1.avi",
                                UrlYoutubeVideo = "8OOhmJ6NS14"
                            },
                            new RemarqueData()
                            {
                              //  HasPointPositif=true,
                                PointPositif="Le contre le sixte (parade circulaire) est parfait, il ne reste plus qu'à toucher. Ne t'inquiète pas si tu ne comprends pas le mot, regarde plutôt le geste sur la vidéo.",
                                Frequency = 1,
                                HasUrlVideo=true,
                                UrlVideo = "/Videos/29-09-2024_ Louison_2.avi",
                                UrlYoutubeVideo = "jfe2kbAemg0"
                            },
                            new RemarqueData()
                            {
                                //HasPointPositif=true,
                                PointPositif="N'attends pas que Eloi ou quelqu'un d'autre attaque, prends des initiatives. Démarre l'attaque la première. Fais des fentes. Attaque la première.",
                                Frequency = 1,
                                HasUrlVideo=true,
                                UrlVideo = "/Videos/29-09-2024_ Louison_3.avi",
                                UrlYoutubeVideo = "ODXjVhz0FPs"
                            }
                        }
                    }
                });
                return remarquesParDateTireur;
            }
        }
      
    }
}