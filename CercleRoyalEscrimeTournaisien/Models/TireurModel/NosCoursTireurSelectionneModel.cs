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
                    case IndexTireurConstantes.TireurIndex.MaeVantroyen:
                        Mae_NosCoursTireurSelectionneModel mae_NosCoursTireurSelectionneModel = new Mae_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (mae_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.AmadoSimon:
                        Amado_NosCoursTireurSelectionneModel amado_NosCoursTireurSelectionneModel = new Amado_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (amado_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.RebeccaVandy:
                        Rebecca_NosCoursTireurSelectionneModel rebecca_NosCoursTireurSelectionneModel = new Rebecca_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (rebecca_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.BenedictCosentini:
                        BenedictCosentini_NosCoursTireurSelectionneModel benedict_NosCoursTireurSelectionneModel = new BenedictCosentini_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (benedict_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.ThéoCuchevalRasson:
                        Théo_NosCoursTireurSelectionneModel théo_NosCoursTireurSelectionneModel = new Théo_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (théo_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.OscarDucrot:
                        OscarDucrot_NosCoursTireurSelectionneModel oscarDucrot_NosCoursTireurSelectionneModel = new OscarDucrot_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (oscarDucrot_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.AmelLawrizy:
                        AmelLawrizy_NosCoursTireurSelectionneModel amelLawrizy_NosCoursTireurSelectionneModel = new AmelLawrizy_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (amelLawrizy_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.GwendalLecomte:
                        GwendalLecomte_NosCoursTireurSelectionneModel gwendalLecomte_NosCoursTireurSelectionneModel = new GwendalLecomte_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (gwendalLecomte_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.SolalSchrouf:
                        SolalSchrouf_NosCoursTireurSelectionneModel solalSchrouf_NosCoursTireurSelectionneModel = new SolalSchrouf_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (solalSchrouf_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.LucasVerheye:
                        LucasVerheye_NosCoursTireurSelectionneModel lucasVerheye_NosCoursTireurSelectionneModel = new LucasVerheye_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (lucasVerheye_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.RomainBracquart:
                        RomainBracquart_NosCoursTireurSelectionneModel romainBracquart_NosCoursTireurSelectionneModel = new RomainBracquart_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (romainBracquart_NosCoursTireurSelectionneModel.Categorie);
                    case IndexTireurConstantes.TireurIndex.SiméonTrovato:
                        SiméonTrovato_NosCoursTireurSelectionneModel siméonTrovato_NosCoursTireurSelectionneModel = new SiméonTrovato_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return (siméonTrovato_NosCoursTireurSelectionneModel.Categorie);
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
                        DateRemarque = new DateTime(2026, 1, 11),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Voici une autre vidéo qui montre les 5 types de parade au sabre (3 pour les débutants). Les actions sont rapides mais elles sont vues au ralenti dans la vidéo. les 3 habituelles parades (tierce, quarte, quinte) sont vues à partir de la minute 48 secondes. Celles avant cette minute 48s (parade de seconde et de prime) sont moins souvent vues en assaut mais elles existent. Cliquez<a target='_blank' href='https://www.youtube.com/watch?v=UpX5IwaAt_0'> ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },    
                        new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2026, 1, 11),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Voici une vidéo qui montre une parade de quarte suivie d'une riposte avec l'arbitrage. Elle est courte mais très facile à comprendre. Cliquez<a target='_blank' href='https://www.youtube.com/watch?v=T6pxldWGsM4'> ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2026, 1, 11),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Voici une vidéo qui explique les positions de main au sabre et le passage d'une position de main à une autre. Cliquez<a target='_blank' href='https://www.youtube.com/watch?v=7tNp4ap8ZEE'> ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                       new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2026, 1, 11),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Une poule a été effectuée ce jour-là. Vous la trouverez en ligne avec les autres poules. (Amel,Lucas,Romain,Théo)",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },

                        new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2026, 1,9),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Aujourd'hui , vous étiez nombreux à reprendre après les fêtes.</br></br> "+
                                        "Je vais essayer de résumer ce que j'ai vu à la salle.</br>" +
                                        "Vous avez habituellement une série de poules à suivre. Aujourd'hui c'était deux, demain cà sera peut-être trois. Aujourd'hui c'était individuellement, demain cela pourrait être par équipes.</br></br>" + 
                                        "L'ordre des matchs est important. Il permet par exemple de ne pas tirer 2x d'affilée, d'écrire le score obtenu dans son cahier, de se faire une auto-évaluation de ce qui a été et de ce qui n'a pas été. </br>" + 
                                        "Ce que vous écrivez ne doit pas être un roman; juste quelques mots clés, des points d'attention du genre, des scores : </br>" +
                                        "Par exemple : </br>" +
                                        "Je gagne parce que j'ai touché à cet endroit-là. </br>" +
                                        "Je perds parce que j'ai trop attaqué. </br>" +
                                        "j'ai perdu mon match en 15 secondes.</br></br> "+
                                        "Au sabre, on distincte principalement 2 types de tireurs : les attaquants et les défenseurs.</br>" + 
                                        "Les attaquants vont chercher la touche sans toucher le fer adverse avec le bras qui s'allonge ou qui est allongé.</br>"+
                                        "Les défenseurs subissent 1 attaque, ils ont leur bras fléchi essayant de faire une parade et bien sûr la riposte qui devrait suivre toujours après une parade.</br>" +
                                        "La seule façon de récupérer la priorité après 1 parade, c'est de refaire une parade.</br></br>" + 
                                        "Ce que je vois quand j'observe vos matchs, c'est le fait de ne pas prendre votre temps dans les 3 minutes imparties.</br>"+
                                        "Prenez votre temps, utilisez toute la longueur de la piste, changez de rythme souvent (ne rien faire pendant quelques secondes, attaquer d'un coup), n'attaquez pas quand vous tirez contre quelqu'un de plus fort que vous, ne faites pas la même action perdante 2x d'affilée."
                                     ,PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                     new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 12,12),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Je vous propose aujourd'hui un petit pdf qui explique l'épée avec quelques constatations que j'ai vues à la salle. Cliquez<a target='_blank' href='/FileToUpload/NosCours/l épée.pps'> ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                          new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 12,12),
                        Arme = TypeArme.Fleuret,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Voici quelques photos de matériel que vous utilisez quotidiennement. Cliquez<a target='_blank' href='/FileToUpload/NosCours/Quelques photos diverses.pps'> ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                        new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 12,10),
                        Arme = TypeArme.Fleuret,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Voici un pdf qui essaie d'expliquer le fleuret et la priorité. Cliquez<a target='_blank' href='/FileToUpload/NosCours/Le fleuret.pps'> ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                        
                        new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 12,7),
                        Arme = TypeArme.Fleuret,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Voici un pdf qui explique l'appareil et la télécommande. Cliquez<a target='_blank' href='/FileToUpload/NosCours/appareil.pps'> ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                        new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 12, 6),
                        Arme = TypeArme.Fleuret,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Voici encore une vidéo sur l'arbitrage au fleuret. Cliquez<a target='_blank' href='https://www.youtube.com/watch?v=GK9JG3b5cWs'> ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                         new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 12, 6),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Voici une vidéo qui explique l'arbitrage (première vidéo). Cliquez <a target='_blank' href='https://www.youtube.com/watch?v=ui-vLt2U63M'>ici</a>. </br> Voici une autre vidéo expliquant les gestes au fleuret/sabre. Cliquez <a target='_blank' href='https://www.youtube.com/watch?v=4IooMLN1SU8'>ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    }, new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 12, 6),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Voici une vidéo qui explique les attaques simples au fleuret. Cliquez<a target='_blank' href='https://www.youtube.com/watch?v=CbeKK_atvQY'> ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                        new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 12, 6),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Voici une vidéo qui explique les positions de main au fleuret. Cliquez<a target='_blank' href='https://www.youtube.com/watch?v=mFYFQ8clY80'> ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                        new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 12, 6),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Voici une vidéo qui explique certaines phrases d'arme difficiles à comprendre pour l'arbitre. Cliquez<a target='_blank' href='https://www.youtube.com/watch?v=PDK673_NLmE'> ici</a>",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    },
                    new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 11, 16),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Un document a été rajouté dans les poules terminées. c'est un document qui sert non seulement aux poules et qui va vous permettre de progresser." + "</br>" + "Toutes les questions devraient se poser après chaque match. Le nom dans la liste des poules est 'Questions après chaque match'",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    }, 
                        new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 11, 16),
                        Arme = TypeArme.Epée,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "2 poules ont été effectuées ce jour-là. Vous les trouverez en ligne avec les autres poules.",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    }, 
                        new RemarqueParDate()
                    {
                        DateRemarque = new DateTime(2025, 11, 14),
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
                        DateRemarque = new DateTime(2025, 11, 9),
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
                        DateRemarque = new DateTime(2025, 11, 7),
                        Arme = TypeArme.Sabre,
                        RemarquesData = new List<RemarqueData>()
                        {
                            new RemarqueData()
                            {
                                Remarque = "Une poule a été effectuée ce jour-là. Vous la trouverez en ligne avec les autres poules.",
                                     PointPositifNégatifObservation = PointPositifNégatifObservation.Observation,
                           }
                        }
                    }, new RemarqueParDate()
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
                    case IndexTireurConstantes.TireurIndex.MaeVantroyen:
                        Mae_NosCoursTireurSelectionneModel mae_NosCoursTireurSelectionneModel = new Mae_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(mae_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.AmadoSimon:
                        Amado_NosCoursTireurSelectionneModel amado_NosCoursTireurSelectionneModel = new Amado_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(amado_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.RebeccaVandy:
                        Rebecca_NosCoursTireurSelectionneModel rebecca_NosCoursTireurSelectionneModel = new Rebecca_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(rebecca_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.BenedictCosentini:
                        BenedictCosentini_NosCoursTireurSelectionneModel benedictCosentini_NosCoursTireurSelectionneModel = new BenedictCosentini_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(benedictCosentini_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.ThéoCuchevalRasson:
                        Théo_NosCoursTireurSelectionneModel théo_NosCoursTireurSelectionneModel = new Théo_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(théo_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.OscarDucrot:
                        OscarDucrot_NosCoursTireurSelectionneModel oscarDucrot_NosCoursTireurSelectionneModel = new OscarDucrot_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(oscarDucrot_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.AmelLawrizy:
                        AmelLawrizy_NosCoursTireurSelectionneModel amelLawrizy_NosCoursTireurSelectionneModel = new AmelLawrizy_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(amelLawrizy_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.GwendalLecomte:
                        GwendalLecomte_NosCoursTireurSelectionneModel gwendalLecomte_NosCoursTireurSelectionneModel = new GwendalLecomte_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(gwendalLecomte_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.SolalSchrouf:
                        SolalSchrouf_NosCoursTireurSelectionneModel solalSchrouf_NosCoursTireurSelectionneModel = new SolalSchrouf_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(solalSchrouf_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.LucasVerheye:
                        LucasVerheye_NosCoursTireurSelectionneModel lucasVerheye_NosCoursTireurSelectionneModel = new LucasVerheye_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(lucasVerheye_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.RomainBracquart:
                        RomainBracquart_NosCoursTireurSelectionneModel romainBracquart_NosCoursTireurSelectionneModel = new RomainBracquart_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(romainBracquart_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
                    case IndexTireurConstantes.TireurIndex.SiméonTrovato:
                        SiméonTrovato_NosCoursTireurSelectionneModel siméonTrovato_NosCoursTireurSelectionneModel = new SiméonTrovato_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return TrierParDate(siméonTrovato_NosCoursTireurSelectionneModel.RemarquesParDateTireur);
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
            if (value.IndexOf("Poule") == -1)
            {
                return value;
            }

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
                    { "/Poules/Poule 2026-01-11 Sabre.pdf", "Poule 2026-01-11 Sabre"  },                    
                    { "/Poules/Questions après chaque match.docx","Questions après chaque match" },
                    { "/Poules/Poule 2025-11-16 Débutants Epée.pdf","Poule 2025-11-16 Débutants Epée" },
                    { "/Poules/Poule 2025-11-16 Epée.pdf","Poule 2025-11-16 Epée" },
                    { "/Poules/Poule 2025-11-14 Epee.pdf","Poule 2025-11-14 Epee" },
                    { "/Poules/Poule 2025-11-09 Sabre.pdf","Poule 2025-11-09 Sabre" },
                    { "/Poules/Poule 2025-11-07 Sabre.pdf","Poule 2025-11-07 Sabre" },
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
                    case IndexTireurConstantes.TireurIndex.MaeVantroyen:
                        Mae_NosCoursTireurSelectionneModel mae_NosCoursTireurSelectionneModel = new Mae_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return mae_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.AmadoSimon:
                        Amado_NosCoursTireurSelectionneModel amado_NosCoursTireurSelectionneModel = new Amado_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return amado_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, y=>y.Value);
                    case IndexTireurConstantes.TireurIndex.RebeccaVandy:
                        Rebecca_NosCoursTireurSelectionneModel rebecca_NosCoursTireurSelectionneModel = new Rebecca_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return rebecca_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
                    case IndexTireurConstantes.TireurIndex.BenedictCosentini:
                        BenedictCosentini_NosCoursTireurSelectionneModel benedictCosentini_NosCoursTireurSelectionneModel = new BenedictCosentini_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return benedictCosentini_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
                    case IndexTireurConstantes.TireurIndex.ThéoCuchevalRasson:
                        Théo_NosCoursTireurSelectionneModel théoCuchevalRasson_NosCoursTireurSelectionneModel = new Théo_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return théoCuchevalRasson_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
                    case IndexTireurConstantes.TireurIndex.OscarDucrot:
                        OscarDucrot_NosCoursTireurSelectionneModel oscarDucrot_NosCoursTireurSelectionneModel = new OscarDucrot_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return oscarDucrot_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
                    case IndexTireurConstantes.TireurIndex.AmelLawrizy:
                        AmelLawrizy_NosCoursTireurSelectionneModel amelLawrizy_NosCoursTireurSelectionneModel = new AmelLawrizy_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return amelLawrizy_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
                    case IndexTireurConstantes.TireurIndex.GwendalLecomte:
                        GwendalLecomte_NosCoursTireurSelectionneModel gwendalLecomte_NosCoursTireurSelectionneModel = new GwendalLecomte_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return gwendalLecomte_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
                    case IndexTireurConstantes.TireurIndex.SolalSchrouf:
                        SolalSchrouf_NosCoursTireurSelectionneModel solalSchrouf_NosCoursTireurSelectionneModel = new SolalSchrouf_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return solalSchrouf_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
                    case IndexTireurConstantes.TireurIndex.LucasVerheye:
                        LucasVerheye_NosCoursTireurSelectionneModel lucasVerheye_NosCoursTireurSelectionneModel = new LucasVerheye_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return lucasVerheye_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
                    case IndexTireurConstantes.TireurIndex.RomainBracquart:
                        RomainBracquart_NosCoursTireurSelectionneModel romainBracquart_NosCoursTireurSelectionneModel = new RomainBracquart_NosCoursTireurSelectionneModel(TireurSelectionne) { };
                        return romainBracquart_NosCoursTireurSelectionneModel.GetPoules.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
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