using E_Library.BUS.IBUS;
using Microsoft.AspNetCore.Mvc;

namespace E_Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IGetTotalSubject _getTotalSubject;

        public HomeController(IGetTotalSubject getTotalSubject)
        {
            _getTotalSubject = getTotalSubject;
        }

        [HttpGet]
        public ActionResult GetTolalSubject()
        {
            var result = _getTotalSubject.GetTotalSubjects();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Khong truy van duoc du lieu trong DB");
        }
    }
}