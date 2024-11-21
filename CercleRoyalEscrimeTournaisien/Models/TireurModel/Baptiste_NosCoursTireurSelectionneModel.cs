using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Baptiste_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public Baptiste_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                        DateRemarque = new DateTime(2024, 10, 20),
                        Arme = TypeArme.Sabre,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                            {
                                new RemarqueData()
                                {
                                    PointPositif="Belle parade de quarte avec riposte. n'hésite pas à réduire les mouvements. tu vas rechercher un peu trop loin l'arme de Valentin. Mais la riposte touche donc gooood",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/20-10-2024_Baptiste.avi",
                                    Frequency = 4,
                                    UrlYoutubeVideo = "774-zK6hayc"
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
                                PointNégatif="Quel vent tu as fait à Lili. Je confirme donc qu'à la fin de l'assaut non seulement on salue son adversaire mais on lui serre la main. Les bonnes pratiques doivent revenir suite au covid...",
                                HasUrlVideo=true,
                                UrlVideo = "/Videos/19-10-2024_Baptiste.avi",
                                UrlYoutubeVideo = "M3VeV8fgarg"
                            }
                        }
                    }
                });

                return remarquesParDateTireur;
            }
        }
      
    }
}