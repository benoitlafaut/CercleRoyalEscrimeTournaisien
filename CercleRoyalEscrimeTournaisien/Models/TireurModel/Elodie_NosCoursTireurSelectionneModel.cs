using System;
using System.Collections.Generic;
using WebApplication1.Models;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Elodie_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private DateTime DateDeNaissance
        {
            get
            {
                return new DateTime(2000, 2, 24);
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
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Elodie_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                Remarque="Beau spectacle que je vois quand tu tires contre Rémi ou Fabrice, il y a du répondant. il y a de la prudence. continue comme cà! je vois aussi que tu m'aides avec les plus jeunes.. merci pour cà ! je n'ai que quelques mots à dire.. Explosivité, moins compliqués parfois plus simples, distance très bonne, précision de la pointe au top. Prends le temps de faire un assaut 3' c'est long mais il faut prendre son temps surtout à chaque touche reçue pour analyser en quatrième vitesse pourquoi tu as été touchée à cet endroit et comment y remédier.",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
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
                                    Remarque="Ah au fait, ne réagis pas forcément au batté que l'autre fait. il ne sert à rien tant qu'il n'y a pas une attaque derrière. Du coup la garde est bonne pas besoin de déplacer ta main. soit tu recules par une retraite inversée soit tu ne bouges pas.",
                                    HasUrlVideo=false,
                                    UrlVideo = "",
                                    UrlYoutubeVideo = ""
                                },
                                new RemarqueData()
                                {
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                   Remarque="La bonne distance par rapport à ton adversaire, tu l'as. La réactivité tu l'as aussi. le fait de bouger, tu bouges plus que certains qui ont le même âge +/- et qui sont déjà fatigués avant même de faire l'échauffement. Ne pas aller trop vite, réfléchir pendant le match, cà tu le fais. Prends le temps d'endormir ton adversaire. Tu laisses traîner souvent le bras trop vers l'avant, c'est bien à l'épée mais il ne faut pas aller trop loin. On dit souvent 1 main voire 2 mains entre le coude et le corps mais pas plus. Il te faut apprendre aussi la deuxième intention j'essaie de faire ceci mais en fait j'ai autre chose de prévu après la première chose effectuée. D'où le fait de faire des redoublements, des travaux de changements de rythme tantôt je vais lentement tantôt je vais plus rapidement. tantôt je me repose en le laissant venir tentant je le provoque pour le faire réagir. c'est très difficile de comprendre comment toucher c'est un peu plus facile de comprendre comment tu es touchée. tu es souvent touchée à la manchette ou entre la manchette et la saignée parce que la main est basse et le bras trop allongé. ce ne sont pas que des points négatifs. Pour résumé, la vitesse la précision (même si y a tjs mieux) c'est top.",
                                    HasUrlVideo=false,
                                    UrlVideo = "",
                                    UrlYoutubeVideo = ""
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
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                   Remarque="Quand on essaie de te toucher plusieurs fois au même endroit, c'est qu'il y a anguille sous roche. Soit tu corriges, soit tu le fais exprès d'amplifier ce défaut là et tu l'utilises à ton avantage.",
                                        HasUrlVideo=false,
                                        UrlVideo = "",
                                        UrlYoutubeVideo = ""
                                    },
                                }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 9, 20),
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
                                  PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                      Remarque="Deux petites choses dans la vidéo. la première c'est décrire ce que tu vois en tant qu'arbitre (je sais c'est dur) mais ici je vois une parade de Rémi et la riposte non valable. et pour la dernière action, c'est attaque d'Arthur car Rémi ne bouge pas. C'est Arthur qui attaque. Du coup on ne regarde pas celui qui allonge le bras en premier mais celui qui est à l'attaque. Ici Rémi est statique et Arthur va chercher la touche en marchés fente. c'est lui qui attaque.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/20-09-2024_Elodie.avi",
                                        UrlYoutubeVideo = "DuFNWIEfDPg"
                                    },
                                }
                    }
                });
                return remarquesParDateTireur;
            }
        }
      
    }
}