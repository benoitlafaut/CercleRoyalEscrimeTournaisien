using System;
using System.Collections.Generic;
using System.Linq;

namespace CercleRoyalEscrimeTournaisien 
{ 
    [Serializable]
    public class NosCoursTireurSelectionneModel
    {
        public IDictionary<bool, string> SpeakerList
        {
            get
            {
                return new Dictionary<bool, string>()
                {
                    { true, "Lecteur" },
                    { false,"Lectrice" }
                };
            }
        }

        //public IDictionary<string, string> Poules { get; set; }
        public bool HasMale { get; set; }
        public bool PouleSelectionnee { get; set; }
        public Tireur TireurSelectionne { get; set; }
        public List<RemarqueParDate> RemarquesPourTousLesTireursParDate
        {
            get
            {
                ToutTireur_NosCoursTireurSelectionneModel toutTireur_NosCoursTireurSelectionneModel = new ToutTireur_NosCoursTireurSelectionneModel() { };
                return toutTireur_NosCoursTireurSelectionneModel.RemarquesParDateTireur;
            }
        }

        public List<RemarqueParDate> RemarquesParDate { 
            get
            {

                switch (TireurSelectionne.UserNameIndex)
                {
                    case IndexTireurConstantes.TireurIndex.EloiBinois:
                        Eloi_NosCoursTireurSelectionneModel eloi_NosCoursTireurSelectionneModel = new Eloi_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(eloi_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.EvaDufrasne:
                        Eva_NosCoursTireurSelectionneModel eva_NosCoursTireurSelectionneModel = new Eva_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(eva_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.LouisonBinois:
                        Louison_NosCoursTireurSelectionneModel louison_NosCoursTireurSelectionneModel = new Louison_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(louison_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.RémiSoyez:
                        Remi_NosCoursTireurSelectionneModel remi_NosCoursTireurSelectionneModel = new Remi_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(remi_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.ElodieMass:
                        Elodie_NosCoursTireurSelectionneModel elodie_NosCoursTireurSelectionneModel = new Elodie_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(elodie_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.FélixTrannoy:
                        Felix_NosCoursTireurSelectionneModel felix_NosCoursTireurSelectionneModel = new Felix_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(felix_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.OscarDeblocq:
                        Oscar_NosCoursTireurSelectionneModel oscar_NosCoursTireurSelectionneModel = new Oscar_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(oscar_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.MaybelleCarlier:
                        Maybelle_NosCoursTireurSelectionneModel maybelle_NosCoursTireurSelectionneModel = new Maybelle_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(maybelle_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.FabriceRazanajao:
                        Fabrice_NosCoursTireurSelectionneModel fabrice_NosCoursTireurSelectionneModel = new Fabrice_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(fabrice_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.AbelMotte:
                        Abel_NosCoursTireurSelectionneModel abel_NosCoursTireurSelectionneModel = new Abel_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(abel_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.BaptisteMotte:
                        Baptiste_NosCoursTireurSelectionneModel baptiste_NosCoursTireurSelectionneModel = new Baptiste_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(baptiste_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.EliotPunchoo:
                        Eliot_NosCoursTireurSelectionneModel Eliot_NosCoursTireurSelectionneModel = new Eliot_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(Eliot_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.ArthurBarbery:
                        ArthurBarbery_NosCoursTireurSelectionneModel arthurBarbery_NosCoursTireurSelectionneModel = new ArthurBarbery_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(arthurBarbery_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.LeanderCle:
                        Leander_NosCoursTireurSelectionneModel leander_NosCoursTireurSelectionneModel = new Leander_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(leander_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.ArthurCouturiaux:
                        ArthurCouturiaux_NosCoursTireurSelectionneModel arthurCouturiaux_NosCoursTireurSelectionneModel = new ArthurCouturiaux_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(arthurCouturiaux_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.JordanMestdagh:
                        Jordan_NosCoursTireurSelectionneModel jordan_NosCoursTireurSelectionneModel = new Jordan_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(jordan_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.MartinSiu:
                        Martin_NosCoursTireurSelectionneModel martin_NosCoursTireurSelectionneModel = new Martin_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(martin_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.RaedwaldVercouter:
                        Raedwald_NosCoursTireurSelectionneModel raedwald_NosCoursTireurSelectionneModel = new Raedwald_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(raedwald_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.AuroreCarlier:
                        Aurore_NosCoursTireurSelectionneModel aurore_NosCoursTireurSelectionneModel = new Aurore_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(aurore_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.AnaelleIvanov:
                        Anaelle_NosCoursTireurSelectionneModel anaelle_NosCoursTireurSelectionneModel = new Anaelle_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(anaelle_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.LiliMestdag:
                        Lili_NosCoursTireurSelectionneModel lili_NosCoursTireurSelectionneModel = new Lili_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(lili_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.MathildeCarette:
                        Mathilde_NosCoursTireurSelectionneModel mathilde_NosCoursTireurSelectionneModel = new Mathilde_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(mathilde_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.MaeVantroyen:
                        Mae_NosCoursTireurSelectionneModel mae_NosCoursTireurSelectionneModel = new Mae_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(mae_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.SachaLessart:
                        Sacha_NosCoursTireurSelectionneModel sacha_NosCoursTireurSelectionneModel = new Sacha_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(sacha_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.ApollineOdendhal:
                        Apolline_NosCoursTireurSelectionneModel apolline_NosCoursTireurSelectionneModel = new Apolline_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(apolline_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.AmadoSimon:
                        Amado_NosCoursTireurSelectionneModel amado_NosCoursTireurSelectionneModel = new Amado_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(amado_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                   
                    case IndexTireurConstantes.TireurIndex.HéloïsePras:
                        Héloïse_NosCoursTireurSelectionneModel héloïse_NosCoursTireurSelectionneModel = new Héloïse_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(héloïse_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.RebeccaVandy:
                        Rebecca_NosCoursTireurSelectionneModel rebecca_NosCoursTireurSelectionneModel = new Rebecca_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(rebecca_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    default:
                        return new List<RemarqueParDate>() { };
                }

                
            }
          
        }
        public IDictionary<string, string> Poules
        {
            get
            {

                switch (TireurSelectionne.UserNameIndex)
                {
                    case IndexTireurConstantes.TireurIndex.EloiBinois:
                        Eloi_NosCoursTireurSelectionneModel eloi_NosCoursTireurSelectionneModel = new Eloi_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return eloi_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.EvaDufrasne:
                        Eva_NosCoursTireurSelectionneModel eva_NosCoursTireurSelectionneModel = new Eva_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return eva_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.LouisonBinois:
                        Louison_NosCoursTireurSelectionneModel louison_NosCoursTireurSelectionneModel = new Louison_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return louison_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.RémiSoyez:
                        Remi_NosCoursTireurSelectionneModel remi_NosCoursTireurSelectionneModel = new Remi_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return remi_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.ElodieMass:
                        Elodie_NosCoursTireurSelectionneModel elodie_NosCoursTireurSelectionneModel = new Elodie_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return elodie_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.FélixTrannoy:
                        Felix_NosCoursTireurSelectionneModel felix_NosCoursTireurSelectionneModel = new Felix_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return felix_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.OscarDeblocq:
                        Oscar_NosCoursTireurSelectionneModel oscar_NosCoursTireurSelectionneModel = new Oscar_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return oscar_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.MaybelleCarlier:
                        Maybelle_NosCoursTireurSelectionneModel maybelle_NosCoursTireurSelectionneModel = new Maybelle_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return maybelle_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.FabriceRazanajao:
                        Fabrice_NosCoursTireurSelectionneModel fabrice_NosCoursTireurSelectionneModel = new Fabrice_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return fabrice_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.AbelMotte:
                        Abel_NosCoursTireurSelectionneModel abel_NosCoursTireurSelectionneModel = new Abel_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return abel_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.BaptisteMotte:
                        Baptiste_NosCoursTireurSelectionneModel baptiste_NosCoursTireurSelectionneModel = new Baptiste_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return baptiste_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.EliotPunchoo:
                        Eliot_NosCoursTireurSelectionneModel Eliot_NosCoursTireurSelectionneModel = new Eliot_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return Eliot_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.ArthurBarbery:
                        ArthurBarbery_NosCoursTireurSelectionneModel arthurBarbery_NosCoursTireurSelectionneModel = new ArthurBarbery_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return arthurBarbery_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.LeanderCle:
                        Leander_NosCoursTireurSelectionneModel leander_NosCoursTireurSelectionneModel = new Leander_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return leander_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.ArthurCouturiaux:
                        ArthurCouturiaux_NosCoursTireurSelectionneModel arthurCouturiaux_NosCoursTireurSelectionneModel = new ArthurCouturiaux_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return arthurCouturiaux_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.JordanMestdagh:
                        Jordan_NosCoursTireurSelectionneModel jordan_NosCoursTireurSelectionneModel = new Jordan_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return jordan_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.MartinSiu:
                        Martin_NosCoursTireurSelectionneModel martin_NosCoursTireurSelectionneModel = new Martin_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return martin_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.RaedwaldVercouter:
                        Raedwald_NosCoursTireurSelectionneModel raedwald_NosCoursTireurSelectionneModel = new Raedwald_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return raedwald_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.AuroreCarlier:
                        Aurore_NosCoursTireurSelectionneModel aurore_NosCoursTireurSelectionneModel = new Aurore_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return aurore_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.AnaelleIvanov:
                        Anaelle_NosCoursTireurSelectionneModel anaelle_NosCoursTireurSelectionneModel = new Anaelle_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return anaelle_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.LiliMestdag:
                        Lili_NosCoursTireurSelectionneModel lili_NosCoursTireurSelectionneModel = new Lili_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return lili_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.MathildeCarette:
                        Mathilde_NosCoursTireurSelectionneModel mathilde_NosCoursTireurSelectionneModel = new Mathilde_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return mathilde_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.MaeVantroyen:
                        Mae_NosCoursTireurSelectionneModel mae_NosCoursTireurSelectionneModel = new Mae_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return mae_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.SachaLessart:
                        Sacha_NosCoursTireurSelectionneModel sacha_NosCoursTireurSelectionneModel = new Sacha_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return sacha_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.ApollineOdendhal:
                        Apolline_NosCoursTireurSelectionneModel apolline_NosCoursTireurSelectionneModel = new Apolline_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return apolline_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.AmadoSimon:
                        Amado_NosCoursTireurSelectionneModel amado_NosCoursTireurSelectionneModel = new Amado_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return amado_NosCoursTireurSelectionneModel.GetPoules;
                   
                    case IndexTireurConstantes.TireurIndex.HéloïsePras:
                        Héloïse_NosCoursTireurSelectionneModel héloïse_NosCoursTireurSelectionneModel = new Héloïse_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return héloïse_NosCoursTireurSelectionneModel.GetPoules;
                    case IndexTireurConstantes.TireurIndex.RebeccaVandy:
                        Rebecca_NosCoursTireurSelectionneModel rebecca_NosCoursTireurSelectionneModel = new Rebecca_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return rebecca_NosCoursTireurSelectionneModel.GetPoules;
                    default:
                        return new Dictionary<string, string>() { };
                }
            }

        }
        private List<RemarqueParDate> TrierParDate(List<RemarqueParDate> remarquesParDateTireur)
        {
            return remarquesParDateTireur.OrderByDescending(x=>x.DateRemarque).ToList();
        }
    } 
}