using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien.Models
{
    public class MyRequestToSaveInPoule
    {
        public List<string> TireursSelected { get; set; }
        public string PouleSelected { get; set; }
    }
}
