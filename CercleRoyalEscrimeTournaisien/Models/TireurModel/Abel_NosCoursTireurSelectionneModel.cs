using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Abel_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
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
                                PointPositif="Tu as beaucoup d'énergie, c'est bien. n'oublie pas que ton bras est allongé avant d'utiliser tes jambes; tu gagneras en précision pour aller toucher tes adversaires soit à la saignée soit à l'épaule droite.",
                            },
                            new RemarqueData()
                            {
                                PointNégatif="Laisse ton tronc bien droit. et laisse ton bras allongé quand tu n'as pas touché. il se fléchit quand tu es à bonne distance de ton adversaire.",
                            },
                        }
                    },
                    
                });
                return remarquesParDateTireur;
            }
        }
      
    }
}