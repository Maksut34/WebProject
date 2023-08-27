using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DTO.DTO.UsersLoginDTO;

namespace Web_BLL.Validations
{
    public class UsersLoginValidator: AbstractValidator<UsersLoginDTO>
    {
        public UsersLoginValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Zorunlu alan!");
            RuleFor(x => x.Password).MinimumLength(2).WithMessage("Zorunlu alan!");
        }
    }
}
