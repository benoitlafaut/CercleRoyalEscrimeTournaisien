using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class JoursDePrésence
    {        
        public DateTime JourMinimumDesJoursDePrésence { 
            get
            {
                if (JourDePrésence == null) { return DateTime.MinValue;  }
                return JourDePrésence.OrderBy(x => x.DatePrésence).First().DatePrésence;
            }
        }
        public List<JourDePrésence> JourDePrésence {get;set;}       
    }
    public class JourDePrésence
    {
        public DateTime DatePrésence { get; set; }
        public List<Guid> EscrimeurId { get; set; }
    }
}