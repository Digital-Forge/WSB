using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using SystemOfBookHotel.Application.Interface;
using SystemOfBookHotel.Application.ViewModel;

namespace SystemOfBookHotel.Application.Service
{
    public class AccessService : IAccessService
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AccessService(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public bool CheckAccess(AccessVM data)
        {
            data.Alert = "";
            return AuthenticateUser(data);
        }

        public bool Registration(AccessVM data)
        {
            data.Alert = "";

            var user = new IdentityUser
            {
                UserName = data.Login,
                Email = "admin@admin.pl"
            };

            user.EmailConfirmed = true;

            var result = _userManager.CreateAsync(user, data.Password).Result;

            if (result.Succeeded)
            {
                return true;
            }
            data.Alert = "Złę dane";
            return false;
        }

        private bool AuthenticateUser(AccessVM data)
        {
            var result = _signInManager.PasswordSignInAsync(data.Login, data.Password, false, lockoutOnFailure: false).Result;
            if (result.Succeeded)
            {
                return result.Succeeded;
            }
            data.Alert = "Złe dane";
            return result.Succeeded;
        }
    }
}
