using System;
using System.Collections.Generic;
using System.Linq;
using SystemOfBookHotel.Application.Interface;
using SystemOfBookHotel.Application.ViewModel;
using SystemOfBookHotel.Domain.Interface;
using SystemOfBookHotel.Domain.Model;

namespace SystemOfBookHotel.Application.Service
{
    public class ReservationService : IReservationService
    {
        private readonly IRoomRepository _roomRepo;
        private readonly IReservationRepository _reservationRepo;
        private readonly IExtraPerkRepository _extraPerkRepo;
        private readonly IProgramSettingRepository _programSettingRepo;
        private readonly IEmailService _emailServ;
        public ReservationService(IRoomRepository roomRepository, IReservationRepository reservationRepository, IExtraPerkRepository extraPerkRepository, IProgramSettingRepository programSettingRepository, IEmailService emailService)
        {
            _roomRepo = roomRepository;
            _reservationRepo = reservationRepository;
            _extraPerkRepo = extraPerkRepository;
            _programSettingRepo = programSettingRepository;
            _emailServ = emailService;
        }

        public ListOfRoomVM AddRoom(ListOfRoomVM listOfRoom)
        {
            var freeRooms = _roomRepo.GetFreeRoomListInTerm(listOfRoom.Dates.DateStart.Value, listOfRoom.Dates.DateEnd.Value).ToList();
            var listFreeRooms = freeRooms.Where(x => !listOfRoom.Rooms.Any(y => y.RoomId == x.Id))
                .OrderBy(x => x.Capacity).Reverse().ToList();

            if (listFreeRooms.Count > 0)
            {
                listOfRoom.Rooms.Add(new RoomVM 
                { 
                    RoomId = listFreeRooms[0].Id, 
                    MaxCount = listFreeRooms[0].Capacity, 
                    CountOld = 2, 
                    CountChild = 0 
                });
            }

            listOfRoom.RoomOut = listFreeRooms.Count > 1 ? false : true;
            return listOfRoom;
        }

        public ListOfRoomVM RemoveRoom(ListOfRoomVM listOfRoom)
        {
            if (listOfRoom.ToRemove != 0)
            {
                listOfRoom.Rooms.Remove(listOfRoom.Rooms.Find(x => x.RoomId == listOfRoom.ToRemove));
            }
            listOfRoom.RoomOut = !checkFreeRoomInTerm(listOfRoom);
            listOfRoom.ToRemove = 0;
            return listOfRoom;
        }

        public ListOfRoomVM RoomDefaultInit(DateReservationVM dates)
        {
            var roomList = new ListOfRoomVM();
            roomList.Rooms = new List<RoomVM>();
            roomList.Dates = dates;
            return AddRoom(roomList);
        }

        private bool checkFreeRoomInTerm(ListOfRoomVM term)
        {
            var freeRooms = _roomRepo.GetFreeRoomListInTerm(term.Dates.DateStart.Value, term.Dates.DateEnd.Value).ToList();
            var listFreeRooms = freeRooms.Where(x => !term.Rooms.Any(y => y.RoomId == x.Id))
                .OrderBy(x => x.Capacity).Reverse().ToList();
            return listFreeRooms.Count > 0;
        }
        
        public ListOfRoomPerkVM PerkDefaultInit(ListOfRoomVM listRoom)
        {
            var perk = _extraPerkRepo.GetListAllActivePerks().OrderBy(x => x.Name).ToList();
            var currency = _programSettingRepo.GetCurrency();

            var con = new ListOfRoomPerkVM();
            con.Dates = listRoom.Dates;
            con.ListRooms = new List<RoomPerkVM>();

            foreach (var item in listRoom.Rooms)
            {
                var roomPerk = new RoomPerkVM();
                roomPerk.Room = item;
                roomPerk.PerkList = new List<PerkVM>();
                foreach (var item2 in perk)
                {
                    var adnotation = item2.Personal ? "/os." : "";
                    roomPerk.PerkList.Add(new PerkVM 
                    { 
                        Id = item2.Id, 
                        Name = $"{item2.Name} : {item2.Price} {currency} {adnotation}",
                        Check = false 
                    });
                }
                con.ListRooms.Add(roomPerk);
            }
            return con;
        }

        public ListOfRoomPerkVM ClientDataDefaultInit(ListOfRoomPerkVM data)
        {
            data.ClientData = new ClientDataVM();
            return data;
        }

        public ListOfRoomVM CheckRoomCount(ListOfRoomVM listOfRoom)
        {
            foreach (var item in listOfRoom.Rooms.ToList())
            {
                if (item.CountOld == 0 && item.CountChild == 0)
                {
                    listOfRoom.Rooms.Remove(item);
                }
            }
            return listOfRoom;
        }

        public SummaryVM Summary(ListOfRoomPerkVM data)
        {
            var freeRooms = _roomRepo.GetFreeRoomListInTerm(data.Dates.DateStart.Value, data.Dates.DateEnd.Value).OrderBy(x => x.Capacity).ToList();
            var perks = _extraPerkRepo.GetListAllPerks().ToList();
            
            var PriceForRoom = _programSettingRepo.GetPriceForRoom();
            var ChildConcession = 1.0 - _programSettingRepo.GetChildConcession();
            var Currency = _programSettingRepo.GetCurrency();

            int day = Convert.ToInt32(Math.Round((data.Dates.DateEnd - data.Dates.DateStart).Value.TotalDays));

            var summary = new SummaryVM();
            summary.Dates = data.Dates;
            summary.CustomerData = data.ClientData;
            summary.Rooms = new List<SummaryRoomVM>();

            double totalPrice = 0;

            foreach (var item in data.ListRooms)
            {
                var room = new SummaryRoomVM();
                room.PerkList = new List<PerkVM>();
                room.CountOld = item.Room.CountOld;
                room.CountChild = item.Room.CountChild;

                var roomPrice = ((room.CountOld * PriceForRoom) + (room.CountChild * PriceForRoom * ChildConcession)) * day;
                room.PriceForRoom = $"{Math.Round(roomPrice, 2).ToString()} {Currency}";
                totalPrice += roomPrice;

                var buffRoom = freeRooms.Where(x => x.Capacity >= (room.CountOld + room.CountChild)).OrderBy(y => y.Capacity).FirstOrDefault();
                if (buffRoom == null)
                {
                    return new SummaryVM();
                }
                room.RoomId = buffRoom.Id;
                freeRooms.Remove(buffRoom);

                double perkPriceBuff = 0;
                foreach (var item2 in item.PerkList)
                {
                    if (item2.Check)
                    {
                        var perk = perks.Where(x => x.Id == item2.Id).FirstOrDefault();

                        if (perk.Personal)
                        {
                            perkPriceBuff += ((room.CountOld * perk.Price) + (room.CountChild * perk.Price * ChildConcession)) * day;
                        }
                        else
                        {
                            perkPriceBuff += perk.Price * day;
                        }

                        room.PerkList.Add(new PerkVM
                        {
                            Id = perk.Id,
                            Name = perk.Name
                        });
                    }
                }
                totalPrice += perkPriceBuff;
                room.PriceForPerks = $"{Math.Round(perkPriceBuff, 2).ToString()} {Currency}";
                summary.Rooms.Add(room);
            }
            summary.TotalPrice = $"{Math.Round(totalPrice, 2).ToString()} {Currency}";
            summary._TotalPrice = totalPrice;
            return summary;
        }

        public bool ConfirmReservation(SummaryVM summary)
        {
            var customer = new Customer
            {
                FullName = $"{summary.CustomerData.Name} {summary.CustomerData.Surname}",
                Email = summary.CustomerData.Email,
                PhoneNumber = summary.CustomerData.Phone
            };

            var reservation = new Reservation
            {
                Start = summary.Dates.DateStart.Value,
                Stop = summary.Dates.DateEnd.Value
            };

            try
            {
                _reservationRepo.AddReservationCustomer(customer, reservation);

                foreach (var room in summary.Rooms)
                {
                    var reservRefRoom = new RoomReservation
                    {
                        CountOld = room.CountOld,
                        CountChild = room.CountChild
                    };

                    _reservationRepo.AddRoomReservatiom(reservation, reservRefRoom);
                    _reservationRepo.SetRoomToReservatiom(reservRefRoom.Id, room.RoomId);

                    if (room.PerkList != null)
                    {
                        foreach (var extraPerk in room.PerkList)
                        {
                            _reservationRepo.SetExtraPerkToReservatiom(reservRefRoom.Id, extraPerk.Id);
                        }
                    }
                }
            }
            catch
            {
                return false;
            }

            _emailServ.SendMail(summary.CustomerData.Email, "Hotel Jednorożek - Zarejestrowanie rezerwacji", $"Rezerwacja pokoju została przyjęta. Cena pobytu : {summary.TotalPrice}");
            return true;
        }

        public PaymentVm Payment(SummaryVM data)
        {
            return new PaymentVm
            {
                Price = data._TotalPrice,
                Currency = _programSettingRepo.GetCurrency(),
                Email = data.CustomerData.Email
            };
        }

        public void EndReservation(PaymentVm x)
        {
            _emailServ.SendMail(x.Email, "Hotel Jednorożek - Potwierdzenie", "Potwierdzam opłacenie rezerwacji. Życzymy miłego pobytu.");
        }
    }
}
