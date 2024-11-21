using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Martin_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
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