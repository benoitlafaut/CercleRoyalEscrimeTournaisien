using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CercleRoyalEscrimeTournaisien
{
    public class ClassEnumLanguage
    {    
        public  enum EnumLanguage
        {
            [Display(Name = "FR")]
            Français = 1,
            [Display(Name = "NL")]
            Néerlandais = 2,
            [Display(Name = "EN")]
            Anglais = 3,
            [Display(Name = "DE")]
            Allemand = 4,
            [Display(Name = "IT")]
            Italien = 5,
            [Display(Name = "ES")]
            Espagnol = 6,
        }
    }
}