using System;
using System.Collections.Generic;
using WebApplication1.Models;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Eloi_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private DateTime DateDeNaissance
        {
            get
            {
                return new DateTime(2014, 11, 10);
            }
        }
        public Categorie Categorie
        {
            get
            {
                return ListGuidTireur.SearchCategorie(DateDeNaissance.Year);

            }
        }
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },                   
                    { "/Poules/Poule 2025-02-02 Epée.pdf", "Poule 2025-02-02 Epée"  },
                    { "/Poules/Poule 2025-03-16 Epée.pdf", "Poule 2025-03-16 Epée"  },
                     { "/Poules/Poule 2025-03-28 Sabre.pdf", "Poule 2025-03-28 Sabre"  },
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
                                Remarque="N'hésite pas à me dire si tu veux affronter l'un ou l'autre tireur (pas forcément les adultes), mais par exemple Martin ou Maé ou Félix ou Oscar. tu es capable de belles choses. il faut croire en toi !",
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                            },
                            new RemarqueData()
                            {
                                Remarque="Evite de mettre ta main armée trop haute (Ramsés), tu risques très souvent d'être touché à ce niveau là. Ta main est à hauteur de ton coude et la coquille bloque les attaques aux avancées.",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
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
                                    Remarque="n'oublie pas que quand tu es en garde, ton pied droit est perpendiculaire au pied gauche. et ton coude devant le corps. Tu peux t'exercer dans un miroir en étant en garde devant. le coude est devant le corps ni au milieu ni à l'extérieur. La main armée et le coude armé à la même hauteur par rapport au sol. et la main est sortie pour que la coquille puisse protéger ton avant-bras.",
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
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                Remarque="Quand tu attaques à l'épée, essaie d'allonger ton bras avant même de démarrer tes jambes. C'est seulement quand ton bras est allongé que tu peux démarrer les jambes. Et pas les deux en même temps sinon ton adversaire n'a qu'à allonger le bras et tu es touché."
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
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                               Remarque="Ne regarde pas l'appareil lors d'un combat. Tes oreilles sont là pour écouter les ordres de l'arbitre."
                            },
                            new RemarqueData()
                            {
                                //HasPointPositif=true,
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                               Remarque="Les déplacements sont top",
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