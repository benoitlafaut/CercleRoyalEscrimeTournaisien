﻿using System;
using System.Collections.Generic;
using WebApplication1.Models;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Jordan_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private DateTime DateDeNaissance
        {
            get
            {
                return new DateTime(1995, 08, 20);
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
                    { "/Poules/Poule 2025-01-24 Epée Grand.pdf", "Poule 2025-01-24 Epée"  },
                    { "/Poules/poule 2025-03-28 Sabre Seniors.pdf", "poule 2025-03-28 Sabre Seniors"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Jordan_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                Remarque="Je vois de beaux assauts. Une belle pointe qui se profile à l'horizon. bien sûr cà se travaille chaque année. même moi je dois la travailler mais une fois qu'elle est là, on a du mal à la perdre. les jambes c'est top aussi. tu bouges bien et à bonne distance. N'oublie pas de penser à la seconde intention. provoque ton adversaire, laisse lui faire croire que c'est une ouverture par exemple aux avancées mais pour que tu puisses l'utiliser pour toi à bon escient.",
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
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
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif ,
                                    Remarque="Lors d'une parade, tu as la priorité et tu peux rechercher directement la touche en faisant la riposte. Pas besoin de te protéger à nouveau. Sur la même vidéo, je peux voir que tu mets ta main non armée devant une surface valable; c'est sanctionnable. En terme d'arbitrage, c'est substitution d'une surface valable. Que ta main soit dans le dos ou devant en face du ventre, pour fleuret ou sabre, c'est carton jaune ou rouge si tu recommences après avoir déjà eu un carton.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Jordan.avi",
                                    Frequency = 3,
                                    UrlYoutubeVideo = "jH4GFXOEibs"
                                },
                                 new RemarqueData()
                                {
                                   //HasPointPositif=false,
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif ,
                                   Remarque="Je remarque dans cette vidéo que ton pied arrière est souvent en hauteur alors qu'il doit être très souvent ancré au sol. Autre chose aussi que je remarque c'est que quand tu attaques, tu ne penses pas à dégager par feinte. Un tireur observe son adversaire en simulant des feintes, en simulant de fausses attaques. Je vais par là en allongeant le bras à 50% et je vois sa réaction. si il recherche en quarte, je passe de l'autre côté de la lame et j'allonge progressivement le bras par dégagements successifs jusqu'à la touche.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Jordan_2.avi",
                                    UrlYoutubeVideo = "lR-ul_IHBe4"
                                },
                                 new RemarqueData()
                                {
                                   // HasPointPositif=false,
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                   Remarque="Dans cette vidéo, on voit vraiment que tu tiens ton arme avec le pouce à 3h alors qu'à 1h cela serait mieux. Pour couper net l'attaque de ton adversaire, tu peux faire un batté. A ce moment, la priorité, si vous vous touchez sans parade, passe de ton côté. N'hésite pas à démarrer l'attaque par un batté et à chercher la touche en esquivant ses parades. Et ne mets plus ta main gauche devant ton corps. Tu risque de te faire mal et c'est sanctionnable.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Jordan_3.avi",
                                    UrlYoutubeVideo  = "nvGFS_93p8Q"
                                },
                                 new RemarqueData()
                                {
                                  //  HasPointPositif=false,
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif ,
                                    Remarque="Après avoir fait une parade, tu as droit à ta riposte (la touche). Et même si il te touche comme c'est le cas sur la vidéo, si tu touches, c'est toi qui as le point. La parade surplombe l'attaque en terme de priorité.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Jordan_4.avi",
                                    UrlYoutubeVideo = "kkUQbj7as-U"
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
                                    //HasPointPositif=false,
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif ,
                                    Remarque="Si ton adversaire voit que tu vas systématiquement à la tête, il va protéger sa tête. Essaie de faire des actions composées. je feinte à la tête mais je vais ailleurs; surtout contre des tireurs avec de l'expérience. Et sur la vidéo on voit que tu attends Rémi de manière statique. Si vous vous touchez en même temps, le point sera pour celui qui aura attaqué c'est-à-dire Rémi. Autre point que je remarque, en défense, le bras ne s'allonge pas.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/20-10-2024_jordan.avi",
                                    Frequency = 2,
                                    UrlYoutubeVideo = "EzXDErOUrjA"
                                },
                            }
                    },
                });

                return remarquesParDateTireur;
            }
        }
      
    }
}