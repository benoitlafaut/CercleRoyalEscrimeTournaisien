﻿using System;
using System.Collections.Generic;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class ToutTireur_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public ToutTireur_NosCoursTireurSelectionneModel() : base()
        {
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
                        DateRemarque = new DateTime(2025,6,28),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Petits points d'attention...</br>Vous tirez contre qqn de plus grand? fléchissez vos jambes, descendez votre pointe pour partir avec une pointe basse, laissez le venir et touchez aux avancées (la manchette).</br>Mon adversaire est plus rapide que moi..!! Prenez le fer adverse pour qu'il ne me vise pas et attaquez le premier.</br>Je mène de deux touches et mon adversaire n'a pas l'air d'attaquer? Laissez le temps défiler, je prends de la distance. je fais de temps en temps des battés pour dire ehh je suis encore là. La piste fait 14 mètres de long, servez-vous en.<br/>N'oubliez pas le petit marché avant la fente. Le bras qui s'allonge est à faire avant la fin du marché.</br>Ne fléchissez pas le bras lors de l'attaque.</br>Ne regardez pas l'appareil lors de l'assaut. Vos oreilles sont là pour entendre les haltes de l'arbitre.</br>Quand vous attaquez, allez jusqu'à la touche sans s'arrêter. Et si par erreur vous stoppez l'attaque, reculez pour reprendre de la distance par rapport à votre adversaire.",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,6,28),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Hello hello,</br>La veille d'une compétition ou d'un assaut, je répète souvent les mêmes observations.</br>Prenez votre temps lors de chaque assaut.</br>Vous avez 3 minutes en poule et 3 x 3 minutes en assaut après les poules pour gagner.</br>Une victoire 3-1 est tout autant une victoire que 15-14.</br>Quand vous avez une stratégie qui marche, faites la régulièrement mais pas trop souvent.</br>Prenez le temps d'observer et d'avoir une stratégie pour gagner.</br>C'est en regardant les autres tirer qu'on peut savoir leurs défauts.</br>Quand vous êtes appelé(e) sur la piste ou à chaque reprise d'assaut, vous devez avoir deux fils de corps et deux armes opérationnels.</br>Si vous avez un doute sur la qualité de l'arme pendant un match (arme défectueuse ou autre), n'hésitez pas à changer d'arme rapidement.</br>Vous n'êtes pas obligé(e) d'attendre la fin du match pour changer d'arme.</br>Dans chaque compétition, il y a un espace où la liste des inscrits et la liste des résultats sont affichés.</br>Ces listes peuvent être format papier ou support écran selon la compétition.</br>N'attaquez pas comme un taureau et ne baissez pas les bras avant la fin de l'assaut.</br>Chaque assaut se finit au halte de l'arbitre.</br>Vérifiez chaque score à la fin de chaque assaut et surtout en signant la feuille de poule auprès de l'arbitre à la fin de tous les assauts d'une poule.</br></br>Amusez-vous... et ayez confiance en vous..",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,4,5),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Vous trouverez ci-joint une vidéo explicative sur les attaques simples et composées au sabre : <a class='divUnderline' target='_blank' href='https://youtu.be/QxGMfZA2-Ak?si=u0P0CNRu-jZ4PXQZ'>Cliquez ici</a>",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,4,5),
                        Arme = TypeArme.Fleuret,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Vous trouverez ci-joint une vidéo explicative sur les attaques simples au fleuret : <a class='divUnderline' target='_blank' href='https://youtu.be/CbeKK_atvQY?si=-uCgz2wm5rsjaLBs'>Cliquez ici</a>",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,4,5),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Vous trouverez ci-joint une vidéo explicative sur les positions de main au fleuret et au sabre, en passant par l'explication sur la pronation et supination : <a class='divUnderline' target='_blank' href='https://youtu.be/mFYFQ8clY80?si=RPqvkcx_5I_zaEvE'>Cliquez ici</a>",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025,3,30),
                        Arme = TypeArme.Sabre,                        
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Vous trouverez ci-joint une vidéo explicative sur l'arbitrage au sabre du Maître Poizat du club du sabre noir (club liégeois) : <a class='divUnderline' target='_blank' href='https://youtu.be/0oKOLPpB8bg?si=sx0bkd0458HfpI1i'>Cliquez ici</a>",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024,9,1),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Si vous menez, utilisez le chrono à votre avantage. Laissez le défiler en prenant vos distances.",
                            },
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Ayant remarqué cela plusieurs fois et récemment (en décembre), je rappelle à tout le monde que vous êtes protégés de la tête au pied. Du coup, évitez de mettre votre main non armée devant votre corps. Je parle surtout pour celles qui ont peur de recevoir un coup d'épée (Héloïse, Anaëlle, Mathilde, Maé, ...).",
                                Frequency = 7
                            },
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="A l'épée, oubliez les combats de capes et d'épées à la Zorro ou les mousquetaires. L'arme est toujours dirigée vers la manchette ou la saignée avec la coquille qui protège votre avant-bras. Et l'arme n'est pas pointée ni vers les étoiles ni vers les mouettes ni même vers les fourmis par terre. Passez en dessous de la coquille quand il y a tentative de prendre votre fer par votre adversaire. Je passe en dessous de la coquille et j'allonge un peu le bras vers la manchette/saignée."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="A l'épée, lorsque vous attaquez, allongez le bras et laissez le allonger. Mais en défense, quand vous subissez une attaque, fléchissez votre bras; une fois le fer adverse écarté d'une surface valable, attaquez en allongeant le bras progressivement vers une surface valable."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="Lorsque vous attaquez à l'épée, c'est votre bras armé votre point fort. Si vous le fléchissez lors de l'attaque, vous perdez un avantage. laissez-le allonger jusqu'à la touche."
                            },
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="A chaque touche et point accordé, exclamez-vous par un yes ou 'come on à la Kim clijsters tenniswoman belge' pour vous donner du peps, ou déstabiliser votre adversaire. Cà vous aidera à prendre confiance en vous et à vous motiver pour remonter le score une touche à la fois si vous êtes en train de perdre."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="Au début d'un assaut et à la fin d'un assaut, on salue son adversaire ainsi que l'arbitre en position préparatoire avec son arme. On lui serre la main à la fin de l'assaut. Quand il s'agit de rencontre entre 2 équipes, on se salue au début mais aussi à la fin et tous les tireurs de chaque équipe se mettent sur leur ligne de mise en garde et se saluent en même temps de la position préparatoire. Après les tireurs serrent la main de tous leurs adversaires de l'autre équipe."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="Quand on tire, on ne regarde pas l'appareil. L'arbitre est là pour arrêter le match si il y a eu touche."
                            },
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Quand l'arbitre suit l'assaut, il doit se trouver entre les deux tireurs. Et ne pas rester devant l'appareil. Il suit le match de telle sorte qu'il voit les deux tireurs ainsi que l'appareil en même temps."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="En fente, les deux pieds sont sur le sol. et même quand on essaie de toucher en fente, les deux pieds restent sur le sol."
                            },
                            new RemarqueData()
                            {
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                                Remarque="Quand nous avons un doute sur notre arme ou fil de corps ou tout autre matériel, du genre mais j'ai touché mais l'appareil n'a pas sonné. Il faut lever la main non armée, attendre que l'arbitre arrête l'assaut, présenter la pointe de l'arme à l'arbitre. S'il y a problème de matériel, fil de corps défectueux ou arme qui ne fonctionne plus, le tireur doit changer d'arme ou de fil de corps, la touche qui était douteuse (si il y en a une) est annulée et l'assaut reprend là où il y a eu arrêt du combat. Le contrôle de la coquille doit se refaire sur l'arme qui a été changée à l'épée. Même chose pour les plastrons fleuret ou sabre, si un fil de corps a été changé, le test des plastrons est à refaire."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque="Parfois en regardant une vidéo, il se peut que l'image ne soit pas droite. Du coup, vous devez tourner la tête pour regarder la vidéo. Pour ma part, j'utilise le programme vlc. C'est, pour ceux qui ne le connaissent pas, un lecteur de vidéo; et dans vlc nous pouvons remettre l'image droite. En allant dans Outils puis Effets et filtres, puis dans le popup dans Effets Vidéos/Géométrie et puis sélectionner Transformation. Désolé d'avance pour ce chipotage-là."
                            },
                            new RemarqueData()
                            {
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                               Remarque ="Beaucoup de tireurs font des marchés ou rompés ou tout autre déplacement excepté la fente en rapprochant leurs pieds l'un de l'autre. Exercez-vous chez vous à garder la même distance entre les pieds après chaque déplacement. Sur la vidéo ci-jointe, on voit l'erreur chez les deux tireurs.",
                                HasUrlVideo=true,
                                UrlVideo = "/Videos/Probleme de distance entre les pieds.avi",
                                UrlYoutubeVideo = "AJLi3Z6aaro"
                            },
                        }
                    }
                });
                return remarquesParDateTireur;
            }
        }

    }
}