﻿using System;
using System.Collections.Generic;
using WebApplication1.Models;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Lili_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private DateTime DateDeNaissance
        {
            get
            {
                return new DateTime(2014, 04, 18);
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
                     { "/Poules/Poule 2025-03-28 Sabre.pdf", "Poule 2025-03-28 Sabre"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Lili_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                        DateRemarque = new DateTime(2024, 11, 18),
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
                                   Remarque="Juste un point d'attention, ton pied avant et ton genou avant vont dans la même direction que la cible que tu veux toucher. Là elles sont souvent vers la gauche. Essaie de corriger cà un peu à la fois chez toi. 5' par jour avec tes pieds à 90° et les genoux qui suivent la même direction que les pieds.",
                                    HasUrlVideo=false,
                                    UrlVideo = "",
                                },
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
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif ,
                                    Remarque="Quand tu fais une fente, laisse ton pied arrière à plat au sol. ",
                                    HasUrlVideo=false,
                                    UrlVideo = "",
                                    Frequency = 5,
                                },
                            }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 11, 14),
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
                                    Remarque="A l'épée, travaille en finesse avec le bras qui est allongé vers la cible et c'est le poignet qui travaille et qui permet de contourner la coquille. et pas l'avant-bras qui te fait un cercle de 50 cm au lieu d'un cercle effectué par le poignet de 20 cm. au plus c'est petit au plus la précision est là.",
                                    HasUrlVideo=false,
                                    UrlVideo = "",
                                    Frequency = 1,
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
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                   Remarque="J'adore ton explosivité. Continue à attaquer. Fais juste attention à ne pas faire des essuye-glaces avec ton arme. Dirige-la vers une surface valable. ",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Lili.avi",
                                    Frequency = 8,
                                    UrlYoutubeVideo = "Bb0Gh9sV77c"
                                },
                                 new RemarqueData()
                                {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                    Remarque="Une petite passe avant non sanctionnée de Maé? ni vu ni connu allez hop.. et juste après deux passe avant de Sacha qui ne sont pas sur cette vidéo.. non sanctionnées",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Lili_2.avi",
                                    UrlYoutubeVideo = "Za-UEEDVyOE"
                                },
                            }
                    },
                     new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 10, 9),
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
                                    Remarque="hello Lili, parfois le simple fait d'attendre le bon moment, de le laisser venir en étant à bonne distance et puis d'attaquer son adversaire alors qu'il a le bras fléchi te donne le point. Attendre le bon moment. puis Les bras d'abord les jambes ensuite et viser la cible que tu as décidée. et bam c'est touche. et exprimer avec un cri le fait d'avoir touché. magnifico!",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/9-10-2024_lili.avi",
                                    Frequency = 3,
                                    UrlYoutubeVideo = "Zg5fQ3DrPpY"
                                },
                            }
                    }
                });

                return remarquesParDateTireur;
            }
        }
      
    }
}