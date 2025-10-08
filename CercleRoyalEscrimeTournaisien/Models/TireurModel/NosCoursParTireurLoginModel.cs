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
                new Tireur() { UserNameIndex = TireurIndex.FélixTrannoy, UserName = "Félix" },
                new Tireur() { UserNameIndex = TireurIndex.OscarDeblocq, UserName = "Oscar Deblocq" },
                new Tireur() { UserNameIndex = TireurIndex.FabriceRazanajao, UserName = "Fabrice" },
                new Tireur() { UserNameIndex = TireurIndex.AbelMotte, UserName = "Abel" },
                new Tireur() { UserNameIndex = TireurIndex.BaptisteMotte, UserName = "Baptiste" },
                new Tireur() { UserNameIndex = TireurIndex.ArthurCouturiaux, UserName = "Arthur C." },
                new Tireur() { UserNameIndex = TireurIndex.JordanMestdagh, UserName = "Jordan" },
                new Tireur() { UserNameIndex = TireurIndex.MartinSiu, UserName = "Martin" },
                new Tireur() { UserNameIndex = TireurIndex.RaedwaldVercouter, UserName = "Raedwald" },
                new Tireur() { UserNameIndex = TireurIndex.AuroreCarlier, UserName = "Aurore" },
                new Tireur() { UserNameIndex = TireurIndex.AnaelleIvanov, UserName = "Anaëlle" },
                new Tireur() { UserNameIndex = TireurIndex.LiliMestdag, UserName = "Lili" },
                new Tireur() { UserNameIndex = TireurIndex.MaeVantroyen, UserName = "Maé" },
                new Tireur() { UserNameIndex = TireurIndex.AmadoSimon, UserName = "Amado" },
                new Tireur() { UserNameIndex = TireurIndex.RebeccaVandy, UserName = "Rebecca" },
                new Tireur() { UserNameIndex = TireurIndex.EliotPunchoo, UserName = "Eliot" },
                new Tireur() { UserNameIndex = TireurIndex.NoelMarieDransart, UserName = "Noël-Marie" },
                new Tireur() { UserNameIndex = TireurIndex.NayaBeaucamp, UserName = "Naya" },
                new Tireur() { UserNameIndex = TireurIndex.BarnabéBeaucamp, UserName = "Barnabé" },
                new Tireur() { UserNameIndex = TireurIndex.RomainBracquart, UserName = "Romain" },
                new Tireur() { UserNameIndex = TireurIndex.BenedictCosentini, UserName = "Benedict" },
                new Tireur() { UserNameIndex = TireurIndex.ThéoCuchevalRasson, UserName = "Théo" },
                new Tireur() { UserNameIndex = TireurIndex.OscarDucrot, UserName = "Oscar Ducrot" },
                new Tireur() { UserNameIndex = TireurIndex.AmelLawrizy, UserName = "Amel" },
                new Tireur() { UserNameIndex = TireurIndex.GwendalLecomte, UserName = "Gwendal" },
                new Tireur() { UserNameIndex = TireurIndex.SolalSchrouf, UserName = "Solal" },
                new Tireur() { UserNameIndex = TireurIndex.LucasVerheye, UserName = "Lucas" },
            });            

            Tireurs = Tireurs.OrderBy(x => x.UserName).ToList();
        }

        public int UserNameIndexSelectionne { get; set; }
        public string UserNameSelectionne { get; set; }
        public string PasswordSelectionne { get; set; }       
        public List<Tireur> Tireurs { get; set; }
    }  
}