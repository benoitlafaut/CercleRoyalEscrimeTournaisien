using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class ArthurBarbery_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public ArthurBarbery_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                    PointNégatif="Ne tourne pas le dos à ton adversaire. Celà peut te faire très mal.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_ArthurBarbery.avi"
                                },
                                new RemarqueData()
                                {
                                   // HasPointPositif=true,
                                    PointPositif="Quand tu vois un adversaire qui fait de trop grandes parades, profites-en. Provoque-le en faisant des feintes de coup droit pour qu'il aille chercher la parade et là tu peux passer de l'autre côté et toucher par dégagements. Quitte à faire des dégagements successifs tout en allongeant le bras progressivement.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_ArthurBarbery_2.avi"
                                },
                                new RemarqueData()
                                {
                                    //HasPointPositif=true,
                                    PointPositif="La garde est très bonne au fleuret.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_ArthurBarbery_3.avi"
                                },
                                new RemarqueData()
                                {
                                    //HasPointPositif=false,
                                    PointNégatif="N'oublie pas que les parades se font avec le bras fléchi. La parade et la riposte ne se font pas en un coup, il faut d'abord parer avec le bras fléchi et puis allonger le bras pour faire la riposte.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_ArthurBarbery_3.avi"
                                },
                                 new RemarqueData()
                                {
                                    //HasPointPositif=true,
                                    PointPositif="La parade de sixte suivie d'une riposte par dégagement est piccobello. de toute beauté!",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_ArthurBarbery_4.avi"
                                },
                            }
                    }
                });
                
                return remarquesParDateTireur;
            }
        }
      
    }
}