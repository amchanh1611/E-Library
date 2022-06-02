using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExamController : ControllerBase
    {
        private readonly IExamBUS _exam;
        public ExamController(IExamBUS exam)
        {
            _exam = exam;
        }
    }
}
