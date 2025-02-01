using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class ArthurBarbery_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },
                    { "/Poules/Poule 24-01-2025 Epée Grand.pdf", "Poule 24-01-2025 Epée"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public ArthurBarbery_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                PointPositif="Je remarque une nette amélioration de ta gestuelle et des combats en général. Quand tu es dans ton match, tu fais des dégâts. Reste dans tes matchs; sois impertubable. Ne te laisse pas déconcentrer par telle ou telle chose. je suis sur que tu peux faire plus de dégâts que cà. La prochaine étape pour toi, c'est de faire des 5-0. ne pas te laisser toucher, garder la distance que tu fais très bien et être posé dans chacun de tes matchs. ",
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
                                    //HasPointPositif=false,
                                    PointNégatif="Ne tourne pas le dos à ton adversaire. Celà peut te faire très mal.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_ArthurBarbery.avi",
                                    UrlYoutubeVideo = "r3-rQ0aM7eY"
                                },
                                new RemarqueData()
                                {
                                   // HasPointPositif=true,
                                    PointPositif="Quand tu vois un adversaire qui fait de trop grandes parades, profites-en. Provoque-le en faisant des feintes de coup droit pour qu'il aille chercher la parade et là tu peux passer de l'autre côté et toucher par dégagements. Quitte à faire des dégagements successifs tout en allongeant le bras progressivement.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_ArthurBarbery_2.avi",
                                    UrlYoutubeVideo = "JTBj_UgJ2FE"
                                },
                                new RemarqueData()
                                {
                                    //HasPointPositif=true,
                                    PointPositif="La garde est très bonne au fleuret.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_ArthurBarbery_3.avi",
                                    UrlYoutubeVideo = "d_0OzLyjhNo"
                                },
                                new RemarqueData()
                                {
                                    //HasPointPositif=false,
                                    PointNégatif="N'oublie pas que les parades se font avec le bras fléchi. La parade et la riposte ne se font pas en un coup, il faut d'abord parer avec le bras fléchi et puis allonger le bras pour faire la riposte.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_ArthurBarbery_3.avi",
                                    UrlYoutubeVideo = "d_0OzLyjhNo"
                                },
                                 new RemarqueData()
                                {
                                    //HasPointPositif=true,
                                    PointPositif="La parade de sixte suivie d'une riposte par dégagement est piccobello. de toute beauté!",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_ArthurBarbery_4.avi",
                                    UrlYoutubeVideo = "dUDuFE6BNnk"
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
                                        PointNégatif="Cela n'est pas la première fois que je le constate, quand tu attaques sans crainte d'être touché, tu vas droit vers le tireur sans l'éviter et tu te retournes en montrant ton dos comme si tu voulais voir le marquoir. Evite de foncer vers l'autre et surtout de te retourner.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/10-11-2024 Arthur.avi",
                                        UrlYoutubeVideo = "KmlUcgoLVAo",
                                        Frequency = 4
                                    }
                                }
                    }
                });
                
                return remarquesParDateTireur;
            }
        }
      
    }
}