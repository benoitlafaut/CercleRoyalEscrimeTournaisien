using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien.Models
{
    [Serializable]
    public class ModelEpub20042023
    {
        public ModelEpub20042023() 
        {
            RowsToRead = new List<string>() { } ;
        }

        public List<string> RowsToRead { get; set; }
        public string TitreLivre { get; set; }
        public int CurrentRowSelected { get; set; }
    }
}