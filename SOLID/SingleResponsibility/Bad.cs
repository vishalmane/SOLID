using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResponsibility.Bad
{
    class UserService
    {
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new Exception("Email is not an email");
            SendEmail(email);
        }
        private bool ValidateEmail(string email)
        {
            return true;
        }
        private bool SendEmail(string email)
        {
            return true;
        }
    }
}
