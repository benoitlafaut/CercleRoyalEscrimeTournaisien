﻿using System;
using System.Collections.Generic;
using WebApplication1.Models;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Fabrice_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private DateTime DateDeNaissance
        {
            get
            {
                return new DateTime(2002, 5, 29);
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
                    { "/Poules/Poule 2025-01-19 Sabre.pdf", "Poule 2025-01-19 Sabre"  },
                    { "/Poules/Poule 2025-01-24 Epée Grand.pdf", "Poule 2025-01-24 Epée"  },
                    { "/Poules/Poule 2025-02-02 Epée.pdf", "Poule 2025-02-02 Epée"  },
                    { "/Poules/Poule 2025-03-16 Epée.pdf", "Poule 2025-03-16 Epée"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Fabrice_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                Remarque="Essaie les choses que tu veux mais fais en part à ceux qui sont en face par forcément pour leur montrer ce que tu fais mais pour communiquer la technique aux autres et peut-être que eux auront d'autres solutions à te donner...",
                            },
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                Remarque="Evite de sauter en l'air. au plus longtemps tu resteras dans les airs, au moins tu sauras repartir vers l'arrière ou même vers l'avant car tu n'as pas de point d'ancrage au sol.",
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
                                    Remarque="Au fleuret, quand tu fais un batté, tu accentues l'attaque. là je vois 3 battés sans attaque. Du coup tu peux aller directement chercher la touche. pas besoin de laisser venir le tireur, c'est toi qui as l'avantage. Et on voit que tu sautes aussi avec les deux pieds en l'air en faisant la riposte à la fin de la vidéo.",
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Fabrice.avi",
                                    UrlYoutubeVideo = "T7R-61MgVf8"
                                },
                                new RemarqueData()
                                {
                                   // HasPointPositif=false,
                                    Remarque="Je vois (à nouveau) que tu sautes aussi avec les deux pieds en l'air lors d'une attaque",
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Fabrice_2.avi",
                                    Frequency =3,
                                    UrlYoutubeVideo = "G-jBpBSjUkU"
                                },
                                new RemarqueData()
                                {
                                   // HasPointPositif=false,
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                    Remarque="Utilise la flexibilité de la lame pour toucher avec le pouce à 3h, c'est mieux. Utilise le coupé horizontal pour toucher au lieu de toucher linéairement.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Fabrice_3.avi",
                                    UrlYoutubeVideo = "L0FBJiipzUA"
                                },
                                new RemarqueData()
                                {
                                    //HasPointPositif=true,
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                    Remarque="Le trompé est bien exécuté. la finalité n'est à mon avis qu'un détail de la gestion du fleuret. le fleuret est plus flexible que l'épée. du coup tu peux utiliser la flexibilité de la lame pour toucher de manière horizontale.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Fabrice_3.avi",
                                    UrlYoutubeVideo = "L0FBJiipzUA"
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
                                   // HasPointPositif=false,
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                    Remarque="une belle passe avant. non sanctionnée.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/20-10-2024_Fabrice.avi",
                                    Frequency = 2,
                                    UrlYoutubeVideo = "fE6ODpliUto"
                                },
                                 new RemarqueData()
                                {
                                  //  HasPointPositif=false,
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                    Remarque="une parade suivie d'une riposte. et pas de point? bizarre...",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/20-10-2024_Fabrice_2.avi",
                                    UrlYoutubeVideo = "b1MGiBGgJjk"
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
                                         Remarque="C'est un détail que j'avais déjà vu, mais quand tu veux faire une attaque à la tête, tu montes trop haut la main, et tu utilises tout bras pour toucher la tête au lieu de travailler le poignet, le pied arrière se soulève et ton corps est déporté vers l'avant",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/10-11-2024 fabrice.avi",
                                        UrlYoutubeVideo = "6AiTmzFXIrw"
                                    }
                                }
                    }
                });

                return remarquesParDateTireur;
            }
        }
      
    }
}