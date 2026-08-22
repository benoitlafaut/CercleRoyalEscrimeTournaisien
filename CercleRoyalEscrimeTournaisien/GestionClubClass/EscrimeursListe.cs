using CercleRoyalEscrimeTournaisien;
using CercleRoyalEscrimeTournaisien.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EscrimeursListe
    {
        public HttpServerUtilityBase ServerTmp { get; set; }
        public JoursDePrésence JoursDePrésence
        { 
            get
            {
                switch (Periode)
                {
                    case "2022-2023":
                        //Paiements_2022_2023 paiements_2022_2023 = new Paiements_2022_2023();
                        //return paiements_2022_2023.ChargerPresences();
                    case "2023-2024":
                        Paiements_2023_2024 paiements_2023_2024 = new Paiements_2023_2024();
                        return paiements_2023_2024.ChargerPresences();
                    case "2024-2025":
                        Paiements_2024_2025 paiements_2024_2025 = new Paiements_2024_2025();
                        return paiements_2024_2025.ChargerPresences();
                    case "2025-2026":
                        Paiements_2025_2026 paiements_2025_2026 = new Paiements_2025_2026();
                        return paiements_2025_2026.ChargerPresences();
                    case "2026-2027":
                        Paiements_2026_2027 paiements_2026_2027 = new Paiements_2026_2027();
                        return paiements_2026_2027.ChargerPresences();
                    default:
                        Paiements_2025_2026 paiements_Default = new Paiements_2025_2026();
                        return paiements_Default.ChargerPresences();
                }
            } 
        }
        public string Periode { get; set; }
        public List<MembreData> Membres { get; set; }
        public string TireurSpecificToSelected { get; set; }
        public bool IsNotTakeAccountTireursOK { get; set; }
        public EscrimeursListe(HttpServerUtilityBase serverTmp)
        {
            this.ServerTmp = serverTmp;
            if (string.IsNullOrEmpty(Periode)) { Periode = Models.Periode.Period_2026_2027; }
            ApplicPeriod();
        }
        public EscrimeursListe(HttpServerUtilityBase serverTmp, string period)
        {
            this.ServerTmp = serverTmp;
            if (string.IsNullOrEmpty(Periode)) { Periode = period; }
            ApplicPeriod();
        }

        public void ApplicPeriod()
        {
            ListGuidTireur listGuidTireur = new ListGuidTireur(this.ServerTmp)
            {
                Période = Periode
            };
            Membres = listGuidTireur.MembresWithPeriod;

            switch (Periode)
            {
                case "2022-2023":
                    Add_FichesSignalétiques_2022_2023();
                    Add_Paiements_2022_2023();
                    break;
                case "2023-2024":
                    Add_FichesSignalétiques_2023_2024();
                    Add_Paiements_2023_2024();
                    break;
                case "2024-2025":
                    Add_FichesSignalétiques_2024_2025();
                    Add_Paiements_2024_2025();
                    break;
                case "2025-2026":
                    Add_FichesSignalétiques_2025_2026();
                    Add_Paiements_2025_2026();
                    break;
                case "2026-2027":                       
                    Membres = new List<MembreData>(){ };                       
                    Add_NewProcedure_ToAddFichesAndPaiements_2026_2027();                   
                    break;
            }            
        }
        private void Add_FichesSignalétiques_2024_2025()
        {
            const string period = "2024-2025";
            FichesSignalétiques_2024_2025 fichesSignalétiques_2024_2025 = new FichesSignalétiques_2024_2025();

            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Vandy_Rebecca(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Punchoo_Eliot(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Trannoy_Félix(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Motte_Baptiste(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Motte_Abel(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Vantroyen_Mae(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Razanajao_Fabrice(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Simon_Amado(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Dufrasne_Eva(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Carlier_Maybelle(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Deblocq_Oscar(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Deblocq_Judith(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Barbery_Arthur(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Soyez_Rémi(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Cle_Leander(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Couturiaux_Arthur(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Mestdagh_Jordan(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Mestdag_Lili(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Siu_Martin(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Vercouter_Raedwald(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Carette_Mathilde(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Lessart_Sacha(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Binois_Eloi(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Binois_Louison(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Odendhal_Apolline(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Carlier_Aurore(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Pras_Héloïse(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Mass_Elodie(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Ivanov_Anaelle(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Dransart_NoelMarie(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Beaucamp_Barnabé(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Beaucamp_Naya(period, Membres);
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Bracquart_Romain(period, Membres);
        }

        #region  Add_FichesSignalétiques_2022_2023
        private void Add_FichesSignalétiques_2022_2023()
        {
            const string period = "2022-2023";
            FichesSignalétiques_2022_2023 fichesSignalétiques_2022_2023 = new FichesSignalétiques_2022_2023();

            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Leclercq_Cyril(period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Deblocq_Judith(period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Deblocq_Oscar(period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Carlier_Maybelle( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Gillet_Thomas(period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Debruyne_Karel( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Debruyne_Helena( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Razanajao_Fabrice( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Trannoy_Félix( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Lemaire_Antoine( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Delmotte_Maxime(period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Dooms_Jules( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Dooms_Gabriel( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Carlier_Arthur( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Motte_Baptiste( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Brabant_Eliot( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Waeselynck_Lisa( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Barbery_Arthur( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Dransart_NoelMarie( period, Membres);
            fichesSignalétiques_2022_2023.Add_FichesSignalétiques_Dransart_Iann(period, Membres);
        }
        #endregion
        private void Add_NewProcedure_ToAddFichesAndPaiements_2026_2027()
        {
            string period2026_2027 = "2026-2027";
            BaseDeDonnéesMapper baseDeDonnéesMapper = new BaseDeDonnéesMapper();
            List<TableListeTireursData> tableTireurs = baseDeDonnéesMapper.GetTableListeTireursData(ServerTmp, period2026_2027);

            foreach (TableListeTireursData tireurData in tableTireurs)
            {
                string seancesGratuites = tireurData.SeancesGratuites;
                string[] arySeancesGratuites = seancesGratuites.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                List<DateTime> arySeancesGratuitesDate = new List<DateTime>() { };
                foreach (string seance in arySeancesGratuites)
                {
                    arySeancesGratuitesDate.Add(Convert.ToDateTime(seance));
                }

                Membres.Add(new MembreData()
                {
                    GuidId = new System.Guid(tireurData.GuidTireur),
                    Nom = tireurData.Nom,
                    Prénom = tireurData.Prenom,
                    Période = period2026_2027,
                    Paiement = new Paiement()
                    {
                        IsChaussettesPayéesEnOrdre = tireurData.IsChaussettesPayeesEnOrdre,
                        IsCotisationAnnuelle = tireurData.IsCotisationAnnuelle,
                        IsCotisationCarte1 = tireurData.IsCotisationCarte1,
                        IsCotisationCarte2 = tireurData.IsCotisationCarte2,
                        IsCotisationCarte3 = tireurData.IsCotisationCarte3,
                        IsCotisationCarte4 = tireurData.IsCotisationCarte4,
                        IsCotisationCarte5 = tireurData.IsCotisationCarte5,
                        IsCotisationCarte6 = tireurData.IsCotisationCarte6,
                        IsCotisationEnOrdre = tireurData.IsCotisationEnOrdre,
                        IsFicheSignaletiqueEnOrdre = tireurData.IsFicheSignaletiqueEnOrdre,
                        IsLocationMatérielEnOrdre = tireurData.IsLocationMaterielEnOrdre,
                        IsMatérielLoue = tireurData.IsMaterielLoue,
                        IsTeeShirtsPayéesEnOrdre = tireurData.IsTeeShirtsPayeesEnOrdre,
                        PaiementsEffectues = tireurData.PaiementsEffectues.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                        SeancesGratuites = arySeancesGratuitesDate,
                        Periode = period2026_2027
                    },
                    Signaletique = new Signaletique()
                    {
                        Categorie = ListGuidTireur.SearchCategorie(Convert.ToDateTime(tireurData.Birthdate).Year),
                        DateDeNaissance = Convert.ToDateTime(tireurData.Birthdate),
                        Email = new List<string>() { tireurData.EmailPropre, tireurData.EmailMere, tireurData.EmailPere },
                        FicheSignaletiqueUrl = tireurData.FicheSignaletiqueUrl,
                        NomMaman = tireurData.NomMere,
                        NomPapa = tireurData.NomPere,
                        Telephone = new List<string>() { tireurData.TelephoneMere, tireurData.TelephonePere, tireurData.TelephonePropre },                        
                    }
                });
            }
        }
        #region  Add_FichesSignalétiques_2023_2024
        private void Add_FichesSignalétiques_2023_2024()
        {
            const string period = "2023-2024";
            FichesSignalétiques_2023_2024 fichesSignalétiques_2023_2024 = new FichesSignalétiques_2023_2024();

            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Trannoy_Félix( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Motte_Baptiste( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Motte_Abel( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Leclercq_Cyril( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Courret_Margaux( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Razanajao_Fabrice( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Dufrasne_Eva( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Carlier_Maybelle( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Deblocq_Oscar( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Deblocq_Judith( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Barbery_Arthur( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Waeselynck_Lisa( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Soyez_Rémi( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Cle_Leander( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Couturiaux_Arthur( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Mestdagh_Jordan( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Siu_Martin( period, Membres);
            fichesSignalétiques_2023_2024.Add_FichesSignalétiques_Vercouter_Raedwald(period, Membres);
        }
        #endregion
        
         
        private void Add_FichesSignalétiques_2025_2026()
        {
            const string period = "2025-2026";
            FichesSignalétiques_2025_2026 fichesSignalétiques_2025_2026 = new FichesSignalétiques_2025_2026();

            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Vandy_Rebecca(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Punchoo_Eliot(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Trannoy_Félix(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Trannoy_Régis(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Motte_Baptiste(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Motte_Abel(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Vantroyen_Mae(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Razanajao_Fabrice(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Simon_Amado(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Deblocq_Oscar(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Barbery_Arthur(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Soyez_Rémi(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Couturiaux_Arthur(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Mestdagh_Jordan(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Mestdag_Lili(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Siu_Martin(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Vercouter_Raedwald(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Carlier_Aurore(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Mass_Elodie(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Ivanov_Anaelle(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Dransart_NoelMarie(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Beaucamp_Barnabé(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Beaucamp_Naya(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Bracquart_Romain(period, Membres);

            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Schrouf_Solal(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Lepas_PierreAugustin(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Thulier_Gabriel(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Cosentini_Benedict(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Verheye_Lucas(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_XXX_Guillaume(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Ducrot_Oscar(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Rasson_Théo(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Lecomte_Gwendal(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Lawrizy_Amel(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_XXX_Jérome(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_XXX_Hubin(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Vercauteren_Delphine(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Motte_Sébastien(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Lafaut_Benoît(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Trovato_Simeon(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Segard_Gabriel(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Duthye_Esteban(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Cucheval_JeanMarc(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Tanis_Matthieu(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Bauffe_Florian(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Colpaert_Eleonara(period, Membres);
            fichesSignalétiques_2025_2026.Add_FichesSignalétiques_Persyn_Marc(period, Membres);
        }
        private void Add_FichesSignalétiques_2026_2027()
        {
            const string period = "2026-2027";
            FichesSignalétiques_2026_2027 fichesSignalétiques = new FichesSignalétiques_2026_2027();

            fichesSignalétiques.Add_FichesSignalétiques_Vandy_Rebecca(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Punchoo_Eliot(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Trannoy_Félix(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Trannoy_Régis(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Motte_Baptiste(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Motte_Abel(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Vantroyen_Mae(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Razanajao_Fabrice(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Simon_Amado(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Deblocq_Oscar(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Soyez_Rémi(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Mestdagh_Jordan(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Mestdag_Lili(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Siu_Martin(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Vercouter_Raedwald(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Carlier_Aurore(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Mass_Elodie(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Ivanov_Anaelle(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Dransart_NoelMarie(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Bracquart_Romain(period, Membres);

            fichesSignalétiques.Add_FichesSignalétiques_Schrouf_Solal(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Cosentini_Benedict(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Verheye_Lucas(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Ducrot_Oscar(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Rasson_Théo(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Lecomte_Gwendal(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Lawrizy_Amel(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Vercauteren_Delphine(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Motte_Sébastien(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Lafaut_Benoît(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Segard_Gabriel(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Duthye_Esteban(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Cucheval_JeanMarc(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Tanis_Matthieu(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Bauffe_Florian(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Colpaert_Eleonara(period, Membres);
            fichesSignalétiques.Add_FichesSignalétiques_Persyn_Marc(period, Membres);
        }

        #region Add_Paiements_2022_2023
        private void Add_Paiements_2022_2023()
        {
            const string period = "2022-2023";
            Paiements_2022_2023 paiements_2022_2023 = new Paiements_2022_2023();

            paiements_2022_2023.Add_Paiements_Leclercq_Cyril(period, Membres);
            paiements_2022_2023.Add_Paiements_Deblocq_Judith(period, Membres);
            paiements_2022_2023.Add_Paiements_Deblocq_Oscar(period, Membres);
            paiements_2022_2023.Add_Paiements_Carlier_Maybelle(period, Membres);
            paiements_2022_2023.Add_Paiements_Gillet_Thomas(period, Membres);
            paiements_2022_2023.Add_Paiements_Debruyne_Helena(period, Membres);
            paiements_2022_2023.Add_Paiements_Debruyne_Karel(period, Membres);
            paiements_2022_2023.Add_Paiements_Razanajao_Fabrice(period, Membres);
            paiements_2022_2023.Add_Paiements_Trannoy_Félix(period, Membres);
            paiements_2022_2023.Add_Paiements_Lemaire_Antoine(period, Membres);
            paiements_2022_2023.Add_Paiements_Delmotte_Maxime(period, Membres);
            paiements_2022_2023.Add_Paiements_Dooms_Gabriel(period, Membres);
            paiements_2022_2023.Add_Paiements_Dooms_Jules(period, Membres);
            paiements_2022_2023.Add_Paiements_Carlier_Arthur( period, Membres);
            paiements_2022_2023.Add_Paiements_Motte_Baptiste( period, Membres);
            paiements_2022_2023.Add_Paiements_Brabant_Eliot(period, Membres);
            paiements_2022_2023.Add_Paiements_Waeselynck_Lisa(period, Membres);
            paiements_2022_2023.Add_Paiements_Barbery_Arthur(period, Membres);
            paiements_2022_2023.Add_Paiements_Dransart_Iann(period, Membres);
            paiements_2022_2023.Add_Paiements_Dransart_NoelMarie(period, Membres);
        }
        #endregion
        private void Add_Paiements_2023_2024()
        {
            const string period = "2023-2024";

            Paiements_2023_2024 paiements_2023_2024 = new Paiements_2023_2024();

            paiements_2023_2024.Add_Paiements_Trannoy_Félix(period, Membres);
            paiements_2023_2024.Add_Paiements_Motte_Baptiste(period, Membres);
            paiements_2023_2024.Add_Paiements_Motte_Abel(period, Membres);
            paiements_2023_2024.Add_Paiements_Leclercq_Cyril(period, Membres);
            paiements_2023_2024.Add_Paiements_Courret_Margaux(period, Membres);
            paiements_2023_2024.Add_Paiements_Razanajao_Fabrice(period, Membres);
            paiements_2023_2024.Add_Paiements_Dufrasne_Eva(period, Membres);
            paiements_2023_2024.Add_Paiements_Carlier_Maybelle(period, Membres);
            paiements_2023_2024.Add_Paiements_Deblocq_Judith(period, Membres);
            paiements_2023_2024.Add_Paiements_Deblocq_Oscar(period, Membres);
            paiements_2023_2024.Add_Paiements_Barbery_Arthur(period, Membres);
            paiements_2023_2024.Add_Paiements_Waeselynck_Lisa(period, Membres);
            paiements_2023_2024.Add_Paiements_Soyez_Rémi(period, Membres);
            paiements_2023_2024.Add_Paiements_Cle_Leander(period, Membres);
            paiements_2023_2024.Add_Paiements_Couturiaux_Arthur(period, Membres);
            paiements_2023_2024.Add_Paiements_Mestdagh_Jordan(period, Membres);
            paiements_2023_2024.Add_Paiements_Siu_Martin(period, Membres);
            paiements_2023_2024.Add_Paiements_Vercouter_Raedwald(period, Membres);
        }
        private void Add_Paiements_2024_2025()
        {
            const string period = "2024-2025";

            Paiements_2024_2025 paiements = new Paiements_2024_2025();

            paiements.Add_Paiements_Trannoy_Félix(period, Membres);
            paiements.Add_Paiements_Motte_Baptiste(period, Membres);
            paiements.Add_Paiements_Binois_Louison(period, Membres);
            paiements.Add_Paiements_Vantroyen_Mae(period, Membres);
            paiements.Add_Paiements_Motte_Abel(period, Membres);
            paiements.Add_Paiements_Razanajao_Fabrice(period, Membres);
            paiements.Add_Paiements_Dufrasne_Eva(period, Membres);
            paiements.Add_Paiements_Carlier_Maybelle(period, Membres);
            paiements.Add_Paiements_Deblocq_Judith(period, Membres);
            paiements.Add_Paiements_Vandy_Rebecca(period, Membres);
            paiements.Add_Paiements_Punchoo_Eliot(period, Membres);
           // paiements.Add_Paiements_CousineARemiJudith(period, Membres);
            paiements.Add_Paiements_Deblocq_Oscar(period, Membres);
            paiements.Add_Paiements_Barbery_Arthur(period, Membres);
            paiements.Add_Paiements_Soyez_Rémi(period, Membres);
            paiements.Add_Paiements_Cle_Leander(period, Membres);
            paiements.Add_Paiements_Couturiaux_Arthur(period, Membres);
            paiements.Add_Paiements_Mestdagh_Jordan(period, Membres);
            paiements.Add_Paiements_Siu_Martin(period, Membres);
            paiements.Add_Paiements_Vercouter_Raedwald(period, Membres);
            paiements.Add_Paiements_Binois_Eloi(period, Membres);
            paiements.Add_Paiements_Pras_Héloïse(period, Membres);
            paiements.Add_Paiements_Dransart_NoelMarie(period, Membres);
            paiements.Add_Paiements_Beaucamp_Barnabé(period, Membres);
            paiements.Add_Paiements_Beaucamp_Naya(period, Membres);
            paiements.Add_Paiements_Simon_Amado(period, Membres);
            paiements.Add_Paiements_Mass_Elodie(period, Membres);
            paiements.Add_Paiements_Carlier_Aurore(period, Membres);
            paiements.Add_Paiements_Carette_Mathilde(period, Membres);
            paiements.Add_Paiements_Mestdag_Lili(period, Membres);
            paiements.Add_Paiements_Odendhal_Apolline(period, Membres);
            paiements.Add_Paiements_Ivanov_Anaelle(period, Membres);
            paiements.Add_Paiements_Lessart_Sacha(period, Membres);
            paiements.Add_Paiements_Bracquart_Romain(period, Membres);
        }

        private void Add_Paiements_2025_2026()
        {
            const string period = "2025-2026";

            Paiements_2025_2026 paiements = new Paiements_2025_2026();

            paiements.Add_Paiements_Trannoy_Félix(period, Membres);
            paiements.Add_Paiements_Trannoy_Régis(period, Membres);
            paiements.Add_Paiements_Motte_Baptiste(period, Membres);
            paiements.Add_Paiements_Vantroyen_Mae(period, Membres);
            paiements.Add_Paiements_Motte_Abel(period, Membres);
            paiements.Add_Paiements_Razanajao_Fabrice(period, Membres);
            paiements.Add_Paiements_Vandy_Rebecca(period, Membres);
            paiements.Add_Paiements_Punchoo_Eliot(period, Membres);
            paiements.Add_Paiements_Deblocq_Oscar(period, Membres);
            paiements.Add_Paiements_Barbery_Arthur(period, Membres);
            paiements.Add_Paiements_Soyez_Rémi(period, Membres);
            paiements.Add_Paiements_Couturiaux_Arthur(period, Membres);
            paiements.Add_Paiements_Mestdagh_Jordan(period, Membres);
            paiements.Add_Paiements_Siu_Martin(period, Membres);
            paiements.Add_Paiements_Vercouter_Raedwald(period, Membres);
            paiements.Add_Paiements_Dransart_NoelMarie(period, Membres);
            paiements.Add_Paiements_Beaucamp_Barnabé(period, Membres);
            paiements.Add_Paiements_Beaucamp_Naya(period, Membres);
            paiements.Add_Paiements_Simon_Amado(period, Membres);
            paiements.Add_Paiements_Mass_Elodie(period, Membres);
            paiements.Add_Paiements_Carlier_Aurore(period, Membres);
            paiements.Add_Paiements_Mestdag_Lili(period, Membres);
            paiements.Add_Paiements_Ivanov_Anaelle(period, Membres);
            paiements.Add_Paiements_Bracquart_Romain(period, Membres);

            paiements.Add_Paiements_Schrouf_Solal(period, Membres);
            paiements.Add_Paiements_Thulier_Gabriel(period, Membres);
            paiements.Add_Paiements_Lepas_PierreAugustin(period, Membres);
            paiements.Add_Paiements_Cosentini_Benedict(period, Membres);
            paiements.Add_Paiements_XXX_Guillaume(period, Membres);
            paiements.Add_Paiements_Verheye_Lucas(period, Membres);
            paiements.Add_Paiements_Ducrot_Oscar(period, Membres);
            paiements.Add_Paiements_Lecomte_Gwendal(period, Membres);
            paiements.Add_Paiements_Rasson_Théo(period, Membres);
            paiements.Add_Paiements_Lawrizy_Amel(period, Membres);
            paiements.Add_Paiements_Rohart_Jérome(period, Membres);
            paiements.Add_Paiements_Delplanque_Hubin(period, Membres);
            paiements.Add_Paiements_Motte_Sébastien(period, Membres);
            paiements.Add_Paiements_Vercauteren_Delphine(period, Membres);
            paiements.Add_Paiements_Lafaut_Benoît(period, Membres);
            paiements.Add_Paiements_Trovato_Simeon(period, Membres);
            paiements.Add_Paiements_Segard_Gabriel(period, Membres);
            paiements.Add_Paiements_Duthye_Esteban(period, Membres); 
            paiements.Add_Paiements_Cucheval_JeanMarc(period, Membres);
            paiements.Add_Paiements_Tanis_Matthieu(period, Membres);
            paiements.Add_Paiements_Bauffe_Florian(period, Membres);
            paiements.Add_Paiements_Colpaert_Eleonara(period, Membres);
            paiements.Add_Paiements_Persyn_Marc(period, Membres);
        }
        private void Add_Paiements_2026_2027()
        {
            const string period = "2026-2027";

            Paiements_2026_2027 paiements = new Paiements_2026_2027();

            paiements.Add_Paiements_Trannoy_Félix(period, Membres);
            paiements.Add_Paiements_Trannoy_Régis(period, Membres);
            paiements.Add_Paiements_Motte_Baptiste(period, Membres);
            paiements.Add_Paiements_Vantroyen_Mae(period, Membres);
            paiements.Add_Paiements_Motte_Abel(period, Membres);
            paiements.Add_Paiements_Razanajao_Fabrice(period, Membres);
            paiements.Add_Paiements_Vandy_Rebecca(period, Membres);
            paiements.Add_Paiements_Punchoo_Eliot(period, Membres);
            paiements.Add_Paiements_Deblocq_Oscar(period, Membres);
            paiements.Add_Paiements_Soyez_Rémi(period, Membres);
            paiements.Add_Paiements_Mestdagh_Jordan(period, Membres);
            paiements.Add_Paiements_Siu_Martin(period, Membres);
            paiements.Add_Paiements_Vercouter_Raedwald(period, Membres);
            paiements.Add_Paiements_Dransart_NoelMarie(period, Membres);
            paiements.Add_Paiements_Simon_Amado(period, Membres);
            paiements.Add_Paiements_Mass_Elodie(period, Membres);
            paiements.Add_Paiements_Carlier_Aurore(period, Membres);
            paiements.Add_Paiements_Mestdag_Lili(period, Membres);
            paiements.Add_Paiements_Ivanov_Anaelle(period, Membres);
            paiements.Add_Paiements_Bracquart_Romain(period, Membres);

            paiements.Add_Paiements_Schrouf_Solal(period, Membres);
            paiements.Add_Paiements_Cosentini_Benedict(period, Membres);
            paiements.Add_Paiements_Verheye_Lucas(period, Membres);
            paiements.Add_Paiements_Ducrot_Oscar(period, Membres);
            paiements.Add_Paiements_Lecomte_Gwendal(period, Membres);
            paiements.Add_Paiements_Rasson_Théo(period, Membres);
            paiements.Add_Paiements_Lawrizy_Amel(period, Membres);
            paiements.Add_Paiements_Motte_Sébastien(period, Membres);
            paiements.Add_Paiements_Vercauteren_Delphine(period, Membres);
            paiements.Add_Paiements_Lafaut_Benoît(period, Membres);
            paiements.Add_Paiements_Segard_Gabriel(period, Membres);
            paiements.Add_Paiements_Duthye_Esteban(period, Membres);
            paiements.Add_Paiements_Cucheval_JeanMarc(period, Membres);
            paiements.Add_Paiements_Tanis_Matthieu(period, Membres);
            paiements.Add_Paiements_Bauffe_Florian(period, Membres);
            paiements.Add_Paiements_Colpaert_Eleonara(period, Membres);
            paiements.Add_Paiements_Persyn_Marc(period, Membres);
        }
    }
}