using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Rebecca_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public Rebecca_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                       // HasPointPositif=false,
                                        PointNégatif="Au fleuret, quand tu fais un batté, tu accentues ta priorité. Du coup, après un batté, n'hésite pas à aller jusqu'à la touche sans qu'il y ait parade de la part de ton adversaire. ",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/22-09-2024_Rebecca_1.avi",
                                        UrlYoutubeVideo = "_aIIVF5N_B8"
                                    },
                                    new RemarqueData()
                                    {
                                       // HasPointPositif=false,
                                        PointNégatif="Quand tu fais une parade, en défense, tu as le droit de faire une riposte. La parade te donne la priorité sur l'attaque.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/22-09-2024_Rebecca_2.avi",
                                        UrlYoutubeVideo = "nn3dSGHhs4M",
                                        Frequency =4
                                    },


                                }
                    },
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
                                      //  HasPointPositif=false,
                                        PointNégatif="Je remarque que Maybelle t'a touchée 3 fois au même endroit. Tu n'es pas bien en garde. Quand qqn te touche au même endroit plusieurs fois, c'est qu'il y a un problème de ton côté. ici ta main armée est trop haute par rapport à ton coude. et tu mets ton arme quasi au milieu de ton corps alors qu'elle doit protéger la partie droite de ton corps. c'est pour cà que Maybelle touche systématiquement à la manchette. ah oui j'oubliais de le dire.. la passe avant est interdite au sabre. je l'ai vue deux fois non sanctionnée par l'arbitre.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/20-10-2024_Rebecca.avi",
                                        UrlYoutubeVideo = "yPHCUZDO19o"
                                    },
                                    new RemarqueData()
                                    {
                                    //    HasPointPositif=false,
                                        PointNégatif="Une simple fente ne devrait pas te toucher. si elle te touche, c'est que tu es trop près de ton adversaire.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/20-10-2024_Rebecca_2.avi",
                                        UrlYoutubeVideo = "TtS7nSSNqbk"
                                    },
                                     new RemarqueData()
                                    {
                                    //    HasPointPositif=false,
                                        PointNégatif="Ayant peur de recevoir un coup, tu mets ta main armée près de ta surface valable. Non seulement c'est sanctionnable si tu caches une surface valable mais tu pourrais avoir mal en recevant un coup. Tu le fais qqs fois ici.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/20-10-2024_Rebecca_3.avi",
                                        UrlYoutubeVideo = "-10mWOkRSaU",
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