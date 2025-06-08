using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebGrease.Css.Ast.Selectors;
using static CercleRoyalEscrimeTournaisien.PointPositifNégatifObservationConstantes;

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

        public Categorie Categorie {
            get
            {
                switch (TireurSelectionne.UserNameIndex)
                {
                    case IndexTireurConstantes.TireurIndex.EloiBinois:
                        Eloi_NosCoursTireurSelectionneModel eloi_NosCoursTireurSelectionneModel = new Eloi_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return eloi_NosCoursTireurSelectionneModel.Categorie;
                    case IndexTireurConstantes.TireurIndex.EvaDufrasne:
                        Eva_NosCoursTireurSelectionneModel eva_NosCoursTireurSelectionneModel = new Eva_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (eva_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.LouisonBinois:
                        Louison_NosCoursTireurSelectionneModel louison_NosCoursTireurSelectionneModel = new Louison_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (louison_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.RémiSoyez:
                        Remi_NosCoursTireurSelectionneModel remi_NosCoursTireurSelectionneModel = new Remi_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (remi_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.ElodieMass:
                        Elodie_NosCoursTireurSelectionneModel elodie_NosCoursTireurSelectionneModel = new Elodie_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (elodie_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.FélixTrannoy:
                        Felix_NosCoursTireurSelectionneModel felix_NosCoursTireurSelectionneModel = new Felix_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (felix_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.OscarDeblocq:
                        Oscar_NosCoursTireurSelectionneModel oscar_NosCoursTireurSelectionneModel = new Oscar_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (oscar_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.MaybelleCarlier:
                        Maybelle_NosCoursTireurSelectionneModel maybelle_NosCoursTireurSelectionneModel = new Maybelle_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (maybelle_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.FabriceRazanajao:
                        Fabrice_NosCoursTireurSelectionneModel fabrice_NosCoursTireurSelectionneModel = new Fabrice_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (fabrice_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.AbelMotte:
                        Abel_NosCoursTireurSelectionneModel abel_NosCoursTireurSelectionneModel = new Abel_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (abel_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.BaptisteMotte:
                        Baptiste_NosCoursTireurSelectionneModel baptiste_NosCoursTireurSelectionneModel = new Baptiste_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (baptiste_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.EliotPunchoo:
                        Eliot_NosCoursTireurSelectionneModel Eliot_NosCoursTireurSelectionneModel = new Eliot_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (Eliot_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.ArthurBarbery:
                        ArthurBarbery_NosCoursTireurSelectionneModel arthurBarbery_NosCoursTireurSelectionneModel = new ArthurBarbery_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (arthurBarbery_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.LeanderCle:
                        Leander_NosCoursTireurSelectionneModel leander_NosCoursTireurSelectionneModel = new Leander_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (leander_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.ArthurCouturiaux:
                        ArthurCouturiaux_NosCoursTireurSelectionneModel arthurCouturiaux_NosCoursTireurSelectionneModel = new ArthurCouturiaux_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (arthurCouturiaux_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.JordanMestdagh:
                        Jordan_NosCoursTireurSelectionneModel jordan_NosCoursTireurSelectionneModel = new Jordan_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (jordan_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.MartinSiu:
                        Martin_NosCoursTireurSelectionneModel martin_NosCoursTireurSelectionneModel = new Martin_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (martin_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.RaedwaldVercouter:
                        Raedwald_NosCoursTireurSelectionneModel raedwald_NosCoursTireurSelectionneModel = new Raedwald_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (raedwald_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.AuroreCarlier:
                        Aurore_NosCoursTireurSelectionneModel aurore_NosCoursTireurSelectionneModel = new Aurore_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (aurore_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.AnaelleIvanov:
                        Anaelle_NosCoursTireurSelectionneModel anaelle_NosCoursTireurSelectionneModel = new Anaelle_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (anaelle_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.LiliMestdag:
                        Lili_NosCoursTireurSelectionneModel lili_NosCoursTireurSelectionneModel = new Lili_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (lili_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.MathildeCarette:
                        Mathilde_NosCoursTireurSelectionneModel mathilde_NosCoursTireurSelectionneModel = new Mathilde_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (mathilde_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.MaeVantroyen:
                        Mae_NosCoursTireurSelectionneModel mae_NosCoursTireurSelectionneModel = new Mae_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (mae_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.SachaLessart:
                        Sacha_NosCoursTireurSelectionneModel sacha_NosCoursTireurSelectionneModel = new Sacha_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (sacha_NosCoursTireurSelectionneModel.Categorie);
                    //case IndexTireurConstantes.TireurIndex.ApollineOdendhal:
                    //    Apolline_NosCoursTireurSelectionneModel apolline_NosCoursTireurSelectionneModel = new Apolline_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                    //    return TrierParDate(apolline_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.AmadoSimon:
                        Amado_NosCoursTireurSelectionneModel amado_NosCoursTireurSelectionneModel = new Amado_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (amado_NosCoursTireurSelectionneModel.Categorie);

                    case IndexTireurConstantes.TireurIndex.HéloïsePras:
                        Héloïse_NosCoursTireurSelectionneModel héloïse_NosCoursTireurSelectionneModel = new Héloïse_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (héloïse_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.RebeccaVandy:
                        Rebecca_NosCoursTireurSelectionneModel rebecca_NosCoursTireurSelectionneModel = new Rebecca_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (rebecca_NosCoursTireurSelectionneModel.Categorie);
                    default:
                        return Categorie.Inconnu;
                }
            }
        }
        public bool HasMale { get; set; }
        public string PouleSelectionnee { get; set; }
        public Tireur TireurSelectionne { get; set; }
        public List<RemarqueParDate> RemarquesPourTousLesTireursParDate
        {
            get
            {
                ToutTireur_NosCoursTireurSelectionneModel toutTireur_NosCoursTireurSelectionneModel = new ToutTireur_NosCoursTireurSelectionneModel() { };
                return toutTireur_NosCoursTireurSelectionneModel.RemarquesParDateTireur;
            }
        }

        public List<RemarqueParDate> RemarquesParDateNewLook
        {
            get
            {
                List<RemarqueParDate> remarqueParDateList = new List<RemarqueParDate>() {};
                remarqueParDateList.AddRange(RemarquesParDate);
                remarqueParDateList.AddRange(RemarquesPourTousLesTireursParDate);
                remarqueParDateList.AddRange(RemarquesPourToutesLesPoules);
                return remarqueParDateList.OrderByDescending(x => x.DateRemarque).ToList();
            }
        }

        private List<RemarqueParDate> RemarquesPourToutesLesPoules
        {
            get
            {
                List<RemarqueParDate> remarquesPourToutesLesPoules = new List<RemarqueParDate>() { };
                remarquesPourToutesLesPoules.AddRange(
                    new List<RemarqueParDate>() {
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 6, 6),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Une poule a été effectuée ce jour-là. Vous la trouverez en ligne avec les autres poules.",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                        new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 3, 28),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Une poule a été effectuée ce jour-là. Vous la trouverez en ligne avec les autres poules.",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                     new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 2, 2),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Une poule a été effectuée ce jour-là. Vous la trouverez en ligne avec les autres poules.",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                        new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 1, 19),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Une poule a été effectuée ce jour-là. Vous la trouverez en ligne avec les autres poules.",
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                            }
                        }
                    },
                  
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 3, 12),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Une poule a été effectuée ce jour-là. Vous la trouverez en ligne avec les autres poules.",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 3, 14),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Une poule a été effectuée ce jour-là. Vous la trouverez en ligne avec les autres poules.",
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                            }
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 3, 16),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Une poule a été effectuée ce jour-là. Vous la trouverez en ligne avec les autres poules.",
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                            }
                        }
                    },
                  
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 1, 24),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Une poule a été effectuée ce jour-là. Vous la trouverez en ligne avec les autres poules.",
                                    PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                            }
                        }
                    }
                    }
                    );

                return remarquesPourToutesLesPoules;
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
                    //case IndexTireurConstantes.TireurIndex.ApollineOdendhal:
                    //    Apolline_NosCoursTireurSelectionneModel apolline_NosCoursTireurSelectionneModel = new Apolline_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                    //    return TrierParDate(apolline_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
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

        public IDictionary<string, string > PoulesFormatted
        {
            get
            {
                PouleSelectionnee = "";

                IDictionary<string, string> essai = new Dictionary<string, string>() { };
                foreach (var poule in PoulesNew)
                {
                    essai.Add(poule.Key, TransformPoule(poule.Value) );
                }

                return essai;
            }
        }

        private string TransformPoule(string value)
        {
            if (string.IsNullOrEmpty(value)) { return value; }
            string[] array = value.Split(' ');
            string[] array2 = array[1].Split('-');
            string valueNew = array[0] + " " + array2[2] + "-" + array2[1] + "-" + array2[0] + " " + array[2];
            if (array.Length  > 3) { valueNew = valueNew + " " + array[3]; }
            return valueNew;
        }
        public IDictionary<string, string> PoulesNew
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "", ""  },
                    { "/Poules/Poule 2025-02-02 Epée.pdf", "Poule 2025-02-02 Epée"  },
                    { "/Poules/Poule 2025-03-16 Epée.pdf", "Poule 2025-03-16 Epée"  },
                    { "/Poules/Poule 2025-03-28 Sabre.pdf", "Poule 2025-03-28 Sabre"  },
                    { "/Poules/Poule 2025-01-19 Sabre.pdf", "Poule 2025-01-19 Sabre"  },
                    { "/Poules/Poule 2025-01-24 Epée Grand.pdf", "Poule 2025-01-24 Epée Grand"  },
                    { "/Poules/Poule 2025-03-14 Epée.pdf", "Poule 2025-03-14 Epée"  },
                    { "/Poules/Poule 2025-03-12 Epée.pdf", "Poule 2025-03-12 Epée"  },
                    { "/Poules/Constatations 2025-03-28 Elodie.pdf", "Constatations 2025-03-28 Elodie"  },
                    { "/Poules/Poule 2025-01-24 Epée.pdf", "Poule 2025-01-24 Epée"  },
                    { "/Poules/poule 2025-05-16 Epée grands.pdf", "poule 2025-05-16 Epée grands"  },
                    { "/Poules/poule 2025-05-16 Epée petits.pdf", "poule 2025-05-16 Epée petits"  },
                    { "/Poules/poule 2025-06-06 Sabre.pdf", "poule 2025-06-06 Sabre"  },
                }.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);               
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
                        return eloi_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.EvaDufrasne:
                        Eva_NosCoursTireurSelectionneModel eva_NosCoursTireurSelectionneModel = new Eva_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return eva_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.LouisonBinois:
                        Louison_NosCoursTireurSelectionneModel louison_NosCoursTireurSelectionneModel = new Louison_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return louison_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.RémiSoyez:
                        Remi_NosCoursTireurSelectionneModel remi_NosCoursTireurSelectionneModel = new Remi_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return remi_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.ElodieMass:
                        Elodie_NosCoursTireurSelectionneModel elodie_NosCoursTireurSelectionneModel = new Elodie_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return elodie_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.FélixTrannoy:
                        Felix_NosCoursTireurSelectionneModel felix_NosCoursTireurSelectionneModel = new Felix_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return felix_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.OscarDeblocq:
                        Oscar_NosCoursTireurSelectionneModel oscar_NosCoursTireurSelectionneModel = new Oscar_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return oscar_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.MaybelleCarlier:
                        Maybelle_NosCoursTireurSelectionneModel maybelle_NosCoursTireurSelectionneModel = new Maybelle_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return maybelle_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.FabriceRazanajao:
                        Fabrice_NosCoursTireurSelectionneModel fabrice_NosCoursTireurSelectionneModel = new Fabrice_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return fabrice_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.AbelMotte:
                        Abel_NosCoursTireurSelectionneModel abel_NosCoursTireurSelectionneModel = new Abel_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return abel_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.BaptisteMotte:
                        Baptiste_NosCoursTireurSelectionneModel baptiste_NosCoursTireurSelectionneModel = new Baptiste_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return baptiste_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.EliotPunchoo:
                        Eliot_NosCoursTireurSelectionneModel Eliot_NosCoursTireurSelectionneModel = new Eliot_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return Eliot_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.ArthurBarbery:
                        ArthurBarbery_NosCoursTireurSelectionneModel arthurBarbery_NosCoursTireurSelectionneModel = new ArthurBarbery_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return arthurBarbery_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.LeanderCle:
                        Leander_NosCoursTireurSelectionneModel leander_NosCoursTireurSelectionneModel = new Leander_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return leander_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.ArthurCouturiaux:
                        ArthurCouturiaux_NosCoursTireurSelectionneModel arthurCouturiaux_NosCoursTireurSelectionneModel = new ArthurCouturiaux_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return arthurCouturiaux_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.JordanMestdagh:
                        Jordan_NosCoursTireurSelectionneModel jordan_NosCoursTireurSelectionneModel = new Jordan_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return jordan_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.MartinSiu:
                        Martin_NosCoursTireurSelectionneModel martin_NosCoursTireurSelectionneModel = new Martin_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return martin_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.RaedwaldVercouter:
                        Raedwald_NosCoursTireurSelectionneModel raedwald_NosCoursTireurSelectionneModel = new Raedwald_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return raedwald_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.AuroreCarlier:
                        Aurore_NosCoursTireurSelectionneModel aurore_NosCoursTireurSelectionneModel = new Aurore_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return aurore_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.AnaelleIvanov:
                        Anaelle_NosCoursTireurSelectionneModel anaelle_NosCoursTireurSelectionneModel = new Anaelle_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return anaelle_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.LiliMestdag:
                        Lili_NosCoursTireurSelectionneModel lili_NosCoursTireurSelectionneModel = new Lili_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return lili_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.MathildeCarette:
                        Mathilde_NosCoursTireurSelectionneModel mathilde_NosCoursTireurSelectionneModel = new Mathilde_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return mathilde_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.MaeVantroyen:
                        Mae_NosCoursTireurSelectionneModel mae_NosCoursTireurSelectionneModel = new Mae_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return mae_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.SachaLessart:
                        Sacha_NosCoursTireurSelectionneModel sacha_NosCoursTireurSelectionneModel = new Sacha_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return sacha_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    //case IndexTireurConstantes.TireurIndex.ApollineOdendhal:
                    //    Apolline_NosCoursTireurSelectionneModel apolline_NosCoursTireurSelectionneModel = new Apolline_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                    //    return apolline_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.AmadoSimon:
                        Amado_NosCoursTireurSelectionneModel amado_NosCoursTireurSelectionneModel = new Amado_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return amado_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                   
                    case IndexTireurConstantes.TireurIndex.HéloïsePras:
                        Héloïse_NosCoursTireurSelectionneModel héloïse_NosCoursTireurSelectionneModel = new Héloïse_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return héloïse_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.RebeccaVandy:
                        Rebecca_NosCoursTireurSelectionneModel rebecca_NosCoursTireurSelectionneModel = new Rebecca_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return rebecca_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
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