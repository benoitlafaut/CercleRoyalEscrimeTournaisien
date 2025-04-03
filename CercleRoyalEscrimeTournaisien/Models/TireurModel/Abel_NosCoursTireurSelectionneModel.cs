using System;
using System.Collections.Generic;
using WebApplication1.Models;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Abel_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private DateTime DateDeNaissance
        { 
            get
            {
                return new DateTime(2015, 4, 22);
            } 
        }
        public Categorie Categorie 
        {
            get
            {
                return ListGuidTireur.SearchCategorie(DateDeNaissance.Year);

            }
        }
        private Tireur _tireurSelectionne { get; set; }
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },
                    { "/Poules/Poule 2025-01-19 Sabre.pdf", "Poule 2025-01-19 Sabre"  },
                };

            }
        }
        public Abel_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                        DateRemarque = new DateTime(2025, 4, 3),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque="Quand tu mènes de plus d' une touche (4-2 par exemple), c'est à ton adversaire à attaquer. Toi tu dois juste tenir la distance et laisser défiler le temps.",
                                PointPositifNégatifObservation = PointPositifNégatifObservation.Observation
                            },
                            new RemarqueData()
                            {
                                Remarque="quand tu recules à juste titre, ne recule pas trop loin. c'est inutile. à bonne distance, je suis d'accord mais pas trop loin.",
                                 PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif
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
                                Remarque="Tu as beaucoup d'énergie, c'est bien. n'oublie pas que ton bras est allongé avant d'utiliser tes jambes; tu gagneras en précision pour aller toucher tes adversaires soit à la saignée soit à l'épaule droite.",
                                        PointPositifNégatifObservation = PointPositifNégatifObservation.Positif
                    },
                            new RemarqueData()
                            {
                                Remarque="Laisse ton tronc bien droit. et laisse ton bras allongé quand tu n'as pas touché. il se fléchit quand tu es à bonne distance de ton adversaire.",
                                                  PointPositifNégatifObservation = PointPositifNégatifObservation.Négatif 
          },
                        }
                    },
                    
                });
                return remarquesParDateTireur;
            }
        }
      
    }
}