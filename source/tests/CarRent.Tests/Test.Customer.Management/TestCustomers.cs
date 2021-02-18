
using CarRent.Tests.TestCustomerManagement;

namespace CarRent.Tests
{
    using System;
    using Xunit;

    public class TestCustomers
    {


        [Fact]
        public void TestAmountOfEntries()
        {
            var fakeCustomerController = new FakeCustomerController();
            var customerlist = fakeCustomerController.Get();
            Assert.False(customerlist.Count > 1,"Es ist genau ein Eintrag in der Liste");
        }

        [Fact]
        public void TestCustomerData()
        {
            var fakeCustomerController = new FakeCustomerController();
            var customerlist = fakeCustomerController.Get();
            Assert.True(customerlist[0].Name == "Scherer" ,"Der Name lauetet nicht wie vorgegeben 'Scherer'");
        }

        [Fact]
        public void TestZipCodePlacerData()
        {
            var fakeCustomerController = new FakeCustomerController();
            var customerlist = fakeCustomerController.Get();
            Assert.True(customerlist[0].ZipCodePlaceDto.Place == "Goldach" ,"Der Ort lauetet nicht wie vorgegeben 'Goldach'");
        }
    }
}
