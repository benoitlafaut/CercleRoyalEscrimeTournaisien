﻿using System;
using System.Collections.Generic;
using WebApplication1.Models;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Aurore_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private DateTime DateDeNaissance
        {
            get
            {
                return new DateTime(2009, 6, 10);
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
        public Aurore_NosCoursTireurSelectionneModel(Tireur tireurSelectionne) : base()
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
                                Remarque="Tu es très bien en garde, n'hésite pas à provoquer ton adversaire et à le laisser venir vers toi pour faire des contre le sixte ou des arrêts à la manchette. La précision de la pointe cà se travaille mais tu es dans la bonne voie.",
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Positif
                            },
                            new RemarqueData()
                            {
                                Remarque="Belles touches à la manchette/saignée, quand tu vois une ouverture, laisse traîner ta pointe vers la manchette ou la saignée. C'est l'autre qui se fera touché, il faut croire en toi !",
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Positif
                           },
                            new RemarqueData()
                            {
                                Remarque="Lorsque tu es en garde à l'épée, ton bras armé est trop allongé. Le coude doit être à une main une main et demi grand max du corps. Pas plus.",
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif
                            },
                            new RemarqueData()
                            {
                                Remarque="lorsque tu allonges le bras, la main est au même niveau que l'épaule. Soit le bras est bien fléchi soit il est allongé avec protection de la coquille.",
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif
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
                                 //   HasPointPositif=true,
                                    Remarque="Sur cette vidéo, on voit une belle phrase d'arme. Arthur commence son attaque par un batté. il a la priorité vu qu'il attaque et il accentue sa priorité par deux choses. Il allonge son bras et il fait un batté. De ton côté, tu pares son attaque en quarte. c'est une parade de quarte typique d'un fleurettiste. La main bouche et elle bloque l'attaque de Arthur. ",
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Aurore.avi",     
                                    UrlYoutubeVideo = "ccr0fxOYm1Y"
                                },
                                 new RemarqueData()
                                {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                    Remarque="Ne va pas aussi loin dans la parade; il est suffisant de se limiter à une surface valable; là ta lame vise la vitre. Une petite chose que je vois c'est que Arthur n'est pas allé en ligne basse en octave pour faire la parade et il laisse son bras allongé en défense. à toi d'en profiter. Je vois aussi lors des fentes que ton bras arrière n'est pas le long de la jambe. Le bras arrière te donne l'impulsion pour aller vers l'avant et il te donne l'équilibre du corps en fente et l'effacement de la partie gauche de ton tronc. N'hésite pas si tu es trop courte à rajouter un marché à la fente.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Aurore_2.avi",
                                    Frequency = 3,
                                    UrlYoutubeVideo = "ouprkfX37c0"
                                },
                                  new RemarqueData()
                                {
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                   Remarque="Le batté quart et riposte en ligne basse par dégagement est de toute beauté.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Aurore_3.avi",
                                    UrlYoutubeVideo = "25jLXxNtnmY"
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
                                   Remarque="Dans cette vidéo, les bêtes touches que Fabrice a mises c'est parce qu'il y a une mauvaise garde. Ta main n'est pas assez à l'extérieur que pour protéger tout ton côté droit. Mais si Fabrice insiste sur le côté droit, ou toute autre touche au même endroit c'est qu'il y a un souci. A toi de rectifier immédiatement. Ici tu dois juste te dire qu'est ce qui ne va pas chez moi dans ma garde. et rectifier. c'est dur. Mais base toi sur ce que ton adversaire essaie de toucher. parfois c'est la distance qui est trop petite parfois la garde. Ici tu reçois deux trois touches de Fabrice bon c'est pas qu'il est rapide ici mais c'est qu'il voit une lacune dans ta garde. Réfléchis en même temps que lui. Je sais que c'est dur par moments, tu arrives chez les grands c'est quelque chose de nouveau. Il faut que tu t'adaptes. mais parfois les simples gestes répétitifs font qu'on gagne. A toi de réfléchir vite dans le feu de l'action. Prends les initiatives, attaque, parfois ce sont les simultanés qui font que l'autre va changer de stratégie. En escrime, si un tireur voit une stratégie qui marche, il ne va pas se casser la tête, il va toujours faire pareil. Au sabre plus qu'à une autre arme, c'est la vitesse des jambes et l'initiative qui priment. Si tu attends que l'autre fasse quelque chose, t'es morte. Vas-y ! ose attaquer ! n'aie pas peur de recevoir une touche quand tu attaques. la première priorité au sabre et au fleuret, c'est l'attaque.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Aurore.avi",
                                    UrlYoutubeVideo = "qHwr8_reuCs"
                                },
                                   new RemarqueData()
                                {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                    Remarque="Lors de l'attaque, ne fléchis pas le bras. La priorité passe à l'adversaire si tu fléchis ton bras, si tu veux passer du côté gauche au côté droit ou l'inverse, c'est le poignet qui doit travailler. Avec toujours cette notion de 'je touche avec le tranchant de la lame' c'est-à-dire que si tu veux toucher le ventre d'un droitier ton pouce est à 3h si c'est l'autre côté, ton pouce est à 9h et si c'est la tête que tu dois toucher, ton pouce est à midi. Va jusqu'au bout de l'action/touche. L'appareil se bloque pour le fleuret et le sabre après une demi seconde. tu vas me dire c'est trop court pour une action!! oui et non. si tu ne le fais pas et que tu as priorité, l'arbitre ne verra qu'une touche et pas de point pour toi.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Aurore_2.avi",
                                    UrlYoutubeVideo = "QGgHTcyHhMQ"
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
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                    Remarque="lors de l'attaque, laisse ton bras allonger jusqu'à la touche, c'est le poignet et seulement le poignet qui travaille. ",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/9-10-2024_aurore.avi",
                                    UrlYoutubeVideo = "IE7ELmVVjoc"
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
                                        Remarque="utilise ton poignet pour viser soit le ventre - côté droit (pouce à 3h) soit le flanc - côté gauche (pouce à 9h); là je vois toujours ta pouce à midi sans vraiment créer une réaction à ton adversaire; il a juste à allonger le bras et faire manchette dessus pour te toucher. ",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/10-11-2024 Aurore.avi",
                                        UrlYoutubeVideo = "jkbM0_Z3kHA",
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