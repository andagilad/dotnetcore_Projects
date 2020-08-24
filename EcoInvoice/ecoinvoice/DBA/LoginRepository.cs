using ecoinvoice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecoinvoice.DBA
{
    public class LoginRepository : ILoginRepository
    {
        Dictionary<string, OTPEmail> lstAccounts = new Dictionary<string, OTPEmail>();
        public bool StoreOTPtoDB(OTPEmail otpDetails)
        {
            throw new NotImplementedException();
        }

        public bool StoreOTPtoMemory(OTPEmail otpDetails)
        {
            if (lstAccounts.ContainsKey(otpDetails.EmailId))
            {
                lstAccounts.Remove(otpDetails.EmailId);
            }
            lstAccounts.Add(otpDetails.EmailId,otpDetails);
            return true;
        }
    }
}
