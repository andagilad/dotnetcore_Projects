using System;
using System.Net;
using System.Net.Mail;

namespace ADEmailSender
{
    public class EmailSender
    {
        public EmailSender()
        {
        }

        public bool SendOTPToEmail(string fromMailId, string fromPassword, string toMailId, string message, int port=587)
        {
            try
            {
                MailMessage msgToSend = new MailMessage(fromMailId, toMailId);
                msgToSend.Subject = "Mail From GorumTech for OTP";
                msgToSend.Body = message;


                SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
                smtpserver.Port = port;
                smtpserver.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpserver.Credentials = new NetworkCredential(fromMailId, fromPassword);
                smtpserver.EnableSsl = true;
                smtpserver.Send(msgToSend);
                return true;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
