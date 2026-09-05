using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class Paiements_2026_2027
    {
        public JoursDePrésence ChargerPresences()
        {
            JoursDePrésence joursDePrésence = new JoursDePrésence()
            {
                JourDePrésence = new List<JourDePrésence>()
                {
                                    new JourDePrésence()
                {
                  DatePrésence = new DateTime(2026,9,4),
                  EscrimeurId = new List<Guid>()
                  {
                    GuidConstantes.GuidAbelMotte,
                    GuidConstantes.GuidAmelLawrizy,
                    GuidConstantes.GuidAnaelleIvanov,
                    GuidConstantes.GuidBalianJanssens,
                    GuidConstantes.GuidBaptisteMotte,
                    GuidConstantes.GuidElineDesprets,
                    GuidConstantes.GuidEstebanDuthye,
                    GuidConstantes.GuidFabriceRazanajao,
                    GuidConstantes.GuidFélixTrannoy,
                    GuidConstantes.GuidGaranceMorren,
                    GuidConstantes.GuidGaspardHoufflain,
                    GuidConstantes.GuidGuillemineCuvelier,
                    GuidConstantes.GuidJeanMarcCucheval,
                    GuidConstantes.GuidJordanMestdagh,
                    GuidConstantes.GuidJoshuaBonte,
                    GuidConstantes.GuidLucasVerheye,
                    GuidConstantes.GuidMaeVantroyen,
                    GuidConstantes.GuidMartinSiu,
                    GuidConstantes.GuidOscarDeblocq,
                    GuidConstantes.GuidRémiSoyez,
                    GuidConstantes.GuidSolalSchrouf,
                    GuidConstantes.GuidThéoCucheval_Rasson,
                  }
                },
                                    new JourDePrésence()
                {
                  DatePrésence = new DateTime(2026,9,2),
                  EscrimeurId = new List<Guid>()
                  {
                    GuidConstantes.GuidAnaelleIvanov,
                    GuidConstantes.GuidBalianJanssens,
                    GuidConstantes.GuidBaptisteMotte,
                    GuidConstantes.GuidBenedictCosentini,
                    GuidConstantes.GuidEleonaraColpaert,
                    GuidConstantes.GuidElineDesprets,
                    GuidConstantes.GuidEliotPunchoo,
                    GuidConstantes.GuidFabriceRazanajao,
                    GuidConstantes.GuidFélixTrannoy,
                    GuidConstantes.GuidGabrielSegard,
                    GuidConstantes.GuidGaranceMorren,
                    GuidConstantes.GuidGaspardHoufflain,
                    GuidConstantes.GuidJosephBearez,
                    GuidConstantes.GuidJoshuaBonte,
                    GuidConstantes.GuidLiliMestdag,
                    GuidConstantes.GuidLucasVerheye,
                    GuidConstantes.GuidMaeVantroyen,
                    GuidConstantes.GuidRebeccaVandy,
                    GuidConstantes.GuidRémiSoyez,
                    GuidConstantes.GuidRomainBracquart,
                    GuidConstantes.GuidSolalSchrouf,
                    GuidConstantes.GuidThéoCucheval_Rasson,
                  }
                },
                }
            };
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
                    IsChaussettesPayéesEnOrdre = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsLocationMatérielEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros"  },

                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,4),
                        new DateTime(2024,9,11),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Schrouf_Solal(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidSolalSchrouf && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidSolalSchrouf && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsChaussettesPayéesEnOrdre = true,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },

                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2025,9,3),
                        new DateTime(2025,9,5),
                    },
                    IsMatérielLoue = true
                };
        }
        
       
        public void Add_Paiements_Segard_Gabriel(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidGabrielSegard && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidGabrielSegard && x.Période == period).FirstOrDefault().Paiement =
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
                    IsChaussettesPayéesEnOrdre = true,

                    PaiementsEffectues = new List<string>() {},

                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2026,3,15),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Duthye_Esteban(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidEstebanDuthye && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidEstebanDuthye && x.Période == period).FirstOrDefault().Paiement =
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
                    IsChaussettesPayéesEnOrdre = true,

                    PaiementsEffectues = new List<string>() {  },

                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2026,3,20),
                        new DateTime(2026,3,22),
                    },
                    IsMatérielLoue = true
                };
        }
       
      
        public void Add_Paiements_Ducrot_Oscar(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidOscarDucrot && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidOscarDucrot && x.Période == period).FirstOrDefault().Paiement =
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
                        new DateTime(2025,9,12),
                        new DateTime(2025,9,21),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Rasson_Théo(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidThéoCucheval_Rasson && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidThéoCucheval_Rasson && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsChaussettesPayéesEnOrdre = true,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = true,

                    PaiementsEffectues = new List<string>() { },

                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2025,9,12),
                        new DateTime(2025,9,14),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Cucheval_JeanMarc(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidJeanMarcCucheval && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidJeanMarcCucheval && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsChaussettesPayéesEnOrdre = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },

                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2026,4,05)
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Lecomte_Gwendal(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidGwendalLecomte && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidGwendalLecomte && x.Période == period).FirstOrDefault().Paiement =
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
                    IsChaussettesPayéesEnOrdre = true,
                    IsTeeShirtsPayéesEnOrdre = true,

                    PaiementsEffectues = new List<string>() {  },

                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2025,9,12),
                    },
                    IsMatérielLoue = true
                };
        }


        public void Add_Paiements_Verheye_Lucas(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLucasVerheye && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidLucasVerheye && x.Période == period).FirstOrDefault().Paiement =
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
                    IsChaussettesPayéesEnOrdre = true,
                    PaiementsEffectues = new List<string>() {  },

                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2025,9,5),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Cosentini_Benedict(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidBenedictCosentini && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidBenedictCosentini && x.Période == period).FirstOrDefault().Paiement =
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

                    PaiementsEffectues = new List<string>() {},

                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2025,9,3),
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
                    IsChaussettesPayéesEnOrdre = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = true,
                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Vercauteren_Delphine(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidDelphineVercauteren && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidDelphineVercauteren && x.Période == period).FirstOrDefault().Paiement =
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

                    PaiementsEffectues = new List<string>() { "" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = false
                };
        }
        public void Add_Paiements_Motte_Sébastien(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidSébastienMotte && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidSébastienMotte && x.Période == period).FirstOrDefault().Paiement =
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

                    PaiementsEffectues = new List<string>() { "" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = false
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
                    IsChaussettesPayéesEnOrdre = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = true,
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
                    IsChaussettesPayéesEnOrdre = true,
                    IsTeeShirtsPayéesEnOrdre = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() { "290 euros" },
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
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

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
                    IsChaussettesPayéesEnOrdre = true,
                    IsTeeShirtsPayéesEnOrdre = true,
                    PaiementsEffectues = new List<string>() {  },
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
                    IsChaussettesPayéesEnOrdre = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsLocationMatérielEnOrdre = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
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
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsChaussettesPayéesEnOrdre = true,
                    IsLocationMatérielEnOrdre = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = true,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,15),
                        new DateTime(2024,9,18),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Bauffe_Florian(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFlorianBauffe && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidFlorianBauffe && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsChaussettesPayéesEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2026,4,19),
                        new DateTime(2026,4,26),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Tanis_Matthieu(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMatthieuTanis && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidMatthieuTanis && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsChaussettesPayéesEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2026,4,19),
                        new DateTime(2026,4,26),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Colpaert_Eleonara(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidEleonaraColpaert && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidEleonaraColpaert && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsChaussettesPayéesEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = false,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2026,5,13),
                        new DateTime(2026,5,17),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Persyn_Marc(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMarcPersyn && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidMarcPersyn && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsChaussettesPayéesEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsTeeShirtsPayéesEnOrdre = false,

                    PaiementsEffectues = new List<string>() { "" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2026,5,24),
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
                    IsChaussettesPayéesEnOrdre = true,
                    IsCotisationCarte4 = false,
                    IsLocationMatérielEnOrdre = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = true,

                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,11,24),
                        new DateTime(2024,11,27),
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
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = false
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
                    IsChaussettesPayéesEnOrdre = true,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = true,
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
                    IsChaussettesPayéesEnOrdre = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = true,
                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,5,27),
                        new DateTime(2024,5,29),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Lafaut_Benoît(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidBenoîtLafaut && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidBenoîtLafaut && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsChaussettesPayéesEnOrdre = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLocationMatérielEnOrdre = false,
                    IsTeeShirtsPayéesEnOrdre = true,
                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = false
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
                    IsChaussettesPayéesEnOrdre = true,
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

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2025,4,9),
                        new DateTime(2025,4,11),
                    },
                    IsMatérielLoue = true
                };
        }
       
        public void Add_Paiements_Bracquart_Romain(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRomainBracquart && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidRomainBracquart && x.Période == period).FirstOrDefault().Paiement =
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
                    IsChaussettesPayéesEnOrdre = true,

                    PaiementsEffectues = new List<string>() { },
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
                    IsChaussettesPayéesEnOrdre = true,
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
                    IsChaussettesPayéesEnOrdre = true,
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
        public void Add_Paiements_Lawrizy_Amel(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAmelLawrizy && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidAmelLawrizy && x.Période == period).FirstOrDefault().Paiement =
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
                    IsTeeShirtsPayéesEnOrdre = true,
                    PaiementsEffectues = new List<string>() {  },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,26),
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
                    IsChaussettesPayéesEnOrdre = true,
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