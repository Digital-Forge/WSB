using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using SystemOfBookHotel.Application.Service;
using SystemOfBookHotel.Application.ViewModel;
using SystemOfBookHotel.Domain.Interface;
using SystemOfBookHotel.Domain.Model;
using Xunit;

namespace SystemOfBookHotel.Tests
{
    public class ReservationServiceTests
    {
        [Fact]
        public void AddRoomTest()
        {
            //Arrange
            var dataInput = new ListOfRoomVM 
            { 
                Dates = new DateReservationVM { DateStart = new DateTime(2000,12,12), DateEnd = new DateTime(2001, 12, 12) },
                Rooms = new List<RoomVM>()                
            };
            var dataMoq = (new List<Room> { new Room { Id = 1, Capacity = 4, NumberRoom = "w12"} }).Where(x => true).AsQueryable();
            var moqService = new Mock<IRoomRepository>();
            moqService.Setup(f => f.GetFreeRoomListInTerm(new DateTime(2000, 12, 12), new DateTime(2001, 12, 12))).Returns(dataMoq);

            var service = new ReservationService(moqService.Object, null, null, null, null);


            //Act
            var x = service.AddRoom(dataInput);


            //Assert
            x.Should().NotBeNull();
            x.RoomOut.Should().BeTrue();
            x.Dates.DateStart.Should().NotBeNull();
            x.Dates.DateStart.Should().Be(dataInput.Dates.DateStart); 
            x.Dates.DateEnd.Should().NotBeNull();
            x.Dates.DateEnd.Should().Be(dataInput.Dates.DateEnd);
            x.Rooms.Should().NotBeNullOrEmpty();
            x.Rooms[0].RoomId.Should().Be(dataMoq.FirstOrDefault().Id);
            x.Rooms[0].MaxCount.Should().Be(dataMoq.FirstOrDefault().Capacity);
        }

        [Fact]
        public void ClientDataDefaultInitTest()
        {
            //Arrange
            var input = new ListOfRoomPerkVM();
            var service = new ReservationService(null, null, null, null, null);

            //Act
            var x = service.ClientDataDefaultInit(input);

            //Assert
            x.Should().NotBeNull();
            x.ListRooms.Should().BeNullOrEmpty();
            x.ClientData.Should().NotBeNull();
        }

        [Fact]
        public void CheckRoomCountTest()
        {
            //Arrange
            var input = new ListOfRoomVM();
            input.Rooms = new List<RoomVM>();
            input.Rooms.Add(new RoomVM { CountChild = 1, CountOld = 0, MaxCount = 10, RoomId = 0 });
            input.Rooms.Add(new RoomVM { CountChild = 0, CountOld = 0, MaxCount = 10, RoomId = 0 });
            input.Rooms.Add(new RoomVM { CountChild = 1, CountOld = 1, MaxCount = 10, RoomId = 0 });
            input.Rooms.Add(new RoomVM { CountChild = 0, CountOld = 1, MaxCount = 10, RoomId = 0 });

            var service = new ReservationService(null, null, null, null, null);

            //Act
            var x = service.CheckRoomCount(input);

            //Assert
            x.Should().NotBeNull();
            x.Rooms.Count.Should().Be(3);
        }
    }
}