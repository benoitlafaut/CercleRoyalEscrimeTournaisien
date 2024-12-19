using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Apolline_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private Tireur _tireurSelectionne { get; set; }
        public Apolline_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
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
                        DateRemarque = new DateTime(2024,11 ,16),
                        Arme = TypeArme.Epée,
                        Tireur = new Tireur()
                        {
                            UserNameIndex = this._tireurSelectionne.UserNameIndex,
                        },
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                PointNégatif="Quand tu es en mode défense, quand tu subis l'attaque, tu cherches à tout prix à toucher à écarter le fer adverse au lieu d'allonger le bras pour chercher la touche. Et même en attaque, tu cherches à tout prix à chercher le fer adverse, oublie cette manie. Va directement jusqu'à la touche en choisissant la cible que tu veux toucher et en allongeant ET ton avant-bras et ta lame vers la cible que tu as choisie.",
                                Frequency = 5
                            },
                        }
                    },
                   
                });
                return remarquesParDateTireur;
            }
        }
      
    }
}