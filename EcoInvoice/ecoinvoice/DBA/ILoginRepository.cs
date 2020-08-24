using ecoinvoice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecoinvoice.DBA
{
    public interface ILoginRepository
    {
        public bool StoreOTPtoDB(OTPEmail otpDetails);
        public bool StoreOTPtoMemory(OTPEmail otpDetails);
    }
}
