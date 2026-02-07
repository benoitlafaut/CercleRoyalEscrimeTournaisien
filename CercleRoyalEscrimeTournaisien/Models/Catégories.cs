using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien
{
    public class Categories
    {
        public Normes Normes { get; set; }
        public static string Title { get; set; } 
        public  List<string> RowsOfCol_1 { get; set; }
        public  List<string> RowsOfCol_2 { get; set; }
        public  List<string> RowsOfCol_3 { get; set; }
        public List<string> RowsOfCol_4 { get; set; }
        public List<string> RowsOfCol_5 { get; set; }

        public Categories()
        {
            Normes = new Normes();
            Title = "Les catégories pour la saison 2025-2026";
            RowsOfCol_1 = new List<string>() { "Catégorie", "U11", "U13", "U15", "U17", "U20", "U23", "Senior", "Vétéran 40+", "Vétéran 50+","Vétéran 60+", "Vétéran 70+" };
            RowsOfCol_2 = new List<string>() { "2022-2023", "2012-2013", "2010-2011", "2008-2009", "2006-2007", "2003-2005", "2000-2002", "à partir de 2002", "1973-1982", "1963-1972", "1953-1962", "1922-1952" };
            RowsOfCol_3 = new List<string>() { "2023-2024", "2013-2014", "2011-2012", "2009-2010", "2007-2008", "2004-2006", "2001-2003", "à partir de 2003", "1974-1983", "1964-1973", "1954-1963", "1923-1953" };
            RowsOfCol_4 = new List<string>() { "2024-2025", "2014-2015", "2012-2013", "2010-2011", "2008-2009", "2005-2007", "2002-2004", "à partir de 2004", "1975-1984", "1965-1974", "1955-1964", "1924-1954" };
            RowsOfCol_5 = new List<string>() { "Année de naissance", "2015-2016", "2013-2014", "2011-2012", "2009-2010", "2006-2008", "2003-2005", "à partir de 2005", "1976-1985", "1966-1975", "1956-1965", "1925-1955" };
        }
    }    
}