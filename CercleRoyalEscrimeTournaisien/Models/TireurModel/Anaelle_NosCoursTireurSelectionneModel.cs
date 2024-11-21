using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Anaelle_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public Anaelle_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                    PointNégatif="Sur la vidéo, on voit que tu es souvent trop près de Maé qui ne fait qu'une fente pour te toucher. Ne sois pas trop près d'elle. A la fin de la vidéo, on voit que tu commences à attaquer, à oser, à prendre l'initiative. c'est moi qui attaque c'est moi le chef  c'est moi qui dirige l'assaut. N'hésite pas à t'affirmer, à oser. tu es protégée de la tête aux pieds, tu peux y aller sans crainte. Au sabre comme au fleuret, celle qui attaque a un avantage sur l'autre. Vas y Anaëlle, montre à ton adversaire qui mène la danse!",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/19-10-2024_Anaelle.avi",
                                    UrlYoutubeVideo = "CD9H6M2O72o"
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
                                PointPositif="Tu attaques c'est bien! continue d'attaquer. N'oublie pas d'allonger le bras avant de démarrer tes jambes. La touche que tu as reçue, c'est juste que tu as fléchi le bras lors de l'attaque. ne le fléchis pas.",
                                HasUrlVideo =true,
                                UrlVideo = "/Videos/12-10-2024_Anaelle.avi",
                                UrlYoutubeVideo = "tszdCVKPXwI"
                            },
                            
                        }
                    }

                });

                return remarquesParDateTireur;
            }
        }
      
    }
}