using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Application.ViewModel
{
    public class AccessVM
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Alert { get; set; }
    }

    public class AccessValidation : AbstractValidator<AccessVM>
    {
        public AccessValidation()
        {
            RuleFor(x => x.Login).NotNull().NotEmpty();
            RuleFor(x => x.Password).NotNull().NotEmpty().MinimumLength(3);
        }
    }
}
