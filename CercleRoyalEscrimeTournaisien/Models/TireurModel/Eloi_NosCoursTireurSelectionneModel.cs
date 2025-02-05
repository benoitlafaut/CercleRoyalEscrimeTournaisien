using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Eloi_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },                   
                    { "/Poules/Poule 02-02-2025 Epée.pdf", "Poule 02-02-2025 Epée"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Eloi_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
        {
            this._tireurSelectionne = tireurSelectionne;
        }
        public List<RemarqueParDate> RemarquesParDateTireur { 
            get 
            {
                List<RemarqueParDate> remarquesParDateTireur = new List<RemarqueParDate>() { };
                remarquesParDateTireur.AddRange(new List<RemarqueParDate>()
                {
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
                                PointPositif="N'hésite pas à me dire si tu veux affronter l'un ou l'autre tireur (pas forcément les adultes), mais par exemple Martin ou Maé ou Félix ou Oscar. tu es capable de belles choses. il faut croire en toi !",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Evite de mettre ta main armée trop haute (Ramsés), tu risques très souvent d'être touché à ce niveau là. Ta main est à hauteur de ton coude et la coquille bloque les attaques aux avancées.",
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
                                    PointNégatif="n'oublie pas que quand tu es en garde, ton pied droit est perpendiculaire au pied gauche. et ton coude devant le corps. Tu peux t'exercer dans un miroir en étant en garde devant. le coude est devant le corps ni au milieu ni à l'extérieur. La main armée et le coude armé à la même hauteur par rapport au sol. et la main est sortie pour que la coquille puisse protéger ton avant-bras.",
                                    HasUrlVideo=false,
                                    UrlVideo = "",
                                    UrlYoutubeVideo = ""
                                },
                            }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024,11 ,16),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointNégatif="Quand tu attaques à l'épée, essaie d'allonger ton bras avant même de démarrer tes jambes. C'est seulement quand ton bras est allongé que tu peux démarrer les jambes. Et pas les deux en même temps sinon ton adversaire n'a qu'à allonger le bras et tu es touché."
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024,10 ,11),
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
                                PointNégatif="Ne regarde pas l'appareil lors d'un combat. Tes oreilles sont là pour écouter les ordres de l'arbitre."
                            },
                            new RemarqueData()
                            {
                                //HasPointPositif=true,
                                PointPositif="Les déplacements sont top",
                                HasUrlVideo=true,
                                UrlVideo = "/Videos/29-09-2024_ Eloi_1.avi",
                                UrlYoutubeVideo = "L2UuFq6ejpA"
                            }
                        }
                    }
                });
                return remarquesParDateTireur;
            }
        }
       
    }
}