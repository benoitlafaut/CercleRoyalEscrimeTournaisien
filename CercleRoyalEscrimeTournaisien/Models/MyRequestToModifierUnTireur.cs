using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien.Models
{
    public class MyRequestToModifierUnTireur
    {
        public string NewComerGuidTireur { get;set; }      
        public string NewComerBirthDate { get; set; }
        public string NewComerDayMercrediSelected { get; set; }
        public string NewComerDayVendrediSelected { get; set; }
        public string NewComerDayDimancheSelected { get; set; }
    }
}
