using System;
using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien.Models
{
    [Serializable]
    public class ModelEpub122024
    {
        public ModelEpub122024() 
        {
            RowsToRead = new List<string>() { } ;
            CurrentStep = 0;
            MotFR = string.Empty;
            MotDE = string.Empty;
            MotEN = string.Empty;
            MotES = string.Empty;
            MotNL = string.Empty;
            MotIT = string.Empty;
            PhraseFR = string.Empty;
            PhraseDE = string.Empty;
            PhraseEN = string.Empty;
            PhraseES = string.Empty;
            PhraseNL = string.Empty;
            PhraseIT = string.Empty;
        }

        public int CurrentStepToListen { get; set; }
        public int NumberScrollWithWheel { get; set; }
        public int CurrentStep { get; set; }
        public int CurrentStepFinal
        {
            get 
            {
                if (RowsToRead.Count == 0) { return 0; }
                if (CurrentStep + 10 > RowsToRead.Count) { return RowsToRead.Count; }
                return CurrentStep + 10;
            }
        }
        public List<string> RowsToRead { get; set; }

        public string MotFR { get; set; }
        public string MotDE { get; set; }
        public string MotEN { get; set; }
        public string MotES { get; set; }
        public string MotNL { get; set; }
        public string MotIT { get; set; }
        public string PhraseFR { get; set; }
        public string PhraseDE { get; set; }
        public string PhraseEN { get; set; }
        public string PhraseES { get; set; }
        public string PhraseNL { get; set; }
        public string PhraseIT { get; set; }
    }
}