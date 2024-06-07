using FlightReservationDemo.Base.Helper;
using FlightReservationDemo.Service.Services;

namespace FlightReservationDemo.Test.Unit.UnitTest
{
    [TestFixture]
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Order(1)]
        public void EmailValidationCorrect_Test()
        {
            string correctEmail = "customer1@customer.com";
            Assert.IsTrue(ValidationHelper.ValidateEmail(correctEmail));
        }

        [Test]
        [Order(2)]
        public void EmailValidationInCorrect_Test()
        {
            string inCorrectEmail = "customer1@customer.com.";
            Assert.IsTrue(!ValidationHelper.ValidateEmail(inCorrectEmail));
        }

        [Test]
        [Order(3)]
        public void GSMNumberValidationCorrect_Test()
        {
            string correctNumber = "222000221";
            Assert.IsTrue(ValidationHelper.ValidateGSMNumber(correctNumber));
        }

        [Test]
        [Order(4)]
        public void GSMNumberValidationInCorrect_Test()
        {
            string inCorrectNumber = "0000222000221";
            Assert.IsTrue(!ValidationHelper.ValidateGSMNumber(inCorrectNumber));
        }

        [Test]
        [Order(5)]
        public void GetCustomers_Test()
        {
            var list = new CustomerService().GetAllCustomers();
        }

        [Test]
        [Order(6)]
        public void GetReservations_Test()
        {
            var list = new ReservationService().GetAllReservation();
        }
    }
}