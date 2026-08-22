using CercleRoyalEscrimeTournaisien;
using CercleRoyalEscrimeTournaisien.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ListGuidTireur
    {
       
        public string Période { get; set; }
        public List<MembreData> Membres { get; set; }
        public ListGuidTireur(HttpServerUtilityBase serverTmp) 
        {
            
            Membres = new List<MembreData>() { };

            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidCyrilLeclercq, Nom = "Leclercq", Prénom = "Cyril", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidJudithDeblocq, Nom = "Deblocq", Prénom = "Judith", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidOscarDeblocq, Nom = "Deblocq", Prénom = "Oscar", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidMaybelleCarlier, Nom = "Carlier", Prénom = "Maybelle", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidHelenaDebruyne, Nom = "Debruyne", Prénom = "Helena", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidKarelDebruyne, Nom = "Debruyne", Prénom = "Karel", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidFabriceRazanajao, Nom = "Razanajao", Prénom = "Fabrice", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidFélixTrannoy, Nom = "Trannoy", Prénom = "Félix", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidAntoineLemaire, Nom = "Lemaire", Prénom = "Antoine", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidMaximeDelmotte, Nom = "Delmotte", Prénom = "Maxime", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidGabrielDooms, Nom = "Dooms", Prénom = "Gabriel", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidJulesDooms, Nom = "Dooms", Prénom = "Jules", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidArthurCarlier, Nom = "Carlier", Prénom = "Arthur", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidBaptisteMotte, Nom = "Motte", Prénom = "Baptiste", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidEliotBrabant, Nom = "Brabant", Prénom = "Eliot", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidLisaWaeselynck, Nom = "Waeselynck", Prénom = "Lisa", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidArthurBarbery, Nom = "Barbery", Prénom = "Arthur", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidThomasGillet, Nom = "Gillet", Prénom = "Thomas", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidNoelMarieDransart, Nom = "Dransart", Prénom = "NoelMarie", Période = "2022-2023" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidIannDransart, Nom = "Dransart", Prénom = "Iann", Période = "2022-2023" }
            );


            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidCyrilLeclercq, Nom = "Leclercq", Prénom = "Cyril", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidJudithDeblocq, Nom = "Deblocq", Prénom = "Judith", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidOscarDeblocq, Nom = "Deblocq", Prénom = "Oscar", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidMaybelleCarlier, Nom = "Carlier", Prénom = "Maybelle", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidFabriceRazanajao, Nom = "Razanajao", Prénom = "Fabrice", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidFélixTrannoy, Nom = "Trannoy", Prénom = "Félix", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidAbelMotte, Nom = "Motte", Prénom = "Abel", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidBaptisteMotte, Nom = "Motte", Prénom = "Baptiste", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidLisaWaeselynck, Nom = "Waeselynck", Prénom = "Lisa", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidArthurBarbery, Nom = "Barbery", Prénom = "Arthur", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidEvaDufrasne, Nom = "Dufrasne", Prénom = "Eva", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidRémiSoyez, Nom = "Soyez", Prénom = "Rémi", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidLeanderCle, Nom = "Cle", Prénom = "Leander", Période = "2023-2024" }
            ); 
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidArthurCouturiaux, Nom = "Couturiaux", Prénom = "Arthur", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidJordanMestdagh, Nom = "Mestdagh", Prénom = "Jordan", Période = "2023-2024" }
            );
            Membres.Add(
            new MembreData() { GuidId = GuidConstantes.GuidMartinSiu, Nom = "Siu", Prénom = "Martin", Période = "2023-2024" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidRaedwaldVercouter, Nom = "Vercouter", Prénom = "Raedwald", Période = "2023-2024" }
            );

            // 2024-2025

            //Membres.Add(
            //    new MembreData() { GuidId = GuidConstantes.GuidJudithDeblocq, Nom = "Deblocq", Prénom = "Judith", Période = "2024-2025" }
            //);
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidOscarDeblocq, Nom = "Deblocq", Prénom = "Oscar", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidMaybelleCarlier, Nom = "Carlier", Prénom = "Maybelle", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidFabriceRazanajao, Nom = "Razanajao", Prénom = "Fabrice", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidFélixTrannoy, Nom = "Trannoy", Prénom = "Félix", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidAbelMotte, Nom = "Motte", Prénom = "Abel", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidBaptisteMotte, Nom = "Motte", Prénom = "Baptiste", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidArthurBarbery, Nom = "Barbery", Prénom = "Arthur", Période = "2024-2025" }
            );
            //Membres.Add(
            //    new MembreData() { GuidId = GuidConstantes.GuidEvaDufrasne, Nom = "Dufrasne", Prénom = "Eva", Période = "2024-2025" }
            //);
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidRémiSoyez, Nom = "Soyez", Prénom = "Rémi", Période = "2024-2025" }
            );
            //Membres.Add(
            //    new MembreData() { GuidId = GuidConstantes.GuidLeanderCle, Nom = "Cle", Prénom = "Leander", Période = "2024-2025" }
            //);
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidArthurCouturiaux, Nom = "Couturiaux", Prénom = "Arthur", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidJordanMestdagh, Nom = "Mestdagh", Prénom = "Jordan", Période = "2024-2025" }
            );
            Membres.Add(
            new MembreData() { GuidId = GuidConstantes.GuidMartinSiu, Nom = "Siu", Prénom = "Martin", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidRaedwaldVercouter, Nom = "Vercouter", Prénom = "Raedwald", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidAuroreCarlier, Nom = "Carlier", Prénom = "Aurore", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidAnaelleIvanov, Nom = "Ivanov", Prénom = "Anaelle", Période = "2024-2025" }
            );
            //Membres.Add(
            //    new MembreData() { GuidId = GuidConstantes.GuidTimXXX, Nom = "XXX", Prénom = "Tim", Période = "2024-2025" }
            //);
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidLiliMestdag, Nom = "Mestdag", Prénom = "Lili", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidEloiBinois, Nom = "Binois", Prénom = "Eloi", Période = "2024-2025" }
            );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidMathildeCarette, Nom = "Carette", Prénom = "Mathilde", Période = "2024-2025" }
           );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidMaeVantroyen, Nom = "Vantroyen", Prénom = "Maé", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidApollineOdendhal, Nom = "Odendhal", Prénom = "Apolline", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidSachaLessart, Nom = "Lessart", Prénom = "Sacha", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidAmadoSimon, Nom = "Simon", Prénom = "Amado", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidLouisonBinois, Nom = "Binois", Prénom = "Louison", Période = "2024-2025" }
            );
           // Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidThéoHelleputte, Nom = "Helleputte", Prénom = "Théo", Période = "2024-2025" }
          //  );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidHéloïsePras, Nom = "Pras", Prénom = "Héloïse", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidElodieMass, Nom = "Mass", Prénom = "Elodie", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidRebeccaVandy, Nom = "Vandy", Prénom = "Rebecca", Période = "2024-2025" }
            );
            //Membres.Add(
            //    new MembreData() { GuidId = GuidConstantes.GuidCousineARemiJudith, Nom = "CousineARemi", Prénom = "Judidth", Période = "2024-2025" }
            //);           
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidEliotPunchoo, Nom = "Punchoo", Prénom = "Eliot", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidNoelMarieDransart, Nom = "Dransart", Prénom = "Noël-Marie", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidNayaBeaucamp, Nom = "Beaucamp", Prénom = "Naya", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidBarnabéBeaucamp, Nom = "Beaucamp", Prénom = "Barnabé", Période = "2024-2025" }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidRomainBracquart, Nom = "Bracquart", Prénom = "Romain", Période = "2024-2025" }
            );

            // 2025-2026

            string period2025_2026 = "2025-2026";
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidOscarDeblocq, Nom = "Deblocq", Prénom = "Oscar", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidFabriceRazanajao, Nom = "Razanajao", Prénom = "Fabrice", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidFélixTrannoy, Nom = "Trannoy", Prénom = "Félix", Période = period2025_2026 }
            ); 
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidRégisTrannoy, Nom = "Trannoy", Prénom = "Régis", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidAbelMotte, Nom = "Motte", Prénom = "Abel", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidBaptisteMotte, Nom = "Motte", Prénom = "Baptiste", Période = period2025_2026 }
            );
           
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidRémiSoyez, Nom = "Soyez", Prénom = "Rémi", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidArthurCouturiaux, Nom = "Couturiaux", Prénom = "Arthur", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidJordanMestdagh, Nom = "Mestdagh", Prénom = "Jordan", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidMartinSiu, Nom = "Siu", Prénom = "Martin", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidRaedwaldVercouter, Nom = "Vercouter", Prénom = "Raedwald", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidAuroreCarlier, Nom = "Carlier", Prénom = "Aurore", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidAnaelleIvanov, Nom = "Ivanov", Prénom = "Anaelle", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidLiliMestdag, Nom = "Mestdag", Prénom = "Lili", Période = period2025_2026 }
            );
           // Membres.Add(
           //    new MembreData() { GuidId = GuidConstantes.GuidMathildeCarette, Nom = "Carette", Prénom = "Mathilde", Période = period2025_2026 }
           //);
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidMaeVantroyen, Nom = "Vantroyen", Prénom = "Maé", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidAmadoSimon, Nom = "Simon", Prénom = "Amado", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidElodieMass, Nom = "Mass", Prénom = "Elodie", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidRebeccaVandy, Nom = "Vandy", Prénom = "Rebecca", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidEliotPunchoo, Nom = "Punchoo", Prénom = "Eliot", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidNoelMarieDransart, Nom = "Dransart", Prénom = "Noël-Marie", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidNayaBeaucamp, Nom = "Beaucamp", Prénom = "Naya", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidBarnabéBeaucamp, Nom = "Beaucamp", Prénom = "Barnabé", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidRomainBracquart, Nom = "Bracquart", Prénom = "Romain", Période = period2025_2026 }
            );
            Membres.Add(
              new MembreData() { GuidId = GuidConstantes.GuidSolalSchrouf, Nom = "Schrouf", Prénom = "Solal", Période = period2025_2026 }
          );
            Membres.Add(
              new MembreData() { GuidId = GuidConstantes.GuidGabrielThulier, Nom = "Thulier", Prénom = "Gabriel", Période = period2025_2026 }
          );
            Membres.Add(
              new MembreData() { GuidId = GuidConstantes.GuidPierreAugustinLepas, Nom = "Lepas", Prénom = "Pierre-Augustin", Période = period2025_2026 }
          );
            Membres.Add(
              new MembreData() { GuidId = GuidConstantes.GuidBenedictCosentini, Nom = "Cosentini", Prénom = "Benedict", Période = period2025_2026 }
          );
            Membres.Add(
              new MembreData() { GuidId = GuidConstantes.GuidLucasVerheye, Nom = "Verheye", Prénom = "Lucas", Période = period2025_2026 }
          );
          //  Membres.Add(
          //    new MembreData() { GuidId = GuidConstantes.GuidGuillaumeXXX, Nom = "XXX", Prénom = "Guillaume", Période = period2025_2026 }
          //);

            Membres.Add(
                        new MembreData() { GuidId = GuidConstantes.GuidThéoCucheval_Rasson, Nom = "Cucheval_Rasson", Prénom = "Théo", Période = period2025_2026 }
                    );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidOscarDucrot, Nom = "Ducrot", Prénom = "Oscar", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidGwendalLecomte, Nom = "Lecomte", Prénom = "Gwendal", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidAmelLawrizy, Nom = "Lawrizy", Prénom = "Amel", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidJéromeRohart, Nom = "Rohart", Prénom = "Jérome", Période = period2025_2026 }
            );
            Membres.Add(
                new MembreData() { GuidId = GuidConstantes.GuidLubinDelplanque, Nom = "Delplanque", Prénom = "Lubin", Période = period2025_2026 }
            );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidSébastienMotte, Nom = "Motte", Prénom = "Sébastien", Période = period2025_2026 }
           );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidDelphineVercauteren, Nom = "Vercauteren", Prénom = "Delphine", Période = period2025_2026 }
           );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidBenoîtLafaut, Nom = "Lafaut", Prénom = "Benoît", Période = period2025_2026 }
           );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidSiméonTrovato, Nom = "Trovato", Prénom = "Siméon", Période = period2025_2026 }
           );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidGabrielSegard, Nom = "Segard", Prénom = "Gabriel", Période = period2025_2026 }
           );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidEstebanDuthye, Nom = "Duthye", Prénom = "Esteban", Période = period2025_2026 }
           );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidJeanMarcCucheval, Nom = "Cucheval", Prénom = "Jean-Marc", Période = period2025_2026 }
           );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidMatthieuTanis, Nom = "Tanis", Prénom = "Matthieu", Période = period2025_2026 }
           );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidFlorianBauffe, Nom = "Bauffe", Prénom = "Florian", Période = period2025_2026 }
           );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidEleonaraColpaert, Nom = "Colpaert", Prénom = "Eleonara", Période = period2025_2026 }
           );
            Membres.Add(
               new MembreData() { GuidId = GuidConstantes.GuidMarcPersyn, Nom = "Persyn", Prénom = "Marc", Période = period2025_2026 }
           );

            // 2026-2027

            string period2026_2027 = "2026-2027";
            Membres.AddRange(GetMembresForPeriod20262027(serverTmp, period2026_2027));
            //Membres = GetMembresForPeriod20262027(serverTmp, period2026_2027);

          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidOscarDeblocq, Nom = "Deblocq", Prénom = "Oscar", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidFabriceRazanajao, Nom = "Razanajao", Prénom = "Fabrice", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidFélixTrannoy, Nom = "Trannoy", Prénom = "Félix", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidRégisTrannoy, Nom = "Trannoy", Prénom = "Régis", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidAbelMotte, Nom = "Motte", Prénom = "Abel", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidBaptisteMotte, Nom = "Motte", Prénom = "Baptiste", Période = period2026_2027 }
          //  );

          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidRémiSoyez, Nom = "Soyez", Prénom = "Rémi", Période = period2026_2027 }
          //  );
           
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidJordanMestdagh, Nom = "Mestdagh", Prénom = "Jordan", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidMartinSiu, Nom = "Siu", Prénom = "Martin", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidRaedwaldVercouter, Nom = "Vercouter", Prénom = "Raedwald", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidAuroreCarlier, Nom = "Carlier", Prénom = "Aurore", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidAnaelleIvanov, Nom = "Ivanov", Prénom = "Anaelle", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidLiliMestdag, Nom = "Mestdag", Prénom = "Lili", Période = period2026_2027 }
          //  );
            
          //  Membres.Add(
          //     new MembreData() { GuidId = GuidConstantes.GuidMaeVantroyen, Nom = "Vantroyen", Prénom = "Maé", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidAmadoSimon, Nom = "Simon", Prénom = "Amado", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidElodieMass, Nom = "Mass", Prénom = "Elodie", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidRebeccaVandy, Nom = "Vandy", Prénom = "Rebecca", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidEliotPunchoo, Nom = "Punchoo", Prénom = "Eliot", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidNoelMarieDransart, Nom = "Dransart", Prénom = "Noël-Marie", Période = period2026_2027 }
          //  );
           
           
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidRomainBracquart, Nom = "Bracquart", Prénom = "Romain", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //    new MembreData() { GuidId = GuidConstantes.GuidSolalSchrouf, Nom = "Schrouf", Prénom = "Solal", Période = period2026_2027 }
          //);
         
         
          //  Membres.Add(
          //    new MembreData() { GuidId = GuidConstantes.GuidBenedictCosentini, Nom = "Cosentini", Prénom = "Benedict", Période = period2026_2027 }
          //);
          //  Membres.Add(
          //    new MembreData() { GuidId = GuidConstantes.GuidLucasVerheye, Nom = "Verheye", Prénom = "Lucas", Période = period2026_2027 }
          //);
           

          //  Membres.Add(
          //              new MembreData() { GuidId = GuidConstantes.GuidThéoCucheval_Rasson, Nom = "Cucheval_Rasson", Prénom = "Théo", Période = period2026_2027 }
          //          );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidOscarDucrot, Nom = "Ducrot", Prénom = "Oscar", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidGwendalLecomte, Nom = "Lecomte", Prénom = "Gwendal", Période = period2026_2027 }
          //  );
          //  Membres.Add(
          //      new MembreData() { GuidId = GuidConstantes.GuidAmelLawrizy, Nom = "Lawrizy", Prénom = "Amel", Période = period2026_2027 }
          //  );
           
          //  Membres.Add(
          //     new MembreData() { GuidId = GuidConstantes.GuidSébastienMotte, Nom = "Motte", Prénom = "Sébastien", Période = period2026_2027 }
          // );
          //  Membres.Add(
          //     new MembreData() { GuidId = GuidConstantes.GuidDelphineVercauteren, Nom = "Vercauteren", Prénom = "Delphine", Période = period2026_2027 }
          // );
          //  Membres.Add(
          //     new MembreData() { GuidId = GuidConstantes.GuidBenoîtLafaut, Nom = "Lafaut", Prénom = "Benoît", Période = period2026_2027 }
          // );
          
          //  Membres.Add(
          //     new MembreData() { GuidId = GuidConstantes.GuidGabrielSegard, Nom = "Segard", Prénom = "Gabriel", Période = period2026_2027 }
          // );
          //  Membres.Add(
          //     new MembreData() { GuidId = GuidConstantes.GuidEstebanDuthye, Nom = "Duthye", Prénom = "Esteban", Période = period2026_2027 }
          // );
          //  Membres.Add(
          //     new MembreData() { GuidId = GuidConstantes.GuidJeanMarcCucheval, Nom = "Cucheval", Prénom = "Jean-Marc", Période = period2026_2027 }
          // );
          //  Membres.Add(
          //     new MembreData() { GuidId = GuidConstantes.GuidMatthieuTanis, Nom = "Tanis", Prénom = "Matthieu", Période = period2026_2027 }
          // );
          //  Membres.Add(
          //     new MembreData() { GuidId = GuidConstantes.GuidFlorianBauffe, Nom = "Bauffe", Prénom = "Florian", Période = period2026_2027 }
          // );
          //  Membres.Add(
          //     new MembreData() { GuidId = GuidConstantes.GuidEleonaraColpaert, Nom = "Colpaert", Prénom = "Eleonara", Période = period2026_2027 }
          // );
          //  Membres.Add(
          //     new MembreData() { GuidId = GuidConstantes.GuidMarcPersyn, Nom = "Persyn", Prénom = "Marc", Période = period2026_2027 }
          // );
        }

        private List<MembreData> GetMembresForPeriod20262027(HttpServerUtilityBase serverTmp, string period2026_2027)
        {
            List<MembreData> membres = new List<MembreData>() { };
            BaseDeDonnéesMapper baseDeDonnéesMapper = new BaseDeDonnéesMapper();
            List<TableListeTireursData> tireursDataList = baseDeDonnéesMapper.GetTableListeTireursData(serverTmp, period2026_2027);

            foreach (TableListeTireursData tableListeTireursData  in tireursDataList)
            {
                membres.Add(
                       new MembreData() 
                       { 
                           GuidId = new Guid(tableListeTireursData.GuidTireur), 
                           Nom = tableListeTireursData.Nom,
                           Prénom = tableListeTireursData.Prenom, 
                           Période = tableListeTireursData.Periode                           
                       }
                );
            }

            return membres;
        }

        public static Categorie SearchCategorie(int annee) 
        {
            if (annee >= 1926 && annee <= 1956) { return Categorie.Vétéran_70; }
            if (annee >= 1957 && annee <= 1966) { return Categorie.Vétéran_60; }
            if (annee >= 1967 && annee <= 1976) { return Categorie.Vétéran_50; }
            if (annee >= 1977 && annee <= 1986) { return Categorie.Vétéran_40; }
            if (annee >= 2004 && annee <= 2006) { return Categorie.U23; }
            if (annee >= 1986 && annee <= 2006) { return Categorie.Senior; }
            if (annee >= 2007 && annee <= 2009) { return Categorie.U20; }
            if (annee >= 2010 && annee <= 2011) { return Categorie.U17; }
            if (annee >= 2012 && annee <= 2013) { return Categorie.U15; }
            if (annee >= 2014 && annee <= 2015) { return Categorie.U13; }
            if (annee >= 2016 && annee <= 2017) { return Categorie.U11; }
            if (annee > 2017) { return Categorie.U11; }

            return Categorie.Senior;
        }

        public List<MembreData> MembresWithPeriod
        {
            get
                {
                return Membres.Where(x => x.Période == Période).OrderBy(x=>x.Nom).ToList();
            }
        }
    }

    public class MembreData
    {
        public Guid GuidId { get; set; }
        public string Période { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public Paiement Paiement { get; set; }
        public Signaletique Signaletique { get; set; }
    }
}