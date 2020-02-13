using System;
using System.Net.Mail;

namespace EmailSend
{
    public class MailValidator
    {
        public bool Validate(string email)
        {
            try
            {
                MailAddress adress = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}