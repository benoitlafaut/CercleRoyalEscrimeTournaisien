using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public  class Paiements_2022_2023
    {
        
        public  void Add_Paiements_Leclercq_Cyril(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidCyrilLeclercq && x.Période == period ))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidCyrilLeclercq && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    //JoursDePrésences = new List<DateTime>()
                    //{                        
                    //},
                    PaiementsEffectues = new List<string>() { "50 euros", "260 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2022,9,12),
                        new DateTime(2022,9,14)
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Deblocq_Judith(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidJudithDeblocq && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidJudithDeblocq && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //},
                    PaiementsEffectues = new List<string>() { "50 euros", "215 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2022,9,12),
                        new DateTime(2022,9,14)
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Deblocq_Oscar(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidOscarDeblocq && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidOscarDeblocq && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //},
                    PaiementsEffectues = new List<string>() { "50 euros", "260 euros", "51 euros (mathos)" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Carlier_Maybelle(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMaybelleCarlier && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidMaybelleCarlier && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = true,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLicenceEnOrdre = false,
                    IsLocationMatérielEnOrdre = true,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //    new DateTime(2022,9,16),
                    //    new DateTime(2022,9,18),
                    //    new DateTime(2022,9,23),
                    //    new DateTime(2022,9,25),
                    //    new DateTime(2022,9,30),
                    //    new DateTime(2022,10,2),
                    //    new DateTime(2022,10,14),
                    //    new DateTime(2022,10,16),
                    //    new DateTime(2022,10,23),
                    //    new DateTime(2022,11,13),
                    //    new DateTime(2022,11,18),
                    //    new DateTime(2022,11,20),
                    //    new DateTime(2022,11,25),
                    //    new DateTime(2022,11,27),
                    //    new DateTime(2022,12,2),
                    //    new DateTime(2022,12,9),
                    //    new DateTime(2022,12,18),
                    //    new DateTime(2022,12,23),
                    //    new DateTime(2022,1,13),
                    //    new DateTime(2022,1,29),
                    //    new DateTime(2022,2,10),
                    //    new DateTime(2022,2,17),
                    //    new DateTime(2022,3,12),
                    //    new DateTime(2022,3,24),
                    //    new DateTime(2022,3,26),
                    //    new DateTime(2022,4,2),
                    //    new DateTime(2022,4,14),
                    //    new DateTime(2022,4,23),
                    //    new DateTime(2022,6,2),
                    //    new DateTime(2022,6,4),
                    //},
                    PaiementsEffectues = new List<string>() { "40 euros", "40 euros", "85 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Gillet_Thomas(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidThomasGillet && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidThomasGillet && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = true,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //    new DateTime(2022,9,16),
                    //    new DateTime(2022,9,18),
                    //    new DateTime(2022,9,23),
                    //    new DateTime(2022,9,25),
                    //    new DateTime(2022,9,07),
                    //    new DateTime(2022,10,21),
                    //    new DateTime(2022,10,23),
                    //    new DateTime(2022,11,18),
                    //    new DateTime(2022,11,20),
                    //    new DateTime(2022,11,25),
                    //    new DateTime(2022,12,02),
                    //    new DateTime(2022,12,09),
                    //    new DateTime(2022,12,18),
                    //    new DateTime(2022,12,23),
                    //    new DateTime(2022,01,13),
                    //    new DateTime(2022,01,20),
                    //    new DateTime(2022,1,27),
                    //    new DateTime(2022,1,29),
                    //    new DateTime(2022,2,3),
                    //    new DateTime(2022,2,5),
                    //    new DateTime(2022,2,10),
                    //    new DateTime(2022,2,17),
                    //    new DateTime(2022,2,19),
                    //    new DateTime(2022,3,10),
                    //    new DateTime(2022,3,17),
                    //    new DateTime(2022,3,31),
                    //    new DateTime(2022,4,2),
                    //},
                    PaiementsEffectues = new List<string>() { "40 euros", "40 euros", "85 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = false
                };
        }

        public  void Add_Paiements_Debruyne_Helena(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidHelenaDebruyne && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidHelenaDebruyne && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLicenceEnOrdre = false,
                    IsLocationMatérielEnOrdre = true,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //    new DateTime(2022,11,30),
                    //    new DateTime(2022,12,5),
                    //    new DateTime(2022,12,7),
                    //    new DateTime(2022,12,19),
                    //    new DateTime(2022,12,21),
                    //    new DateTime(2022,1,9),
                    //    new DateTime(2022,1,18),
                    //    new DateTime(2022,1,25),
                    //    new DateTime(2022,2,6),
                    //    new DateTime(2022,2,8),
                    //    new DateTime(2022,2,15),
                    //    new DateTime(2022,3,13),
                    //    new DateTime(2022,3,22),
                    //    new DateTime(2022,3,27),
                    //    new DateTime(2022,3,29),
                    //    new DateTime(2022,4,12),
                    //    new DateTime(2022,4,19),
                    //    new DateTime(2022,4,24),
                    //    new DateTime(2022,4,26),
                    //    new DateTime(2022,5,31),
                    //},
                    PaiementsEffectues = new List<string>() { "321 euros (Karel+Helena)" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2022,11,16),
                        new DateTime(2022,11,28),                    
                    },
                    IsMatérielLoue = true
                };
        }

        public  void Add_Paiements_Debruyne_Karel(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidKarelDebruyne && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId ==  GuidConstantes.GuidKarelDebruyne && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { "321 euros (Karel+Helena)" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }

        public  void Add_Paiements_Razanajao_Fabrice(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFabriceRazanajao && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidFabriceRazanajao && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //    new DateTime(2022,9,16),
                    //    new DateTime(2022,9,18),
                    //    new DateTime(2022,9,23),
                    //    new DateTime(2022,9,30),
                    //    new DateTime(2022,10,7),
                    //    new DateTime(2022,10,14),
                    //    new DateTime(2022,10,16),
                    //    new DateTime(2022,10,21),
                    //    new DateTime(2022,11,18),
                    //    new DateTime(2022,11,25),
                    //    new DateTime(2022,11,27),
                    //    new DateTime(2022,12,2),
                    //    new DateTime(2022,12,4),
                    //    new DateTime(2022,12,11),
                    //    new DateTime(2022,2,3),
                    //    new DateTime(2022,2,5),
                    //    new DateTime(2022,2,10),
                    //    new DateTime(2022,2,19),
                    //    new DateTime(2022,3,12),
                    //    new DateTime(2022,3,26),
                    //    new DateTime(2022,4,14),
                    //    new DateTime(2022,4,16),
                    //    new DateTime(2022,4,21),
                    //    new DateTime(2022,5,26),
                    //},
                    PaiementsEffectues = new List<string>() { "85 euros", "40 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Trannoy_Félix(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFélixTrannoy && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidFélixTrannoy && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { "260 euros", "50 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2022,9,12),
                        new DateTime(2022,9,14),
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Lemaire_Antoine(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAntoineLemaire && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidAntoineLemaire && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //    new DateTime(2022,9,18),
                    //    new DateTime(2022,9,25),
                    //    new DateTime(2022,10,2),
                    //    new DateTime(2022,10,14),
                    //    new DateTime(2022,10,16),
                    //    new DateTime(2022,11,13),
                    //    new DateTime(2022,11,20),
                    //    new DateTime(2022,11,27),
                    //    new DateTime(2022,12,11),
                    //    new DateTime(2022,12,23),
                    //    new DateTime(2023,1,20),
                    //    new DateTime(2023,1,29),
                    //    new DateTime(2023,2,19),
                    //    new DateTime(2023,3,19),
                    //    new DateTime(2023,3,26),
                    //    new DateTime(2023,4,2),
                    //    new DateTime(2023,5,21),
                    //},
                    PaiementsEffectues = new List<string>() { "85 euros", "40 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        
                    },
                    IsMatérielLoue = false
                };
        }
        public  void Add_Paiements_Delmotte_Maxime(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMaximeDelmotte && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidMaximeDelmotte && x.Période == period).Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = false,
                    IsLocationMatérielEnOrdre = true,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //    new DateTime(2022,10,16),
                    //    new DateTime(2022,10,21),
                    //    new DateTime(2023,1,20),
                    //},
                    PaiementsEffectues = new List<string>() { "85 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = false
                };
        }

        public  void Add_Paiements_Dooms_Gabriel(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidGabrielDooms && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidGabrielDooms && x.Période == period).Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { "260 euros", "50 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2022,9,12),
                        new DateTime(2022,9,14)
                    },
                    IsMatérielLoue = true
                };
        }

        public  void Add_Paiements_Dooms_Jules(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidJulesDooms && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidJulesDooms && x.Période == period).Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { "260 euros", "50 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2022,11,7),
                        new DateTime(2022,11,9)
                    },
                    IsMatérielLoue = true
                };
        }

        public  void Add_Paiements_Carlier_Arthur(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidArthurCarlier && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidArthurCarlier && x.Période == period).Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { "260 euros", "50 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2022,9,12),
                        new DateTime(2022,9,14)
                    },
                    IsMatérielLoue = true
                };
        }

        public  void Add_Paiements_Motte_Baptiste(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidBaptisteMotte && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidBaptisteMotte && x.Période == period).Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = false,
                    IsLocationMatérielEnOrdre = true,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //    new DateTime(2022,10,17),
                    //    new DateTime(2022,11,7),
                    //    new DateTime(2022,11,21),
                    //    new DateTime(2022,11,28),
                    //    new DateTime(2022,12,5),
                    //    new DateTime(2022,12,12),
                    //    new DateTime(2022,12,19),
                    //    new DateTime(2023,1,9),
                    //    new DateTime(2023,1,16),
                    //    new DateTime(2023,1,23),
                    //    new DateTime(2023,1,30),
                    //    new DateTime(2023,2,6),
                    //    new DateTime(2023,2,13),
                    //    new DateTime(2023,3,6),
                    //    new DateTime(2023,3,13),
                    //    new DateTime(2023,3,20),
                    //    new DateTime(2023,3,27),
                    //    new DateTime(2023,4,17),
                    //    new DateTime(2023,4,24),
                    //    new DateTime(2023,5,15),
                    //    new DateTime(2023,5,17),
                    //    new DateTime(2023,5,22),
                    //    new DateTime(2023,5,24),
                    //    new DateTime(2023,5,31),
                    //},
                    PaiementsEffectues = new List<string>() { "85 euros", "50 euros", "40 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {                        
                    },
                    IsMatérielLoue = true
                };
        }

        public  void Add_Paiements_Brabant_Eliot(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidEliotBrabant && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidEliotBrabant && x.Période == period).Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { "155 euros", "155 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }

        public  void Add_Paiements_Waeselynck_Lisa(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLisaWaeselynck && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidLisaWaeselynck && x.Période == period).Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = false,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //    new DateTime(2023,5,28),
                    //    new DateTime(2023,6,2),
                    //    new DateTime(2023,6,04),
                    //},
                    PaiementsEffectues = new List<string>() { "73 euros (proratisé)" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,5,19),
                        new DateTime(2023,5,26),
                    },
                    IsMatérielLoue = true
                };
        }

        public  void Add_Paiements_Barbery_Arthur(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidArthurBarbery && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidArthurBarbery && x.Période == period).Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    
                    PaiementsEffectues = new List<string>() { "260 euros", "50 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }

       

        public  void Add_Paiements_Dransart_Iann(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidIannDransart && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidIannDransart && x.Période == period).Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //    new DateTime(2023,5,31)
                    //},
                    PaiementsEffectues = new List<string>() { "100 euros (proratisé)" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,5,17),
                        new DateTime(2023,5,22)
                    },
                    IsMatérielLoue = true
                };
        }
        public  void Add_Paiements_Dransart_NoelMarie(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidNoelMarieDransart && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidNoelMarieDransart && x.Période == period).Paiement =
                new Paiement()
                {
                    Periode = Periode.Period_2022_2023,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    //JoursDePrésences = new List<DateTime>()
                    //{
                    //    new DateTime(2023,5,31)
                    //},
                    PaiementsEffectues = new List<string>() { "100 euros (proratisé)" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,5,17),
                        new DateTime(2023,5,22)
                    },
                    IsMatérielLoue = true
                };
        }

     
    }
}