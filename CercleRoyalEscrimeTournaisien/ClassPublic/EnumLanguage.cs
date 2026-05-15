using System.ComponentModel.DataAnnotations;

namespace CercleRoyalEscrimeTournaisien
{
    public class ClassEnumLanguage
    {    
        public  enum EnumLanguage
        {
            [Display(Name = "fra")]
            Français = 1,
            [Display(Name = "dut")]
            Néerlandais = 2,
            [Display(Name = "eng")]
            Anglais = 3,
            [Display(Name = "ger")]
            Allemand = 4,
            [Display(Name = "ita")]
            Italien = 5,
            [Display(Name = "spa")]
            Espagnol = 6,
        }
    }
}