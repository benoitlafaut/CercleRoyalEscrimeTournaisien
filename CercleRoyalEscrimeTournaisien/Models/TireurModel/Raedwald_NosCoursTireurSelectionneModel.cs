using System;
using System.Collections.Generic;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Raedwald_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
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
        public Raedwald_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                    //HasPointPositif=false,
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                   Remarque="Au fleuret, quand tu fais une retraite, tu n'es pas considéré comme à l'attaque et du coup tu es en mode défense et tu dois essayer de reprendre la priorité en faisant une parade et ne pas allonger le bras en cherchant la touche ca la première priorité c'est l'attaque.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Raedwald.avi",
                                    UrlYoutubeVideo = "pS15cMKEnVY"
                                },
                               new RemarqueData()
                                {
                                   // HasPointPositif=false,
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                   Remarque="Dans cette vidéo, je vois de la raideur dans tes jambes. Travaille chaque jour un petit peu et celà disparaîtra. je vois aussi deux points d'attention à éviter. Ta main armée un peu basse quand elle est allongée; Elle doit être à hauteur de l'épaule. et tu décolles ton pied arrière pour toucher et tu penches ton corps. Laisse tes deux pieds ancrés au sol et le tronc bien droit. Si tu es trop court au niveau de la distance, ajoute un marché en plus de la fente.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Raedwald_2.avi",
                                    UrlYoutubeVideo = "S65S7kd0ZNw"
                                },
                                new RemarqueData()
                                {
                                  //  HasPointPositif=true,
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Positif,
                                     Remarque="La parade de sixte est bien faite. Fais juste attention de ne pas tourner ta main lors de la touche (il n'y a pas besoin de la tourner).",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/22-09-2024_Raedwald_3.avi",
                                    UrlYoutubeVideo = "NgAeJR-ioXA"
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
                                        //HasPointPositif=false,
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif,
                                        Remarque="les passe avant sont interdites au sabre. N'hésite pas à faire les gestes. et à parler plus fort. Pour le commun des mortels, c'est très dur de suivre un match sans entendre ni voir. Ici tu as même deux passe avant l'une à la suite de l'autre non sanctionnées.",
                                        HasUrlVideo=true,
                                        UrlVideo = "/Videos/20-10-2024_Raedwald.avi",
                                        UrlYoutubeVideo = "NSuLlMTWpOE",
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