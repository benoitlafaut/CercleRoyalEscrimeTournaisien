using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class Paiements_2024_2025
    {
        public JoursDePrésence ChargerPresences()
        {
            JoursDePrésence joursDePrésence = new JoursDePrésence()
            {
                //GuidConstantes.GuidMartinSiu,
                //GuidConstantes.GuidFélixTrannoy,
                //GuidConstantes.GuidAuroreCarlier,
                //GuidConstantes.GuidAnaelleIvanov,
                //GuidConstantes.GuidLiliMestdag,
                //GuidConstantes.GuidMathildeCarette,
                //GuidConstantes.GuidAmadoSimon,
                //GuidConstantes.GuidEloiBinois,
                //GuidConstantes.GuidLouisonBinois,
                //GuidConstantes.GuidOscarDeblocq,
                //GuidConstantes.GuidArthurBarbery,
                //GuidConstantes.GuidJordanMestdagh,
                //GuidConstantes.GuidRémiSoyez,
                //GuidConstantes.GuidRaedwaldVercouter,
                //GuidConstantes.GuidMaybelleCarlier,
                //GuidConstantes.GuidFabriceRazanajao,
                //GuidConstantes.GuidBaptisteMotte,
                //GuidConstantes.GuidAbelMotte,
                //GuidConstantes.GuidMaeVantroyen,
                //GuidConstantes.GuidSachaLessart,
                //GuidConstantes.GuidEvaDufrasne,
                //GuidConstantes.GuidHéloïsePras,
                //GuidConstantes.GuidElodieMass,
                //GuidConstantes.GuidRebeccaVandy,
                //GuidConstantes.GuidEliotPunchoo,
                //GuidConstantes.GuidNoelMarieDransart

                JourDePrésence = new List<JourDePrésence>()
                {
                     new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,27),
                         EscrimeurId = new List<Guid>()
                         {
                      //GuidConstantes.GuidMartinSiu,
                //GuidConstantes.GuidFélixTrannoy,
                //GuidConstantes.GuidAuroreCarlier,
                //GuidConstantes.GuidAnaelleIvanov,
                //GuidConstantes.GuidLiliMestdag,
                //GuidConstantes.GuidMathildeCarette,
                //GuidConstantes.GuidAmadoSimon,
                //GuidConstantes.GuidEloiBinois,
                //GuidConstantes.GuidLouisonBinois,
                GuidConstantes.GuidOscarDeblocq,
                //GuidConstantes.GuidArthurBarbery,
                //GuidConstantes.GuidJordanMestdagh,
                //GuidConstantes.GuidRémiSoyez,
                //GuidConstantes.GuidRaedwaldVercouter,
                //GuidConstantes.GuidMaybelleCarlier,
                GuidConstantes.GuidFabriceRazanajao,
                GuidConstantes.GuidBaptisteMotte,
                GuidConstantes.GuidAbelMotte,
                GuidConstantes.GuidMaeVantroyen,
                //GuidConstantes.GuidSachaLessart,
                //GuidConstantes.GuidEvaDufrasne,
                //GuidConstantes.GuidHéloïsePras,
                //GuidConstantes.GuidElodieMass,
                GuidConstantes.GuidRebeccaVandy,
                GuidConstantes.GuidEliotPunchoo,
                GuidConstantes.GuidNoelMarieDransart
                         }
                     },
                      new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,25),
                         EscrimeurId = new List<Guid>()
                         {
                       //GuidConstantes.GuidMartinSiu,
                //GuidConstantes.GuidFélixTrannoy,
                //GuidConstantes.GuidAuroreCarlier,
                //GuidConstantes.GuidAnaelleIvanov,
                //GuidConstantes.GuidLiliMestdag,
                GuidConstantes.GuidMathildeCarette,
                GuidConstantes.GuidAmadoSimon,
                GuidConstantes.GuidEloiBinois,
                GuidConstantes.GuidLouisonBinois,
                //GuidConstantes.GuidOscarDeblocq,
                GuidConstantes.GuidArthurBarbery,
                //GuidConstantes.GuidJordanMestdagh,
                GuidConstantes.GuidRémiSoyez,
                //GuidConstantes.GuidRaedwaldVercouter,
                //GuidConstantes.GuidMaybelleCarlier,
                GuidConstantes.GuidFabriceRazanajao,
                GuidConstantes.GuidBaptisteMotte,
                //GuidConstantes.GuidAbelMotte,
                GuidConstantes.GuidMaeVantroyen,
                GuidConstantes.GuidSachaLessart,
                //GuidConstantes.GuidEvaDufrasne,
                //GuidConstantes.GuidHéloïsePras,
                GuidConstantes.GuidElodieMass,
                //GuidConstantes.GuidRebeccaVandy,
                GuidConstantes.GuidEliotPunchoo,
                GuidConstantes.GuidNoelMarieDransart
                         }
                     },
                      new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,23),
                         EscrimeurId = new List<Guid>()
                         {
                       GuidConstantes.GuidMartinSiu,
                GuidConstantes.GuidFélixTrannoy,
                //GuidConstantes.GuidAuroreCarlier,
                GuidConstantes.GuidAnaelleIvanov,
                GuidConstantes.GuidLiliMestdag,
                GuidConstantes.GuidMathildeCarette,
                //GuidConstantes.GuidAmadoSimon,
                //GuidConstantes.GuidEloiBinois,
                //GuidConstantes.GuidLouisonBinois,
                //GuidConstantes.GuidOscarDeblocq,
                //GuidConstantes.GuidArthurBarbery,
                //GuidConstantes.GuidJordanMestdagh,
                //GuidConstantes.GuidRémiSoyez,
                //GuidConstantes.GuidRaedwaldVercouter,
                //GuidConstantes.GuidMaybelleCarlier,
                //GuidConstantes.GuidFabriceRazanajao,
                GuidConstantes.GuidBaptisteMotte,
                GuidConstantes.GuidAbelMotte,
                GuidConstantes.GuidMaeVantroyen,
                //GuidConstantes.GuidSachaLessart,
                //GuidConstantes.GuidEvaDufrasne,
                GuidConstantes.GuidHéloïsePras,
                //GuidConstantes.GuidElodieMass,
                GuidConstantes.GuidRebeccaVandy,
                GuidConstantes.GuidEliotPunchoo,
                GuidConstantes.GuidNoelMarieDransart
                         }
                     },
                     new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,20),
                         EscrimeurId = new List<Guid>()
                         {
                            //GuidConstantes.GuidMartinSiu,
                //GuidConstantes.GuidFélixTrannoy,
                GuidConstantes.GuidAuroreCarlier,
                //GuidConstantes.GuidAnaelleIvanov,
                //GuidConstantes.GuidLiliMestdag,
                //GuidConstantes.GuidMathildeCarette,
                //GuidConstantes.GuidAmadoSimon,
                //GuidConstantes.GuidEloiBinois,
                //GuidConstantes.GuidLouisonBinois,
                //GuidConstantes.GuidOscarDeblocq,
                GuidConstantes.GuidArthurBarbery,
                GuidConstantes.GuidJordanMestdagh,
                //GuidConstantes.GuidRémiSoyez,
                GuidConstantes.GuidRaedwaldVercouter,
                //GuidConstantes.GuidMaybelleCarlier,
                //GuidConstantes.GuidFabriceRazanajao,
                //GuidConstantes.GuidBaptisteMotte,
                //GuidConstantes.GuidAbelMotte,
                //GuidConstantes.GuidMaeVantroyen,
                //GuidConstantes.GuidSachaLessart,
                //GuidConstantes.GuidEvaDufrasne,
                //GuidConstantes.GuidHéloïsePras,
                //GuidConstantes.GuidElodieMass,
                GuidConstantes.GuidRebeccaVandy,
                GuidConstantes.GuidEliotPunchoo,
                //GuidConstantes.GuidNoelMarieDransart
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,18),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            //GuidConstantes.GuidAuroreCarlier,
                            //GuidConstantes.GuidAnaelleIvanov,
                            //GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidMathildeCarette,
                            //GuidConstantes.GuidAmadoSimon,
                            //GuidConstantes.GuidEloiBinois,
                            //GuidConstantes.GuidLouisonBinois,
                            GuidConstantes.GuidOscarDeblocq,
                            //GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidRaedwaldVercouter,
                            //GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidMaeVantroyen,
                            //GuidConstantes.GuidSachaLessart,
                            //GuidConstantes.GuidEvaDufrasne,
                            //GuidConstantes.GuidHéloïsePras,
                            GuidConstantes.GuidElodieMass,
                            //GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidEliotPunchoo,
                            GuidConstantes.GuidNoelMarieDransart
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,16),
                         EscrimeurId = new List<Guid>()
                         {
                                GuidConstantes.GuidMartinSiu,
                                GuidConstantes.GuidFélixTrannoy,
                                GuidConstantes.GuidAuroreCarlier,
                                GuidConstantes.GuidAnaelleIvanov,
                                //GuidConstantes.GuidLiliMestdag,
                                GuidConstantes.GuidMathildeCarette,
                                GuidConstantes.GuidAmadoSimon,
                                //GuidConstantes.GuidEloiBinois,
                                //GuidConstantes.GuidLouisonBinois,
                                //GuidConstantes.GuidOscarDeblocq,
                                //GuidConstantes.GuidArthurBarbery,
                                //GuidConstantes.GuidJordanMestdagh,
                                GuidConstantes.GuidRémiSoyez,
                                //GuidConstantes.GuidRaedwaldVercouter,
                                //GuidConstantes.GuidMaybelleCarlier,
                                //GuidConstantes.GuidFabriceRazanajao,
                                GuidConstantes.GuidBaptisteMotte,
                                //GuidConstantes.GuidAbelMotte,
                                GuidConstantes.GuidMaeVantroyen,
                                //GuidConstantes.GuidSachaLessart,
                                //GuidConstantes.GuidEvaDufrasne,
                                //GuidConstantes.GuidHéloïsePras,
                                GuidConstantes.GuidElodieMass,
                                GuidConstantes.GuidRebeccaVandy,
                                GuidConstantes.GuidEliotPunchoo,
                                GuidConstantes.GuidNoelMarieDransart

                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,13),
                         EscrimeurId = new List<Guid>()
                         {
                              //GuidConstantes.GuidMartinSiu,
                GuidConstantes.GuidFélixTrannoy,
                //GuidConstantes.GuidAuroreCarlier,
                //GuidConstantes.GuidAnaelleIvanov,
                //GuidConstantes.GuidLiliMestdag,
                //GuidConstantes.GuidMathildeCarette,
                //GuidConstantes.GuidAmadoSimon,
                GuidConstantes.GuidEloiBinois,
                //GuidConstantes.GuidLouisonBinois,
                //GuidConstantes.GuidOscarDeblocq,
                //GuidConstantes.GuidArthurBarbery,
                GuidConstantes.GuidJordanMestdagh,
                GuidConstantes.GuidRémiSoyez,
                //GuidConstantes.GuidRaedwaldVercouter,
                //GuidConstantes.GuidMaybelleCarlier,
                GuidConstantes.GuidFabriceRazanajao,
                GuidConstantes.GuidBaptisteMotte,
                //GuidConstantes.GuidAbelMotte,
                //GuidConstantes.GuidMaeVantroyen,
                //GuidConstantes.GuidSachaLessart,
                //GuidConstantes.GuidEvaDufrasne,
                //GuidConstantes.GuidHéloïsePras,
                GuidConstantes.GuidElodieMass,
                //GuidConstantes.GuidRebeccaVandy,
                //GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,11),
                         EscrimeurId = new List<Guid>()
                         {
 GuidConstantes.GuidMartinSiu,
                GuidConstantes.GuidFélixTrannoy,
                //GuidConstantes.GuidAuroreCarlier,
                //GuidConstantes.GuidAnaelleIvanov,
                GuidConstantes.GuidLiliMestdag,
                GuidConstantes.GuidMathildeCarette,
                GuidConstantes.GuidAmadoSimon,
                GuidConstantes.GuidEloiBinois,
                GuidConstantes.GuidLouisonBinois,
                GuidConstantes.GuidOscarDeblocq,
                GuidConstantes.GuidArthurBarbery,
                //GuidConstantes.GuidJordanMestdagh,
                GuidConstantes.GuidRémiSoyez,
                //GuidConstantes.GuidRaedwaldVercouter,
                //GuidConstantes.GuidMaybelleCarlier,
                GuidConstantes.GuidFabriceRazanajao,
                //GuidConstantes.GuidBaptisteMotte,
                //GuidConstantes.GuidAbelMotte,               
                GuidConstantes.GuidMaeVantroyen,
                GuidConstantes.GuidSachaLessart,
                //GuidConstantes.GuidEvaDufrasne,
                //GuidConstantes.GuidHéloïsePras,
                GuidConstantes.GuidElodieMass,
                //GuidConstantes.GuidRebeccaVandy,
                //GuidConstantes.GuidEliotPunchoo,
                GuidConstantes.GuidNoelMarieDransart
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,9),
                         EscrimeurId = new List<Guid>()
                         {
                              GuidConstantes.GuidMartinSiu,
                GuidConstantes.GuidFélixTrannoy,
                //GuidConstantes.GuidAuroreCarlier,
                //GuidConstantes.GuidAnaelleIvanov,
                GuidConstantes.GuidLiliMestdag,
                GuidConstantes.GuidMathildeCarette,
                GuidConstantes.GuidAmadoSimon,
                //GuidConstantes.GuidEloiBinois,
                //GuidConstantes.GuidLouisonBinois,
                //GuidConstantes.GuidOscarDeblocq,
                //GuidConstantes.GuidArthurBarbery,
                //GuidConstantes.GuidJordanMestdagh,
                GuidConstantes.GuidRémiSoyez,
                //GuidConstantes.GuidRaedwaldVercouter,
                //GuidConstantes.GuidMaybelleCarlier,
                //GuidConstantes.GuidFabriceRazanajao,
                GuidConstantes.GuidBaptisteMotte,
                GuidConstantes.GuidAbelMotte,
                GuidConstantes.GuidMaeVantroyen,
                //GuidConstantes.GuidSachaLessart,
                //GuidConstantes.GuidEvaDufrasne,
                //GuidConstantes.GuidHéloïsePras,
                //GuidConstantes.GuidElodieMass,
                //GuidConstantes.GuidRebeccaVandy,
                GuidConstantes.GuidEliotPunchoo,
                GuidConstantes.GuidNoelMarieDransart
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,6),
                         EscrimeurId = new List<Guid>()
                         {
 GuidConstantes.GuidMartinSiu,
                //GuidConstantes.GuidFélixTrannoy,
                GuidConstantes.GuidAuroreCarlier,
                //GuidConstantes.GuidAnaelleIvanov,
                //GuidConstantes.GuidLiliMestdag,
                //GuidConstantes.GuidMathildeCarette,
                //GuidConstantes.GuidAmadoSimon,
                GuidConstantes.GuidEloiBinois,
                GuidConstantes.GuidLouisonBinois,
                GuidConstantes.GuidOscarDeblocq,
                GuidConstantes.GuidArthurBarbery,
                //GuidConstantes.GuidJordanMestdagh,
                GuidConstantes.GuidRémiSoyez,
                //GuidConstantes.GuidRaedwaldVercouter,
                //GuidConstantes.GuidMaybelleCarlier,
                GuidConstantes.GuidFabriceRazanajao,
                GuidConstantes.GuidBaptisteMotte,
                //GuidConstantes.GuidAbelMotte,
                GuidConstantes.GuidMaeVantroyen,
                //GuidConstantes.GuidSachaLessart,
                //GuidConstantes.GuidEvaDufrasne,
                //GuidConstantes.GuidHéloïsePras,
                //GuidConstantes.GuidElodieMass,
                GuidConstantes.GuidRebeccaVandy,
                GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,4),
                         EscrimeurId = new List<Guid>()
                         {
                            GuidConstantes.GuidMartinSiu,
                //GuidConstantes.GuidFélixTrannoy,
                GuidConstantes.GuidAuroreCarlier,
                GuidConstantes.GuidAnaelleIvanov,
                //GuidConstantes.GuidLiliMestdag,
                GuidConstantes.GuidMathildeCarette,
                GuidConstantes.GuidAmadoSimon,
                //GuidConstantes.GuidEloiBinois,
                //GuidConstantes.GuidLouisonBinois,
                //GuidConstantes.GuidOscarDeblocq,
                GuidConstantes.GuidArthurBarbery,
                //GuidConstantes.GuidJordanMestdagh,
                GuidConstantes.GuidRémiSoyez,
                GuidConstantes.GuidRaedwaldVercouter,
                //GuidConstantes.GuidMaybelleCarlier,
                GuidConstantes.GuidFabriceRazanajao,
                GuidConstantes.GuidBaptisteMotte,
                //GuidConstantes.GuidAbelMotte,
                GuidConstantes.GuidMaeVantroyen,
                GuidConstantes.GuidSachaLessart,
                //GuidConstantes.GuidEvaDufrasne,
                //GuidConstantes.GuidHéloïsePras,
                //GuidConstantes.GuidElodieMass,
                //GuidConstantes.GuidRebeccaVandy,
                GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,4,2),
                         EscrimeurId = new List<Guid>()
                         {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            //GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidAnaelleIvanov,
                            //GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidAmadoSimon,
                            //GuidConstantes.GuidEloiBinois,
                            //GuidConstantes.GuidLouisonBinois,
                            //GuidConstantes.GuidOscarDeblocq,
                            //GuidConstantes.GuidArthurBarbery,
                            //GuidConstantes.GuidJordanMestdagh,
                            //GuidConstantes.GuidRémiSoyez,
                            //GuidConstantes.GuidRaedwaldVercouter,
                            //GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidMaeVantroyen,
                            //GuidConstantes.GuidSachaLessart,
                            //GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidHéloïsePras,
                            //GuidConstantes.GuidElodieMass,
                            //GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidEliotPunchoo,   
                         }
                     },
                     new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,3,30),
                         EscrimeurId = new List<Guid>()
                         {
                                GuidConstantes.GuidMartinSiu,
                                //GuidConstantes.GuidFélixTrannoy,
                                //GuidConstantes.GuidAuroreCarlier,
                                //GuidConstantes.GuidAnaelleIvanov,
                                //GuidConstantes.GuidLiliMestdag,
                                //GuidConstantes.GuidMathildeCarette,
                                //GuidConstantes.GuidAmadoSimon,
                                GuidConstantes.GuidEloiBinois,
                                GuidConstantes.GuidLouisonBinois,
                                //GuidConstantes.GuidOscarDeblocq,
                                //GuidConstantes.GuidArthurBarbery,
                                //GuidConstantes.GuidJordanMestdagh,
                                //GuidConstantes.GuidRémiSoyez,
                                //GuidConstantes.GuidRaedwaldVercouter,
                                //GuidConstantes.GuidMaybelleCarlier,
                                //GuidConstantes.GuidFabriceRazanajao,
                                GuidConstantes.GuidBaptisteMotte,
                                GuidConstantes.GuidAbelMotte,
                                //GuidConstantes.GuidMaeVantroyen,
                                //GuidConstantes.GuidSachaLessart,
                                //GuidConstantes.GuidEvaDufrasne,
                                //GuidConstantes.GuidHéloïsePras,
                                GuidConstantes.GuidElodieMass,
                                GuidConstantes.GuidRebeccaVandy,
                                GuidConstantes.GuidEliotPunchoo, 
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,3,28),
                         EscrimeurId = new List<Guid>()
                         {
                                GuidConstantes.GuidMartinSiu,
                                GuidConstantes.GuidFélixTrannoy,
                                //GuidConstantes.GuidAuroreCarlier,
                                GuidConstantes.GuidAnaelleIvanov,
                                GuidConstantes.GuidLiliMestdag,
                                //GuidConstantes.GuidMathildeCarette,
                                //GuidConstantes.GuidAmadoSimon,
                                GuidConstantes.GuidEloiBinois,
                                GuidConstantes.GuidLouisonBinois,
                                //GuidConstantes.GuidOscarDeblocq,
                                GuidConstantes.GuidArthurBarbery,
                                GuidConstantes.GuidJordanMestdagh,
                                //GuidConstantes.GuidRémiSoyez,
                                //GuidConstantes.GuidRaedwaldVercouter,
                                //GuidConstantes.GuidMaybelleCarlier,
                                //GuidConstantes.GuidFabriceRazanajao,
                                GuidConstantes.GuidBaptisteMotte,
                                //GuidConstantes.GuidAbelMotte,
                                //GuidConstantes.GuidMaeVantroyen,
                                GuidConstantes.GuidSachaLessart,
                                //GuidConstantes.GuidEvaDufrasne,
                                //GuidConstantes.GuidHéloïsePras,
                                //GuidConstantes.GuidElodieMass,
                                //GuidConstantes.GuidRebeccaVandy,
                                GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,3,26),
                         EscrimeurId = new List<Guid>()
                         {
                                GuidConstantes.GuidMartinSiu,
                                GuidConstantes.GuidFélixTrannoy,
                                //GuidConstantes.GuidAuroreCarlier,
                                GuidConstantes.GuidAnaelleIvanov,
                                //GuidConstantes.GuidLiliMestdag,
                                GuidConstantes.GuidMathildeCarette,
                                //GuidConstantes.GuidAmadoSimon,
                                //GuidConstantes.GuidEloiBinois,
                                //GuidConstantes.GuidLouisonBinois,
                                //GuidConstantes.GuidOscarDeblocq,
                                //GuidConstantes.GuidArthurBarbery,
                                //GuidConstantes.GuidJordanMestdagh,
                                //GuidConstantes.GuidRémiSoyez,
                                //GuidConstantes.GuidRaedwaldVercouter,
                                //GuidConstantes.GuidMaybelleCarlier,
                                //GuidConstantes.GuidFabriceRazanajao,
                                GuidConstantes.GuidBaptisteMotte,
                                GuidConstantes.GuidAbelMotte,
                                GuidConstantes.GuidMaeVantroyen,
                                //GuidConstantes.GuidSachaLessart,
                                //GuidConstantes.GuidEvaDufrasne,
                                GuidConstantes.GuidHéloïsePras,
                                GuidConstantes.GuidElodieMass,
                                GuidConstantes.GuidRebeccaVandy,
                                GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,3,23),
                         EscrimeurId = new List<Guid>()
                         {
                                //GuidConstantes.GuidMartinSiu,
                                //GuidConstantes.GuidFélixTrannoy,
                                GuidConstantes.GuidAuroreCarlier,
                                //GuidConstantes.GuidAnaelleIvanov,
                                //GuidConstantes.GuidLiliMestdag,
                                //GuidConstantes.GuidMathildeCarette,
                                //GuidConstantes.GuidAmadoSimon,
                                GuidConstantes.GuidEloiBinois,
                                GuidConstantes.GuidLouisonBinois,
                                GuidConstantes.GuidOscarDeblocq,
                                GuidConstantes.GuidArthurBarbery,
                                //GuidConstantes.GuidJordanMestdagh,
                                //GuidConstantes.GuidRémiSoyez,
                                GuidConstantes.GuidRaedwaldVercouter,
                                //GuidConstantes.GuidMaybelleCarlier,
                                GuidConstantes.GuidFabriceRazanajao,
                                GuidConstantes.GuidBaptisteMotte,
                                GuidConstantes.GuidAbelMotte,
                                //GuidConstantes.GuidMaeVantroyen,
                                //GuidConstantes.GuidSachaLessart,
                                //GuidConstantes.GuidEvaDufrasne,
                                //GuidConstantes.GuidHéloïsePras,
                                GuidConstantes.GuidElodieMass,
                                GuidConstantes.GuidRebeccaVandy,
                                GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,3,21),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAuroreCarlier,
                            //GuidConstantes.GuidAnaelleIvanov,
                            //GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidAmadoSimon,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidLouisonBinois,
                            GuidConstantes.GuidOscarDeblocq,
                            //GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidRaedwaldVercouter,
                            //GuidConstantes.GuidMaybelleCarlier,
                            //GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidBaptisteMotte,
                            //GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidMaeVantroyen,
                            //GuidConstantes.GuidSachaLessart,
                            //GuidConstantes.GuidEvaDufrasne,
                            //GuidConstantes.GuidHéloïsePras,
                            //GuidConstantes.GuidElodieMass,
                            //GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,3,19),
                         EscrimeurId = new List<Guid>()
                         {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            //GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidAnaelleIvanov,
                            //GuidConstantes.GuidLiliMestdag,
                            //GuidConstantes.GuidMathildeCarette,
                            //GuidConstantes.GuidAmadoSimon,
                            //GuidConstantes.GuidEloiBinois,
                            //GuidConstantes.GuidLouisonBinois,
                            //GuidConstantes.GuidOscarDeblocq,
                            //GuidConstantes.GuidArthurBarbery,
                            //GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRémiSoyez,
                            //GuidConstantes.GuidRaedwaldVercouter,
                            //GuidConstantes.GuidMaybelleCarlier,
                            //GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidMaeVantroyen,
                            //GuidConstantes.GuidSachaLessart,
                            //GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidHéloïsePras,
                            //GuidConstantes.GuidElodieMass,
                            GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,3,16),
                         EscrimeurId = new List<Guid>()
                         {
                            //GuidConstantes.GuidMartinSiu,
                            //GuidConstantes.GuidFélixTrannoy,
                            //GuidConstantes.GuidAuroreCarlier,
                            //GuidConstantes.GuidAnaelleIvanov,
                            //GuidConstantes.GuidLiliMestdag,
                            //GuidConstantes.GuidMathildeCarette,
                            //GuidConstantes.GuidAmadoSimon,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidLouisonBinois,
                            GuidConstantes.GuidOscarDeblocq,
                            //GuidConstantes.GuidArthurBarbery,
                            //GuidConstantes.GuidJordanMestdagh,
                            //GuidConstantes.GuidRémiSoyez,
                            //GuidConstantes.GuidRaedwaldVercouter,
                            //GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidBaptisteMotte,
                            //GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidMaeVantroyen,
                            //GuidConstantes.GuidSachaLessart,
                            //GuidConstantes.GuidEvaDufrasne,
                            //GuidConstantes.GuidHéloïsePras,
                            //GuidConstantes.GuidElodieMass,
                            //GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,3,14),
                         EscrimeurId = new List<Guid>()
                         {
                            GuidConstantes.GuidMartinSiu,
                            //GuidConstantes.GuidFélixTrannoy,
                            //GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidAnaelleIvanov,
                            //GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidAmadoSimon,
                            //GuidConstantes.GuidEloiBinois,
                            //GuidConstantes.GuidLouisonBinois,
                            //GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidArthurBarbery,
                            //GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRémiSoyez,
                            //GuidConstantes.GuidRaedwaldVercouter,
                            //GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidBaptisteMotte,
                            //GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidMaeVantroyen,
                            //GuidConstantes.GuidSachaLessart,
                            //GuidConstantes.GuidEvaDufrasne,
                            //GuidConstantes.GuidHéloïsePras,
                            GuidConstantes.GuidElodieMass,
                            //GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,3,12),
                         EscrimeurId = new List<Guid>()
                         {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidAmadoSimon,
                            //GuidConstantes.GuidEloiBinois,
                            //GuidConstantes.GuidLouisonBinois,
                            //GuidConstantes.GuidOscarDeblocq,
                            //GuidConstantes.GuidArthurBarbery,
                            //GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRémiSoyez,
                            //GuidConstantes.GuidRaedwaldVercouter,
                            //GuidConstantes.GuidMaybelleCarlier,
                            //GuidConstantes.GuidFabriceRazanajao,
                            //GuidConstantes.GuidBaptisteMotte,
                            //GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidMaeVantroyen,
                            //GuidConstantes.GuidSachaLessart,
                            //GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidHéloïsePras,
                            //GuidConstantes.GuidElodieMass,
                            //GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,2,23),
                         EscrimeurId = new List<Guid>()
                         {
                            //GuidConstantes.GuidMartinSiu,
                            //GuidConstantes.GuidFélixTrannoy,
                            //GuidConstantes.GuidAuroreCarlier,
                            //GuidConstantes.GuidAnaelleIvanov,
                            //GuidConstantes.GuidLiliMestdag,
                            //GuidConstantes.GuidMathildeCarette,
                            //GuidConstantes.GuidAmadoSimon,
                            //GuidConstantes.GuidEloiBinois,
                            //GuidConstantes.GuidLouisonBinois,
                            //GuidConstantes.GuidOscarDeblocq,
                            //GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidJordanMestdagh,
                            //GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidRaedwaldVercouter,
                            //GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidMaeVantroyen,
                            //GuidConstantes.GuidSachaLessart,
                            //GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidHéloïsePras,
                            //GuidConstantes.GuidElodieMass,
                            GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,2,21),
                         EscrimeurId = new List<Guid>()
                         {
                                GuidConstantes.GuidMartinSiu,
                                GuidConstantes.GuidFélixTrannoy,
                                GuidConstantes.GuidAuroreCarlier,
                                GuidConstantes.GuidAnaelleIvanov,
                                GuidConstantes.GuidLiliMestdag,
                                //GuidConstantes.GuidMathildeCarette,
                                GuidConstantes.GuidAmadoSimon,
                                GuidConstantes.GuidEloiBinois,
                                GuidConstantes.GuidLouisonBinois,
                                //GuidConstantes.GuidOscarDeblocq,
                                //GuidConstantes.GuidArthurBarbery,
                                //GuidConstantes.GuidJordanMestdagh,
                                //GuidConstantes.GuidRémiSoyez,
                                GuidConstantes.GuidRaedwaldVercouter,
                                //GuidConstantes.GuidMaybelleCarlier,
                                GuidConstantes.GuidFabriceRazanajao,
                                //GuidConstantes.GuidBaptisteMotte,
                                //GuidConstantes.GuidAbelMotte,
                                GuidConstantes.GuidMaeVantroyen,
                                //GuidConstantes.GuidSachaLessart,
                                //GuidConstantes.GuidEvaDufrasne,
                                //GuidConstantes.GuidHéloïsePras,
                                GuidConstantes.GuidElodieMass,
                                //GuidConstantes.GuidRebeccaVandy,
                                //GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,2,19),
                         EscrimeurId = new List<Guid>()
                         {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            //GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidAnaelleIvanov,
                            //GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidAmadoSimon,
                            //GuidConstantes.GuidEloiBinois,
                            //GuidConstantes.GuidLouisonBinois,
                            //GuidConstantes.GuidOscarDeblocq,
                            //GuidConstantes.GuidArthurBarbery,
                            //GuidConstantes.GuidJordanMestdagh,
                            //GuidConstantes.GuidRémiSoyez,
                            //GuidConstantes.GuidRaedwaldVercouter,
                            //GuidConstantes.GuidMaybelleCarlier,
                            //GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidAbelMotte,
                            //GuidConstantes.GuidMaeVantroyen,
                            //GuidConstantes.GuidSachaLessart,
                            //GuidConstantes.GuidEvaDufrasne,
                            //GuidConstantes.GuidHéloïsePras,
                            //GuidConstantes.GuidElodieMass,
                            GuidConstantes.GuidRebeccaVandy,
                            //GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,2,16),
                         EscrimeurId = new List<Guid>()
                         {
                            //GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidLiliMestdag,
                            //GuidConstantes.GuidMathildeCarette,
                            //GuidConstantes.GuidAmadoSimon,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidLouisonBinois,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidArthurBarbery,
                            //GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRémiSoyez,
                            //GuidConstantes.GuidRaedwaldVercouter,
                            //GuidConstantes.GuidMaybelleCarlier,
                            //GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidBaptisteMotte,
                            GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidMaeVantroyen,
                            //GuidConstantes.GuidSachaLessart,
                            //GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidHéloïsePras,
                            GuidConstantes.GuidElodieMass,
                            //GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,2,14),
                         EscrimeurId = new List<Guid>()
                         {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            //GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidAnaelleIvanov,
                            //GuidConstantes.GuidLiliMestdag,
                            //GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidAmadoSimon,
                            //GuidConstantes.GuidEloiBinois,
                            //GuidConstantes.GuidLouisonBinois,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidArthurBarbery,
                            //GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRémiSoyez,
                            //GuidConstantes.GuidRaedwaldVercouter,
                            //GuidConstantes.GuidMaybelleCarlier,
                            //GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidBaptisteMotte,
                            //GuidConstantes.GuidAbelMotte,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidSachaLessart,
                            //GuidConstantes.GuidEvaDufrasne,
                            //GuidConstantes.GuidHéloïsePras,
                            //GuidConstantes.GuidElodieMass,
                            //GuidConstantes.GuidRebeccaVandy,
                            //GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,2,12),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,2,9),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             //GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidRaedwaldVercouter,
                             GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,2,7),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,2,2),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             //GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,1,31),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,1,29),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             //GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,1,26),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,1,24),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,1,22),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,1,19),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,1,17),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,1,15),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,1,12),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                      new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,1,10),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidSachaLessart,
                             GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                      new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2025,1,8),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2024,12,20),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             //GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                      new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2024,12,15),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2024,12,13),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidApollineOdendhal,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                      {
                         DatePrésence = new DateTime(2024,12,11),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,12,8),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,12,6),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidSachaLessart,
                             GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,12,4),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,12,1),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidRaedwaldVercouter,
                             GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                    new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,11,29),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                   new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,11,27),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },   new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,11,24),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             //GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                             GuidConstantes.GuidEliotPunchoo,
                         }
                     },
                     new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,11,22),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                         }
                     },
                     new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,11,20),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                         }
                     },
                    new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,11,17),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidApollineOdendhal,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                         }
                     },
                    new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,11,15),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             //GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                         }
                     },
                     new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,11,13),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidApollineOdendhal,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                         }
                     },        
                    new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,11,10),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             //GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                            // GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             //GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidAbelMotte,
                             //GuidConstantes.GuidApollineOdendhal,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                         }
                     }, new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,11,8),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             //GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidAbelMotte,
                             GuidConstantes.GuidApollineOdendhal,
                             GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                         }
                     },
                     new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,11,6),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidApollineOdendhal,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                         }
                     },
                    new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,10,20),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             //GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAuroreCarlier,
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidRaedwaldVercouter,
                             GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             //GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                             //GuidConstantes.GuidValentinXXX,
                         }
                     },
                    new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,10,18),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidMartinSiu,
                             //GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             //GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidRaedwaldVercouter,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidBaptisteMotte,
                             GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidSachaLessart,
                             //GuidConstantes.GuidEvaDufrasne,
                             //GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidFabriceRazanajao,
                             //GuidConstantes.GuidElodieMass,
                             //GuidConstantes.GuidRebeccaVandy,
                         }
                     },
                     new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,10,16),
                         EscrimeurId = new List<Guid>()
                         {
                             GuidConstantes.GuidMartinSiu,
                             GuidConstantes.GuidFélixTrannoy,
                             GuidConstantes.GuidAuroreCarlier,
                             GuidConstantes.GuidAnaelleIvanov,
                             GuidConstantes.GuidLiliMestdag,
                             GuidConstantes.GuidMathildeCarette,
                             //GuidConstantes.GuidAmadoSimon,
                             //GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             //GuidConstantes.GuidOscarDeblocq,
                             //GuidConstantes.GuidArthurBarbery,
                             //GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             //GuidConstantes.GuidMaybelleCarlier,
                             GuidConstantes.GuidMaeVantroyen,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidHéloïsePras,
                             //GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                         }
                     },
                     new JourDePrésence()
                     {
                         DatePrésence = new DateTime(2024,10,13),
                         EscrimeurId = new List<Guid>()
                         {
                             //GuidConstantes.GuidAnaelleIvanov,
                             //GuidConstantes.GuidMartinSiu,
                             //GuidConstantes.GuidFélixTrannoy,
                             //GuidConstantes.GuidAmadoSimon,
                             GuidConstantes.GuidEloiBinois,
                             //GuidConstantes.GuidLouisonBinois,
                             GuidConstantes.GuidOscarDeblocq,
                             GuidConstantes.GuidArthurBarbery,
                             GuidConstantes.GuidJordanMestdagh,
                             GuidConstantes.GuidRémiSoyez,
                             GuidConstantes.GuidMaybelleCarlier,
                             //GuidConstantes.GuidEvaDufrasne,
                             GuidConstantes.GuidFabriceRazanajao,
                             GuidConstantes.GuidMaeVantroyen,
                             GuidConstantes.GuidElodieMass,
                             GuidConstantes.GuidRebeccaVandy,
                         }
                     },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,10,11),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAmadoSimon,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidLouisonBinois,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidElodieMass
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,10,9),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidApollineOdendhal,
                            GuidConstantes.GuidAmadoSimon,
                            GuidConstantes.GuidHéloïsePras
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,10,6),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidRaedwaldVercouter,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidLouisonBinois,
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidElodieMass,
                            GuidConstantes.GuidRebeccaVandy,
                            //GuidConstantes.GuidCousineARemiJudith,
                            //GuidConstantes.GuidValentinXXX
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,10,4),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidRaedwaldVercouter,
                            GuidConstantes.GuidMaybelleCarlier,
                            GuidConstantes.GuidEvaDufrasne,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidApollineOdendhal,
                            GuidConstantes.GuidSachaLessart,
                            GuidConstantes.GuidAmadoSimon,
                            GuidConstantes.GuidLouisonBinois,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,10,2),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidApollineOdendhal,
                            GuidConstantes.GuidAmadoSimon,
                            GuidConstantes.GuidHéloïsePras,
                            GuidConstantes.GuidElodieMass,
                            GuidConstantes.GuidRebeccaVandy,
                            //GuidConstantes.GuidMiloXXX,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,9,29),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidElodieMass,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidLouisonBinois,
                           // GuidConstantes.GuidMiloXXX,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidHéloïsePras
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,9,25),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidSachaLessart,
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidAmadoSimon,
                            GuidConstantes.GuidElodieMass
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,9,22),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidApollineOdendhal,
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidLouisonBinois,
                            GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidRaedwaldVercouter,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidHéloïsePras,
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRebeccaVandy
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,9,20),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidApollineOdendhal,
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidAmadoSimon,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidLouisonBinois,
                            GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidRaedwaldVercouter,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidElodieMass
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,9,18),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidApollineOdendhal,
                            GuidConstantes.GuidRebeccaVandy,
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidAmadoSimon,
                            GuidConstantes.GuidHéloïsePras,
                          //  GuidConstantes.GuidMiloXXX
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,9,15),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidApollineOdendhal,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidLouisonBinois,
                            GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidRebeccaVandy

                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,9,13),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidApollineOdendhal,
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidAmadoSimon,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                            GuidConstantes.GuidArthurBarbery,
                            GuidConstantes.GuidRaedwaldVercouter,
                            GuidConstantes.GuidSachaLessart,
                            GuidConstantes.GuidLouisonBinois,
                            GuidConstantes.GuidHéloïsePras,
                            GuidConstantes.GuidElodieMass

                        }
                    },
                      new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,9,11),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidApollineOdendhal,
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidAmadoSimon,
                           // GuidConstantes.GuidThéoHelleputte
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,9,8),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidApollineOdendhal,
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidLouisonBinois,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,9,6),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidSachaLessart,
                            GuidConstantes.GuidOscarDeblocq,
                            GuidConstantes.GuidJudithDeblocq,
                            GuidConstantes.GuidJordanMestdagh,
                            GuidConstantes.GuidRémiSoyez,
                            GuidConstantes.GuidFabriceRazanajao,
                            GuidConstantes.GuidApollineOdendhal,
                            GuidConstantes.GuidAmadoSimon,
                        }
                    },
                    new JourDePrésence()
                    {
                        DatePrésence = new DateTime(2024,9,4),
                        EscrimeurId = new List<Guid>()
                        {
                            GuidConstantes.GuidFélixTrannoy,
                            GuidConstantes.GuidMartinSiu,
                            GuidConstantes.GuidAuroreCarlier,
                            GuidConstantes.GuidAnaelleIvanov,
                            GuidConstantes.GuidLiliMestdag,
                            GuidConstantes.GuidEloiBinois,
                            GuidConstantes.GuidMathildeCarette,
                            GuidConstantes.GuidMaeVantroyen,
                            GuidConstantes.GuidSachaLessart,
                        }
                    },

                }
            };

            return joursDePrésence;
        }
        public void Add_Paiements_Binois_Louison(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLouisonBinois && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidLouisonBinois && x.Période == period).FirstOrDefault().Paiement =
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
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "245 euros", "75 euros" },

                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,9,8),
                        new DateTime(2023,9,13),
                    },
                    IsMatérielLoue = true
                };
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
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "75 euros",  "290 euros" },

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
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "95 euros", "75 euros", "50 euros", "100 euros" },
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
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "95 euros","75 euros", "50 euros" },
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
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }

        public void Add_Paiements_Courret_Margaux(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMargauxCourret && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidMargauxCourret && x.Période == period).FirstOrDefault().Paiement =
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
                    IsLicenceEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,9,6),
                        new DateTime(2023,9,8)
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
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "170 euros", "50 euros","50 euros", "50 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }

        public void Add_Paiements_Dufrasne_Eva(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidEvaDufrasne && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidEvaDufrasne && x.Période == period).FirstOrDefault().Paiement =
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
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "170 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,9,10),
                        new DateTime(2023,9,8)
                    },
                    IsMatérielLoue = true
                };
        }

        public void Add_Paiements_Carlier_Maybelle(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMaybelleCarlier && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidMaybelleCarlier && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
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
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsLocationMatérielEnOrdre = true,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,


                    PaiementsEffectues = new List<string>() { "170 euros", "50 euros", "50 euros" },
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
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "75 euros", "290 euros" },
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
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsLocationMatérielEnOrdre = true,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,11,24),
                        new DateTime(2024,11,27),
                    },
                    IsMatérielLoue = true
                };
        }

        //public void Add_Paiements_CousineARemiJudith(string period, List<MembreData> Membres)
        //{
        //    if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidCousineARemiJudith && x.Période == period))
        //    {
        //        return;
        //    }
        //    Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidCousineARemiJudith && x.Période == period).Paiement =
        //        new Paiement()
        //        {
        //            Periode = period,
        //            IsCotisationAnnuelle = false,
        //            IsCotisationCarte1 = false,
        //            IsCotisationCarte2 = false,
        //            IsCotisationCarte3 = false,
        //            IsCotisationCarte4 = false,
        //            IsLocationMatérielEnOrdre = false,
        //            IsCotisationEnOrdre = false,
        //            IsFicheSignaletiqueEnOrdre = false,
        //            IsLicenceEnOrdre = false,

        //            PaiementsEffectues = new List<string>() { },
        //            SeancesGratuites = new List<DateTime>()
        //            {
        //                 new DateTime(2024,10,6),
        //            },
        //            IsMatérielLoue = true
        //        };
        //}
       
        public void Add_Paiements_Deblocq_Judith(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidJudithDeblocq && x.Période == period))
            {
                return;
            }
            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidJudithDeblocq && x.Période == period).Paiement =
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
                    IsLicenceEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
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
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "265 euros", "100 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Waeselynck_Lisa(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLisaWaeselynck && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidLisaWaeselynck && x.Période == period).FirstOrDefault().Paiement =
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
                    IsLicenceEnOrdre = false,
                    IsLocationMatérielEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
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
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                    },
                    IsMatérielLoue = false
                };
        }

        public void Add_Paiements_Cle_Leander(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLeanderCle && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidLeanderCle && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsLocationMatérielEnOrdre = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = false,
                    IsFicheSignaletiqueEnOrdre = false,
                    IsLicenceEnOrdre = false,

                    PaiementsEffectues = new List<string>() { },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2023,9,18),
                        new DateTime(2023,9,17),
                    },
                    IsMatérielLoue = true
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
                    IsLicenceEnOrdre = false,

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
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "365 euros" },
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
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "75 euros", "290 euros" },
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
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "95 euros", "50 euros", "25 euros", "50 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,5,31),
                        new DateTime(2024,6,2),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Pras_Héloïse(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidHéloïsePras && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidHéloïsePras && x.Période == period).FirstOrDefault().Paiement =
                new Paiement()
                {
                    Periode = period,
                    IsCotisationAnnuelle = false,
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = true,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "95 euros", "75 euros", "50 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,4),
                        new DateTime(2024,9,13),
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
                    IsLicenceEnOrdre = false,
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
                    IsCotisationCarte1 = true,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = false,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
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
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,13),
                        new DateTime(2024,9,20),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Binois_Eloi(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidEloiBinois && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidEloiBinois && x.Période == period).FirstOrDefault().Paiement =
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
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,4),
                        new DateTime(2024,9,6),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Odendhal_Apolline(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidApollineOdendhal && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidApollineOdendhal && x.Période == period).FirstOrDefault().Paiement =
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
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,6),
                        new DateTime(2024,9,8),
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
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
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
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
                    SeancesGratuites = new List<DateTime>()
                    {
                        new DateTime(2024,9,4),
                        new DateTime(2024,9,6),
                    },
                    IsMatérielLoue = true
                };
        }
        public void Add_Paiements_Lessart_Sacha(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidSachaLessart && x.Période == period))
            {
                return;
            }
            Membres.Where(x => x.GuidId == GuidConstantes.GuidSachaLessart && x.Période == period).FirstOrDefault().Paiement =
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
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
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
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
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
                    IsCotisationAnnuelle = true,
                    IsCotisationCarte1 = false,
                    IsCotisationCarte2 = false,
                    IsCotisationCarte3 = false,
                    IsCotisationCarte4 = false,
                    IsCotisationEnOrdre = true,
                    IsFicheSignaletiqueEnOrdre = true,
                    IsLicenceEnOrdre = true,
                    IsLocationMatérielEnOrdre = true,

                    PaiementsEffectues = new List<string>() { "290 euros", "75 euros" },
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