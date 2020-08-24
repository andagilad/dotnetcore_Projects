using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ecoinvoice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecoinvoice.Controllers
{
    [ApiController]
    public class OTPLoginController : ControllerBase
    {
        private IOTPLoginService _otpLoginService;

        public OTPLoginController(IOTPLoginService otpoginService)
        {
            _otpLoginService = otpoginService;
        }

        [HttpPost]
        [Route("api/v1/emailotp/{emailid}")]
        public bool GenerateEmailOTP( string emailId)
        {
            try
            {
                return _otpLoginService.GenerateEmailOTP(emailId);

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
   