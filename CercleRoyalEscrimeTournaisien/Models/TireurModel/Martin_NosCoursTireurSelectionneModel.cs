using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Martin_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                { 
                    { "", ""  },                    
                    { "/Poules/Poule 2025-03-12 Epée.pdf", "Poule 2025-03-12 Epée"  },
                };
            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public Martin_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
        {
            this._tireurSelectionne = tireurSelectionne;
        }
        public List<RemarqueParDate> RemarquesParDateTireur
        {
            get
            {
                List<RemarqueParDate> remarquesParDateTireur = new List<RemarqueParDate>() { };
                remarquesParDateTireur.AddRange(
                new List<RemarqueParDate>()
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
                                PointPositif="Je n'ai pas beaucoup de vue sur tes matchs. mais je sais que la pointe tu l'attrapes un peu à la fois. Il y a encore du taf, cà c'est sur. mais le fait d'attaquer et le fait d'oser, tu peux t'en tirer en gagnant des touches par ci par là. Il faut croire en toi et oser !",
                            },
                        }
                    },
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
                                PointPositif="la pointe est très bonne. continue de toucher aux avancées (manchette, saignée). Tu peux y arriver, il faut croire en toi !",
                            },
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2024,11 ,16),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex ,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointPositif="Une fois que tu as touché et que tu sais comment tu as touché (c'est le plus important), utilise cette méthode très souvent. Par exemple, quand tu tires contre Félix, et que tu recules et que lui attaque, laisse ton bras allongé en visant la saignée et c'est celui qui aura le bras le plus allongé avec la pointe vers la saignée qui marquera. Une fois que tu mènes de 2 3 touches, laisse le temps défiler et laisse le attaquer. c'est lui qui perdra car tu as trouvé une stratégie pour le battre qui marche.",
                                HasUrlVideo =false,
                                UrlVideo = "",
                                UrlYoutubeVideo = ""
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
                                PointNégatif="Sur cette vidéo, on voit que ta main est trop haute par rapport à ton coude et elle se trouve au milieu de ton corps. Ta main doit être bien à droite et à hauteur de ton coude, et la pointe doit rentrer pour viser la manchette adverse. La coquille de l'épée sert à te protéger ton avant-bras.",
                                HasUrlVideo =true,
                                UrlVideo = "/Videos/12-10-2024_martin.avi",
                                UrlYoutubeVideo = "T47pHrhJjkQ"
                            },
                            new RemarqueData()
                            {
                                PointPositif="Ici tu attaques très bien, les jambes suivent. magnifique. Par deux fois Oscar bloque ton attaque en t'emmenant en ligne basse et vient chercher la touche. C'est un travail de poignet que tu dois t'habituer à faire. Travaille uniquement ton poignet afin de faire passer de l'autre côté de la lame de ton adversaire en attaquant. En travaillant ce petit mouvement de poignet, tu vas parvenir à dégager de la parade d'Oscar et si tu continues ton action, tu vas toucher en premier. Mais n'hésite pas à ne plus te faire prendre le fer lors de l'attaque, anticipe le fait que Oscar ou quelqu'un d'autre puisse prendre ton fer lors de ton attaque en passant de l'autre côté de la lame.",
                                HasUrlVideo =true,
                                UrlVideo = "/Videos/12-10-2024_martin_2.avi",
                                Frequency = 3,
                                UrlYoutubeVideo = "cK4lxbRogVc"
                            },
                        }
                    }

                });

                return remarquesParDateTireur;
            }
        }
      
    }
}