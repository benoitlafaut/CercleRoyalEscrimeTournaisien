using System;
using System.Collections.Generic;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Eva_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
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
        public Eva_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()        
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
                        DateRemarque = new DateTime(2024,10 ,11),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex ,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                               // HasPointPositif=false,
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                              Remarque="Ne regarde pas l'appareil lors d'un combat. Tes oreilles sont là pour écouter les ordres de l'arbitre."
                            },
                             new RemarqueData()
                            {
                              //   HasPointPositif=false,
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                Remarque="Les appareils et les caméras coûtent chers. Ne vise pas les appareils avec l'arme."
                            },
                            new RemarqueData()
                            {
                             //    HasPointPositif=false,
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                Remarque="Ne lève pas ta jambe arrière quand tu essayes de toucher. les deux pieds doivent être ancrés au sol pour revenir très vite en garde."
                            },
                            new RemarqueData()
                            {
                             //    HasPointPositif=false,
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                               Remarque="Lors de la fente, la main droite se termine à la hauteur de l'épaule."
                            },
                            new RemarqueData()
                            {
                             //   HasPointPositif=false,
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                               Remarque="Prends le temps de tirer. utilise tes 3 minutes... De un, parce que tu peux les utiliser. De deux pour ne pas dégoûter les autres de tirer avec toi. De trois pour endormir ton adversaire."
                            },
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
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                               Remarque="Allonge bien ton bras quand tu attaques jusqu'à ce que ta main soit à hauteur de ton épaule et puis utilise tes jambes pour aller jusqu'à la touche. Et n'oublie pas que les appareils coûtent chers.",
                                HasUrlVideo =true,
                                UrlVideo = "/Videos/12-10-2024_Eva.avi",
                                UrlYoutubeVideo = "MpsYOSTguvw"
                            },
                        }
                    }
                });
                return remarquesParDateTireur;
            }
        }
       
    }
}