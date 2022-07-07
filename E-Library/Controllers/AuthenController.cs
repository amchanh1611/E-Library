    using E_Library.BUS.IBUS;
using E_Library.DTO.Anthen;
using Microsoft.AspNetCore.Mvc;

namespace E_Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenController : ControllerBase
    {
        private readonly IAuthenBUS _authenBUS;

        public AuthenController(IAuthenBUS authenBUS)
        {
            _authenBUS = authenBUS;
        }

        [HttpPost]
        public ActionResult CreateNewUser(UserDTO infoUser)
        {
            var result = _authenBUS.CreateNewUser(infoUser);
            if (result)
                return Ok();
            return BadRequest("Loi roi");
        }

        [HttpPost("Login")]
        public ActionResult Login(LoginDTO login)
        {
            var result = _authenBUS.Login(login);
            if (result != null)
                return Ok(result);
            return BadRequest("Uncorrect LoginName/Password");
        }
        [HttpGet("ForgotPassword/{Email}")]
        public ActionResult ForgotPassword(string email)
        {
            var result = _authenBUS.ForgotPassword(email);
            if(result != 0)
                return Ok(result);
            return NotFound("Uncorect Email");
        }
        [HttpGet("ValidateOTP/{OTP}")]
        public ActionResult ValidateOTP(string oTP)
        {
            var result = _authenBUS.ValidateOTP(oTP);
            if (result)
                return Ok();
            return BadRequest();
        }
    }
}