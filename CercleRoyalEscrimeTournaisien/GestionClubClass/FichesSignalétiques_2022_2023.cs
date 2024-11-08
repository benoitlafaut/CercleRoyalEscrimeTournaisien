using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class FichesSignalétiques_2022_2023
    {
        public void Add_FichesSignalétiques_Leclercq_Cyril(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidCyrilLeclercq && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidCyrilLeclercq && x.Période == period).FirstOrDefault().Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2015),
                  DateDeNaissance = new DateTime(2015, 02, 21),
                  Email = new List<string>() { "marjorie.schoonjans@gmail.com", "yvesleclercq2@gmail.com" },
                  NomMaman = "Schoonjans Marjorie",
                  NomPapa = "Leclercq Yves",
                  Telephone = new List<string>() { "0493/812784", "0493/812787" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Leclercq_Cyril.pdf",
//Groupe = new List<string>() { GetEnumDescription(Groupe.One) } ,                  
              };
        }
        public  void Add_FichesSignalétiques_Deblocq_Judith(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidJudithDeblocq && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidJudithDeblocq && x.Période == period).FirstOrDefault().Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2013),
                  DateDeNaissance = new DateTime(2013, 08, 22),
                  Email = new List<string>() { "vdeblocq@gmail.com", "cecile.duplat@gmail.com" },
                  NomMaman = "Duplat Cecile",
                  NomPapa = "Deblocq Vincent",
                  Telephone = new List<string>() { "0473/352418", "0479/503655" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Deblocq_Judith.pdf",
               //   Groupe = new List<string>() { GetEnumDescription(Groupe.One) },
              };
        }
        public  void Add_FichesSignalétiques_Deblocq_Oscar(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidOscarDeblocq && x.Période == period ))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidOscarDeblocq && x.Période == period).FirstOrDefault().Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2011),
                  DateDeNaissance = new DateTime(2011, 12, 16),
                  Email = new List<string>() { "vdeblocq@gmail.com", "cecile.duplat@gmail.com" },
                  NomMaman = "Duplat Cecile",
                  NomPapa = "Deblocq Vincent",
                  Telephone = new List<string>() { "0473/352418", "0479/503655" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Deblocq_Oscar.pdf",
                 // Groupe = new List<string>() { GetEnumDescription( Groupe.One), GetEnumDescription(Groupe.Two) },
              };
        }
        public  void Add_FichesSignalétiques_Carlier_Maybelle(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMaybelleCarlier && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidMaybelleCarlier && x.Période == period).FirstOrDefault().Signaletique =
              new Signaletique()
              {
                  Categorie = Categorie.Inconnu,
                  DateDeNaissance = new DateTime(9999, 12, 31),
                  Email = new List<string>() { "marjorie.dupont2807@gmail.com" },
                  NomMaman = "Dupont Marjorie",
                  NomPapa = "",
                  Telephone = new List<string>() { "0471/535515" },
                  FicheSignaletiqueUrl = "",
               //   Groupe = new List<string>() { GetEnumDescription(Groupe.Two) },
              };
        }
        public  void Add_FichesSignalétiques_Gillet_Thomas(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidThomasGillet && x.Période == period ))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidThomasGillet && x.Période == period).FirstOrDefault().Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2002),
                  DateDeNaissance = new DateTime(2002, 06, 27),
                  Email = new List<string>() { "thgi2706@gmail.com", "vgi7500@gmail.com" },
                  NomMaman = "Delhaye Muriel",
                  NomPapa = "Gillet Vincent",
                  Telephone = new List<string>() { "0475/230601", "0483/451488", "0487258346" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Gillet_Thomas.pdf",
              //    Groupe = new List<string>() { GetEnumDescription(Groupe.Two) },
              };
        }
        public  void Add_FichesSignalétiques_Debruyne_Helena(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidHelenaDebruyne && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidHelenaDebruyne && x.Période == period).FirstOrDefault().Signaletique =
              new Signaletique()
              {
                  Categorie = Categorie.Inconnu,
                  DateDeNaissance = new DateTime(9999, 12, 31),
                  Email = new List<string>() { "aleidruijs@hotmail.com", "abdebruyne@hotmail.com" },
                  NomMaman = "Ruijs Aleid",
                  NomPapa = "Debruyne Pieter",
                  Telephone = new List<string>() { "0470/428854" },
                  FicheSignaletiqueUrl = "",
             //     Groupe = new List<string>() { GetEnumDescription(Groupe.One) },
              };
        }
        public  void Add_FichesSignalétiques_Debruyne_Karel(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidKarelDebruyne && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidKarelDebruyne && x.Période == period).FirstOrDefault().Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2011),
                  DateDeNaissance = new DateTime(2011, 8, 18),
                  Email = new List<string>() { "aleidruijs@hotmail.com", "abdebruyne@hotmail.com" },
                  NomMaman = "Ruijs Aleid",
                  NomPapa = "Debruyne Pieter",
                  Telephone = new List<string>() { "0470/428854" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Debruyne_Karel.pdf",
              //    Groupe = new List<string>() { GetEnumDescription(Groupe.One), GetEnumDescription(Groupe.Two) },
              };
        }
        public  void Add_FichesSignalétiques_Lemaire_Antoine(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidAntoineLemaire && x.Période == period))
            {
                return;
            }

            Membres.Where(x => x.GuidId == GuidConstantes.GuidAntoineLemaire && x.Période == period).FirstOrDefault().Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2007),
                  DateDeNaissance = new DateTime(2007, 2, 24),
                  Email = new List<string>() { "manfroid.stephanie@skynet.be", "crolem.TL@gmail.com" },
                  NomMaman = "Manfroid Stéphanie",
                  NomPapa = "Lemaire Thierry",
                  Telephone = new List<string>() { "0475/971303", "0472/574080" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Lemaire_Antoine.pdf",
                 // Groupe = new List<string>() { GetEnumDescription(Groupe.Two) },
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
                  Categorie = ListGuidTireur.SearchCategorie(2002) ,
                  DateDeNaissance = new DateTime(2002, 5, 29),
                  Email = new List<string>() { "bedidamada@gmail.com", "bedidakely@live.be" },
                  NomMaman = "Andrianasoloson Nera Tiana",
                  NomPapa = "Razanajao Harilala",
                  Telephone = new List<string>() { "0493/507810", "0493/306050" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Razanajao_Fabrice.pdf",
            //      Groupe = new List<string>() {  GetEnumDescription(Groupe.Two) },
              };
        }
        public  void Add_FichesSignalétiques_Trannoy_Félix(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidFélixTrannoy && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidFélixTrannoy  && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2023),
                  DateDeNaissance = new DateTime(2013, 10, 17),
                  Email = new List<string>() { "valerie_regis@live.be" },
                  NomMaman = "Chirez Valérie",
                  NomPapa = "Trannoy Régis",
                  Telephone = new List<string>() { "0472/289741", "0477/566152" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Trannoy_Félix.pdf",
            //      Groupe = new List<string>() { GetEnumDescription(Groupe.One) },
              };
        }
        public  void Add_FichesSignalétiques_Delmotte_Maxime(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidMaximeDelmotte && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidMaximeDelmotte && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(1987),
                  DateDeNaissance = new DateTime(1987, 5, 19),
                  Email = new List<string>() { "maxime.delmotte@gmail.com" },
                  NomMaman = "",
                  NomPapa = "",
                  Telephone = new List<string>() { "0497/694208" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Delmotte_Maxime.pdf",
            //      Groupe = new List<string>() { GetEnumDescription(Groupe.Two) },
              };
        }
        public  void Add_FichesSignalétiques_Dooms_Gabriel(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidGabrielDooms  && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidGabrielDooms && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2012),
                  DateDeNaissance = new DateTime(2012, 11, 20),
                  Email = new List<string>() { "anne.parys.dooms@gmail.com", "ldooms@gmail.com" },
                  NomMaman = "Parys Anne",
                  NomPapa = "Dooms Louis",
                  Telephone = new List<string>() { "0474/283813", "0494/421591" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Dooms_Gabriel.pdf",
             //     Groupe = new List<string>() { GetEnumDescription(Groupe.One) },
              };
        }
        public  void Add_FichesSignalétiques_Dooms_Jules(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidJulesDooms  && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidJulesDooms && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2014),
                  DateDeNaissance = new DateTime(2014, 07, 24),
                  Email = new List<string>() { "anne.parys.dooms@gmail.com", "ldooms@gmail.com" },
                  NomMaman = "Parys Anne",
                  NomPapa = "Dooms Louis",
                  Telephone = new List<string>() { "0474/283813", "0494/421591" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Dooms_Jules.pdf",
           //       Groupe = new List<string>() { GetEnumDescription(Groupe.One) },
              };
        }
        public  void Add_FichesSignalétiques_Carlier_Arthur(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidArthurCarlier && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidArthurCarlier && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2015),
                  DateDeNaissance = new DateTime(2015, 06, 4),
                  Email = new List<string>() { "c.ragot@icloud.com" },
                  NomMaman = "Ragot Carole",
                  NomPapa = "Carlier Alexis",
                  Telephone = new List<string>() { "0033626433883", "0033672403024" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Carlier_Arthur.pdf",
             //     Groupe = new List<string>() { GetEnumDescription(Groupe.One) },
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
         //         Groupe = new List<string>() { GetEnumDescription(Groupe.One) },
              };
        }
        public  void Add_FichesSignalétiques_Brabant_Eliot(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidEliotBrabant && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidEliotBrabant && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2008),
                  DateDeNaissance = new DateTime(2008, 7, 28),
                  Email = new List<string>() { "sophiedobbelaere21@gmail.com", "flo_julien@outlook.be" },
                  NomMaman = "Dobbelaere Sophie",
                  NomPapa = "Brabant Julien",
                  Telephone = new List<string>() { "0470/813478", "0491/756677" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Brabant_Eliot.pdf",
              //    Groupe = new List<string>() { GetEnumDescription(Groupe.Two) },
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
                  Categorie = Categorie.Inconnu,
                  DateDeNaissance = new DateTime(9999, 12, 31),
                  Email = new List<string>() { "contact@coach-anneberrier.be" },
                  NomMaman = "Berrier Anne",
                  NomPapa = "",
                  Telephone = new List<string>() { "0472951152" },
                  FicheSignaletiqueUrl = "",
            //      Groupe = new List<string>() { GetEnumDescription(Groupe.Two) },
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
                  Email = new List<string>() { "arthurbarbery@icloud.com","sb.sophie.bellet@gmail.com", "jfbarbery@yahoo.fr" },
                  NomMaman = "Bellet Sophie",
                  NomPapa = "Barbery JF",
                  Telephone = new List<string>() { "0033632904612", "0491649753","0488573000" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Barbery_Arthur.pdf",
            //      Groupe = new List<string>() { GetEnumDescription(Groupe.Two) },
              };
        }

        public  void Add_FichesSignalétiques_Dransart_NoelMarie(string period, List<MembreData> Membres)
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
                  Email = new List<string>() { "o.dransart7500@gmail.com", "pelille76@gmail.com" },
                  NomMaman = "Dransart Oana",
                  NomPapa = "Dransart Pierre-Emmanuel",
                  Telephone = new List<string>() { "0033647413691", "0033674801500" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Dransart_Noel_Marie.pdf",
         //         Groupe = new List<string>() { GetEnumDescription(Groupe.One) },
              };
        }
        public  void Add_FichesSignalétiques_Dransart_Iann(string period, List<MembreData> Membres)
        {
            if (!Membres.Any(x => x.GuidId == GuidConstantes.GuidIannDransart && x.Période == period))
            {
                return;
            }

            Membres.FirstOrDefault(x => x.GuidId == GuidConstantes.GuidIannDransart && x.Période == period).Signaletique =
              new Signaletique()
              {
                  Categorie = ListGuidTireur.SearchCategorie(2014),
                  DateDeNaissance = new DateTime(2014, 03, 03),
                  Email = new List<string>() { "o.dransart7500@gmail.com", "pelille76@gmail.com" },
                  NomMaman = "Dransart Oana",
                  NomPapa = "Dransart Pierre-Emmanuel",
                  Telephone = new List<string>() { "0033647413691", "0033674801500" },
                  FicheSignaletiqueUrl = "../../FileToUpload/FichesSignaletiques/Dransart_Iann.pdf",
       ///           Groupe = new List<string>() { GetEnumDescription(Groupe.One) },
              };
        }
    }
}