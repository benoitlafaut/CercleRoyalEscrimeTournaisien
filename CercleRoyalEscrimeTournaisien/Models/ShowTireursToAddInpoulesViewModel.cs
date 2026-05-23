using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien.Models
{
    [Serializable]
    public class ShowTireursToAddInpoulesViewModel
    {
        public ShowTireursToAddInpoulesViewModel()
        {
            Tireurs = new List<ClassShowTireursToAddInpoules>();
        }
        
        public List<ClassShowTireursToAddInpoules> Tireurs { get; set; }
    }
    public class ClassShowTireursToAddInpoules
    {
        public ClassShowTireursToAddInpoules()
        {
            Tireur = new ClassTireur();
            Poules = new List<ClassPoule>() { };
        }

        public ClassTireur Tireur { get; set; }
        public List<ClassPoule> Poules { get; set; }
    }
}