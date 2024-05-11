using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CshaprSocialNetWorkManager.Utilities
{
    public static class HelperValidator
    {
        public static bool validEmail(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }
        public static bool validAge(short age)
        {
            if ((age < 0) || (age > 100))
                return false;
            else
                return true;
        }
        public static bool validString(string name, string email)
        {
            if ((string.IsNullOrEmpty(name)) || (string.IsNullOrEmpty(email)))
                return false;
            else
                return true;
        }
    }
}
