using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmailValidation
    {
        public static bool IsValid(string emailAddress)
        {

            try
            {
                if (String.IsNullOrEmpty(emailAddress))
                {
                    return false;
                }

                MailAddress mail = new MailAddress(emailAddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
