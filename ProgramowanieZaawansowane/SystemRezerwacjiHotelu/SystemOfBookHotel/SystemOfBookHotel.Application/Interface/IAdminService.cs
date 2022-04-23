using System;
using System.Collections.Generic;
using System.Text;
using SystemOfBookHotel.Application.ViewModel;

namespace SystemOfBookHotel.Application.Interface
{
    public interface IAdminService
    {
        List<AdmReservationVM> GetListOfActualReservation();
        void RemoveRoomReservation(int roomReservationId);
        AdmReservationDetals GetDetalsOfRoomReservation(int roomReservationId);
    }
}
