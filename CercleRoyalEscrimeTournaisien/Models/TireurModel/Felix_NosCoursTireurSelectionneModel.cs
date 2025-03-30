using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Felix_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },
                    { "/Poules/Poule 2025-01-19 Sabre.pdf", "Poule 2025-01-19 Sabre"  },
                    { "/Poules/Poule 2025-01-24 Epée Grand.pdf", "Poule 2025-01-24 Epée"  },
                     { "/Poules/Poule 2025-03-12 Epée.pdf", "Poule 2025-03-12 Epée"  },
                      { "/Poules/poule 2025-03-28 Sabre Seniors.pdf", "poule 2025-03-28 Sabre Seniors"  },
                };
            }
        }
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
                        DateRemarque = new DateTime(2025, 1, 17),
                        Arme = TypeArme.Sabre,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositif="Tu bouges beaucoup vers l'avant, tu vas chercher les touches, prends ton temps davantage pour utiliser les 3 minutes. tu ne dois pas vite vite terminer ton match. et note dans ton carnet tout ce qui marche. je suis sur que si tu le notais tu pourrais te rappeler de plus de choses qui marchent selon que tu tires contre l'un ou l'autre.",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Si une fente ne marche pas, fais un marché fente. Généralement tu arrives trop court car tu ne fais qu'une seule fente. rajoute un marché ou un déplacement plus important pour te rapprocher de ton adversaire.",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Prends ton temps après chaque touche surtout si tu te fais toucher pour analyser pourquoi tu as été touché, tu as tendance à aller trop vite et l'autre en profite et fait généralement la même chose",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="lors de la retraite, le bras se fléchit bien pour faire un contre le sixte facilement. tu laisses trop souvent ton bras allongé ou à moitié allongé.",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Ta main armée est souvent trop haute par rapport à ton coude.",
                                Frequency = 5
                            },
                            new RemarqueData()
                            {
                                PointNégatif="On ne dit pas problème de branchement quand on arbitre... on le résoud en m'appelant ou Rémi ou Fabrice.. mais là quand cà sonne régulièrement, c'est le fil de corps à changer.",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Quand un tireur touche la coquille adverse, l'autre a fait une parade.",
                            },
                        }
                    },
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