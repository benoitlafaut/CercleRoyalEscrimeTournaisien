using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class Paiements_2025_2026
    {
        public JoursDePrésence ChargerPresences()
        {
            JoursDePrésence joursDePrésence = new JoursDePrésence();

            return joursDePrésence;
        }
        
        public void Add_Paiements_Vantroyen_Mae(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMaeVantroyen && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidMaeVantroyen && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = false,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },

                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,4),
                        new DateTime(2024,9,11),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Motte_Baptiste(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidBaptisteMotte && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidBaptisteMotte && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Motte_Abel(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAbelMotte && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidAbelMotte && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,9,6),
                        new DateTime(2023,9,8)
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Trannoy_Félix(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFélixTrannoy && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidFélixTrannoy && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }

        public void Add_Paiements_Trannoy_Régis(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRégisTrannoy && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidRégisTrannoy && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "45 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }


        public void Add_Paiements_Razanajao_Fabrice(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFabriceRazanajao && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidFabriceRazanajao && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationCarte5 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }

       
        public void Add_Paiements_Deblocq_Oscar(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidOscarDeblocq && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidOscarDeblocq && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsLocationMatérielEnOrdre = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Vandy_Rebecca(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRebeccaVandy && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidRebeccaVandy && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsLocationMatérielEnOrdre = true,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = false,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,15),
                        new DateTime(2024,9,18),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Punchoo_Eliot(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidEliotPunchoo && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidEliotPunchoo && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsLocationMatérielEnOrdre = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,11,24),
                        new DateTime(2024,11,27),
                    },
                    IsMatérielLoue = true
                };
        }

       
        public void Add_Paiements_Barbery_Arthur(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidArthurBarbery && x.Période == period))
            {
                return;
            }
            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidArthurBarbery && x.Période == period).Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
       

        public void Add_Paiements_Soyez_Rémi(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRémiSoyez && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidRémiSoyez && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = false
                };
        }

       





        public void Add_Paiements_Couturiaux_Arthur(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidArthurCouturiaux && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidArthurCouturiaux && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre= false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,11,6),
                        new DateTime(2023,11,8),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Mestdagh_Jordan(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidJordanMestdagh && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidJordanMestdagh && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,2,2),
                        new DateTime(2024,2,4),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Siu_Martin(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMartinSiu && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidMartinSiu && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,5,27),
                        new DateTime(2024,5,29),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Vercouter_Raedwald(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRaedwaldVercouter && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidRaedwaldVercouter && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,5,31),
                        new DateTime(2024,6,2),
                    },
                    IsMatérielLoue = true
                };
        }
       
        public void Add_Paiements_Dransart_NoelMarie(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidNoelMarieDransart && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidNoelMarieDransart && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2025,4,9),
                        new DateTime(2025,4,11),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Beaucamp_Barnabé(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidBarnabéBeaucamp && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidBarnabéBeaucamp && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2025,5,14),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Belbenoit_Romain(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRomainBelbenoit && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidRomainBelbenoit && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2025,5,14),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Beaucamp_Naya(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidNayaBeaucamp && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidNayaBeaucamp && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                       new DateTime(2025,5,14),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Simon_Amado(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAmadoSimon && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidAmadoSimon && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,6),
                        new DateTime(2024,9,11),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Mass_Elodie(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidElodieMass && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidElodieMass && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,13),
                        new DateTime(2024,9,20),
                    },
                    IsMatérielLoue = true
                };
        }
        
        public void Add_Paiements_Carlier_Aurore(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAuroreCarlier && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidAuroreCarlier && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,4),
                        new DateTime(2024,9,8),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Carette_Mathilde(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMathildeCarette && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidMathildeCarette && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,4),
                        new DateTime(2024,9,6),
                    },
                    IsMatérielLoue = true
                };
        }
       
        public void Add_Paiements_Ivanov_Anaelle(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAnaelleIvanov && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidAnaelleIvanov && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,4),
                        new DateTime(2024,9,11)
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Mestdag_Lili(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLiliMestdag && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidLiliMestdag && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,4),
                        new DateTime(2024,9,6),
                    },
                    IsMatérielLoue = true
                };
        }
    }
}