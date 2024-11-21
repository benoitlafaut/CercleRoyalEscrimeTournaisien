using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Sacha_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public Sacha_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                    PointPositif="C'est un beau match. Tu prends des initiatives et tu attaques en choisissant une cible. Continue ainsi. Fais juste attention de ne pas sauter en l'air comme les kangourous au lieu de faire de beaux marchés ou marchés fente.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Sacha.avi",
                                    UrlYoutubeVideo = "KipxcKDd6Mg"
                                }
                            }
                        }
                });

                return remarquesParDateTireur;
            }
        }
      
    }
}