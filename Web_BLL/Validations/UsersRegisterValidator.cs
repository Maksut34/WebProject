using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DTO.DTO.UsersRegisterDTO;

namespace Web_BLL.Validations
{
    public class UsersRegisterValidator:AbstractValidator<UsersRegisterDTO>
    {
        public UsersRegisterValidator()
        {
<<<<<<< HEAD
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Zorunlu alan! En az iki karakter!");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Zorunlu alan!");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Zorunlu alan!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Zorunlu alan! En az iki karakter!");
=======
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Zorunlu alan! En az iki kere!");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Zorunlu alan!");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Zorunlu alan!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Zorunlu alan!");
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
            RuleFor(x => x.Password).MinimumLength(2).WithMessage("Zorunlu alan!");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Aynı şifreyi tekrar girin!");
            
        }
    }
}
