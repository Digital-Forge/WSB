using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Application.ViewModel
{
    public class ClientDataVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class ClientDataValidation : AbstractValidator<ClientDataVM>
    {
        public ClientDataValidation()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
            RuleFor(x => x.Surname).NotEmpty().NotNull();
            RuleFor(x => x.Email).EmailAddress().NotNull();
            RuleFor(x => x.Phone).NotNull().Length(9,11);
        }

    }
}
