using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class EscrimeursListe
    {
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
                    default:
                        Paiements_2024_2025 paiements_2024_2025 = new Paiements_2024_2025();
                        return paiements_2024_2025.ChargerPresences();
                }
            } 
        }
        public string Periode { get; set; }
        public List<MembreData> Membres { get; set; }
        public string TireurSpecificToSelected { get; set; }
        public bool IsNotTakeAccountTireursOK { get; set; }
        public EscrimeursListe()
        {
            if (string.IsNullOrEmpty(Periode)) { Periode = Models.Periode.Period_2024_2025; }
            ApplicPeriod();
        }

        public void ApplicPeriod()
        {
            ListGuidTireur listGuidTireur = new ListGuidTireur
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
            }            
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

        private void Add_FichesSignalétiques_2024_2025()
        {
            const string period = "2024-2025";
            FichesSignalétiques_2024_2025 fichesSignalétiques_2024_2025 = new FichesSignalétiques_2024_2025();

            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Vandy_Rebecca(period, Membres);
           // fichesSignalétiques_2024_2025.Add_FichesSignalétiques_CousineARemiJudith(period, Membres);
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
            fichesSignalétiques_2024_2025.Add_FichesSignalétiques_Belbenoit_Romain(period, Membres);
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
            paiements.Add_Paiements_Belbenoit_Romain(period, Membres);
        }
    }
}