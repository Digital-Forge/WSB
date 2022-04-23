using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemOfBookHotel.Application.Interface;
using SystemOfBookHotel.Application.ViewModel;

namespace SystemOfBookHotel.Web.Controllers
{
    [AllowAnonymous]
    public class AccessController : Controller
    {
        private readonly IAccessService _accessServ;
        private readonly ILogger<AccessController> _logger;

        public AccessController(IAccessService accessService, ILogger<AccessController> logger)
        {
            _accessServ = accessService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("Access", new AccessVM { Role = "Login" });
        }

        [HttpPost]
        public IActionResult Login(AccessVM data)
        {
            if (_accessServ.CheckAccess(data))
            {
                return RedirectToAction("Index","Admin");
            }
            return View("Access", data);
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View("Access", new AccessVM { Role = "Registration" });
        }
        
        [HttpPost]
        public IActionResult Registration(AccessVM data)
        {
            if (_accessServ.Registration(data))
            {
                _logger.LogWarning($"Założono konto administatorskie {data.Login}");
                return RedirectToAction("Login");
            }
            return View("Access", data);
        }
    }
}
