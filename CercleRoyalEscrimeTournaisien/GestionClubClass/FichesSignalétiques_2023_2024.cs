using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WebApplication1.Models
{
    public  class FichesSignalétiques_2023_2024
    {
        private string period { get { return "2023-2024"; } }

        public void Add_FichesSignalétiques_Leclercq_Cyril(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidCyrilLeclercq && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidCyrilLeclercq && x.Période == period).FirstOrDefault().Signaletique =
              new Signaletique()
              {
                  Categorie = Categorie.U11,
                  DateDeNaissance = new DateTime(2015, 02, 21),
                  Email = new List<string>() { "marjorie.schoonjans@gmail.com", "yvesleclercq2@gmail.com" },
                  NomMaman = "Schoonjans Marjorie",
                  NomPapa = "Leclercq Yves",
                  Telephone = new List<string>() { "0493/812784", "0493/812787" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Leclercq_Cyril.pdf",
              };
        }
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
        public  void Add_FichesSignalétiques_Motte_Abel(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAbelMotte && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidAbelMotte && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "motte.archi@gmail.com", "delphine.vercauteren@gmail.com" },
                   NomPapa = "Motte Sébastien",
                   NomMaman = "Vercauteren Delphine",
                   Telephone = new List<string>() { "0496/799495", "0473/766523" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Motte_Abel.pdf",
               };
        }
        public  void Add_FichesSignalétiques_Trannoy_Félix(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFélixTrannoy && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidFélixTrannoy && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2023),
                  DateDeNaissance = new DateTime(2013, 10, 17),
                  Email = new List<string>() { "valerie_regis@live.be" },
                  NomMaman = "Chirez Valérie",
                  NomPapa = "Trannoy Régis",
                  Telephone = new List<string>() {  },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Trannoy_Félix.pdf",
              };
        }

        public  void Add_FichesSignalétiques_Courret_Margaux(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMargauxCourret && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidMargauxCourret && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2016),
                   DateDeNaissance = new DateTime(2016, 2, 9),
                   Email = new List<string>() { "rcourret@b-centurion.fr", "juliarenaudo@hotmail.fr" },
                   NomPapa = "Courret Romain",
                   NomMaman = "Renaudo Julia",
                   Telephone = new List<string>() { "0033687842747", "0033637327459" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Courret_Margaux.pdf",
               };
        }
     
        public  void Add_FichesSignalétiques_Razanajao_Fabrice(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFabriceRazanajao && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidFabriceRazanajao && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2002),
                   DateDeNaissance = new DateTime(2002,5,29),
                   Email = new List<string>() { "bedidamada@gmail.com", "" },
                   NomMaman = "Andrianasoloson Nera Tiana",
                   NomPapa = "Razanajao Harilala",
                   Telephone = new List<string>() { "0493/507810", "0493/306050" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Razanajao_Fabrice.pdf",
               };
        }
        public  void Add_FichesSignalétiques_Dufrasne_Eva(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidEvaDufrasne && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidEvaDufrasne && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2010),
                   DateDeNaissance = new DateTime(2010,9,28),
                   Email = new List<string>() { "vanessa.fernandez.do@gmail.com" },
                   NomMaman = "Fernandez Vanessa",
                   NomPapa = "Dufrasne Alain",
                   Telephone = new List<string>() { "0479/429854", "0485/513101" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Dufrasne_Eva.pdf",
               };
        }

        public  void Add_FichesSignalétiques_Carlier_Maybelle(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMaybelleCarlier && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidMaybelleCarlier && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2008),
                   DateDeNaissance = new DateTime(2008, 8, 8),
                   Email = new List<string>() { "marjorie.dupont2807@gmail.com" },
                   NomMaman = "Dupont Marjorie",
                   NomPapa = "",
                   Telephone = new List<string>() { "0471/535515" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Carlier_Maybelle.pdf",
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
        public  void Add_FichesSignalétiques_Deblocq_Judith(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidJudithDeblocq && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidJudithDeblocq && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2013),
                   DateDeNaissance = new DateTime(2013, 8, 22),
                   Email = new List<string>() { "vdeblocq@gmail.com", "cecile.duplat@gmail.com" },
                   NomPapa = "Deblocq Vincent",
                   NomMaman = "Duplat Cecile",
                   Telephone = new List<string>() { "0473/352418", "0479/503655" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Deblocq_Judith.pdf",
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
        public  void Add_FichesSignalétiques_Waeselynck_Lisa(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLisaWaeselynck && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidLisaWaeselynck && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2010),
                   DateDeNaissance = new DateTime(2010, 11, 03),
                   Email = new List<string>() { "contact@coach-anneberrier.be", "pierre.waeselynck@outlook.com" },
                   NomPapa = "Waeselynck Pierre",
                   NomMaman = "Berrier Anne",
                   Telephone = new List<string>() { "0472/951152", "+33637632638" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Waeselynck_Lisa.pdf",
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
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   NomPapa = "Soyez Rudy",
                   NomMaman = "",
                   Telephone = new List<string>() { "" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/soyez_remi.pdf",
               };
        }
      
        public  void Add_FichesSignalétiques_Cle_Leander(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidLeanderCle && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidLeanderCle && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = ListGuidTireur.SearchCategorie(2014),
                   DateDeNaissance = new DateTime(2014, 01, 10),
                   Email = new List<string>() { "grietli@hotmail.com", "christian.cle@gmail.com" },
                   NomPapa = "Cle Christian",
                   NomMaman = "Hutsentruyt Griet",
                   Telephone = new List<string>() { "0485851505", "0497810157" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Cle_Leander.pdf",
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
                   Telephone = new List<string>() { "0471/037292" },
                   FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Siu_Martin.pdf",
               };
        }
        public  void Add_FichesSignalétiques_Vercouter_Raedwald(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidRaedwaldVercouter && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidRaedwaldVercouter && x.Période == period).Signaletique =
               new Signaletique()
               {
                   Categorie = Categorie.Inconnu,
                   DateDeNaissance = new DateTime(9999, 12, 31),
                   Email = new List<string>() { "" },
                   Telephone = new List<string>() { "" },
               };
        }
      
      
        
    }
}