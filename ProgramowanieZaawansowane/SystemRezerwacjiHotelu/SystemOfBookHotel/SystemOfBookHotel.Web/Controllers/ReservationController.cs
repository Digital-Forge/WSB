using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using SystemOfBookHotel.Application.Interface;
using SystemOfBookHotel.Application.ViewModel;

namespace SystemOfBookHotel.Web.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationServ;
        private readonly ILogger<ReservationController> _logger;
        public ReservationController(IReservationService reservationService, ILogger<ReservationController> logger)
        {
            _reservationServ = reservationService;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new DateReservationVM());
        }

        [HttpPost]
        public ActionResult RoomDefault(DateReservationVM date)
        {
            if (date.DateStart == null 
             || date.DateEnd == null 
             || date.DateStart > date.DateEnd 
             || date.DateStart < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day))
            {
                _logger.LogDebug($"badRequest - Room Default dates : {date.DateStart} : {date.DateEnd}");
                return BadRequest();
            }
            return View(_reservationServ.RoomDefaultInit(date));
        }

        [HttpPost]
        public ActionResult AddRoom(ListOfRoomVM listOfRoom)
        {
            return View("RoomDefault", _reservationServ.AddRoom(listOfRoom));
        }

        [HttpPost]
        public ActionResult RemoveRoom(ListOfRoomVM listOfRoom)
        {
            return View("RoomDefault", _reservationServ.RemoveRoom(listOfRoom));
        }

        [HttpPost]
        public ActionResult ExtraPerk(ListOfRoomVM listOfRoom)
        {
            _logger.LogInformation("Wybieranie dodatkowego wyposarzenia");
            listOfRoom = _reservationServ.CheckRoomCount(listOfRoom);
            return View(_reservationServ.PerkDefaultInit(listOfRoom));
        }

        [HttpPost]
        public ActionResult ClientData(ListOfRoomPerkVM list)
        {
            return View(_reservationServ.ClientDataDefaultInit(list));
        }

        [HttpPost]
        public ActionResult Summary(ListOfRoomPerkVM data)
        {
            _logger.LogInformation("Generowanie podsumowaia rezerwacji");
            return View(_reservationServ.Summary(data));
        }

        [HttpPost]
        public ActionResult Payment(SummaryVM summary)
        {
            _logger.LogInformation("Potwierdzeniw rezerwacji");
            if (_reservationServ.ConfirmReservation(summary))
            {
                return View(_reservationServ.Payment(summary));
            }
            return BadRequest();
        }

        [HttpPost]
        public ActionResult EndReservation(PaymentVm x)
        {
            _logger.LogInformation("zakończono sukcesem rezerwacjie");
            _reservationServ.EndReservation(x);
            return View();
        }

    }
}
