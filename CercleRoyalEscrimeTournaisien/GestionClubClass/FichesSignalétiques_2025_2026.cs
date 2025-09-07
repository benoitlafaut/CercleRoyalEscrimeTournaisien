using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public  class FichesSignalétiques_2025_2026
    {
        public  void Add_FichesSignalétiques_Motte_Baptiste(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidBaptisteMotte && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidBaptisteMotte && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2012),
                   DateDeNaissance = new DateTime(2012, 7, 1),
                   Email = new List<string>() { "motte.archi@gmail.com", "delphine.vercauteren@gmail.com" },
                   NomPapa = "Motte Sébastien",
                   NomMaman = "Vercauteren Delphine",
                   Telephone = new List<string>() { "0496/799495", "0473/766523" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Motte_Baptiste.pdf",
               };
        }
        public void Add_FichesSignalétiques_Motte_Abel(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAbelMotte && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidAbelMotte && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2015),
                   DateDeNaissance = new DateTime(2015, 4, 22),
                   Email = new List<string>() { "motte.archi@gmail.com", "delphine.vercauteren@gmail.com" },
                   NomPapa = "Motte Sébastien",
                   NomMaman = "Vercauteren Delphine",
                   Telephone = new List<string>() { "0496/799495", "0473/766523" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Motte_Abel.pdf",
               };
        }
        public void Add_FichesSignalétiques_Vantroyen_Mae(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMaeVantroyen && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidMaeVantroyen && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2012),
                   DateDeNaissance = new DateTime(2012, 3, 28),
                   Email = new List<string>() { "mva.maubray@gmail.com" },
                   NomPapa = "Vantroyen Michael",
                   NomMaman = "Nottebaert Fanny",
                   Telephone = new List<string>() { "0478/450007", "0494/924435" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Vantroyen_Mae.pdf",
               };
        }
        public void Add_FichesSignalétiques_Trannoy_Félix(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFélixTrannoy && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidFélixTrannoy && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2013),
                  DateDeNaissance = new DateTime(2013, 10, 17),
                  Email = new List<string>() { "valerie_regis@live.be" },
                  NomMaman = "Chirez Valérie",
                  NomPapa = "Trannoy Régis",
                  Telephone = new List<string>() {  },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Trannoy_Félix.pdf",
              };
        }
        public void Add_FichesSignalétiques_Trannoy_Régis(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRégisTrannoy && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidRégisTrannoy && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(1977),
                  DateDeNaissance = new DateTime(1977, 5, 17),
                  Email = new List<string>() { "valerie_regis@live.be" },
                  NomMaman = "",
                  NomPapa = "",
                  Telephone = new List<string>() { },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Trannoy_Régis.pdf",
              };
        }
        public void Add_FichesSignalétiques_Vandy_Rebecca(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRebeccaVandy && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidRebeccaVandy && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2013),
                  DateDeNaissance = new DateTime(2013, 1, 18),
                  Email = new List<string>() { "vandyalain@hotmail.com","sandrine.robert@laposte.net" },
                  NomMaman = "Robert Sandrine",
                  NomPapa = "Vandy Alain",
                  Telephone = new List<string>() { "0495775873", "0033637455402" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Vandy_Rebecca.pdf",
              };
        }
       
        
        public void Add_FichesSignalétiques_Punchoo_Eliot(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidEliotPunchoo && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidEliotPunchoo && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2013),
                  DateDeNaissance = new DateTime(2013, 3, 24),
                  Email = new List<string>() { "jeremypunchoo58@gmail.com", "wivterryn@gmail.com" },
                  NomMaman = "Terryn Wivine",
                  NomPapa = "Punchoo Jérémy",
                  Telephone = new List<string>() { "0471/795186", "0474/048202" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Punchoo_Eliot.pdf",
              };
        }
        public void Add_FichesSignalétiques_Razanajao_Fabrice(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFabriceRazanajao && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidFabriceRazanajao && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2002),
                   DateDeNaissance = new DateTime(2002, 5, 29),
                   Email = new List<string>() { "bedidamada@gmail.com", "bedidakely@live.be" },
                   NomMaman = "Andrianasoloson Nera Tiana",
                   NomPapa = "Razanajao Harilala",
                   Telephone = new List<string>() { "0493/507810", "0493/306050" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Razanajao_Fabrice.pdf",
               };
        }
        public void Add_FichesSignalétiques_Simon_Amado(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAmadoSimon && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidAmadoSimon && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2017),
                   DateDeNaissance = new DateTime(2017, 6, 7),
                   Email = new List<string>() { "thimo.simo@outlook.com", "sandramillenafranco@hotmail.com" },
                   NomMaman = "Gleyze Isabelle",
                   NomPapa = "Simon Thimothée",
                   Telephone = new List<string>() { "0497/707657", "0493/542915" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Simon_Amado.pdf",
               };
        }
       
        public  void Add_FichesSignalétiques_Deblocq_Oscar(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidOscarDeblocq && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidOscarDeblocq && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2011),
                   DateDeNaissance = new DateTime(2011, 12, 16),
                   Email = new List<string>() { "vdeblocq@gmail.com", "cecile.duplat@gmail.com" },
                   NomPapa = "Deblocq Vincent",
                   NomMaman = "Duplat Cecile",
                   Telephone = new List<string>() { "0473/352418", "0479/503655" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Deblocq_Oscar.pdf",
               };
        }
        
        public  void Add_FichesSignalétiques_Barbery_Arthur(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidArthurBarbery && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidArthurBarbery && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2010),
                   DateDeNaissance = new DateTime(2010, 9, 26),
                   Email = new List<string>() { "arthurbarbery@icloud.com", "sb.sophie.bellet@gmail.com", "jfbarbery@yahoo.fr" },
                   NomPapa = "Barbery JF",
                   NomMaman = "Bellet Sophie",
                   Telephone = new List<string>() { "0491/649753", "+33632904612", "0488573000" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Barbery_Arthur.pdf",
               };
        }          
        public  void Add_FichesSignalétiques_Soyez_Rémi(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRémiSoyez && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidRémiSoyez && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(1999),
                   DateDeNaissance = new DateTime(1999, 10, 12),
                   Email = new List<string>() { "soyez.rem@gmail.com" },
                   NomPapa = "Soyez Rudy",
                   NomMaman = "",
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/soyez_remi.pdf",
               };
        }      
      
        public  void Add_FichesSignalétiques_Couturiaux_Arthur(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidArthurCouturiaux && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidArthurCouturiaux && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2014),
                   DateDeNaissance = new DateTime(2014, 01, 27),
                   Email = new List<string>() { "famakanopru@gmail.com", "fabian7.couturiaux@gmail.com" },
                   NomPapa = "Couturiaux Fabian",
                   NomMaman = "Maturin Désirella",
                   Telephone = new List<string>() { "0494/679758", "0455/131289" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Couturiaux_Arthur.pdf",
               };
        }
        public  void Add_FichesSignalétiques_Mestdagh_Jordan(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidJordanMestdagh && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidJordanMestdagh && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(1995),
                   DateDeNaissance = new DateTime(1995, 08, 20),
                   Email = new List<string>() { "jordan.mestdagh@hotmail.com" },
                   Telephone = new List<string>() { "0471/037292" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Mestdagh_Jordan.pdf",
               };
        }
        public void Add_FichesSignalétiques_Mestdag_Lili(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLiliMestdag && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidLiliMestdag && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2014),
                   DateDeNaissance = new DateTime(2014, 04, 18),
                   Email = new List<string>() { "aureliedelcroix1985@outlook.be" },
                   Telephone = new List<string>() { "0496/732649", "0485/982028" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Mestdag_Lili.pdf",
               };
        }
        public  void Add_FichesSignalétiques_Siu_Martin(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMartinSiu && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidMartinSiu && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2015),
                   DateDeNaissance = new DateTime(2015, 04, 12),
                   Email = new List<string>() { "christophe_siu@hotmail.com", "sammiyan881@gmail.com" },
                   Telephone = new List<string>() { "0477/758523" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Siu_Martin.pdf",
               };
        }
        public void Add_FichesSignalétiques_Cosentini_Benedict(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidBenedictCosentini && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidBenedictCosentini && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "",
               };
        }
        public void Add_FichesSignalétiques_Thulier_Gabriel(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidGabrielThulier && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidGabrielThulier && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "",
               };
        }
        public void Add_FichesSignalétiques_Lepas_PierreAugustin(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidPierreAugustinLepas && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidPierreAugustinLepas && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "",
               };
        }
        public void Add_FichesSignalétiques_Schrouf_Solal(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidSolalSchrouf && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidSolalSchrouf && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "",
               };
        }
        public void Add_FichesSignalétiques_XXX_Guillaume(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidGuillaumeXXX && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidGuillaumeXXX && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "",
               };
        }
        public void Add_FichesSignalétiques_CopainDeFélicie_Guillaume(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidGuillaumeCopainDeFélicie && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidGuillaumeCopainDeFélicie && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "",
               };
        }
        public void Add_FichesSignalétiques_XXX_Félicie(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFélicieXXX && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidFélicieXXX && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "",
               };
        }
        public void Add_FichesSignalétiques_Lucas_Verheye(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLucasVerheye && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidLucasVerheye && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "",
               };
        }
        public void Add_FichesSignalétiques_Vercouter_Raedwald(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRaedwaldVercouter && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidRaedwaldVercouter && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2009),
                   DateDeNaissance = new DateTime(2009, 12, 24),
                   Email = new List<string>() { "c.b.o@skynet.be", "mathildadebski@gmail.com" },
                   Telephone = new List<string>() { "0474/905459", "0032478034641" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Vercouter_Raedwald.pdf",
               };
        }
        public void Add_FichesSignalétiques_Carette_Mathilde(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMathildeCarette && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidMathildeCarette && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2014),
                   DateDeNaissance = new DateTime(2014, 4, 28),
                   Email = new List<string>() { "laraescudero@hotmail.com" },
                   Telephone = new List<string>() { "0476/464895", "0473/263131" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Carette_Mathilde.pdf",
               };
        }
       
        public void Add_FichesSignalétiques_Ivanov_Anaelle(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAnaelleIvanov && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidAnaelleIvanov && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2014),
                   DateDeNaissance = new DateTime(2014, 3, 24),
                   Email = new List<string>() { "luciecoq35@hotmail.com" },
                   NomMaman = "Coquelin Lucie",
                   NomPapa = "Ivanov Vitaliy",
                   Telephone = new List<string>() { "0498/595609", "0474/432776" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Ivanov_Anaelle.pdf",
               };
        }
        public void Add_FichesSignalétiques_Dransart_NoelMarie(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidNoelMarieDransart && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidNoelMarieDransart && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2015),
                   DateDeNaissance = new DateTime(2015, 11, 10),
                   Email = new List<string>() { "o.dransart7500@gmail.com" },
                   NomMaman = "Dransart Oana",
                   NomPapa = "Dransart Pierre-Emmanuel",
                   Telephone = new List<string>() { "+33647413691" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Dransart_NoelMarie.pdf",
               };
        }
        public void Add_FichesSignalétiques_Beaucamp_Naya(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidNayaBeaucamp && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidNayaBeaucamp && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   NomMaman = "",
                   NomPapa = "",
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "",
               };
        }
        public void Add_FichesSignalétiques_Beaucamp_Barnabé(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidBarnabéBeaucamp && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidBarnabéBeaucamp && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   NomMaman = "",
                   NomPapa = "",
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "",
               };
        }
        public void Add_FichesSignalétiques_Bracquart_Romain(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRomainBracquart && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidRomainBracquart && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2015),
                   DateDeNaissance = new DateTime(2015, 4, 11),
                   Email = new List<string>() { "pauline.belbenoit@hotmail.fr", "benoitbracquart@hotmail.fr" },
                   NomMaman = "Belbenoit Pauline",
                   NomPapa = "Bracquart Benoit",
                   Telephone = new List<string>() { "+33640598670", "+33612500023" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Bracquart_Romain.pdf",
               };
        }
       
        public void Add_FichesSignalétiques_Mass_Elodie(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidElodieMass && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidElodieMass && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2000),
                   DateDeNaissance = new DateTime(2000, 2, 24),
                   Email = new List<string>() { "elodie.mass24@gmail.com" },
                   Telephone = new List<string>() { "0470/525956" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Mass_Elodie.pdf",
               };
        }
        public void Add_FichesSignalétiques_Carlier_Aurore(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAuroreCarlier && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidAuroreCarlier && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2009),
                   DateDeNaissance = new DateTime(2009, 6, 10),
                   Email = new List<string>() { "cpascalec@live.be", "benoît@live.be" },
                   Telephone = new List<string>() { "0495/362039", "0493/132546" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Carlier_Aurore.pdf",
               };
        }
    }
}