using System;

namespace CercleRoyalEscrimeTournaisien
{
    [Serializable]
    public class Tireur
    {
        public string UserName { get; set; }
        public IndexTireurConstantes.TireurIndex UserNameIndex { get; set; }
    }
}