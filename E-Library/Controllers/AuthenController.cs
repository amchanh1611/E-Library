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
            return BadRequest("Dang nhap khong thanh cong");
        }
    }
}