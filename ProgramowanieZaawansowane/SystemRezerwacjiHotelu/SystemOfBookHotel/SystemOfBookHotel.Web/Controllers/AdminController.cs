using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemOfBookHotel.Application.Interface;

namespace SystemOfBookHotel.Web.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminServ;
        private readonly ILogger<AdminController> _logger;

        public AdminController(IAdminService adminService, ILogger<AdminController> logger)
        {
            _adminServ = adminService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            _logger.LogInformation($"Zalogowano Administratora - {HttpContext.User.Identity.Name}");
            return View(_adminServ.GetListOfActualReservation());
        }

        [HttpGet]
        public IActionResult Details(int roomReservationId)
        {
            return View(_adminServ.GetDetalsOfRoomReservation(roomReservationId));
        }

        [HttpGet]
        public IActionResult Remove(int roomReservationId)
        {
            _adminServ.RemoveRoomReservation(roomReservationId);
            _logger.LogWarning($"Usunięto rezerwację pokoju (id_roomReservation : {roomReservationId}) przez Administratora - {HttpContext.User.Identity.Name}");
            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            //FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Access");
        }
    }
}
