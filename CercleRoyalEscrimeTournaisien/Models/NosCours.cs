﻿using CercleRoyalEscrimeTournaisien.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CercleRoyalEscrimeTournaisien
{
    public class NosCours
    {
        public NosCours()
        {
            NewSelectedIndexTheme = 0;

            const string libelléTheme1 = "L'épée";
            const string libelléTheme2 = "Les déplacements";
            const string libelléTheme3 = "Les armes";
            const string libelléTheme4 = "Les différentes positions";
            const string libelléTheme5 = "Introduction à l'escrime";
            const string libelléTheme6 = "Le sabre";
            const string libelléTheme7 = "Le fleuret";

            ALL_Themes = new List<clsThemes>();

            #region introduction à l'escrime
            TryAdd(libelléTheme5,
                     "Les valeurs de l'escrime",
                     //*"https://www.youtube.com/watch?v=K_xWIU3gDa4",*//
                     "https://www.youtube.com/embed/K_xWIU3gDa4?autoplay=1",
                     "'lesvaleursdelescrime.jpg'");

            TryAdd(libelléTheme5,
                                 "Les règles de sécurité",
                                 "",
                                 "'reglesdesecurité.jpg'");


            TryAdd(libelléTheme5,
                     "L'explication de l'escrime",
                     "https://www.youtube.com/embed/rMjLZEYEbcs?start=0&end=127&autoplay=1",
                     "");

            TryAdd(libelléTheme5,
                        "Les qualités de l'escrimeur",
                        "https://www.youtube.com/embed/rMjLZEYEbcs?start=513&end=537&autoplay=1",
                        "");

            TryAdd(libelléTheme5,
                        "L'équipement",
                        "https://www.youtube.com/embed/rMjLZEYEbcs?start=168&end=200&autoplay=1",
                        "");

            TryAdd(libelléTheme5,
                        "La piste",
                        "https://www.youtube.com/embed/rMjLZEYEbcs?start=136&end=158&autoplay=1",
                        "");
            #endregion

            #region les déplacements

            TryAdd(libelléTheme2,
           "Introduction aux déplacements",
           "https://www.youtube.com/embed/rMjLZEYEbcs?start=232&end=264&autoplay=1",
           "");

            TryAdd(libelléTheme2,
                  "Une erreur fréquente des déplacements",
                  "https://www.youtube.com/embed/rMjLZEYEbcs?start=291&end=297&autoplay=1",
                  "");

            TryAdd(libelléTheme2,
                    "Le marché et le rompé - Partie 1",
                    "https://www.youtube.com/embed/rMjLZEYEbcs?start=263&end=274&autoplay=1",
                    "");

            TryAdd(libelléTheme2,
                    "Le marché et le rompé - Partie 2",
                    "https://www.youtube.com/embed/PPHrpJfwD64?start=53&end=61&autoplay=1",
                    "");

            TryAdd(libelléTheme2,
                    "La passe avant et la passe arrière",
                    "https://www.youtube.com/embed/rMjLZEYEbcs?start=275&end=282&autoplay=1",
                    "");

            TryAdd(libelléTheme2,
                    "Le bond avant et le bond arrière",
                    "https://www.youtube.com/embed/rMjLZEYEbcs?start=283&end=291&autoplay=1",
                    "");

            TryAdd(libelléTheme2,
                    "La flèche",
                    "https://www.youtube.com/embed/PPHrpJfwD64?start=220&end=230&autoplay=1",
                    ""); 
            
            TryAdd(libelléTheme2,
                    "La distance",
                    "https://www.youtube.com/embed/lRVTkVc8AJY?start=1&end=142&autoplay=1",
                    "");
            #endregion

            #region le fleuret

            TryAdd(libelléTheme7,
                   "Les positions de main - sixte, quarte, septime et octave",
                   "https://www.youtube.com/embed/mFYFQ8clY80?start=7&end=151&autoplay=1",
                   "");

            TryAdd(libelléTheme7,
                   "Les attaques simples",
                   "https://www.youtube.com/embed/CbeKK_atvQY?autoplay=1",
                   "");

            TryAdd(libelléTheme7,
                             "Les attaques composées",
                             "https://www.youtube.com/embed/Q7Xbg05RzOM?autoplay=1",
                             "");



            #endregion

            #region l'épée

            TryAdd(libelléTheme1,
                   "Les actions offensives - Le coup droit en fente",
                   "https://www.youtube.com/embed/JZF5Qwi4Ofo?start=4&end=9&autoplay=1",
                   "");

            TryAdd(libelléTheme1,
                  "Les actions offensives - Le coup droit en flèche",
                  "https://www.youtube.com/embed/JZF5Qwi4Ofo?start=12&end=14&autoplay=1",
                  "");

            #endregion

            #region le sabre

            TryAdd(libelléTheme6,
                   "Les positions de main - la tierce, la quarte et la quinte",
                   "https://www.youtube.com/embed/mFYFQ8clY80?start=176&end=216&autoplay=1",
                   "");

          

            #endregion

            #region les armes

            TryAdd(libelléTheme3,
                    "Introduction aux armes",
                    "https://www.youtube.com/embed/rMjLZEYEbcs?start=300&end=309&autoplay=1",
                    "");

            TryAdd(libelléTheme3,
                        "La tenue de l'arme au fleuret",
                        "https://www.youtube.com/embed/PMRwkTal5sc?start=25&end=162&autoplay=1",
                    "");

            TryAdd(libelléTheme3,
                        "La garde à l'épée",
                        "https://www.youtube.com/embed/ozPcWw-MOQM?start=15&end=52&autoplay=1",
                    "");
 
            TryAdd(libelléTheme3,
                        "Le fleuret",
                        "https://www.youtube.com/embed/rMjLZEYEbcs?start=310&end=351&autoplay=1",
                    "'lefleuret.jpg'");
           
            TryAdd(libelléTheme3,
                        "L'épée",
                        "https://www.youtube.com/embed/rMjLZEYEbcs?start=353&end=378&autoplay=1",
                    "'epée.jpg'");

            TryAdd(libelléTheme3,
                        "Le sabre",
                        "https://www.youtube.com/embed/rMjLZEYEbcs?start=379&end=410&autoplay=1",
                    "'lesabre.jpg'");

            TryAdd(libelléTheme3,
                        "Qui a le point?",
                        "https://www.youtube.com/embed/rMjLZEYEbcs?start=486&end=507&autoplay=1",
                    "");

            TryAdd(libelléTheme3,
                        "Un peu d'arbitrage",
                        "https://www.youtube.com/embed/rMjLZEYEbcs?start=596&end=694&autoplay=1",
                    "");
            #endregion

            #region les différentes positions

            TryAdd(libelléTheme4,
                        "Le salut",
                        "https://www.youtube.com/embed/rMjLZEYEbcs?start=546&end=552&autoplay=1",
                    "");

            TryAdd(libelléTheme4,
                      "La position d'attente",
                      "",
                  "'lapositiondattente.jpg'");

            TryAdd(libelléTheme4,
                      "La position préparatoire",
                      "",
                  "'lapositionpreparatoire.jpg'");
            #endregion

            AllTitresThemeDistinct = ALL_Themes.Select(x=>x.Theme).ToList().Distinct();

            ALL_ThemesSelected = ALL_Themes.Where(x => x.Theme == AllTitresThemeDistinct.ElementAt(Convert.ToInt32(NewSelectedIndexTheme)));
            
        }
        public string ThemeSelectionne { get; set; }
        public string Newsletter { get; set; }

        public IDictionary<string, string> ListeDesThemes
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "","" },
                    { "1","La position en garde au fleuret et épée" },
                    { "2","Les 4 positions de main de base au  fleuret" },
                    { "3","Les gestes d'arbitre" }
                };
            }
        }
        public int NewSelectedIndexTheme { get; set; }
        private void TryAdd(string theme, string titreTheme, string urlTheme, string image)
        {
            ALL_Themes = ALL_Themes.Append(new clsThemes()
            {
                Theme = theme,
                TitreTheme = titreTheme,
                UrlTheme = urlTheme,
                Image = image
            });
        }
        public IEnumerable<clsThemes> ALL_Themes { get; set; }
        public IEnumerable<clsThemes> ALL_ThemesSelected { get; set; }
        public IEnumerable<string> AllTitresThemeDistinct { get; set; }
        //public int SelectedIndexTheme { get; set; }
    }
}