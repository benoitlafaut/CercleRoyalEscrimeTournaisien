using System;
using System.Collections.Generic;
using WebApplication1.Models;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Maybelle_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private DateTime DateDeNaissance
        {
            get
            {
                return new DateTime(2008, 8, 8);
            }
        }
        public Categorie Categorie
        {
            get
            {
                return ListGuidTireur.SearchCategorie(DateDeNaissance.Year);

            }
        }
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Maybelle_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                       // HasPointPositif=true,
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                        Remarque="Je dirai que c'est un point positif car tu ne t'es jamais trompée au niveau de qui a la priorité. mais y a un mais évidemment, explique ta décision. Elle est bonne. Mais les tireurs doivent savoir pourquoi c'est l'autre qui a le point. Précise qui attaque. Rien que de dire attaque de la droite ou de la gauche, c'est suffisant à mes yeux. Et avec les gestes, cela serait top!",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/20-10-2024_Maybelle.avi",
                                        UrlYoutubeVideo = "GJDYWy6Gl3s"
                                    },
                                }
                    }
                });
                return remarquesParDateTireur;
            }
        }
      
    }
}