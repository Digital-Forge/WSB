using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemOfBookHotel.Application.Interface;
using SystemOfBookHotel.Application.ViewModel;
using SystemOfBookHotel.Domain.Interface;

namespace SystemOfBookHotel.Application.Service
{
    public class AdminService : IAdminService
    {
        private readonly IRoomRepository _roomRepo;
        private readonly IReservationRepository _reservationRepo;

        public AdminService(IReservationRepository reservationRepository, IRoomRepository roomRepository)
        {
            _reservationRepo = reservationRepository;
            _roomRepo = roomRepository;
        }

        public List<AdmReservationVM> GetListOfActualReservation()
        {
            var roomResList = _reservationRepo.GetReservationRoomListFromTerm(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
            List<AdmReservationVM> list = new List<AdmReservationVM>();

            var ResList = roomResList.OrderBy(x => x.Reservation.Start)
                .Select(x => new 
                { 
                    x.Reservation.Start, 
                    x.Reservation.Stop, 
                    x.Reservation.Customer.Email,
                    x.Room.NumberRoom,
                    x.Id
                }).ToList();

            foreach (var item in ResList)
            {
                list.Add(new AdmReservationVM 
                {
                    Start = item.Start,
                    End = item.Stop,
                    RoomNumber = item.NumberRoom,
                    RoomReservationId = item.Id,
                    Email = item.Email
                });
            }
            return list;
        }

        public AdmReservationDetals GetDetalsOfRoomReservation(int roomReservationId)
        {
            var buff = _reservationRepo.GetRoomReservationById(roomReservationId)
                .Select(x => new AdmReservationDetals
                {
                    FullName = x.Reservation.Customer.FullName,
                    Phone = x.Reservation.Customer.PhoneNumber,
                    Email = x.Reservation.Customer.Email,
                    Start = x.Reservation.Start,
                    End = x.Reservation.Stop,
                    RoomName = x.Room.NumberRoom,
                    CountAdult = x.CountOld,
                    CountChild = x.CountChild,
                    ExtraPerk = x.PerksToRooms.Where(y => y.RoomReservationId == x.Id).Select(y => y.ExtraPerk.Name).ToList()
                }).FirstOrDefault();
            return buff;
        }

        public void RemoveRoomReservation(int roomReservationId)
        {
            _reservationRepo.DeleteRoomReservation(roomReservationId);
        }
    }
}
