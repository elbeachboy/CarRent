
using CarRent.Tests.TestCarManagement;

namespace CarRent.Tests
{
    using System;
    using Xunit;

    public class TestCars
    {
        [Fact]
        public void TestAmountOfEntries()
        {
            var fakeCarController = new FakeCarController();
            var carList = fakeCarController.Get();
            Assert.True(carList.Count == 1,"Es darf nicht mehr als einen EIntrag in der Liste haben");
        }

        [Fact]
        public void TestCarData()
        {
            var fakeCarController = new FakeCarController();
            var carList = fakeCarController.Get();
            Assert.True(carList[0].Brand == "Volkswagen" ,"Der Brand lauetet nicht wie vorgegeben 'Volkswagen'");
        }

        [Fact]
        public void TestCarClassData()
        {
            var fakeCarController = new FakeCarController();
            var carList = fakeCarController.Get();
            Assert.True(carList[0].CarClassDto.PricePerDay == 50 ,"Der Preis pro Tag lauetet nicht wie vorgegeben '50'");
        }
    }
}
