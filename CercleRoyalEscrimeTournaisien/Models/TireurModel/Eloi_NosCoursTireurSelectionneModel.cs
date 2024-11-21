using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Eloi_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public Eloi_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
        {
            this._tireurSelectionne = tireurSelectionne;
        }
        public List<RemarqueParDate> RemarquesParDateTireur { 
            get 
            {
                List<RemarqueParDate> remarquesParDateTireur = new List<RemarqueParDate>() { };
                remarquesParDateTireur.AddRange(new List<RemarqueParDate>()
                {
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024,10 ,11),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                //HasPointPositif=false,
                                PointNégatif="Ne regarde pas l'appareil lors d'un combat. Tes oreilles sont là pour écouter les ordres de l'arbitre."
                            },
                            new RemarqueData()
                            {
                                //HasPointPositif=true,
                                PointPositif="Les déplacements sont top",
                                HasUrlVideo=true,
                                UrlVideo = "/Videos/29-09-2024_ Eloi_1.avi",
                                UrlYoutubeVideo = "L2UuFq6ejpA"
                            }
                        }
                    }
                });
                return remarquesParDateTireur;
            }
        }
       
    }
}