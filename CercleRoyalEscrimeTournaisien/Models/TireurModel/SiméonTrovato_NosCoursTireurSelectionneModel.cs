using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class SiméonTrovato_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private DateTime DateDeNaissance
        {
            get
            {
                return new DateTime(2015,5, 4);
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
                };
            }
        }
        public SiméonTrovato_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
        {
            this._tireurSelectionne  = tireurSelectionne;
        }
        public List<RemarqueParDate> RemarquesParDateTireur
        {
            get
            {
                List<RemarqueParDate> remarquesParDateTireur = new List<RemarqueParDate>() { };
              
                return remarquesParDateTireur;
            }
        }
      
    }
}