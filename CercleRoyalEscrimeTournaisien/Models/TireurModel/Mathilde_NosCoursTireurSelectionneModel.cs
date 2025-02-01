using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Mathilde_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },
                    { "/Poules/Poule 24-01-2025 Epée.pdf", "Poule 24-01-2025 Epée"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Mathilde_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                        DateRemarque = new DateTime(2025, 1, 24),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositif="Dans les assauts que je vois, il y a du progrès par rapport au début de saison. Tu oses des choses, tu as moins peur de recevoir des coups. t'as pas peur de rentrer dans le lard. il faut continuer! ose attaquer. prends l'initiative et touche. Y a qu'en osant qu'on apprend de ses erreurs.",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Quand tu tires contre un gaucher, essaie de le toucher à l'épaule gauche. droit devant toi. En gardant ton bras allongé. et ton avant-bras toujours direction de l'épaule gauche. ",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Quand tu vois que tu peux toucher à la manchette dessous (en dessous de la main car la main est trop relevée), fléchis tes jambes et essaie de toucher la manchette.",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Lorsque tu passes de l'autre côté de la coquille, ne fléchis pas le bras, utilise ton poigner pour passer en dessous. Comme cà, l'avant-bras est toujours dirigé vers la cible que tu veux toucher.",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Lorsque tu es en garde, ta main est à la même hauteur que le coude. et lorsque tu attaques, ton bras reste allongé. même quand tu es trop près de ton adversaire, laisse ton bras allongé vers la cible que tu veux toucher. C'est seulement quand tu es à bonne distance de ton adversaire que tu peux fléchir le bras.",
                            },
                        }
                    },
                    new RemarqueParDate()
                {
                    DateRemarque = new DateTime(2024, 12, 18),
                    Arme = TypeArme.Epée,
                    Tireur = new Tireur()
                    {
                        UserNameIndex = this._tireurSelectionne.UserNameIndex,
                    },
                    RemarquesData = new List<RemarqueData>()
                            {
                             new RemarqueData()
                                {
                                    PointNégatif="Avant d'attaquer, pense à la cible où tu vas toucher. J'ai l'impression que tu démarres ton attaque souvent vers la ligne basse au lieu de viser la saignée ou l'épaule. Ecarte le fer avant d'attaquer pour que ton adversaire ne soit plus menaçant. Et avant de démarrer tes jambes, ton bras doit être allongé complètement.",
                                    HasUrlVideo=false,
                                    Frequency =3,
                                },

                            }
                },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024, 10, 9),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                            {
                                new RemarqueData()
                                {
                                    PointPositif="Hello Mathilde, parfois le simple fait de prendre l'initiative, d'allonger ton bras vers la saignée et d'avancer avec tes jambes te donnent le point. surtout quand ton adversaire arrive avec un bras fléchi. là tu ne dois pas réfléchir, tu allonges le bras vers sa saignée et c'est lui qui se prend la touche. Par contre, s' il essaie de prendre le fer, essaie qu'il n'y arrive pas en passant de l'autre côté de sa lame et en allongeant ton bras. le plus important c'est qu'il n'arrive pas à continuer son attaque en gardant ton fer par dégagement. ",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/9-10-2024_mathilde.avi",
                                    Frequency = 3,
                                    UrlYoutubeVideo = "dQctvUBMnjw"
                                },
                            }
                    }
                });

                return remarquesParDateTireur;
            }
        }
      
    }
}