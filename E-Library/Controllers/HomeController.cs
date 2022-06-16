using E_Library.BUS.BUS.Authorize;
using E_Library.BUS.IBUS;
using E_Library.Common.Enum.Author;
using Microsoft.AspNetCore.Mvc;

namespace E_Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IHomeBUS _homeBUS;

        public HomeController(IHomeBUS getTotalExamBUS)
        {
            _homeBUS = getTotalExamBUS;
        }

        [HttpGet("HomeSubject")]
        public ActionResult GetTolalSubject()
        {
            var result = _homeBUS.GetTotalSubjects();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Khong truy van duoc du lieu trong DB");
        }
        [Authorize(Roles.Admin)]
        [HttpGet("HomeExam")]
        public ActionResult GetTotalExam()
        {
            var result = _homeBUS.GetTotalExam();
            if (result != null)
                return Ok(result);
            return BadRequest("Loi Roi");
        }
    }
}