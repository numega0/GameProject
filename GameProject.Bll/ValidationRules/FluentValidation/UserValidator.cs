using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using GameProject.Entity.Concrete;

namespace GameProject.Bll.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName).NotEmpty().WithMessage("UserName are not empty");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Password are not empty");
        }
    }
}
