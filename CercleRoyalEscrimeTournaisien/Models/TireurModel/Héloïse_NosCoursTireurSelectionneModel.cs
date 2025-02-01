using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Héloïse_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
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
        public Héloïse_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                                PointPositif="La machine commence à se mettre en place. tu commences à bouger un peu plus. pas encore comme des adultes et c'est normal mais cà commence à évoluer. pour toi, cà sera surtout stabilisation des jambes, aller vers l'avant en faisant de beaux marchés ou rompés et de belles fentes. il est normal que tu puisses pas encore rivaliser avec des jeunes de 11 13 ans mais c'est en bonne voie! ",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Quand tu attaques, n'inverse pas tes épaules. L'épaule gauche est toujours derrière l'épaule droite et ne passe pas devant.",
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
                                    PointPositif="Parfois, le simple fait d'allonger le bras, lorsqu'il est trop près, est suffisant à toucher ton adversaire. Fais des rompés marchés pour casser la distance; une fois proche de ton adversaire, allonge le bras et utilise tes jambes pour le toucher.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/9-10-2024_heloise.avi",
                                    UrlYoutubeVideo = "tisM4JuO4Fw"
                                }, 
                            new RemarqueData()
                                {
                                    PointNégatif="Quand tu es en garde, descends un peu ta main pour l'avoir à la hauteur que le coude; là on voit que ta main est trop haute et Amado peut toucher ton avant-bras. Descends juste la main. si l'épée est trop lourde, tu peux prendre une plus petite épée.",
                                    HasUrlVideo=true,
                                    UrlVideo = "/Videos/9-10-2024_heloise_2.avi",
                                    UrlYoutubeVideo = "L-tnXs5Oilk"
                                },
                            }
                    }
                });

                return remarquesParDateTireur;
            }
        }
      
    }
}