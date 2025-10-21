using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using static CercleRoyalEscrimeTournaisien.ClassEnumLanguage;

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
        public bool IsLectureWithLangue { get; set; }
        public int CurrentStepToListen { get; set; }
        public int ScrollTopStart { get; set; }
        public int ScrollTopEnd { get; set; }
        public int PositionStartForNoScrollbar { get; set; }
        public int PositionEndForNoScrollbar { get; set; }
        public int CurrentStep { get; set; }
        public string FileNameBook { get; set; }
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
        public string LanguageForLanguageDefaultSelected { get; set; }
        public string LanguageItemsForTraduceAutomaticallySelected { get; set; }
        
        public List<EnumLanguageItem> CheckBoxLanguageItemsForTraduceAutomatically
        {
            get
            {
                List<EnumLanguageItem> list = new List<EnumLanguageItem>()
                {
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/french.svg", Language = GetDisplayName(EnumLanguage.Français), IsSelected = true },
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/néerlandais.svg", Language = GetDisplayName(EnumLanguage.Néerlandais), IsSelected = false },
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/anglais.svg", Language = GetDisplayName(EnumLanguage.Anglais), IsSelected = false },
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/espagnol.svg", Language = GetDisplayName(EnumLanguage.Espagnol), IsSelected = false },
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/allemand.svg", Language = GetDisplayName(EnumLanguage.Allemand), IsSelected = false },
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/italien.svg", Language = GetDisplayName(EnumLanguage.Italien), IsSelected = false }
                };
                return list;
            }
        }
        
        public List<EnumLanguageItem> CheckBoxLanguageItemsForLanguageDefault 
        { 
            get
            {
                List<EnumLanguageItem> list = new List<EnumLanguageItem>()
                {
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/french.svg", Language = GetDisplayName(EnumLanguage.Français), IsSelected = true },
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/néerlandais.svg", Language = GetDisplayName(EnumLanguage.Néerlandais), IsSelected = false },
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/anglais.svg", Language = GetDisplayName(EnumLanguage.Anglais), IsSelected = false },
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/espagnol.svg", Language = GetDisplayName(EnumLanguage.Espagnol), IsSelected = false },
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/allemand.svg", Language = GetDisplayName(EnumLanguage.Allemand), IsSelected = false },
                    new EnumLanguageItem() { UrlFlag = "../Content/SVG/italien.svg", Language = GetDisplayName(EnumLanguage.Italien), IsSelected = false }
                };
                return list;
            }
        }
        public string GetDisplayName( Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }
    }

    public class EnumLanguageItem
    {
        public string UrlFlag { get; set; }
        public string Language { get; set; }
        public bool IsSelected { get; set; }
    }
}