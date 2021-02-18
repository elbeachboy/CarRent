
namespace CarRent.Tests
{
    using System;
    using Xunit;

    public class TestReservation
    {


        [Fact]
        public void TestAmountOfEntries()
        {
            var fakeReservationController = new FakeReservationController();
            var reservationList = fakeReservationController.Get();
            Assert.False(reservationList.Count > 1,"Es ist genau ein Eintrag in der Liste");
        }

        [Fact]
        public void TestReservationData()
        {
            var fakeReservationController = new FakeReservationController();
            var reservationList = fakeReservationController.Get();
            Assert.False(reservationList[0].IsContract != true ,"Es ist kein VErtrag wie vorgegeben.");
        }

        [Fact]
        public void TestCustomerDataInReservation()
        {
            var fakeReservationController = new FakeReservationController();
            var reservationList = fakeReservationController.Get();
            Assert.True(reservationList[0].CustomerDto.Name == "Scherer" ,"Der Name lauetet nicht wie vorgegeben 'Scherer'");
        }
    }
}
