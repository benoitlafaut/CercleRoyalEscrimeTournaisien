using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Mae_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public Mae_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
        {
            this._tireurSelectionne = tireurSelectionne;
        }
        public List<RemarqueParDate> RemarquesParDateTireur
        {
            get
            {
                List<RemarqueParDate> remarquesParDateTireur = new List<RemarqueParDate>() { };
                remarquesParDateTireur.AddRange(
                new List<RemarqueParDate>()
                {
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
                                    PointPositif="Ce sont de belles touches que tu mets à Anaëlle sur cette vidéo. n'hésite pas à varier la cible que tu veux toucher : la tête par exemple. pas toujours la manchette même si cela paie. Si l'autre cible ne marche pas, reviens à la cible de départ. Ce qui marche bien aussi ce sont les marchés rompés que tu fais pour te rapprocher d'Anaëlle. Cela paie de casser la distance pour te rapprocher de ton adversaire et finir par une belle touche en fente.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Mae.avi",
                                    Frequency = 4
                                }
                            }
                    },
                     new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024,10 ,12),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex ,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointNégatif="Je vois sur cette vidéo que ta pointe est trop haute par rapport à ton coude. A l'épée, le coude ainsi que la main et la pointe doivent être au même niveau par rapport au sol. Là tu relèves et la main et la pointe. tout est parallèle au sol à l'épée. Si ton adversaire essaie de te toucher à un certain endroit c'est qu'il voit une ouverture.",
                                HasUrlVideo =true,
                                UrlVideo = "/Videos/12-10-2024_Mae.avi"
                            },
                        }
                    }

                });

                return remarquesParDateTireur;
            }
        }
      
    }
}