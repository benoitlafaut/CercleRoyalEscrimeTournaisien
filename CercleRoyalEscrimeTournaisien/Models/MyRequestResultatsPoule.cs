using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien.Models
{
    public class MyRequestResultatsPoule
    {       
        public List<ClassResultats> ClassResultatsList { get; set; }
    }
    public class ClassResultats
    {
        public Guid TireurGuid { get; set; }
        public string Tireur { get; set; }
        public string NombreDeVictoiresParMatchs { get; set; }
        public string TDMoinsTR { get; set; }
        public string TD { get; set; }        
    }
}
