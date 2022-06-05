using E_Library.BUS.IBUS;
using E_Library.Common.Enum;
using E_Library.DTO.Exam;
using Microsoft.AspNetCore.Mvc;

namespace E_Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExamController : ControllerBase
    {
        private readonly IExamBUS _examBUS;

        public ExamController(IExamBUS examBUS)
        {
            _examBUS = examBUS;
        }

        [HttpGet]
        public ActionResult GetAllExam()
        {
            var result = _examBUS.GetAllExam();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }

        [HttpGet("ComboboxStatus")]
        public ActionResult GetComboboxStatus()
        {
            var result = _examBUS.GetComboboxStatus();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }

        [HttpGet("ComboboxSubject")]
        public ActionResult GetComboboxSubject()
        {
            var result = _examBUS.GetComboboxSubject();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }

        [HttpGet("ComboboxTeacher")]
        public ActionResult GetComboboxTeacher()
        {
            var result = _examBUS.GetComboboxTeacher();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }
        [HttpGet("FillAndSearch")]
        public ActionResult FillAndSearchExam(FillAndSearchExamDTO fillAndSearchExam)
        {
            var result = _examBUS.FillAndSearchExam(fillAndSearchExam);
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }
        [HttpGet("ExamDetail/{Id}")]
        public ActionResult GetExamDetail(int id)
        {
            var result = _examBUS.GetExamDetailById(id);
            if (result != null)
                return Ok(result);
            return BadRequest("Loi roi");
        }
    }
}