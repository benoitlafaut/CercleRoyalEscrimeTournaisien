using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class ToutTireur_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public ToutTireur_NosCoursTireurSelectionneModel() : base()
        {            
        }
        public List<RemarqueParDate> RemarquesParDateTireur { 
            get 
            {
                List<RemarqueParDate> remarquesParDateTireur = new List<RemarqueParDate>() { };
                remarquesParDateTireur.AddRange(new List<RemarqueParDate>()
                {                   
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024,9,1),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositif="Si vous menez, utilisez le chrono à votre avantage. Laissez le défiler en prenant vos distances.",
                            },
                            new RemarqueData()
                            {
                                PointPositif="Ayant remarqué cela plusieurs fois et récemment (en décembre), je rappelle à tout le monde que vous êtes protégés de la tête au pied. Du coup, évitez de mettre votre main non armée devant votre corps. Je parle surtout pour celles qui ont peur de recevoir un coup d'épée (Héloïse, Anaëlle, Mathilde, Maé, ...).",
                                Frequency = 7
                            },
                            new RemarqueData()
                            {
                                PointPositif="A l'épée, oubliez les combats de capes et d'épées à la Zorro ou les mousquetaires. L'arme est toujours dirigée vers la manchette ou la saignée avec la coquille qui protège votre avant-bras. Et l'arme n'est pas pointée ni vers les étoiles ni vers les mouettes ni même vers les fourmis par terre. Passez en dessous de la coquille quand il y a tentative de prendre votre fer par votre adversaire. Je passe en dessous de la coquille et j'allonge un peu le bras vers la manchette/saignée."
                            },
                            new RemarqueData()
                            {
                                PointPositif="A l'épée, lorsque vous attaquez, allongez le bras et laissez le allonger. Mais en défense, quand vous subissez une attaque, fléchissez votre bras; une fois le fer adverse écarté d'une surface valable, attaquez en allongeant le bras progressivement vers une surface valable."
                            },
                            new RemarqueData()
                            {
                                PointPositif="Lorsque vous attaquez à l'épée, c'est votre bras armé votre point fort. Si vous le fléchissez lors de l'attaque, vous perdez un avantage. laissez-le allonger jusqu'à la touche."
                            },
                            new RemarqueData()
                            {
                                PointPositif="A chaque touche et point accordé, exclamez-vous par un yes ou 'come on à la Kim clijsters tenniswoman belge' pour vous donner du peps, ou déstabiliser votre adversaire. Cà vous aidera à prendre confiance en vous et à vous motiver pour remonter le score une touche à la fois si vous êtes en train de perdre."
                            },
                            new RemarqueData()
                            {
                                PointPositif="Au début d'un assaut et à la fin d'un assaut, on salue son adversaire ainsi que l'arbitre en position préparatoire avec son arme. On lui serre la main à la fin de l'assaut. Quand il s'agit de rencontre entre 2 équipes, on se salue au début mais aussi à la fin et tous les tireurs de chaque équipe se mettent sur leur ligne de mise en garde et se saluent en même temps de la position préparatoire. Après les tireurs serrent la main de tous leurs adversaires de l'autre équipe."
                            },
                            new RemarqueData()
                            {
                                PointPositif="Quand on tire, on ne regarde pas l'appareil. L'arbitre est là pour arrêter le match si il y a eu touche."
                            },
                            new RemarqueData()
                            {
                                PointPositif="Quand l'arbitre suit l'assaut, il doit se trouver entre les deux tireurs. Et ne pas rester devant l'appareil. Il suit le match de telle sorte qu'il voit les deux tireurs ainsi que l'appareil en même temps."
                            },
                            new RemarqueData()
                            {
                                PointPositif="En fente, les deux pieds sont sur le sol. et même quand on essaie de toucher en fente, les deux pieds restent sur le sol."
                            },
                            new RemarqueData()
                            {
                                PointPositif="Quand nous avons un doute sur notre arme ou fil de corps ou tout autre matériel, du genre mais j'ai touché mais l'appareil n'a pas sonné. Il faut lever la main non armée, attendre que l'arbitre arrête l'assaut, présenter la pointe de l'arme à l'arbitre. S'il y a problème de matériel, fil de corps défectueux ou arme qui ne fonctionne plus, le tireur doit changer d'arme ou de fil de corps, la touche qui était douteuse (si il y en a une) est annulée et l'assaut reprend là où il y a eu arrêt du combat. Le contrôle de la coquille doit se refaire sur l'arme qui a été changée à l'épée. Même chose pour les plastrons fleuret ou sabre, si un fil de corps a été changé, le test des plastrons est à refaire."
                            },
                            new RemarqueData()
                            {
                                PointPositif="Parfois en regardant une vidéo, il se peut que l'image ne soit pas droite. Du coup, vous devez tourner la tête pour regarder la vidéo. Pour ma part, j'utilise le programme vlc. C'est, pour ceux qui ne le connaissent pas, un lecteur de vidéo; et dans vlc nous pouvons remettre l'image droite. En allant dans Outils puis Effets et filtres, puis dans le popup dans Effets Vidéos/Géométrie et puis sélectionner Transformation. Désolé d'avance pour ce chipotage-là."
                            },
                            new RemarqueData()
                            {
                                PointPositif="Beaucoup de tireurs font des marchés ou rompés ou tout autre déplacement excepté la fente en rapprochant leurs pieds l'un de l'autre. Exercez-vous chez vous à garder la même distance entre les pieds après chaque déplacement. Sur la vidéo ci-jointe, on voit l'erreur chez les deux tireurs.",
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