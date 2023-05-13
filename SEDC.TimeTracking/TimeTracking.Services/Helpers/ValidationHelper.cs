using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracking.Services.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateFirstName(string firstName)
        {
            if(firstName.Length < 2 || firstName.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        public static bool ValidateLastName(string lastName)
        {
            if(lastName.Length < 2 || lastName.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        public static bool ValidateUserName(string userName)
        {
            if(userName.Length < 5)
            {
                return false;
            }
            return true;
        }

        public static bool ValidatePassword(string password)
        {
            if(!password.Any(char.IsDigit) || password.Length < 6 || !password.Any(char.IsUpper))
            {
                return false;   
            }
            return true;
        }

        public static bool ValidateAge(int age)
        {
            if(age < 18 || age > 120)
            {
                return false;
            }
            return true;
        }
    }
}
