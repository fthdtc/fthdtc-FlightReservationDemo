using FlightReservationDemo.Base.Helper;
using FlightReservationDemo.Service.Services;

namespace FlightReservationDemo.Test.Unit
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void EmailValidationCorrect_Test()
        {
            string correctEmail = "customer1@customer.com";
            Assert.IsTrue(ValidationHelper.ValidateEmail(correctEmail));
        }

        [TestMethod]
        public void EmailValidationInCorrect_Test()
        {
            string inCorrectEmail = "customer1@customer.com.";
            Assert.IsTrue(!ValidationHelper.ValidateEmail(inCorrectEmail));
        }

        [TestMethod]
        public void GSMNumberValidationCorrect_Test()
        {
            string correctNumber = "222000221";
            Assert.IsTrue(ValidationHelper.ValidateGSMNumber(correctNumber));
        }

        [TestMethod]
        public void GSMNumberValidationInCorrect_Test()
        {
            string inCorrectNumber = "0000222000221";
            Assert.IsTrue(!ValidationHelper.ValidateGSMNumber(inCorrectNumber));
        }

        [TestMethod]
        public void GetCustomers_Test()
        {
            var list = new CustomerService().GetAllCustomers();
        }

        [TestMethod]
        public void GetReservations_Test()
        {
            var list = new ReservationService().GetAllReservation();
        }
    }
}