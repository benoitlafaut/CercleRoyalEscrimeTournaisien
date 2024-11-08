using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Lili_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
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
                                    PointPositif="J'adore ton explosivité. Continue à attaquer. Fais juste attention à ne pas faire des essuye-glaces avec ton arme. Dirige-la vers une surface valable. ",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Lili.avi",
                                    Frequency = 6
                                },
                                 new RemarqueData()
                                {
                                    PointNégatif="Une petite passe avant non sanctionnée de Mae? ni vu ni connu allez hop.. et juste après deux passe avant de Sacha qui ne sont pas sur cette vidéo.. non sanctionnées",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Lili_2.avi",
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
                                    PointPositif="hello Lili, parfois le simple fait d'attendre le bon moment, de le laisser venir en étant à bonne distance et puis d'attaquer son adversaire alors qu'il a le bras fléchi te donne le point. Attendre le bon moment. puis Les bras d'abord les jambes ensuite et viser la cible que tu as décidée. et bam c'est touche. et exprimer avec un cri le fait d'avoir touché. magnifico!",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/9-10-2024_lili.avi",
                                    Frequency = 3
                                },
                            }
                    }
                });

                return remarquesParDateTireur;
            }
        }
      
    }
}