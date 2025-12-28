using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Paiement
    {
        public Guid EscrimeurId { get; set; }
        public string Periode { get; set; }
        public bool IsCotisationEnOrdre { get; set; }
        public bool IsLicenceEnOrdre { get; set; }
        public bool IsFicheSignaletiqueEnOrdre { get; set; }
        public bool IsChaussettesPayéesEnOrdre { get; set; }
        public bool IsTeeShirtsPayéesEnOrdre { get; set; }
        public bool IsLocationMatérielEnOrdre { get; set; }        
        public List<DateTime> SeancesGratuites { get; set; }
        public List<DateTime> JoursDePrésences { get; set; }
        public int NombreDeJoursDePrésence { get; set; }
        public List<string> PaiementsEffectues { get; set; }
        public bool IsCotisationAnnuelle { get; set; }
        public bool IsCotisationCarte1 { get; set; }
        public bool IsCotisationCarte2 { get; set; }
        public bool IsCotisationCarte3 { get; set; }
        public bool IsCotisationCarte4 { get; set; }
        public bool IsCotisationCarte5 { get; set; }
        public bool IsCotisationCarte6 { get; set; }
        public bool IsMatérielLoue { get; set; }
    }
}