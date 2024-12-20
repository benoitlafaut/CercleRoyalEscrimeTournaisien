﻿using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Felix_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public Felix_NosCoursTireurSelectionneModel(Tireur tireurSelectionne) : base()
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
                        DateRemarque = new DateTime(2024, 11, 16),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointNégatif="Quand tu fais une parade circulaire ou contre le sixte, ta lame vise les mouettes. Essaie de jouer plus fin, plus petit; au plus tes gestes sont petits, au mieux c'est pour la précision. Et toujours quand il s'agit d'un grand de te cantonner à la manchette voire la saignée pas plus loin."
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 10, 11),
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
                                PointNégatif="La pointe est trop haute. elle doit toujours être en direction de la manchette"
                            },
                            new RemarqueData()
                            {
                                //HasPointPositif=false,
                                PointNégatif="Tourner le dos à son adversaire est sanctionnable."
                            },
                            new RemarqueData()
                            {
                               // HasPointPositif=false,
                                PointNégatif="Si tu tires contre plus grand que toi, à l'allonge du bras, lève la coquille pour te diriger vers la manchette dessous et ne vise pas le ventre. S'il est plus rapide que toi, il va essayer de te toucher à la manchette dessous. Prends le fer en pronation et touche à la cuisse."
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
                                PointPositif="Aaah Félix Félix Félix, quand tu tires contre qqn de plus grand expérimenté que toi, il ne faut pas foncer tête baissée comme un taureau. Quand tu tires contre quelqu'un de plus grand que toi, lors de l'allongement du bras, lève ta main pour qu'il soit gêné par ta coquille. C'est aussi l'occasion de se redresser aussi et être moins assis sur tes jambes. pour que ton adversaire est plus difficile à te toucher. si ton avant-bras est trop bas, un simple allongement du bras de ton adversaire suffit à te faire toucher.",
                                HasUrlVideo =true,
                                UrlVideo = "/Videos/12-10-2024_Félix.avi",
                                UrlYoutubeVideo = "JcSTeChd9XU"
                            },

                        }
                    }

                });
                return remarquesParDateTireur;
            }
        }
      
    }
}