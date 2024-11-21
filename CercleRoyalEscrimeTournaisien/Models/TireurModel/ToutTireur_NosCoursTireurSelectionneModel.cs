using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class ToutTireur_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public ToutTireur_NosCoursTireurSelectionneModel()  : base()
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
                                PointNégatif="Au début d'un assaut et à la fin d'un assaut, on salue son adversaire ainsi que l'arbitre en position préparatoire avec son arme. On lui serre la main à la fin de l'assaut. Quand il s'agit de rencontre entre 2 équipes, on se salue au début mais aussi à la fin et tous les tireurs de chaque équipe se mettent sur leur ligne de mise en garde et se saluent en même temps de la position préparatoire. Après les tireurs serrent la main de tous leurs adversaires de l'autre équipe."
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Quand on tire, on ne regarde pas l'appareil. L'arbitre est là pour arrêter le match si il y a eu touche."
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Quand l'arbitre suit l'assaut, il doit se trouver entre les deux tireurs. Et ne pas rester devant l'appareil. Il suit le match de telle sorte qu'il voit les deux tireurs ainsi que l'appareil en même temps."
                            },
                            new RemarqueData()
                            {
                                PointNégatif="En fente, les deux pieds sont sur le sol. et même quand on essaie de toucher en fente, les deux pieds restent sur le sol."
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Quand nous avons un doute sur notre arme ou fil de corps ou tout autre matériel, du genre mais j'ai touché mais l'appareil n'a pas sonné. Il faut lever la main non armée, attendre que l'arbitre arrête l'assaut, présenter la pointe de l'arme à l'arbitre. S'il y a problème de matériel, fil de corps défectueux ou arme qui ne fonctionne plus, le tireur doit changer d'arme ou de fil de corps, la touche qui était douteuse (si il y en a une) est annulée et l'assaut reprend là où il y a eu arrêt du combat. Le contrôle de la coquille doit se refaire sur l'arme qui a été changée à l'épée. Même chose pour les plastrons fleuret ou sabre, si un fil de corps a été changé, le test des plastrons est à refaire."
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Parfois en regardant une vidéo, il se peut que l'image ne soit pas droite. Du coup, vous devez tourner la tête pour regarder la vidéo. Pour ma part, j'utilise le programme vlc. C'est, pour ceux qui ne le connaissent pas, un lecteur de vidéo; et dans vlc nous pouvons remettre l'image droite. En allant dans Outils puis Effets et filtres, puis dans le popup dans Effets Vidéos/Géométrie et puis sélectionner Transformation. Désolé d'avance pour ce chipotage-là."
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Beaucoup de tireurs font des marchés ou rompés ou tout autre déplacement excepté la fente en rapprochant leurs pieds l'un de l'autre. Exercez-vous chez vous à garder la même distance entre les pieds après chaque déplacement. Sur la vidéo ci-jointe, on voit l'erreur chez les deux tireurs.",
                                HasUrlVideo=true,
                                UrlVideo = "/Videos/Probleme de distance entre les pieds.avi",
                                UrlYoutubeVideo = "774-zK6hayc"
                            },
                        }
                    }
                });
                return remarquesParDateTireur;
            }
        }
       
    }
}