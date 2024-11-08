using FluentValidation;

namespace WebApplication1.Models
{
    public class ModelLogonValidator : AbstractValidator<ModelLogon>
    {
        public ModelLogonValidator() 
        {
            RuleFor(x => x.UserName).Must(x => x == "EscrimeTournai").WithMessage("Le username n'est pas correct.");
            RuleFor(x => x.Password).Must(x => x == "1884Tournai1884").WithMessage("Le mot de passe n'est pas correct.");
        }
    }
}