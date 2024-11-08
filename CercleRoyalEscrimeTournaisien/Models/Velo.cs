using System;

namespace CercleRoyalEscrimeTournaisien.Models
{
    [Serializable]
    public class Velo
    {
        public Velo() 
        {
            SequencyListenHour = "1";

        }
        public string SequencyListenHour { get; set; }

    }
}