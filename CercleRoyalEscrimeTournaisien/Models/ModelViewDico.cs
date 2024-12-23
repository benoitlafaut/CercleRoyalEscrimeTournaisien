using System.Collections.Generic;
using System.Linq;

namespace CercleRoyalEscrimeTournaisien.Models
{
    public class ModelViewDico
    {
        public ModelViewDico()
        {
            WordsOutputList = new List<classWord>() { };
        }

        public string WordInputOne { get; set; }
        public string WordInputTwo { get; set; }
        public string WorldInput { get; set; }
        public string WorldInputTemporaire { get; set; }        

        public List<classWord> WordsOutputList { get; set; }

        public List<string> WordFounded
        {
            get
            {
                return WordsOutputList.Select(x => x.Word).ToList();
            }

        }
    }

    public class classWord
    {
        public string Word { get; set; }
        public string Definition { get; set; }
    }
}