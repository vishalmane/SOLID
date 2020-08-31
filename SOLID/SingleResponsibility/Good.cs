using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResponsibility.Good
{
    class UserService
    {
        private readonly EmailService _emailService;

        public UserService(EmailService emailService)
        {
            _emailService = emailService;
        }

        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new Exception("Email is not an email");
            _emailService.SendEmail(email);
        }

    }

    class EmailService
    {
        internal bool ValidateEmail(string email)
        {
            return true;
        }
        internal bool SendEmail(string email)
        {
            return true;
        }
    }
}
