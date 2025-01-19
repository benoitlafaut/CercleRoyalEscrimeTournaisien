using System;
using System.Collections.Generic;
using System.Linq;
using static CercleRoyalEscrimeTournaisien.IndexTireurConstantes;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]    
    public class NosCoursParTireurLoginModel
    {
        public NosCoursParTireurLoginModel()
        {
            GetTireurs();
        }

        private void GetTireurs()
        {
            Tireurs = new List<Tireur>() { };
            Tireurs.AddRange(new List<Tireur> {
                new Tireur() { UserNameIndex = TireurIndex.RémiSoyez, UserName = "Rémi" },
                new Tireur() { UserNameIndex = TireurIndex.ElodieMass, UserName = "Elodie" },
                new Tireur() { UserNameIndex = TireurIndex.EvaDufrasne, UserName = "Eva" },
                new Tireur() { UserNameIndex = TireurIndex.FélixTrannoy, UserName = "Félix" },
                new Tireur() { UserNameIndex = TireurIndex.OscarDeblocq, UserName = "Oscar" },
                new Tireur() { UserNameIndex = TireurIndex.MaybelleCarlier, UserName = "Maybelle" },
                new Tireur() { UserNameIndex = TireurIndex.FabriceRazanajao, UserName = "Fabrice" },
                new Tireur() { UserNameIndex = TireurIndex.AbelMotte, UserName = "Abel" },
                new Tireur() { UserNameIndex = TireurIndex.BaptisteMotte, UserName = "Baptiste" },
                new Tireur() { UserNameIndex = TireurIndex.ArthurBarbery, UserName = "Arthur B." },
                new Tireur() { UserNameIndex = TireurIndex.LeanderCle, UserName = "Leander" },
                new Tireur() { UserNameIndex = TireurIndex.ArthurCouturiaux, UserName = "Arthur C." },
                new Tireur() { UserNameIndex = TireurIndex.JordanMestdagh, UserName = "Jordan" },
                new Tireur() { UserNameIndex = TireurIndex.MartinSiu, UserName = "Martin" },
                new Tireur() { UserNameIndex = TireurIndex.RaedwaldVercouter, UserName = "Raedwald" },
                new Tireur() { UserNameIndex = TireurIndex.EloiBinois, UserName = "Eloi" },
                new Tireur() { UserNameIndex = TireurIndex.AuroreCarlier, UserName = "Aurore" },
                new Tireur() { UserNameIndex = TireurIndex.AnaelleIvanov, UserName = "Anaëlle" },
                new Tireur() { UserNameIndex = TireurIndex.LiliMestdag, UserName = "Lili" },
                new Tireur() { UserNameIndex = TireurIndex.MathildeCarette, UserName = "Mathilde" },
                new Tireur() { UserNameIndex = TireurIndex.MaeVantroyen, UserName = "Mae" },
                new Tireur() { UserNameIndex = TireurIndex.SachaLessart, UserName = "Sacha" },
                new Tireur() { UserNameIndex = TireurIndex.AmadoSimon, UserName = "Amado" },
                new Tireur() { UserNameIndex = TireurIndex.LouisonBinois, UserName = "Louison" },
                new Tireur() { UserNameIndex = TireurIndex.HéloïsePras, UserName = "Héloïse" },
                new Tireur() { UserNameIndex = TireurIndex.RebeccaVandy, UserName = "Rebecca" },
                new Tireur() { UserNameIndex = TireurIndex.EliotPunchoo, UserName = "Eliot" },
            });            

            Tireurs = Tireurs.OrderBy(x => x.UserName).ToList();
        }

        public int UserNameIndexSelectionne { get; set; }
        public string UserNameSelectionne { get; set; }
        public string PasswordSelectionne { get; set; }       
        public List<Tireur> Tireurs { get; set; }
    }  
}