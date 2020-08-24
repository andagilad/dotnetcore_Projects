using ecoinvoice.DBA;
using ecoinvoice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ecoinvoice.Services
{
    public class OTPLoginService : IOTPLoginService
    {
        private ILoginRepository _loginRepo;
        public OTPLoginService(ILoginRepository repoService)
        {
            _loginRepo = repoService;
        }

        public bool GenerateEmailOTP(string emailId)
        {
            try
            {
                var emailSender = new ADEmailSender.EmailSender();

                //Generate random alpha numeric number START
                StringBuilder otpString = new StringBuilder();
                char c;
                Random rnd = new Random(DateTime.Now.Millisecond);
                while (otpString.Length < 7)
                {
                    c = Convert.ToChar(rnd.Next(48, 123));
                    if (char.IsLetterOrDigit(c))
                    {
                        otpString.Append(c);
                    }
                }
                //Ends
                string msgTosend = "Your one time password is " + otpString + " . you received this message because you tried to login to Portal.";
                emailSender.SendOTPToEmail("gorumtech@gmail.com", "Tintin@579", emailId, msgTosend);
                OTPEmail objEmail = new OTPEmail(emailId, otpString.ToString());
                return _loginRepo.StoreOTPtoMemory(objEmail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
