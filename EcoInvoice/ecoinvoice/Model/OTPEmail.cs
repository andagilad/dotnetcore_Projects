using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecoinvoice.Model
{
    public class OTPEmail
    {
        private string emailId;
        private string otp;
        private DateTime createdDateTime;
        private DateTime lastExtendedDateTime;
        private DateTime sessionExpiryDateTime;
        private DateTime otpValidity;


        public OTPEmail(string emailid, string otp)
        {
            this.EmailId = emailid;
            this.Otp = otp;
            this.CreatedDateTime = DateTime.Now;
            this.LastExtendedDateTime = DateTime.Now;
            this.SessionExpiryDateTime = DateTime.Now;
            this.OtpValidity = DateTime.Now;
            this.OtpValidity.AddMinutes(10);
        }
        public string EmailId { get => emailId; set => emailId = value; }
        public string Otp { get => otp; set => otp = value; }
        public DateTime CreatedDateTime { get => createdDateTime; set => createdDateTime = value; }
        public DateTime LastExtendedDateTime { get => lastExtendedDateTime; set => lastExtendedDateTime = value; }
        public DateTime SessionExpiryDateTime { get => sessionExpiryDateTime; set => sessionExpiryDateTime = value; }
        public DateTime OtpValidity { get => otpValidity; set => otpValidity = value; }
    }
}
