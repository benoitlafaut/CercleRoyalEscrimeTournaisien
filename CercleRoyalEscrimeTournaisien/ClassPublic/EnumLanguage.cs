using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CercleRoyalEscrimeTournaisien
{
    public class ClassEnumLanguage
    {    
        public  enum EnumLanguage
        {
            [Display(Name = "Français")]
            Français = 1,
            [Display(Name = "Néerlandais")]
            Néerlandais = 2,
            [Display(Name = "Anglais")]
            Anglais = 3,
            [Display(Name = "Allemand")]
            Allemand = 4,
            [Display(Name = "Italien")]
            Italien = 5,
        }
    }
}