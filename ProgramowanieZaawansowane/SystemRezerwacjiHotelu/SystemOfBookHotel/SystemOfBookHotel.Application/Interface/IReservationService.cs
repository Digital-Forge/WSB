using System;
using System.Collections.Generic;
using System.Text;
using SystemOfBookHotel.Application.ViewModel;

namespace SystemOfBookHotel.Application.Interface
{
    public interface IReservationService
    {
        ListOfRoomVM AddRoom(ListOfRoomVM listOfRoom);
        ListOfRoomVM RemoveRoom(ListOfRoomVM listOfRoom);
        ListOfRoomVM RoomDefaultInit(DateReservationVM dates);
        ListOfRoomPerkVM PerkDefaultInit(ListOfRoomVM listRoom);
        ListOfRoomPerkVM ClientDataDefaultInit(ListOfRoomPerkVM data);
        ListOfRoomVM CheckRoomCount(ListOfRoomVM listOfRoom);
        SummaryVM Summary(ListOfRoomPerkVM data);
        bool ConfirmReservation(SummaryVM summary);
        PaymentVm Payment(SummaryVM data);
        void EndReservation(PaymentVm x);
    }
}
