using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class SolalSchrouf_NosCoursTireurSelectionneModel : NosCoursTireurSelectionneModel
    {
        private DateTime DateDeNaissance
        {
            get
            {
                return new DateTime(2017, 10, 3);
            }
        }
        public Categorie Categorie
        {
            get
            {
                return ListGuidTireur.SearchCategorie(DateDeNaissance.Year);

            }
        }
        public IDictionary<string, string> GetPoules
        {
            get
            {
                return new Dictionary<string, string>()
                {
                };
            }
        }
        public SolalSchrouf_NosCoursTireurSelectionneModel(Tireur tireurSelectionne)  : base()
        {
            TireurSelectionne = tireurSelectionne;
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