using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Base.Helper
{
    public static class ValidationHelper
    {
        public static bool ValidateEmail(this string email)
        {
            if (email.EndsWith("."))
            {
                return false; 
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            } 
        }

        public static bool ValidateAdress(this string adress)
        {
            if (string.IsNullOrEmpty(adress)) return false;

            if (adress.Length < 10) return false;

            return true;
        }

        public static bool ValidateGSMNumber(this string number)
        {
            if (string.IsNullOrEmpty(number)) return false;

            if (number.Length > 10 && number.Length < 8) return false;

            return true;
        }

    }
}
