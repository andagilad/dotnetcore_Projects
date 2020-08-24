using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecoinvoice.Services
{
    public interface IOTPLoginService
    {
        public bool GenerateEmailOTP(string emailId);
    }
}
