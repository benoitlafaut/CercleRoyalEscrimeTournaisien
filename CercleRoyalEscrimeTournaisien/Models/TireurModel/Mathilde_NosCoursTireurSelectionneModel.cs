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